
create or alter procedure spConsolidado_IngresosPorProducto
	@fecha_ini date,
	@fecha_fin date
as
	select d.codigo_pr, p.descripcion_pr, m.descripcion_ma, u.descripcion_um, c.fecha_ep, 
			d.cantidad, d.pu_compra, d.total,
			a.descripcion_al, e.descripcion_tde, c.nro_documento_ep
		from Det_Entrada_Productos         	    d
			inner join Productos                p on p.codigo_pr = d.codigo_pr
			inner join Marcas                   m on m.codigo_ma = p.codigo_pr
			inner join Unidad_Medida            u on u.codigo_um = p.codigo_um
			inner join Enc_Entrada_Productos    c on c.codigo_ep = d.codigo_ep
			inner join Almacenes                a on c.codigo_al = a.codigo_al
			inner join Tipos_Documentos_Emision e on c.codigo_tde = e.codigo_tde
		where c.estado = 1 and c.fecha_ep between @fecha_ini and @fecha_fin
		order by d.codigo_pr, c.fecha_ep;
go

create or alter procedure spConsolidado_SalidasPorProducto
	@fecha_ini date,
	@fecha_fin date
as
	select d.codigo_pr, p.descripcion_pr, m.descripcion_ma, u.descripcion_um, c.fecha_sp,
			d.cantidad, d.pu_venta, d.total,
			e.descripcion_tde, c.nro_documento_sp
		from Det_Salida_Productos				d
			inner join Productos                p on p.codigo_pr = d.codigo_pr
			inner join Marcas                   m on m.codigo_ma = p.codigo_pr
			inner join Unidad_Medida            u on u.codigo_um = p.codigo_um
			inner join Enc_Salida_Productos     c on c.codigo_sp = d.codigo_sp
			inner join Tipos_Documentos_Emision e on c.codigo_tde = e.codigo_tde
		where c.estado = 1 and c.fecha_sp between @fecha_ini and @fecha_fin
		order by d.codigo_pr, c.fecha_sp;
go