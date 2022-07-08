namespace CapaPresentacion.Reportes
{
    partial class frmRepAlmacenes
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
            this.spListadoAlmacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spListado_AlmacenesTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.spListado_AlmacenesTableAdapter();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.txt_texto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoAlmacenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spListadoAlmacenesBindingSource
            // 
            this.spListadoAlmacenesBindingSource.DataMember = "spListado_Almacenes";
            this.spListadoAlmacenesBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListadoAlmacenesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptRepAlmacenes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spListado_AlmacenesTableAdapter
            // 
            this.spListado_AlmacenesTableAdapter.ClearBeforeFill = true;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(42, 108);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 8;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.Visible = false;
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(42, 60);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(100, 20);
            this.txt_texto.TabIndex = 7;
            this.txt_texto.Visible = false;
            // 
            // frmRepAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepAlmacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepAlmacenes";
            this.Load += new System.EventHandler(this.frmRepAlmacenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListadoAlmacenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListadoAlmacenesBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.spListado_AlmacenesTableAdapter spListado_AlmacenesTableAdapter;
        public System.Windows.Forms.CheckBox chk_estado;
        public System.Windows.Forms.TextBox txt_texto;
    }
}