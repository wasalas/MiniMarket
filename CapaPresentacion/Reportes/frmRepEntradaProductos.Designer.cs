namespace CapaPresentacion.Reportes
{
    partial class frmRepEntradaProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.spListadoEncEntradaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spListado_Enc_Entrada_ProductosTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.spListado_Enc_Entrada_ProductosTableAdapter();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.txt_texto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoEncEntradaProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListadoEncEntradaProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptRepEntradaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1171, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListadoEncEntradaProductosBindingSource
            // 
            this.spListadoEncEntradaProductosBindingSource.DataMember = "spListado_Enc_Entrada_Productos";
            this.spListadoEncEntradaProductosBindingSource.DataSource = this.dS_Reportes;
            // 
            // spListado_Enc_Entrada_ProductosTableAdapter
            // 
            this.spListado_Enc_Entrada_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(46, 107);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 10;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.Visible = false;
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(46, 59);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(100, 20);
            this.txt_texto.TabIndex = 9;
            this.txt_texto.Visible = false;
            // 
            // frmRepEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepEntradaProductos";
            this.Text = "frmRepEntradaProductos";
            this.Load += new System.EventHandler(this.frmRepEntradaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoEncEntradaProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListadoEncEntradaProductosBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.spListado_Enc_Entrada_ProductosTableAdapter spListado_Enc_Entrada_ProductosTableAdapter;
        public System.Windows.Forms.CheckBox chk_estado;
        public System.Windows.Forms.TextBox txt_texto;
    }
}