namespace CapaPresentacion
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_cerrar_sistema = new FontAwesome.Sharp.IconButton();
            this.pnl_sistema = new System.Windows.Forms.Panel();
            this.btn_usuarios = new FontAwesome.Sharp.IconButton();
            this.btn_sistema = new FontAwesome.Sharp.IconButton();
            this.pnl_tablas = new System.Windows.Forms.Panel();
            this.btn_ubicacion = new FontAwesome.Sharp.IconButton();
            this.btn_rubros = new FontAwesome.Sharp.IconButton();
            this.btn_proveedores = new FontAwesome.Sharp.IconButton();
            this.btn_clientes = new FontAwesome.Sharp.IconButton();
            this.btn_almacen = new FontAwesome.Sharp.IconButton();
            this.btn_categorias = new FontAwesome.Sharp.IconButton();
            this.btn_unidades = new FontAwesome.Sharp.IconButton();
            this.btn_marcas = new FontAwesome.Sharp.IconButton();
            this.btn_productos = new FontAwesome.Sharp.IconButton();
            this.btn_tablas = new FontAwesome.Sharp.IconButton();
            this.pnl_reportes = new System.Windows.Forms.Panel();
            this.btn_RepSalAcuProd = new FontAwesome.Sharp.IconButton();
            this.btn_RepSalProd = new FontAwesome.Sharp.IconButton();
            this.btn_RepIngAcuProd = new FontAwesome.Sharp.IconButton();
            this.btn_RepIngProd = new FontAwesome.Sharp.IconButton();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.pnl_procesos = new System.Windows.Forms.Panel();
            this.btn_salida_prod = new FontAwesome.Sharp.IconButton();
            this.btn_entrada_prod = new FontAwesome.Sharp.IconButton();
            this.btn_procesos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_cuerpo = new System.Windows.Forms.Panel();
            this.pnl_pie = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_sistema.SuspendLayout();
            this.pnl_tablas.SuspendLayout();
            this.pnl_reportes.SuspendLayout();
            this.pnl_procesos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.AutoScroll = true;
            this.pnl_menu.BackColor = System.Drawing.Color.Coral;
            this.pnl_menu.Controls.Add(this.btn_cerrar_sistema);
            this.pnl_menu.Controls.Add(this.pnl_sistema);
            this.pnl_menu.Controls.Add(this.btn_sistema);
            this.pnl_menu.Controls.Add(this.pnl_tablas);
            this.pnl_menu.Controls.Add(this.btn_tablas);
            this.pnl_menu.Controls.Add(this.pnl_reportes);
            this.pnl_menu.Controls.Add(this.btn_reportes);
            this.pnl_menu.Controls.Add(this.pnl_procesos);
            this.pnl_menu.Controls.Add(this.btn_procesos);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(227, 761);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_cerrar_sistema
            // 
            this.btn_cerrar_sistema.BackColor = System.Drawing.Color.Coral;
            this.btn_cerrar_sistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cerrar_sistema.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btn_cerrar_sistema.IconColor = System.Drawing.Color.Black;
            this.btn_cerrar_sistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar_sistema.IconSize = 38;
            this.btn_cerrar_sistema.Location = new System.Drawing.Point(0, 920);
            this.btn_cerrar_sistema.Name = "btn_cerrar_sistema";
            this.btn_cerrar_sistema.Size = new System.Drawing.Size(210, 45);
            this.btn_cerrar_sistema.TabIndex = 23;
            this.btn_cerrar_sistema.Text = "SALIR";
            this.btn_cerrar_sistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar_sistema.UseVisualStyleBackColor = false;
            this.btn_cerrar_sistema.Click += new System.EventHandler(this.btn_cerrar_sistema_Click);
            // 
            // pnl_sistema
            // 
            this.pnl_sistema.AutoSize = true;
            this.pnl_sistema.Controls.Add(this.btn_usuarios);
            this.pnl_sistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sistema.Location = new System.Drawing.Point(0, 880);
            this.pnl_sistema.Name = "pnl_sistema";
            this.pnl_sistema.Size = new System.Drawing.Size(210, 40);
            this.pnl_sistema.TabIndex = 22;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Orange;
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_usuarios.IconColor = System.Drawing.Color.Black;
            this.btn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 0);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(210, 40);
            this.btn_usuarios.TabIndex = 11;
            this.btn_usuarios.Text = "Usuarios del Sistema";
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_sistema
            // 
            this.btn_sistema.BackColor = System.Drawing.Color.Coral;
            this.btn_sistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sistema.IconChar = FontAwesome.Sharp.IconChar.Safari;
            this.btn_sistema.IconColor = System.Drawing.Color.Black;
            this.btn_sistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sistema.IconSize = 38;
            this.btn_sistema.Location = new System.Drawing.Point(0, 835);
            this.btn_sistema.Name = "btn_sistema";
            this.btn_sistema.Size = new System.Drawing.Size(210, 45);
            this.btn_sistema.TabIndex = 21;
            this.btn_sistema.Text = "SISTEMA";
            this.btn_sistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sistema.UseVisualStyleBackColor = false;
            this.btn_sistema.Click += new System.EventHandler(this.btn_sistema_Click);
            // 
            // pnl_tablas
            // 
            this.pnl_tablas.AutoSize = true;
            this.pnl_tablas.Controls.Add(this.btn_ubicacion);
            this.pnl_tablas.Controls.Add(this.btn_rubros);
            this.pnl_tablas.Controls.Add(this.btn_proveedores);
            this.pnl_tablas.Controls.Add(this.btn_clientes);
            this.pnl_tablas.Controls.Add(this.btn_almacen);
            this.pnl_tablas.Controls.Add(this.btn_categorias);
            this.pnl_tablas.Controls.Add(this.btn_unidades);
            this.pnl_tablas.Controls.Add(this.btn_marcas);
            this.pnl_tablas.Controls.Add(this.btn_productos);
            this.pnl_tablas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tablas.Location = new System.Drawing.Point(0, 475);
            this.pnl_tablas.Name = "pnl_tablas";
            this.pnl_tablas.Size = new System.Drawing.Size(210, 360);
            this.pnl_tablas.TabIndex = 20;
            // 
            // btn_ubicacion
            // 
            this.btn_ubicacion.BackColor = System.Drawing.Color.Orange;
            this.btn_ubicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ubicacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ubicacion.IconColor = System.Drawing.Color.Black;
            this.btn_ubicacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ubicacion.Location = new System.Drawing.Point(0, 320);
            this.btn_ubicacion.Name = "btn_ubicacion";
            this.btn_ubicacion.Size = new System.Drawing.Size(210, 40);
            this.btn_ubicacion.TabIndex = 18;
            this.btn_ubicacion.Text = "Ubicacion Geografica";
            this.btn_ubicacion.UseVisualStyleBackColor = false;
            // 
            // btn_rubros
            // 
            this.btn_rubros.BackColor = System.Drawing.Color.Orange;
            this.btn_rubros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rubros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_rubros.IconColor = System.Drawing.Color.Black;
            this.btn_rubros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rubros.Location = new System.Drawing.Point(0, 280);
            this.btn_rubros.Name = "btn_rubros";
            this.btn_rubros.Size = new System.Drawing.Size(210, 40);
            this.btn_rubros.TabIndex = 17;
            this.btn_rubros.Text = "Rubros";
            this.btn_rubros.UseVisualStyleBackColor = false;
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackColor = System.Drawing.Color.Orange;
            this.btn_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_proveedores.IconColor = System.Drawing.Color.Black;
            this.btn_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_proveedores.Location = new System.Drawing.Point(0, 240);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(210, 40);
            this.btn_proveedores.TabIndex = 16;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Orange;
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_clientes.IconColor = System.Drawing.Color.Black;
            this.btn_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clientes.Location = new System.Drawing.Point(0, 200);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(210, 40);
            this.btn_clientes.TabIndex = 15;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_almacen
            // 
            this.btn_almacen.BackColor = System.Drawing.Color.Orange;
            this.btn_almacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_almacen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_almacen.IconColor = System.Drawing.Color.Black;
            this.btn_almacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_almacen.Location = new System.Drawing.Point(0, 160);
            this.btn_almacen.Name = "btn_almacen";
            this.btn_almacen.Size = new System.Drawing.Size(210, 40);
            this.btn_almacen.TabIndex = 14;
            this.btn_almacen.Text = "Almacenes";
            this.btn_almacen.UseVisualStyleBackColor = false;
            // 
            // btn_categorias
            // 
            this.btn_categorias.BackColor = System.Drawing.Color.Orange;
            this.btn_categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_categorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_categorias.IconColor = System.Drawing.Color.Black;
            this.btn_categorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_categorias.Location = new System.Drawing.Point(0, 120);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(210, 40);
            this.btn_categorias.TabIndex = 13;
            this.btn_categorias.Text = "Categorias";
            this.btn_categorias.UseVisualStyleBackColor = false;
            // 
            // btn_unidades
            // 
            this.btn_unidades.BackColor = System.Drawing.Color.Orange;
            this.btn_unidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_unidades.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_unidades.IconColor = System.Drawing.Color.Black;
            this.btn_unidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_unidades.Location = new System.Drawing.Point(0, 80);
            this.btn_unidades.Name = "btn_unidades";
            this.btn_unidades.Size = new System.Drawing.Size(210, 40);
            this.btn_unidades.TabIndex = 12;
            this.btn_unidades.Text = "Unidades de Medida";
            this.btn_unidades.UseVisualStyleBackColor = false;
            // 
            // btn_marcas
            // 
            this.btn_marcas.BackColor = System.Drawing.Color.Orange;
            this.btn_marcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_marcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_marcas.IconColor = System.Drawing.Color.Black;
            this.btn_marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_marcas.Location = new System.Drawing.Point(0, 40);
            this.btn_marcas.Name = "btn_marcas";
            this.btn_marcas.Size = new System.Drawing.Size(210, 40);
            this.btn_marcas.TabIndex = 11;
            this.btn_marcas.Text = "Marcas";
            this.btn_marcas.UseVisualStyleBackColor = false;
            this.btn_marcas.Click += new System.EventHandler(this.btn_marcas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.Color.Orange;
            this.btn_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_productos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_productos.IconColor = System.Drawing.Color.Black;
            this.btn_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_productos.Location = new System.Drawing.Point(0, 0);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(210, 40);
            this.btn_productos.TabIndex = 10;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            // 
            // btn_tablas
            // 
            this.btn_tablas.BackColor = System.Drawing.Color.Coral;
            this.btn_tablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tablas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tablas.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btn_tablas.IconColor = System.Drawing.Color.Black;
            this.btn_tablas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tablas.IconSize = 38;
            this.btn_tablas.Location = new System.Drawing.Point(0, 430);
            this.btn_tablas.Name = "btn_tablas";
            this.btn_tablas.Size = new System.Drawing.Size(210, 45);
            this.btn_tablas.TabIndex = 19;
            this.btn_tablas.Text = "TABLAS";
            this.btn_tablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tablas.UseVisualStyleBackColor = false;
            this.btn_tablas.Click += new System.EventHandler(this.btn_tablas_Click);
            // 
            // pnl_reportes
            // 
            this.pnl_reportes.AutoSize = true;
            this.pnl_reportes.Controls.Add(this.btn_RepSalAcuProd);
            this.pnl_reportes.Controls.Add(this.btn_RepSalProd);
            this.pnl_reportes.Controls.Add(this.btn_RepIngAcuProd);
            this.pnl_reportes.Controls.Add(this.btn_RepIngProd);
            this.pnl_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_reportes.Location = new System.Drawing.Point(0, 270);
            this.pnl_reportes.Name = "pnl_reportes";
            this.pnl_reportes.Size = new System.Drawing.Size(210, 160);
            this.pnl_reportes.TabIndex = 18;
            // 
            // btn_RepSalAcuProd
            // 
            this.btn_RepSalAcuProd.BackColor = System.Drawing.Color.Orange;
            this.btn_RepSalAcuProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RepSalAcuProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RepSalAcuProd.IconColor = System.Drawing.Color.Black;
            this.btn_RepSalAcuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RepSalAcuProd.Location = new System.Drawing.Point(0, 120);
            this.btn_RepSalAcuProd.Name = "btn_RepSalAcuProd";
            this.btn_RepSalAcuProd.Size = new System.Drawing.Size(210, 40);
            this.btn_RepSalAcuProd.TabIndex = 19;
            this.btn_RepSalAcuProd.Text = "Salida Acumulada de Productos";
            this.btn_RepSalAcuProd.UseVisualStyleBackColor = false;
            // 
            // btn_RepSalProd
            // 
            this.btn_RepSalProd.BackColor = System.Drawing.Color.Orange;
            this.btn_RepSalProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RepSalProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RepSalProd.IconColor = System.Drawing.Color.Black;
            this.btn_RepSalProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RepSalProd.Location = new System.Drawing.Point(0, 80);
            this.btn_RepSalProd.Name = "btn_RepSalProd";
            this.btn_RepSalProd.Size = new System.Drawing.Size(210, 40);
            this.btn_RepSalProd.TabIndex = 18;
            this.btn_RepSalProd.Text = "Salida de Productos";
            this.btn_RepSalProd.UseVisualStyleBackColor = false;
            // 
            // btn_RepIngAcuProd
            // 
            this.btn_RepIngAcuProd.BackColor = System.Drawing.Color.Orange;
            this.btn_RepIngAcuProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RepIngAcuProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RepIngAcuProd.IconColor = System.Drawing.Color.Black;
            this.btn_RepIngAcuProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RepIngAcuProd.Location = new System.Drawing.Point(0, 40);
            this.btn_RepIngAcuProd.Name = "btn_RepIngAcuProd";
            this.btn_RepIngAcuProd.Size = new System.Drawing.Size(210, 40);
            this.btn_RepIngAcuProd.TabIndex = 17;
            this.btn_RepIngAcuProd.Text = "Ingreso Acumulado de Productos";
            this.btn_RepIngAcuProd.UseVisualStyleBackColor = false;
            // 
            // btn_RepIngProd
            // 
            this.btn_RepIngProd.BackColor = System.Drawing.Color.Orange;
            this.btn_RepIngProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RepIngProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RepIngProd.IconColor = System.Drawing.Color.Black;
            this.btn_RepIngProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RepIngProd.Location = new System.Drawing.Point(0, 0);
            this.btn_RepIngProd.Name = "btn_RepIngProd";
            this.btn_RepIngProd.Size = new System.Drawing.Size(210, 40);
            this.btn_RepIngProd.TabIndex = 16;
            this.btn_RepIngProd.Text = "Ingreso Productos";
            this.btn_RepIngProd.UseVisualStyleBackColor = false;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Coral;
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btn_reportes.IconColor = System.Drawing.Color.Black;
            this.btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reportes.IconSize = 38;
            this.btn_reportes.Location = new System.Drawing.Point(0, 225);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(210, 45);
            this.btn_reportes.TabIndex = 17;
            this.btn_reportes.Text = "REPORTES";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // pnl_procesos
            // 
            this.pnl_procesos.AutoSize = true;
            this.pnl_procesos.Controls.Add(this.btn_salida_prod);
            this.pnl_procesos.Controls.Add(this.btn_entrada_prod);
            this.pnl_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_procesos.Location = new System.Drawing.Point(0, 145);
            this.pnl_procesos.Name = "pnl_procesos";
            this.pnl_procesos.Size = new System.Drawing.Size(210, 80);
            this.pnl_procesos.TabIndex = 16;
            // 
            // btn_salida_prod
            // 
            this.btn_salida_prod.BackColor = System.Drawing.Color.Orange;
            this.btn_salida_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salida_prod.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_salida_prod.IconColor = System.Drawing.Color.Black;
            this.btn_salida_prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_salida_prod.Location = new System.Drawing.Point(0, 40);
            this.btn_salida_prod.Name = "btn_salida_prod";
            this.btn_salida_prod.Size = new System.Drawing.Size(210, 40);
            this.btn_salida_prod.TabIndex = 11;
            this.btn_salida_prod.Text = "Salida de Productos";
            this.btn_salida_prod.UseVisualStyleBackColor = false;
            this.btn_salida_prod.Click += new System.EventHandler(this.btn_salida_prod_Click);
            // 
            // btn_entrada_prod
            // 
            this.btn_entrada_prod.BackColor = System.Drawing.Color.Orange;
            this.btn_entrada_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_entrada_prod.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_entrada_prod.IconColor = System.Drawing.Color.Black;
            this.btn_entrada_prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_entrada_prod.Location = new System.Drawing.Point(0, 0);
            this.btn_entrada_prod.Name = "btn_entrada_prod";
            this.btn_entrada_prod.Size = new System.Drawing.Size(210, 40);
            this.btn_entrada_prod.TabIndex = 12;
            this.btn_entrada_prod.Text = "Entrada de Productos";
            this.btn_entrada_prod.UseVisualStyleBackColor = false;
            this.btn_entrada_prod.Click += new System.EventHandler(this.btn_entrada_prod_Click);
            // 
            // btn_procesos
            // 
            this.btn_procesos.BackColor = System.Drawing.Color.Coral;
            this.btn_procesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_procesos.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            this.btn_procesos.IconColor = System.Drawing.Color.Black;
            this.btn_procesos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_procesos.IconSize = 38;
            this.btn_procesos.Location = new System.Drawing.Point(0, 100);
            this.btn_procesos.Name = "btn_procesos";
            this.btn_procesos.Size = new System.Drawing.Size(210, 45);
            this.btn_procesos.TabIndex = 15;
            this.btn_procesos.Text = "PROCESOS";
            this.btn_procesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_procesos.UseVisualStyleBackColor = false;
            this.btn_procesos.Click += new System.EventHandler(this.btn_procesos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 100);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Coral;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.White;
            this.pnl_titulo.Controls.Add(this.lbl_subtitulo);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(227, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1144, 117);
            this.pnl_titulo.TabIndex = 1;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_subtitulo.Location = new System.Drawing.Point(6, 75);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(1126, 25);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "label2";
            this.lbl_subtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_subtitulo.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE MINIMARKET (Version 1.0)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_cuerpo
            // 
            this.pnl_cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cuerpo.Location = new System.Drawing.Point(227, 117);
            this.pnl_cuerpo.Name = "pnl_cuerpo";
            this.pnl_cuerpo.Size = new System.Drawing.Size(1144, 644);
            this.pnl_cuerpo.TabIndex = 2;
            this.pnl_cuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cuerpo_Paint);
            // 
            // pnl_pie
            // 
            this.pnl_pie.BackColor = System.Drawing.Color.LightGray;
            this.pnl_pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pie.Location = new System.Drawing.Point(227, 695);
            this.pnl_pie.Name = "pnl_pie";
            this.pnl_pie.Size = new System.Drawing.Size(1144, 66);
            this.pnl_pie.TabIndex = 3;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 761);
            this.Controls.Add(this.pnl_pie);
            this.Controls.Add(this.pnl_cuerpo);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_menu);
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard MiniMarket";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.pnl_sistema.ResumeLayout(false);
            this.pnl_tablas.ResumeLayout(false);
            this.pnl_reportes.ResumeLayout(false);
            this.pnl_procesos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_cuerpo;
        private System.Windows.Forms.Panel pnl_pie;
        private FontAwesome.Sharp.IconButton btn_cerrar_sistema;
        private System.Windows.Forms.Panel pnl_sistema;
        private FontAwesome.Sharp.IconButton btn_usuarios;
        private FontAwesome.Sharp.IconButton btn_sistema;
        private System.Windows.Forms.Panel pnl_tablas;
        private FontAwesome.Sharp.IconButton btn_ubicacion;
        private FontAwesome.Sharp.IconButton btn_rubros;
        private FontAwesome.Sharp.IconButton btn_proveedores;
        private FontAwesome.Sharp.IconButton btn_clientes;
        private FontAwesome.Sharp.IconButton btn_almacen;
        private FontAwesome.Sharp.IconButton btn_categorias;
        private FontAwesome.Sharp.IconButton btn_unidades;
        private FontAwesome.Sharp.IconButton btn_marcas;
        private FontAwesome.Sharp.IconButton btn_productos;
        private FontAwesome.Sharp.IconButton btn_tablas;
        private System.Windows.Forms.Panel pnl_reportes;
        private FontAwesome.Sharp.IconButton btn_RepSalAcuProd;
        private FontAwesome.Sharp.IconButton btn_RepSalProd;
        private FontAwesome.Sharp.IconButton btn_RepIngAcuProd;
        private FontAwesome.Sharp.IconButton btn_RepIngProd;
        private FontAwesome.Sharp.IconButton btn_reportes;
        private System.Windows.Forms.Panel pnl_procesos;
        private FontAwesome.Sharp.IconButton btn_salida_prod;
        private FontAwesome.Sharp.IconButton btn_entrada_prod;
        private FontAwesome.Sharp.IconButton btn_procesos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label label1;
    }
}