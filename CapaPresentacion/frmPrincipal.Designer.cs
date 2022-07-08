namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_UnidadMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Rubros = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Almacenes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Ubicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_EntradaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SalidaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ConsolidadoIngPorProd = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ConsolidadoSalPorProd = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraBotones = new System.Windows.Forms.ToolStrip();
            this.btn_Categorias = new System.Windows.Forms.ToolStripButton();
            this.btn_Marcas = new System.Windows.Forms.ToolStripButton();
            this.btn_UnidadMedida = new System.Windows.Forms.ToolStripButton();
            this.btn_Rubros = new System.Windows.Forms.ToolStripButton();
            this.btn_Almacen = new System.Windows.Forms.ToolStripButton();
            this.btn_ubicacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Productos = new System.Windows.Forms.ToolStripButton();
            this.btn_clientes = new System.Windows.Forms.ToolStripButton();
            this.btn_proveedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_entrada_productos = new System.Windows.Forms.ToolStripButton();
            this.btn_salida_productos = new System.Windows.Forms.ToolStripButton();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.Menu_ConsolidadoIngAcuPorProd = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ConsolidadoSalAcuPorProd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.BarraBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.utilidadesToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1369, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Categorias,
            this.Menu_Marcas,
            this.Menu_UnidadMedida,
            this.Menu_Rubros,
            this.Menu_Almacenes,
            this.Menu_Ubicacion,
            this.toolStripSeparator3,
            this.Menu_Productos,
            this.Menu_Clientes,
            this.Menu_Proveedores});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // Menu_Categorias
            // 
            this.Menu_Categorias.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Categorias.Image")));
            this.Menu_Categorias.Name = "Menu_Categorias";
            this.Menu_Categorias.Size = new System.Drawing.Size(187, 22);
            this.Menu_Categorias.Text = "Categorias";
            this.Menu_Categorias.Click += new System.EventHandler(this.Menu_Categorias_Click);
            // 
            // Menu_Marcas
            // 
            this.Menu_Marcas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Marcas.Image")));
            this.Menu_Marcas.Name = "Menu_Marcas";
            this.Menu_Marcas.Size = new System.Drawing.Size(187, 22);
            this.Menu_Marcas.Text = "Marcas";
            this.Menu_Marcas.Click += new System.EventHandler(this.Menu_Marcas_Click);
            // 
            // Menu_UnidadMedida
            // 
            this.Menu_UnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("Menu_UnidadMedida.Image")));
            this.Menu_UnidadMedida.Name = "Menu_UnidadMedida";
            this.Menu_UnidadMedida.Size = new System.Drawing.Size(187, 22);
            this.Menu_UnidadMedida.Text = "Unidad de Medida";
            this.Menu_UnidadMedida.Click += new System.EventHandler(this.Menu_UnidadMedida_Click);
            // 
            // Menu_Rubros
            // 
            this.Menu_Rubros.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Rubros.Image")));
            this.Menu_Rubros.Name = "Menu_Rubros";
            this.Menu_Rubros.Size = new System.Drawing.Size(187, 22);
            this.Menu_Rubros.Text = "Rubros";
            this.Menu_Rubros.Click += new System.EventHandler(this.Menu_Rubros_Click);
            // 
            // Menu_Almacenes
            // 
            this.Menu_Almacenes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Almacenes.Image")));
            this.Menu_Almacenes.Name = "Menu_Almacenes";
            this.Menu_Almacenes.Size = new System.Drawing.Size(187, 22);
            this.Menu_Almacenes.Text = "Almacenes";
            this.Menu_Almacenes.Click += new System.EventHandler(this.Menu_Almacenes_Click);
            // 
            // Menu_Ubicacion
            // 
            this.Menu_Ubicacion.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Ubicacion.Image")));
            this.Menu_Ubicacion.Name = "Menu_Ubicacion";
            this.Menu_Ubicacion.Size = new System.Drawing.Size(187, 22);
            this.Menu_Ubicacion.Text = "Ubicación Geografica";
            this.Menu_Ubicacion.Click += new System.EventHandler(this.Menu_Ubicacion_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // Menu_Productos
            // 
            this.Menu_Productos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Productos.Image")));
            this.Menu_Productos.Name = "Menu_Productos";
            this.Menu_Productos.Size = new System.Drawing.Size(187, 22);
            this.Menu_Productos.Text = "Productos";
            this.Menu_Productos.Click += new System.EventHandler(this.Menu_Productos_Click);
            // 
            // Menu_Clientes
            // 
            this.Menu_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Clientes.Image")));
            this.Menu_Clientes.Name = "Menu_Clientes";
            this.Menu_Clientes.Size = new System.Drawing.Size(187, 22);
            this.Menu_Clientes.Text = "Clientes";
            this.Menu_Clientes.Click += new System.EventHandler(this.Menu_Clientes_Click);
            // 
            // Menu_Proveedores
            // 
            this.Menu_Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Proveedores.Image")));
            this.Menu_Proveedores.Name = "Menu_Proveedores";
            this.Menu_Proveedores.Size = new System.Drawing.Size(187, 22);
            this.Menu_Proveedores.Text = "Proveedores";
            this.Menu_Proveedores.Click += new System.EventHandler(this.Menu_Proveedores_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_EntradaProductos,
            this.Menu_SalidaProductos});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // Menu_EntradaProductos
            // 
            this.Menu_EntradaProductos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_EntradaProductos.Image")));
            this.Menu_EntradaProductos.Name = "Menu_EntradaProductos";
            this.Menu_EntradaProductos.Size = new System.Drawing.Size(246, 22);
            this.Menu_EntradaProductos.Text = "Entrada de Productos - Compras";
            this.Menu_EntradaProductos.Click += new System.EventHandler(this.Menu_EntradaProductos_Click);
            // 
            // Menu_SalidaProductos
            // 
            this.Menu_SalidaProductos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_SalidaProductos.Image")));
            this.Menu_SalidaProductos.Name = "Menu_SalidaProductos";
            this.Menu_SalidaProductos.Size = new System.Drawing.Size(246, 22);
            this.Menu_SalidaProductos.Text = "Salida de Productos - Ventas";
            this.Menu_SalidaProductos.Click += new System.EventHandler(this.Menu_SalidaProductos_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ConsolidadoIngPorProd,
            this.Menu_ConsolidadoIngAcuPorProd});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // Menu_ConsolidadoIngPorProd
            // 
            this.Menu_ConsolidadoIngPorProd.Name = "Menu_ConsolidadoIngPorProd";
            this.Menu_ConsolidadoIngPorProd.Size = new System.Drawing.Size(279, 22);
            this.Menu_ConsolidadoIngPorProd.Text = "Consolidado por Producto";
            this.Menu_ConsolidadoIngPorProd.Click += new System.EventHandler(this.Menu_ConsolidadoIngresoPorProducto_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ConsolidadoSalPorProd,
            this.Menu_ConsolidadoSalAcuPorProd});
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // Menu_ConsolidadoSalPorProd
            // 
            this.Menu_ConsolidadoSalPorProd.Name = "Menu_ConsolidadoSalPorProd";
            this.Menu_ConsolidadoSalPorProd.Size = new System.Drawing.Size(279, 22);
            this.Menu_ConsolidadoSalPorProd.Text = "Consolidado por Producto";
            this.Menu_ConsolidadoSalPorProd.Click += new System.EventHandler(this.Menu_ConsolidadoSalidaPorProducto_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Salir});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // Menu_Salir
            // 
            this.Menu_Salir.Name = "Menu_Salir";
            this.Menu_Salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.Menu_Salir.Size = new System.Drawing.Size(132, 22);
            this.Menu_Salir.Text = "Salir";
            this.Menu_Salir.Click += new System.EventHandler(this.Menu_Salir_Click);
            // 
            // BarraBotones
            // 
            this.BarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Categorias,
            this.btn_Marcas,
            this.btn_UnidadMedida,
            this.btn_Rubros,
            this.btn_Almacen,
            this.btn_ubicacion,
            this.toolStripSeparator1,
            this.btn_Productos,
            this.btn_clientes,
            this.btn_proveedores,
            this.toolStripSeparator2,
            this.btn_entrada_productos,
            this.btn_salida_productos,
            this.btn_Salir});
            this.BarraBotones.Location = new System.Drawing.Point(0, 24);
            this.BarraBotones.Name = "BarraBotones";
            this.BarraBotones.Size = new System.Drawing.Size(1369, 43);
            this.BarraBotones.TabIndex = 3;
            this.BarraBotones.Text = "BarraBotones";
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.AutoSize = false;
            this.btn_Categorias.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categorias.Image")));
            this.btn_Categorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Categorias.Size = new System.Drawing.Size(70, 40);
            this.btn_Categorias.Text = "Categorias";
            this.btn_Categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Categorias.Click += new System.EventHandler(this.btn_Categorias_Click);
            // 
            // btn_Marcas
            // 
            this.btn_Marcas.AutoSize = false;
            this.btn_Marcas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Marcas.Image")));
            this.btn_Marcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Marcas.Name = "btn_Marcas";
            this.btn_Marcas.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Marcas.Size = new System.Drawing.Size(70, 40);
            this.btn_Marcas.Text = "Marcas";
            this.btn_Marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Marcas.Click += new System.EventHandler(this.btn_Marcas_Click);
            // 
            // btn_UnidadMedida
            // 
            this.btn_UnidadMedida.AutoSize = false;
            this.btn_UnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("btn_UnidadMedida.Image")));
            this.btn_UnidadMedida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_UnidadMedida.Name = "btn_UnidadMedida";
            this.btn_UnidadMedida.Padding = new System.Windows.Forms.Padding(10);
            this.btn_UnidadMedida.Size = new System.Drawing.Size(70, 40);
            this.btn_UnidadMedida.Text = "Unidades";
            this.btn_UnidadMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_UnidadMedida.ToolTipText = "Unidades de Medida";
            this.btn_UnidadMedida.Click += new System.EventHandler(this.btn_UnidadMedida_Click);
            // 
            // btn_Rubros
            // 
            this.btn_Rubros.AutoSize = false;
            this.btn_Rubros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rubros.Image")));
            this.btn_Rubros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Rubros.Name = "btn_Rubros";
            this.btn_Rubros.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Rubros.Size = new System.Drawing.Size(70, 40);
            this.btn_Rubros.Text = "Rubros";
            this.btn_Rubros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Rubros.ToolTipText = "Rubros";
            this.btn_Rubros.Click += new System.EventHandler(this.btn_Rubros_Click);
            // 
            // btn_Almacen
            // 
            this.btn_Almacen.AutoSize = false;
            this.btn_Almacen.Image = ((System.Drawing.Image)(resources.GetObject("btn_Almacen.Image")));
            this.btn_Almacen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Almacen.Name = "btn_Almacen";
            this.btn_Almacen.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Almacen.Size = new System.Drawing.Size(70, 40);
            this.btn_Almacen.Text = "Almacen";
            this.btn_Almacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Almacen.ToolTipText = "Almacenes";
            this.btn_Almacen.Click += new System.EventHandler(this.btn_Almacen_Click);
            // 
            // btn_ubicacion
            // 
            this.btn_ubicacion.AutoSize = false;
            this.btn_ubicacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubicacion.Image")));
            this.btn_ubicacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ubicacion.Name = "btn_ubicacion";
            this.btn_ubicacion.Padding = new System.Windows.Forms.Padding(10);
            this.btn_ubicacion.Size = new System.Drawing.Size(70, 40);
            this.btn_ubicacion.Text = "Ubicación";
            this.btn_ubicacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ubicacion.ToolTipText = "Ubicacion Geografica";
            this.btn_ubicacion.Click += new System.EventHandler(this.btn_ubicacion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btn_Productos
            // 
            this.btn_Productos.AutoSize = false;
            this.btn_Productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Productos.Image")));
            this.btn_Productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Padding = new System.Windows.Forms.Padding(10);
            this.btn_Productos.Size = new System.Drawing.Size(70, 40);
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Productos.ToolTipText = "Productos y Stock";
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.AutoSize = false;
            this.btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Image")));
            this.btn_clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Padding = new System.Windows.Forms.Padding(10);
            this.btn_clientes.Size = new System.Drawing.Size(70, 40);
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clientes.ToolTipText = "Clientes";
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.AutoSize = false;
            this.btn_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("btn_proveedores.Image")));
            this.btn_proveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Padding = new System.Windows.Forms.Padding(10);
            this.btn_proveedores.Size = new System.Drawing.Size(70, 40);
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_proveedores.ToolTipText = "Proveedores";
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btn_entrada_productos
            // 
            this.btn_entrada_productos.AutoSize = false;
            this.btn_entrada_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_entrada_productos.Image")));
            this.btn_entrada_productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_entrada_productos.Name = "btn_entrada_productos";
            this.btn_entrada_productos.Padding = new System.Windows.Forms.Padding(10);
            this.btn_entrada_productos.Size = new System.Drawing.Size(70, 40);
            this.btn_entrada_productos.Text = "Entradas";
            this.btn_entrada_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_entrada_productos.ToolTipText = "Entrada de Productos";
            this.btn_entrada_productos.Click += new System.EventHandler(this.btn_entrada_productos_Click);
            // 
            // btn_salida_productos
            // 
            this.btn_salida_productos.AutoSize = false;
            this.btn_salida_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_salida_productos.Image")));
            this.btn_salida_productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salida_productos.Name = "btn_salida_productos";
            this.btn_salida_productos.Padding = new System.Windows.Forms.Padding(10);
            this.btn_salida_productos.Size = new System.Drawing.Size(70, 40);
            this.btn_salida_productos.Text = "Salidas";
            this.btn_salida_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salida_productos.ToolTipText = "Salida de Productos";
            this.btn_salida_productos.Click += new System.EventHandler(this.btn_salida_productos_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = false;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(70, 40);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Menu_ConsolidadoIngAcuPorProd
            // 
            this.Menu_ConsolidadoIngAcuPorProd.Name = "Menu_ConsolidadoIngAcuPorProd";
            this.Menu_ConsolidadoIngAcuPorProd.Size = new System.Drawing.Size(279, 22);
            this.Menu_ConsolidadoIngAcuPorProd.Text = "Consolidado Acumulado por Producto";
            this.Menu_ConsolidadoIngAcuPorProd.Click += new System.EventHandler(this.Menu_ConsolidadoIngAcuPorProd_Click);
            // 
            // Menu_ConsolidadoSalAcuPorProd
            // 
            this.Menu_ConsolidadoSalAcuPorProd.Name = "Menu_ConsolidadoSalAcuPorProd";
            this.Menu_ConsolidadoSalAcuPorProd.Size = new System.Drawing.Size(279, 22);
            this.Menu_ConsolidadoSalAcuPorProd.Text = "Consolidado Acumulado por Producto";
            this.Menu_ConsolidadoSalAcuPorProd.Click += new System.EventHandler(this.Menu_ConsolidadoSalAcuPorProd_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 847);
            this.Controls.Add(this.BarraBotones);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación de Minimarket San Jorge";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.BarraBotones.ResumeLayout(false);
            this.BarraBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Salir;
        private System.Windows.Forms.ToolStrip BarraBotones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripButton btn_Categorias;
        private System.Windows.Forms.ToolStripMenuItem Menu_Categorias;
        private System.Windows.Forms.ToolStripMenuItem Menu_Marcas;
        private System.Windows.Forms.ToolStripMenuItem Menu_UnidadMedida;
        private System.Windows.Forms.ToolStripButton btn_Marcas;
        private System.Windows.Forms.ToolStripButton btn_UnidadMedida;
        private System.Windows.Forms.ToolStripMenuItem Menu_Almacenes;
        private System.Windows.Forms.ToolStripButton btn_Almacen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Menu_Productos;
        private System.Windows.Forms.ToolStripButton btn_Productos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_Rubros;
        private System.Windows.Forms.ToolStripButton btn_Rubros;
        private System.Windows.Forms.ToolStripMenuItem Menu_Ubicacion;
        private System.Windows.Forms.ToolStripButton btn_ubicacion;
        private System.Windows.Forms.ToolStripButton btn_proveedores;
        private System.Windows.Forms.ToolStripButton btn_entrada_productos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Clientes;
        private System.Windows.Forms.ToolStripButton btn_clientes;
        private System.Windows.Forms.ToolStripButton btn_salida_productos;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_EntradaProductos;
        private System.Windows.Forms.ToolStripMenuItem Menu_SalidaProductos;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_ConsolidadoIngPorProd;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_ConsolidadoSalPorProd;
        private System.Windows.Forms.ToolStripMenuItem Menu_ConsolidadoIngAcuPorProd;
        private System.Windows.Forms.ToolStripMenuItem Menu_ConsolidadoSalAcuPorProd;
    }
}