--
-- Limpiando tablas
--
delete from Det_Entrada_Productos;
delete from Enc_Entrada_Productos;
dbcc checkident(Enc_Entrada_Productos, reseed, 0);

--
-- Crear Estructura del Detalle
--
drop procedure if exists spGuardar_Entrada_Productos
DROP Type IF EXISTS Ty_detalle_ep

create type Ty_detalle_ep as table(
	codigo_pr int,
    descripcion_pr varchar(100),
    descripcion_ma varchar(40),
    descripcion_um varchar(40),
    descripcion_ca varchar(40),
    cantidad decimal(10,2),
    pu_compra decimal(10,2),
    total decimal(10,2));

go

--
-- Listado de Cabecera
--
create or alter procedure spListado_Enc_Entrada_Productos
 @estado bit,
 @texto varchar(100)    
as    
	select e.codigo_ep, d.descripcion_tde, e.nro_documento_ep, e.fecha_ep, 
		p.razon_social_pv, a.descripcion_al, e.observaciones, 
		e.subtotal, e.igv, e.total_importe, 		
		e.codigo_tde, e.codigo_pv, e.codigo_al, e.estado
	from Enc_Entrada_Productos			 e
	 inner join Tipos_Documentos_Emision d on e.codigo_tde = d.codigo_tde
	 inner join Proveedores              p on e.codigo_pv = p.codigo_pv
	 inner join Almacenes                a on e.codigo_al = a.codigo_al
	 where e.estado = @estado and  
   upper(trim(razon_social_pv)) like '%' + upper(trim(@texto)) + '%'    
 ORDER BY p.razon_social_pv

go

--
-- Listado de Detalle
--
create or alter procedure spListado_Det_Entrada_Productos
	@codigo_ep int
as
select	d.codigo_pr,
		p.descripcion_pr, 
		m.descripcion_ma, 
		u.descripcion_um, 
		c.descripcion_ca, 
		d.cantidad, d.pu_compra, d.total
	from Det_Entrada_Productos	 d
		inner join Productos	 p on d.codigo_pr = p.codigo_pr
		inner join Marcas		 m on p.codigo_ma = m.codigo_ma
		inner join Unidad_Medida u on p.codigo_um = u.codigo_um
		inner join Categorias    c on p.codigo_ca = c.codigo_ca
	where d.codigo_ep = @codigo_ep
	order by p.descripcion_pr;	
go

--
-- Guardar Cabecera-Detalle y actualizar stock
--
create or alter procedure spGuardar_Entrada_Productos
	@opt_guarda int,
	@codigo_ep int,
	@codigo_tde int,
	@nro_documento_ep varchar(30),
	@codigo_pv int,
	@fecha_ep date,
	@codigo_al int,
	@observaciones text,
	@subtotal decimal(10,2),
	@igv decimal(10,2),
	@total_importe decimal(10,2),
	@tDetalle Ty_Detalle_ep readonly
as
	declare @codigo int
	declare @fecha_crea datetime
	set @fecha_crea = CONVERT(datetime, GETDATE())

	if @opt_guarda = 1
		begin
			-- insertando en Cabecera
			insert into Enc_Entrada_Productos
				(codigo_tde, nro_documento_ep, codigo_pv,fecha_ep, codigo_al, 
				observaciones, subtotal, igv, total_importe, fecha_crea, estado) values
				(@codigo_tde, @nro_documento_ep, @codigo_pv, @fecha_ep, @codigo_al,
				@observaciones, @subtotal, @igv, @total_importe, @fecha_crea, 1);
			
			set @codigo = @@IDENTITY

			-- insertando en Detalle
			insert into Det_Entrada_Productos
				(codigo_ep, codigo_pr, cantidad, pu_compra, total) 
				select @codigo, t.codigo_pr, t.cantidad, t.pu_compra, t.total from @tDetalle t;

			-- actualizando stock
			update s
				set s.stock_actual = s.stock_actual + d.cantidad,
					s.pu_compra    = d.pu_compra
				from Stock_Productos	s
					inner join Det_Entrada_Productos d on d.codigo_pr = s.codigo_pr
					inner join Enc_Entrada_Productos e on e.codigo_ep = d.codigo_ep and
														  e.codigo_al = s.codigo_al
				where e.codigo_ep = @codigo
		end;
	else
		begin
			-- Solo actualiza Cabecera
			update Enc_Entrada_Productos 
				set @codigo_tde = @codigo_tde,
					nro_documento_ep = @nro_documento_ep ,
					codigo_pv = @codigo_pv,
					fecha_ep = @fecha_ep,
					codigo_al = @codigo_al,
					observaciones = @observaciones
				where codigo_ep = @codigo_ep;
		end;
go

--
-- Elimina Cabecera
--
create or alter Procedure spEliminar_Entrada_Productos
	@codigo_ep int
as
	update Enc_Entrada_Productos
		set estado = 0
		where codigo_ep = @codigo_ep

	-- actualizando stock
	update s
		set s.stock_actual = s.stock_actual - d.cantidad
		from Stock_Productos	s
					inner join Det_Entrada_Productos d on d.codigo_pr = s.codigo_pr
					inner join Enc_Entrada_Productos e on e.codigo_ep = d.codigo_ep and
														  e.codigo_al = s.codigo_al
		where e.codigo_ep = @codigo_ep