select * from Categorias
select * from Marcas
select * from Unidad_Medida

select * from Almacenes
select * from Productos
select * from Stock_Productos

insert into Categorias values('LACTEOS',1)
insert into Marcas VALUES ('GLORIA',1)
insert into Unidad_Medida VALUES('LATAS','LAT',1)

delete from Stock_Productos
delete from Productos
delete from Almacenes

delete from Categorias
delete from Marcas
delete from Unidad_Medida

dbcc checkident(almacenes, reseed,0)
dbcc checkident(Almacenes, reseed,0)
dbcc checkident(Categorias, reseed,0)
dbcc checkident(Marcas, reseed,0)
dbcc checkident(Productos, reseed,0)
dbcc checkident(Unidad_Medida, reseed,0)

sp_helptext 'spEliminar_Marcas'