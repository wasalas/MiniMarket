namespace CapaPresentacion
{
    partial class frmDistritos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistritos));
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.ts_estado = new System.Windows.Forms.StatusStrip();
            this.ts_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkEsatdo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo_de = new System.Windows.Forms.TextBox();
            this.txt_descripcion_de = new System.Windows.Forms.TextBox();
            this.txt_descripcion_po = new System.Windows.Forms.TextBox();
            this.txt_codigo_po = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.ts_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToOrderColumns = true;
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
            this.dgDatos.Location = new System.Drawing.Point(0, 105);
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
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(618, 208);
            this.dgDatos.TabIndex = 5;
            this.dgDatos.DoubleClick += new System.EventHandler(this.dgDatos_DoubleClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Location = new System.Drawing.Point(54, 339);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 52);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.Text = "&Nuevo";
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(157, 339);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 52);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "&Modificar";
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.Location = new System.Drawing.Point(363, 339);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(100, 52);
            this.btn_reporte.TabIndex = 12;
            this.btn_reporte.Text = "&Reporte";
            this.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(260, 339);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 52);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(466, 339);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 52);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar :";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(115, 12);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(202, 20);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(323, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(81, 30);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(409, 6);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(81, 30);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // ts_estado
            // 
            this.ts_estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_1,
            this.ts_2,
            this.ts_3});
            this.ts_estado.Location = new System.Drawing.Point(0, 399);
            this.ts_estado.Name = "ts_estado";
            this.ts_estado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_estado.Size = new System.Drawing.Size(620, 22);
            this.ts_estado.TabIndex = 18;
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
            this.ts_2.Size = new System.Drawing.Size(340, 17);
            // 
            // ts_3
            // 
            this.ts_3.AutoSize = false;
            this.ts_3.Name = "ts_3";
            this.ts_3.Size = new System.Drawing.Size(118, 17);
            this.ts_3.Text = "toolStripStatusLabel2";
            // 
            // chkEsatdo
            // 
            this.chkEsatdo.AutoSize = true;
            this.chkEsatdo.Checked = true;
            this.chkEsatdo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEsatdo.Location = new System.Drawing.Point(66, 320);
            this.chkEsatdo.Name = "chkEsatdo";
            this.chkEsatdo.Size = new System.Drawing.Size(61, 17);
            this.chkEsatdo.TabIndex = 11;
            this.chkEsatdo.TabStop = false;
            this.chkEsatdo.Text = "Activos";
            this.chkEsatdo.UseVisualStyleBackColor = true;
            this.chkEsatdo.CheckedChanged += new System.EventHandler(this.chkEsatdo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DEPARTAMENTO :";
            // 
            // txt_codigo_de
            // 
            this.txt_codigo_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_de.Location = new System.Drawing.Point(128, 51);
            this.txt_codigo_de.Name = "txt_codigo_de";
            this.txt_codigo_de.ReadOnly = true;
            this.txt_codigo_de.Size = new System.Drawing.Size(57, 20);
            this.txt_codigo_de.TabIndex = 20;
            this.txt_codigo_de.TabStop = false;
            // 
            // txt_descripcion_de
            // 
            this.txt_descripcion_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_de.Location = new System.Drawing.Point(187, 51);
            this.txt_descripcion_de.Name = "txt_descripcion_de";
            this.txt_descripcion_de.ReadOnly = true;
            this.txt_descripcion_de.Size = new System.Drawing.Size(360, 20);
            this.txt_descripcion_de.TabIndex = 21;
            this.txt_descripcion_de.TabStop = false;
            // 
            // txt_descripcion_po
            // 
            this.txt_descripcion_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_po.Location = new System.Drawing.Point(187, 77);
            this.txt_descripcion_po.Name = "txt_descripcion_po";
            this.txt_descripcion_po.ReadOnly = true;
            this.txt_descripcion_po.Size = new System.Drawing.Size(360, 20);
            this.txt_descripcion_po.TabIndex = 24;
            this.txt_descripcion_po.TabStop = false;
            // 
            // txt_codigo_po
            // 
            this.txt_codigo_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_po.Location = new System.Drawing.Point(128, 77);
            this.txt_codigo_po.Name = "txt_codigo_po";
            this.txt_codigo_po.ReadOnly = true;
            this.txt_codigo_po.Size = new System.Drawing.Size(57, 20);
            this.txt_codigo_po.TabIndex = 23;
            this.txt_codigo_po.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "PROVINCIA :";
            // 
            // frmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 421);
            this.Controls.Add(this.txt_descripcion_po);
            this.Controls.Add(this.txt_codigo_po);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion_de);
            this.Controls.Add(this.txt_codigo_de);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ts_estado);
            this.Controls.Add(this.chkEsatdo);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Distritos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDistritos_FormClosed);
            this.Load += new System.EventHandler(this.frmDistritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ts_estado.ResumeLayout(false);
            this.ts_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.StatusStrip ts_estado;
        private System.Windows.Forms.ToolStripStatusLabel ts_1;
        private System.Windows.Forms.ToolStripStatusLabel ts_2;
        private System.Windows.Forms.ToolStripStatusLabel ts_3;
        private System.Windows.Forms.CheckBox chkEsatdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_codigo_de;
        public System.Windows.Forms.TextBox txt_descripcion_de;
        public System.Windows.Forms.TextBox txt_descripcion_po;
        public System.Windows.Forms.TextBox txt_codigo_po;
        private System.Windows.Forms.Label label4;
    }
}