namespace CapaPresentacion
{
    partial class frmSalidaProductos_ed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalidaProductos_ed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo_sp = new System.Windows.Forms.TextBox();
            this.txt_num_doc_sp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.gb_Datos_generales = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_importe_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_igv = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.cbo_productos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_Fecha_sp = new System.Windows.Forms.DateTimePicker();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbo_tip_doc_sp = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ts_estado = new System.Windows.Forms.StatusStrip();
            this.ts_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chk_Imprimir_Tiket = new System.Windows.Forms.CheckBox();
            this.gb_Datos_generales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.ts_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo :";
            // 
            // txt_codigo_sp
            // 
            this.txt_codigo_sp.Enabled = false;
            this.txt_codigo_sp.Location = new System.Drawing.Point(134, 19);
            this.txt_codigo_sp.Name = "txt_codigo_sp";
            this.txt_codigo_sp.Size = new System.Drawing.Size(44, 20);
            this.txt_codigo_sp.TabIndex = 4;
            // 
            // txt_num_doc_sp
            // 
            this.txt_num_doc_sp.Location = new System.Drawing.Point(424, 44);
            this.txt_num_doc_sp.MaxLength = 30;
            this.txt_num_doc_sp.Name = "txt_num_doc_sp";
            this.txt_num_doc_sp.Size = new System.Drawing.Size(202, 20);
            this.txt_num_doc_sp.TabIndex = 12;
            this.txt_num_doc_sp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mayusculas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Documento :";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(472, 479);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 52);
            this.btn_cancelar.TabIndex = 72;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(366, 479);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 52);
            this.btn_guardar.TabIndex = 70;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // gb_Datos_generales
            // 
            this.gb_Datos_generales.Controls.Add(this.chk_Imprimir_Tiket);
            this.gb_Datos_generales.Controls.Add(this.label8);
            this.gb_Datos_generales.Controls.Add(this.txt_stock);
            this.gb_Datos_generales.Controls.Add(this.label13);
            this.gb_Datos_generales.Controls.Add(this.label10);
            this.gb_Datos_generales.Controls.Add(this.txt_importe_total);
            this.gb_Datos_generales.Controls.Add(this.label9);
            this.gb_Datos_generales.Controls.Add(this.label6);
            this.gb_Datos_generales.Controls.Add(this.txt_total);
            this.gb_Datos_generales.Controls.Add(this.txt_igv);
            this.gb_Datos_generales.Controls.Add(this.txt_precio);
            this.gb_Datos_generales.Controls.Add(this.label5);
            this.gb_Datos_generales.Controls.Add(this.txt_cantidad);
            this.gb_Datos_generales.Controls.Add(this.txt_subtotal);
            this.gb_Datos_generales.Controls.Add(this.cbo_productos);
            this.gb_Datos_generales.Controls.Add(this.label3);
            this.gb_Datos_generales.Controls.Add(this.label7);
            this.gb_Datos_generales.Controls.Add(this.dt_Fecha_sp);
            this.gb_Datos_generales.Controls.Add(this.dgDatos);
            this.gb_Datos_generales.Controls.Add(this.btn_del);
            this.gb_Datos_generales.Controls.Add(this.txt_observaciones);
            this.gb_Datos_generales.Controls.Add(this.btn_add);
            this.gb_Datos_generales.Controls.Add(this.cbo_cliente);
            this.gb_Datos_generales.Controls.Add(this.label17);
            this.gb_Datos_generales.Controls.Add(this.cbo_tip_doc_sp);
            this.gb_Datos_generales.Controls.Add(this.label12);
            this.gb_Datos_generales.Controls.Add(this.label11);
            this.gb_Datos_generales.Controls.Add(this.label4);
            this.gb_Datos_generales.Controls.Add(this.txt_num_doc_sp);
            this.gb_Datos_generales.Controls.Add(this.label1);
            this.gb_Datos_generales.Controls.Add(this.txt_codigo_sp);
            this.gb_Datos_generales.Controls.Add(this.label2);
            this.gb_Datos_generales.Location = new System.Drawing.Point(7, 13);
            this.gb_Datos_generales.Name = "gb_Datos_generales";
            this.gb_Datos_generales.Size = new System.Drawing.Size(925, 457);
            this.gb_Datos_generales.TabIndex = 1;
            this.gb_Datos_generales.TabStop = false;
            this.gb_Datos_generales.Text = "DATOS GENERALES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Stock :";
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(317, 191);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(70, 20);
            this.txt_stock.TabIndex = 32;
            this.txt_stock.Text = "0.00";
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(734, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Total :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Precio Venta :";
            // 
            // txt_importe_total
            // 
            this.txt_importe_total.Enabled = false;
            this.txt_importe_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe_total.Location = new System.Drawing.Point(743, 428);
            this.txt_importe_total.Name = "txt_importe_total";
            this.txt_importe_total.Size = new System.Drawing.Size(100, 20);
            this.txt_importe_total.TabIndex = 62;
            this.txt_importe_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cantidad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Importe Total :";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(776, 191);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(81, 20);
            this.txt_total.TabIndex = 44;
            this.txt_total.Text = "0.00";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_igv
            // 
            this.txt_igv.Enabled = false;
            this.txt_igv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_igv.Location = new System.Drawing.Point(743, 403);
            this.txt_igv.Name = "txt_igv";
            this.txt_igv.Size = new System.Drawing.Size(100, 20);
            this.txt_igv.TabIndex = 58;
            this.txt_igv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(487, 191);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(81, 20);
            this.txt_precio.TabIndex = 36;
            this.txt_precio.Text = "0.00";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "I.G.V. :";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(642, 191);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(81, 20);
            this.txt_cantidad.TabIndex = 40;
            this.txt_cantidad.Text = "0.00";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(743, 378);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 54;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_productos
            // 
            this.cbo_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_productos.FormattingEnabled = true;
            this.cbo_productos.Location = new System.Drawing.Point(77, 191);
            this.cbo_productos.Name = "cbo_productos";
            this.cbo_productos.Size = new System.Drawing.Size(185, 21);
            this.cbo_productos.TabIndex = 28;
            this.cbo_productos.SelectionChangeCommitted += new System.EventHandler(this.cbo_productos_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Sub Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Producto :";
            // 
            // dt_Fecha_sp
            // 
            this.dt_Fecha_sp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Fecha_sp.Location = new System.Drawing.Point(134, 93);
            this.dt_Fecha_sp.Name = "dt_Fecha_sp";
            this.dt_Fecha_sp.Size = new System.Drawing.Size(102, 20);
            this.dt_Fecha_sp.TabIndex = 20;
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToOrderColumns = true;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(111)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDatos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDatos.EnableHeadersVisualStyles = false;
            this.dgDatos.Location = new System.Drawing.Point(9, 223);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowTemplate.Height = 25;
            this.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDatos.Size = new System.Drawing.Size(867, 150);
            this.dgDatos.TabIndex = 48;
            this.dgDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellEndEdit);
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(880, 223);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(36, 28);
            this.btn_del.TabIndex = 50;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(134, 123);
            this.txt_observaciones.MaxLength = 250;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(499, 54);
            this.txt_observaciones.TabIndex = 24;
            this.txt_observaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mayusculas);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(881, 185);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 28);
            this.btn_add.TabIndex = 46;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(134, 68);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(181, 21);
            this.cbo_cliente.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Observaciones :";
            // 
            // cbo_tip_doc_sp
            // 
            this.cbo_tip_doc_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tip_doc_sp.FormattingEnabled = true;
            this.cbo_tip_doc_sp.Location = new System.Drawing.Point(134, 43);
            this.cbo_tip_doc_sp.Name = "cbo_tip_doc_sp";
            this.cbo_tip_doc_sp.Size = new System.Drawing.Size(181, 21);
            this.cbo_tip_doc_sp.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Cliente :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fecha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nº Documento :";
            // 
            // ts_estado
            // 
            this.ts_estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_1,
            this.ts_2,
            this.ts_3});
            this.ts_estado.Location = new System.Drawing.Point(0, 536);
            this.ts_estado.Name = "ts_estado";
            this.ts_estado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_estado.Size = new System.Drawing.Size(956, 22);
            this.ts_estado.TabIndex = 56;
            this.ts_estado.Text = "statusStrip1";
            // 
            // ts_1
            // 
            this.ts_1.AutoSize = false;
            this.ts_1.Name = "ts_1";
            this.ts_1.Size = new System.Drawing.Size(118, 17);
            this.ts_1.Text = "toolStripStatusLabel1";
            // 
            // ts_2
            // 
            this.ts_2.AutoSize = false;
            this.ts_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_2.Name = "ts_2";
            this.ts_2.Size = new System.Drawing.Size(670, 17);
            // 
            // ts_3
            // 
            this.ts_3.AutoSize = false;
            this.ts_3.Name = "ts_3";
            this.ts_3.Size = new System.Drawing.Size(118, 17);
            this.ts_3.Text = "toolStripStatusLabel2";
            // 
            // chk_Imprimir_Tiket
            // 
            this.chk_Imprimir_Tiket.AutoSize = true;
            this.chk_Imprimir_Tiket.Checked = true;
            this.chk_Imprimir_Tiket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Imprimir_Tiket.Location = new System.Drawing.Point(392, 381);
            this.chk_Imprimir_Tiket.Name = "chk_Imprimir_Tiket";
            this.chk_Imprimir_Tiket.Size = new System.Drawing.Size(140, 17);
            this.chk_Imprimir_Tiket.TabIndex = 51;
            this.chk_Imprimir_Tiket.Text = "Imprimir Ticket de Venta";
            this.chk_Imprimir_Tiket.UseVisualStyleBackColor = true;
            // 
            // frmSalidaProductos_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.Controls.Add(this.ts_estado);
            this.Controls.Add(this.gb_Datos_generales);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalidaProductos_ed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Datos";
            this.Load += new System.EventHandler(this.frmSalidaProductos_ed_Load);
            this.gb_Datos_generales.ResumeLayout(false);
            this.gb_Datos_generales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ts_estado.ResumeLayout(false);
            this.ts_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo_sp;
        private System.Windows.Forms.TextBox txt_num_doc_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox gb_Datos_generales;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbo_tip_doc_sp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_Fecha_sp;
        private System.Windows.Forms.TextBox txt_importe_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_igv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip ts_estado;
        private System.Windows.Forms.ToolStripStatusLabel ts_1;
        private System.Windows.Forms.ToolStripStatusLabel ts_2;
        private System.Windows.Forms.ToolStripStatusLabel ts_3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cbo_productos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.CheckBox chk_Imprimir_Tiket;
    }
}