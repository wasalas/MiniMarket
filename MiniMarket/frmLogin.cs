using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaNegocio;

namespace MiniMarket
{
    public partial class frmLogin : Form
    {
        #region "Variables del Form"
        DataTable dt_Usuarios = new DataTable();
        #endregion
        #region "Metodos del form"

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            dt_Usuarios = NUsuarios.Listado(1, "");
            this.cbo_usuarios.DataSource = dt_Usuarios;
            this.cbo_usuarios.ValueMember = "codigo_us";
            this.cbo_usuarios.DisplayMember = "nombre_us";
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            int codigo_us = 0;
            string clave_us = "";
            int nIndex = cbo_usuarios.SelectedIndex;

            if (nIndex == -1 || this.cbo_usuarios.Items.Count == 0)
            {
                MessageBox.Show("Seleccione un Usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_usuarios.Focus();
                return;
            }
            if (txt_clave.Text == string.Empty)
            {
                MessageBox.Show("Ingrese su clave de acceso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();
                return;
            }

            codigo_us = Convert.ToInt32(cbo_usuarios.SelectedValue);
            clave_us = Convert.ToString( dt_Usuarios.Rows[nIndex]["clave_us"]);
            if (clave_us.Trim() != txt_clave.Text.Trim())
            {
                MessageBox.Show("La clave de acceso no concuerda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();
                return;
            }
            this.Hide();

            if (rb_dashboard.Checked)
            {
                frmDashBoard frmIniDash = new frmDashBoard();
                frmIniDash.Show();
            }

                
            if (rb_pulldown.Checked)
            {
                frmPrincipal frmIniPrin = new frmPrincipal();
                frmIniPrin.Show();

            }

            

        }
    }
}
