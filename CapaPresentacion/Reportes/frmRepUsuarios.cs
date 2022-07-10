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
    public partial class frmRepUsuarios : Form
    {
        public frmRepUsuarios()
        {
            InitializeComponent();
        }

        private void frmRepUsuarios_Load(object sender, EventArgs e)
        {

            bool est = Convert.ToBoolean(this.chk_estado.Checked ? 1 : 0);
            string text = this.txt_texto.Text;

            this.spListado_UsuariosTableAdapter.Fill(this.dS_Reportes.spListado_Usuarios, estado: est, texto: text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
