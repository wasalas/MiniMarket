using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios_ed : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private int Estado_guarda;
        private EUsuarios oDatos;
        public bool GraboDatos = false;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmUsuarios_ed(int Opcion, EUsuarios Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmUsuarios_ed_Load(object sender, EventArgs e)
        {
            if (this.Estado_guarda == 1)
            {
                this.txt_codigo.Text = "0";
                this.txt_nombre.Text = "";
                this.txt_clave.Text = "";
                this.chk_admin.Checked = false;
                this.chk_estado.Checked = true;
                this.chk_estado.Enabled = false;

                this.Text = "Nuevo ";
            }
            else
            {
                this.txt_codigo.Text = oDatos.Codigo_us.ToString();
                this.txt_nombre.Text = oDatos.Nombre_us;
                this.txt_clave.Text = oDatos.Clave_us.ToString();
                this.chk_admin.Checked = oDatos.Admin == 1 ? true : false;
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;
                this.Text = "Modificar ";
            }
            this.Text += "Usuario";
        }
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            oDatos.Codigo_us = Convert.ToInt32(this.txt_codigo.Text);
            oDatos.Nombre_us = Convert.ToString(this.txt_nombre.Text.Trim().ToUpper());
            oDatos.Clave_us = Convert.ToString(this.txt_clave.Text.Trim().ToUpper());
            oDatos.Admin = Convert.ToByte(this.chk_admin.Checked ? 1 : 0);
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            if (oDatos.Nombre_us == String.Empty)
            {
                this.txt_nombre.Focus();
                MessageBox.Show("Ingrese el Nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NUsuarios.Guardar(this.Estado_guarda, this.oDatos);
                if (Rpta == "OK")
                {
                    MessageBox.Show("Datos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GraboDatos = true;
                    this.Close();
                }
                else
                    MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // ***********************************************************************************
        #region "Mis Metodos"
        #endregion
    }
}
