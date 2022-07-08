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
    public partial class frmRepRubros : Form
    {
        public frmRepRubros()
        {
            InitializeComponent();
        }

        private void frmRepRubros_Load(object sender, EventArgs e)
        {
            // byte est = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);
            bool est = this.chk_estado.Checked;
            string text = this.txt_texto.Text;
            this.spListado_RubrosTableAdapter.Fill(this.dS_Reportes.spListado_Rubros, estado: est, texto: text);            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
