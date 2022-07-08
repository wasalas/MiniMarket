--
-- Consultas
--
select * from Departamentos order by descripcion_de
select * from Provincias order by codigo_de,descripcion_po
select * from Distritos  order by codigo_de, codigo_po, descripcion_di
--
--departamentos
--
CREATE or alter procedure spListado_Departamentos
 @estado bit,  
 @texto varchar(100)  
as  
 select codigo_de, descripcion_de, estado   
 from Departamentos
 where estado = @estado and  
  upper(trim(cast(codigo_de as char)) + trim(descripcion_de)) like '%' + upper(trim(@texto)) + '%'  
 ORDER BY descripcion_de;

 go

 CREATE or alter procedure spGuardar_Departamentos
  @opt_guarda int, 
  @codigo int,  
  @descripcion varchar(50),  
  @estado bit  
 as  
  if @opt_guarda = 1  
   begin  
	insert into Departamentos (descripcion_de, estado)values(@descripcion, 1)  
   end;  
  else  
   begin  
	update Departamentos set descripcion_de = @descripcion, estado = @estado where codigo_de = @codigo  
   End;  
 
 go

create or alter procedure spEliminar_Departamentos
 @codigo int  
as  
 update Departamentos set estado = 0  
 where codigo_de = @codigo  

--
-- Provincias
--
CREATE or alter procedure spListado_Provincias
 @codigo_de int,  
 @estado bit,  
 @texto varchar(100)  
as  
 select codigo_po, descripcion_po, estado   
	 from Provincias
	where codigo_de = @codigo_de and
			estado = @estado and  
			upper(trim(cast(codigo_po as char)) + trim(descripcion_po)) like '%' + upper(trim(@texto)) + '%'  
	ORDER BY descripcion_po;

go

CREATE or alter procedure spGuardar_Provincias
  @opt_guarda int, 
  @codigo_po int,  
  @descripcion varchar(50),  
  @codigo_de int,
  @estado bit  
 as  
  if @opt_guarda = 1  
   begin  
    insert into Provincias (descripcion_po, codigo_de, estado)values(@descripcion, @codigo_de, 1)  
   end;  
  else  
   begin  
    update Provincias set descripcion_po = @descripcion, estado = @estado where codigo_po = @codigo_po
   End;  

go

create or alter procedure spEliminar_Provincias
 @codigo int  
as  
 update Provincias  
 set estado = 0  
 where codigo_po = @codigo  

go

--
-- Distritos
--
CREATE or alter procedure spListado_Distritos
 @codigo_de int,
 @codigo_po int,
 @estado bit,  
 @texto varchar(100)  
as  
 select codigo_di, descripcion_di, estado   
 from Distritos
 where	codigo_de = @codigo_de and 
		codigo_po = @codigo_po and
		estado    = @estado and  
		upper(trim(cast(codigo_di as char)) + trim(descripcion_di)) like '%' + upper(trim(@texto)) + '%'  
 ORDER BY descripcion_di;

 go

 CREATE or alter procedure spGuardar_Distritos
  @opt_guarda int, 
  @codigo_di int,  
  @descripcion varchar(50),
  @codigo_de int,
  @codigo_po int,
  @estado bit  
 as  
  if @opt_guarda = 1  
   begin  
    insert into Distritos (descripcion_di,codigo_de, codigo_po, estado)values(@descripcion,@codigo_de,@codigo_po, 1)  
   end;  
  else  
   begin  
    update Distritos set descripcion_di = @descripcion, 
						 codigo_de = @codigo_de,
						 codigo_po = @codigo_po,
						 estado = @estado 
					 where codigo_di = @codigo_di
   End;  
 
 go

create or alter procedure spEliminar_Distritos
 @codigo int  
as  
 update Distritos  
 set estado = 0  
 where codigo_di = @codigo  
