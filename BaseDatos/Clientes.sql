--
-- Clientes
--
CREATE or alter procedure spListado_Clientes
 @estado bit,  
 @texto varchar(150)  
as  
	select c.codigo_cl, i.descripcion_tdi, c.nro_documento_cl, c.razon_social_cl, c.apellidos, c.nombres,
      s.descripcion_sx, c.email, c.telefonos, c.movil, c.direccion,
      d.descripcion_di, c.observaciones, c.estado,
	  c.codigo_tdi, c.codigo_sx, c.codigo_de, c.codigo_po, c.codigo_di
	from Clientes                          c
		inner join Tipos_Documentos_Identidad i on c.codigo_tdi = i.codigo_tdi
		inner join Sexos                      s on c.codigo_sx  = s.codigo_sx
		inner join Distritos                  d on c.codigo_di  = d.codigo_di
	where c.estado = @estado and
 		upper(trim(razon_social_cl) + trim(nombres) + trim(apellidos)) like '%' + upper(trim(@texto)) + '%'  
	ORDER BY razon_social_cl, apellidos, nombres;
 
 go

 CREATE or alter procedure spGuardar_Clientes
  @opt_guarda int,
  @codigo_cl int,
  @codigo_tdi int,
  @nro_documento_cl varchar(30),
  @razon_social_cl varchar(150),
  @apellidos varchar(100),
  @nombres varchar(100),
  @codigo_sx int,
  @email varchar(150),
  @telefonos varchar(50),
  @movil varchar(50),
  @direccion varchar(150),
  @codigo_de int,
  @codigo_po int,
  @codigo_di int,
  @observaciones text,  
  @estado bit
 as  
	declare @fecha_crea datetime
	set @fecha_crea = convert( datetime, getdate())

	if @opt_guarda = 1  
		begin  
			INSERT INTO Clientes
	           (codigo_tdi, nro_documento_cl, razon_social_cl, apellidos, nombres, 
		       codigo_sx, email, telefonos, movil, direccion, 
			   codigo_de, codigo_po, codigo_di, observaciones, fecha_crea, estado)
     VALUES
	           (@codigo_tdi, @nro_documento_cl, @razon_social_cl, @apellidos, @nombres, 
		        @codigo_sx, @email, @telefonos, @movil, @direccion, 
			    @codigo_de, @codigo_po, @codigo_di, @observaciones, @fecha_crea, @estado);
		end;  
	else  
		begin  
			UPDATE Clientes
			   SET codigo_tdi = @codigo_tdi,
				  nro_documento_cl = @nro_documento_cl,
				  razon_social_cl = @razon_social_cl,
				  apellidos = @apellidos, 
				  nombres = @nombres, 
				  codigo_sx = @codigo_sx, 
				  email = @email, 
				  telefonos = @telefonos, 
				  movil = @movil, 
				  direccion = @direccion, 
				  codigo_de = @codigo_de, 
				  codigo_po = @codigo_po, 
				  codigo_di = @codigo_di, 
				  observaciones = @observaciones, 
				  fecha_modifica = @fecha_crea,
				  estado = @estado
			 WHERE codigo_cl = @codigo_cl;
		End;  

go

create or alter procedure spEliminar_Clientes
 @codigo_cl int  
as  
	update Clientes set estado = 0  
		where codigo_cl = @codigo_cl;

go