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
    public partial class frmRepEntradaProductos : Form
    {
        public frmRepEntradaProductos()
        {
            InitializeComponent();
        }

        private void frmRepEntradaProductos_Load(object sender, EventArgs e)
        {


            // byte est = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);         
            bool est = this.chk_estado.Checked;
            string text = this.txt_texto.Text;

            this.spListado_Enc_Entrada_ProductosTableAdapter.Fill(this.dS_Reportes.spListado_Enc_Entrada_Productos, estado: est, texto: text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
