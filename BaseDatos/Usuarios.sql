--
-- Usuarios
--
CREATE or alter procedure spListado_Usuarios
 @estado bit,  
 @texto varchar(150)  
as  
	select codigo_us, nombre_us, clave_us, admin, estado
	from Usuarios
	where estado = @estado and
 		upper(trim(nombre_us)) like '%' + upper(trim(@texto)) + '%'  
	ORDER BY nombre_us
 
 go

CREATE or alter procedure spGuardar_Usuarios
  @opt_guarda int,
  @codigo_us int, 
  @nombre_us varchar(20), 
  @clave_us varchar(20), 
  @admin  bit,
  @estado bit
 as  

	if @opt_guarda = 1  
		begin  
			INSERT INTO Usuarios (nombre_us, clave_us, admin, estado)
						 VALUES (@nombre_us, @clave_us, @admin, 1);
		end;  
	else  
		begin  
			UPDATE Usuarios
			   SET nombre_us = @nombre_us,
				   clave_us = @clave_us, 
				   admin = @admin, 
				   estado = @estado
			 WHERE codigo_us = @codigo_us;
		End;  
go

create or alter procedure spEliminar_Usuarios
 @codigo_us int  
as  
	update Usuarios set estado = 0  
		where codigo_us = @codigo_us;

go