namespace CapaPresentacion.Reportes
{
    partial class frmConIngProd
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
            this.spConsolidadoIngPorProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new CapaPresentacion.Reportes.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spConsolidado_IngPorProdTableAdapter = new CapaPresentacion.Reportes.DS_ReportesTableAdapters.spConsolidado_IngPorProdTableAdapter();
            this.txt_fecfin = new System.Windows.Forms.TextBox();
            this.txt_fecini = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spConsolidadoIngPorProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spConsolidadoIngPorProdBindingSource
            // 
            this.spConsolidadoIngPorProdBindingSource.DataMember = "spConsolidado_IngPorProd";
            this.spConsolidadoIngPorProdBindingSource.DataSource = this.dS_Reportes;
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
            reportDataSource1.Value = this.spConsolidadoIngPorProdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptConIngPro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spConsolidado_IngPorProdTableAdapter
            // 
            this.spConsolidado_IngPorProdTableAdapter.ClearBeforeFill = true;
            // 
            // txt_fecfin
            // 
            this.txt_fecfin.Location = new System.Drawing.Point(12, 66);
            this.txt_fecfin.Name = "txt_fecfin";
            this.txt_fecfin.Size = new System.Drawing.Size(100, 20);
            this.txt_fecfin.TabIndex = 13;
            this.txt_fecfin.Visible = false;
            // 
            // txt_fecini
            // 
            this.txt_fecini.Location = new System.Drawing.Point(12, 40);
            this.txt_fecini.Name = "txt_fecini";
            this.txt_fecini.Size = new System.Drawing.Size(100, 20);
            this.txt_fecini.TabIndex = 12;
            this.txt_fecini.Visible = false;
            // 
            // frmConIngProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.txt_fecfin);
            this.Controls.Add(this.txt_fecini);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConIngProd";
            this.Text = "frmConIngProd";
            this.Load += new System.EventHandler(this.frmConIngProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spConsolidadoIngPorProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsolidadoIngPorProdBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.spConsolidado_IngPorProdTableAdapter spConsolidado_IngPorProdTableAdapter;
        public System.Windows.Forms.TextBox txt_fecfin;
        public System.Windows.Forms.TextBox txt_fecini;
    }
}