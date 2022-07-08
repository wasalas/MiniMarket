--
-- Proveedores
--
CREATE or alter procedure spListado_Proveedores
 @estado bit,  
 @texto varchar(150)  
as  
	select codigo_pv, i.descripcion_tdi, nro_documento_pv, razon_social_pv, apellidos, nombres,
      s.descripcion_sx, r.descripcion_ru, email, telefonos, movil, direccion,
      d.descripcion_di, observaciones, p.estado,
	  p.codigo_tdi, p.codigo_sx, p.codigo_ru, p.codigo_de, p.codigo_po, p.codigo_di
	from Proveedores                          p
		inner join Tipos_Documentos_Identidad i on p.codigo_tdi = i.codigo_tdi
		inner join Sexos                      s on p.codigo_sx   = s.codigo_sx
		inner join Rubros                     r on p.codigo_ru   = r.codigo_ru
		inner join Distritos                  d on p.codigo_di    = d.codigo_di
	where p.estado = @estado and
 		upper(trim(razon_social_pv) + trim(nombres) + trim(apellidos)) like '%' + upper(trim(@texto)) + '%'  
	ORDER BY p.razon_social_pv, p.apellidos, p.nombres;
 
 go

 CREATE or alter procedure spGuardar_Proveedores
  @opt_guarda int,
  @codigo_pv int,
  @codigo_tdi int,
  @nro_documento_pv varchar(30),
  @razon_social_pv varchar(150),
  @apellidos varchar(100),
  @nombres varchar(100),
  @codigo_sx int,
  @codigo_ru int,
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
			INSERT INTO Proveedores
	           (codigo_tdi, nro_documento_pv, razon_social_pv, apellidos, nombres, 
		       codigo_sx, codigo_ru, email, telefonos, movil, direccion, 
			   codigo_de, codigo_po, codigo_di, observaciones, fecha_crea, estado)
     VALUES
	           (@codigo_tdi, @nro_documento_pv, @razon_social_pv, @apellidos, @nombres, 
		        @codigo_sx, @codigo_ru, @email, @telefonos, @movil, @direccion, 
			    @codigo_de, @codigo_po, @codigo_di, @observaciones, @fecha_crea, @estado);
		end;  
	else  
		begin  
			UPDATE Proveedores
			   SET codigo_tdi = @codigo_tdi,
				  nro_documento_pv = @nro_documento_pv,
				  razon_social_pv = @razon_social_pv,
				  apellidos = @apellidos, 
				  nombres = @nombres, 
				  codigo_sx = @codigo_sx, 
				  codigo_ru = @codigo_ru, 
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
			 WHERE codigo_pv = @codigo_pv;
		End;  

go

create or alter procedure spEliminar_Proveedores
 @codigo_pv int  
as  
	update Proveedores set estado = 0  
		where codigo_pv = @codigo_pv;

go