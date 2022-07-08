using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmRepVentaGenerada : Form
    {
        public frmRepVentaGenerada()
        {
            InitializeComponent();
        }

        private void frmRepVentaGenerada_Load(object sender, EventArgs e)
        {
            int codigo_gen = Convert.ToInt32(this.txt_codigo.Text);
            

            this.spListado_Venta_GeneradaTableAdapter.Fill(this.dS_Reportes.spListado_Venta_Generada, codigo_sp: codigo_gen);            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
