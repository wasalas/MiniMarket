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
    public partial class frmRepSalidaProductos : Form
    {
        public frmRepSalidaProductos()
        {
            InitializeComponent();
        }

        private void frmRepSalidaProductos_Load(object sender, EventArgs e)
        {
            // byte est = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);         
            bool est = this.chk_estado.Checked;
            string text = this.txt_texto.Text;

            this.spListado_Enc_Salida_ProductosTableAdapter.Fill(this.dS_Reportes.spListado_Enc_Salida_Productos, estado: est, texto: text);
            this.reportViewer1.RefreshReport();
        }
    }
}
