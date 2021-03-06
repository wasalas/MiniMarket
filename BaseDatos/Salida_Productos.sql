--
-- Limpiando tablas
--
select * from Det_Salida_Productos;
select * from Enc_Salida_Productos;


delete from Det_Salida_Productos;
delete from Enc_Salida_Productos;
dbcc checkident(Enc_Salida_Productos, reseed, 0);

--
-- Crear Estructura del Detalle
--
drop procedure if exists spGuardar_Salida_Productos
DROP Type IF EXISTS Ty_detalle_sp

create type Ty_detalle_sp as table(
	codigo_pr int,
    descripcion_pr varchar(100),
    descripcion_ma varchar(40),
    descripcion_um varchar(40),
    descripcion_ca varchar(40),
    cantidad decimal(10,2),
    pu_venta decimal(10,2),
    total decimal(10,2));

go

--
-- Listado de Cabecera
--
create or alter procedure spListado_Enc_Salida_Productos
 @estado bit,
 @texto varchar(100)    
as    
	select s.codigo_sp, d.descripcion_tde, s.nro_documento_sp, s.fecha_sp, 
		c.razon_social_cl, s.observaciones, 
		s.subtotal, s.igv, s.total_importe, 		
		s.codigo_tde, s.codigo_cl, s.estado
	from Enc_Salida_Productos			 s
	 inner join Tipos_Documentos_Emision d on s.codigo_tde = d.codigo_tde
	 inner join Clientes                 c on s.codigo_cl  = c.codigo_cl
	 where s.estado = @estado and  
   upper(trim(razon_social_cl)) like '%' + upper(trim(@texto)) + '%'    
 ORDER BY razon_social_cl

go

--
-- Listado de Detalle
--
create or alter procedure spListado_Det_Salida_Productos
	@codigo_sp int
as
select	d.codigo_pr,
		p.descripcion_pr, 
		m.descripcion_ma, 
		u.descripcion_um, 
		c.descripcion_ca, 
		d.cantidad, d.pu_venta, d.total
	from Det_Salida_Productos	 d
		inner join Productos	 p on d.codigo_pr = p.codigo_pr
		inner join Marcas		 m on p.codigo_ma = m.codigo_ma
		inner join Unidad_Medida u on p.codigo_um = u.codigo_um
		inner join Categorias    c on p.codigo_ca = c.codigo_ca
	where d.codigo_sp = @codigo_sp
	order by p.descripcion_pr;	
go

--
-- Guardar Cabecera-Detalle y actualizar stock
--
create or alter procedure spGuardar_Salida_Productos
	@opt_guarda int,
	@codigo_sp int output,
	@codigo_tde int,
	@nro_documento_sp varchar(30),
	@codigo_cl int,
	@fecha_sp date,
	@observaciones text,
	@subtotal decimal(10,2),
	@igv decimal(10,2),
	@total_importe decimal(10,2),
	@tDetalle Ty_Detalle_sp readonly
as
	declare @codigo int
	declare @fecha_crea datetime
	set @fecha_crea = CONVERT(datetime, GETDATE())

	if @opt_guarda = 1
		begin
			-- insertando en Cabecera
			insert into Enc_Salida_Productos
				(codigo_tde, nro_documento_sp, codigo_cl, fecha_sp, 
				observaciones, subtotal, igv, total_importe, fecha_crea, estado) values
				(@codigo_tde, @nro_documento_sp, @codigo_cl, @fecha_sp, 
				@observaciones, @subtotal, @igv, @total_importe, @fecha_crea, 1);
			
			set @codigo = @@IDENTITY;
			set @codigo_sp = @codigo;

			-- insertando en Detalle
			insert into Det_Salida_Productos
				(codigo_sp, codigo_pr, cantidad, pu_venta, total) 
				select @codigo, t.codigo_pr, t.cantidad, t.pu_venta, t.total from @tDetalle t;

			-- actualizando stock
			update s
				set s.stock_actual = s.stock_actual - d.cantidad
				from Stock_Productos	s
					inner join Det_Salida_Productos d on d.codigo_pr = s.codigo_pr
					inner join Enc_Salida_Productos e on e.codigo_sp = d.codigo_sp and
														  s.codigo_al = 1
				where e.codigo_sp = @codigo;			
		end;
	else
		begin
			-- Solo actualiza Cabecera
			update Enc_Salida_Productos 
				set @codigo_tde = @codigo_tde,
					nro_documento_sp = @nro_documento_sp,
					codigo_cl = @codigo_cl,
					fecha_sp = @fecha_sp,
					observaciones = @observaciones
				where codigo_sp = @codigo_sp;
		end;
go

--
-- Elimina Cabecera
--
create or alter Procedure spEliminar_Salida_Productos
	@codigo_sp int
as
	update Enc_Salida_Productos
		set estado = 0
		where codigo_sp = @codigo_sp

	-- actualizando stock
	update s
		set s.stock_actual = s.stock_actual + d.cantidad
		from Stock_Productos	s
					inner join Det_Salida_Productos d on d.codigo_pr = s.codigo_pr
					inner join Enc_Salida_Productos e on e.codigo_sp = d.codigo_sp and
														  s.codigo_al = 1
		where e.codigo_sp = @codigo_sp
