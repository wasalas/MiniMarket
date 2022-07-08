select * from Enc_Entrada_Productos;
select * from Det_Entrada_Productos;
select * from Stock_Productos;
select * from Productos
--
-- Limnpia toda la base de datos
--
delete from Det_Entrada_Productos;
delete from Enc_Entrada_Productos;
dbcc checkident(Enc_Entrada_Productos, reseed, 0);

update Stock_Productos set stock_actual = 0, pu_compra = 0


delete from Productos
dbcc checkident(productos, reseed, 0);

delete from Almacenes
dbcc checkident(almacenes, reseed, 0);

delete from Proveedores
dbcc checkident(Proveedores, reseed, 0);

delete from Rubros
dbcc checkident(Rubros, reseed, 0);

delete from Marcas
dbcc checkident(Marcas, reseed, 0);

delete from Unidad_Medida
dbcc checkident(Unidad_Medida, reseed, 0);

delete from Categorias
dbcc checkident(Categorias, reseed, 0);


