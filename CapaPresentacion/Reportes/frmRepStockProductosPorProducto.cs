using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion.Reportes
{
    public partial class frmRepStockProductosPorProducto : Form
    {
        public frmRepStockProductosPorProducto()
        {
            InitializeComponent();
        }

        private void frmRepStockProductosPorProducto_Load(object sender, EventArgs e)
        {
            // byte est = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            ReportParameter parm_codigo = new ReportParameter("codigo_pr", txt_codigo.Text);
            ReportParameter parm_descrip = new ReportParameter("descripcion_pr", txt_descripcion.Text);

            int p_codigo = Convert.ToInt32( this.txt_codigo.Text);
            this.spListado_Stock_Productos_PorProductoTableAdapter.Fill(this.dS_Reportes.spListado_Stock_Productos_PorProducto, codigo_pr: p_codigo);
            this.reportViewer1.LocalReport.SetParameters(parm_codigo);
            this.reportViewer1.LocalReport.SetParameters(parm_descrip);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
