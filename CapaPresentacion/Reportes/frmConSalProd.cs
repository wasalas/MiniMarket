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
    public partial class frmConSalProd : Form
    {
        public frmConSalProd()
        {
            InitializeComponent();
        }

        private void frmConSalProd_Load(object sender, EventArgs e)
        {

            ReportParameter parm_fecini = new ReportParameter("fecini", txt_fecini.Text);
            ReportParameter parm_fecfin = new ReportParameter("fecfin", txt_fecfin.Text);

            DateTime dt_fecini = Convert.ToDateTime(txt_fecini.Text);
            DateTime dt_fecfin = Convert.ToDateTime(txt_fecfin.Text);

            this.spConsolidado_SalPorProdTableAdapter.Fill(this.dS_Reportes.spConsolidado_SalPorProd, fecha_ini: dt_fecini, fecha_fin: dt_fecfin);

            this.reportViewer1.LocalReport.SetParameters(parm_fecini);
            this.reportViewer1.LocalReport.SetParameters(parm_fecfin);
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
