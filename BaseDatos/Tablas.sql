
-- SP Listado de Tablas que no llevan mantenimiento

--
-- Tipos de Doc Identidad
--
CREATE or alter procedure spListado_Tipos_Documentos_Identidad
 @estado bit 
as  
 select codigo_tdi, descripcion_tdi, estado
	from Tipos_Documentos_Identidad  
	where estado = @estado  
	ORDER BY codigo_tdi;
 go

--
-- Tipos de Doc Emision
--
CREATE or alter procedure spListado_Tipos_Documentos_Emision
 @estado bit 
as  
 select codigo_tde, descripcion_tde, estado
	from Tipos_Documentos_Emision
	where estado = @estado  
	ORDER BY codigo_tde;
 go

--
-- sexos
--
CREATE or alter procedure spListado_Sexos
 @estado bit 
as  
 select codigo_sx, descripcion_sx, estado
	from Sexos
	where estado = @estado  
	ORDER BY codigo_sx;
 go
--
-- rubros
--
CREATE or alter procedure spListado_Rubros
 @estado bit,
 @texto varchar(100)  
as  
	select codigo_ru, descripcion_ru, estado
		from Rubros
		where estado = @estado  and
			upper(trim(descripcion_ru)) like '%' + upper(trim(@texto)) + '%'  
		ORDER BY descripcion_ru;
 go
--
-- departamentos
--
CREATE or alter procedure spListado_Departamentos
 @estado bit,
 @texto varchar(100)  
as  
 select codigo_de, descripcion_de, estado
	from Departamentos
	where estado = @estado  and
		upper(trim(descripcion_de)) like '%' + upper(trim(@texto)) + '%'  
	ORDER BY descripcion_de;
 go


--
-- provincias
--
CREATE or alter procedure spListado_Provincias
 @codigo_de int,
 @estado bit,
 @texto varchar(100)  
as  
 select codigo_po, descripcion_po, codigo_de, estado
 from Provincias
		where codigo_de = @codigo_de and 
			estado = @estado  and
			upper(trim(descripcion_po)) like '%' + upper(trim(@texto)) + '%'  
 ORDER BY descripcion_po;
 go

--
-- distritos
--
CREATE or alter procedure spListado_Distritos
 @codigo_de int,
 @codigo_po int,
 @estado bit,
 @texto varchar(100)  
as  
 select codigo_di, descripcion_di, codigo_de, codigo_po, estado
 from Distritos
		where codigo_de = @codigo_de and 
		codigo_po = @codigo_po and 
		estado = @estado  and
		upper(trim(descripcion_di)) like '%' + upper(trim(@texto)) + '%'  
 ORDER BY descripcion_di; 
go