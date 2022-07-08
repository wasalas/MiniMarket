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
    public partial class frmDepartamentos_ed : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private int Estado_guarda;
        private EDepartamentos oDatos;
        public bool GraboDatos = false;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmDepartamentos_ed(int Opcion, EDepartamentos Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmDepartamentos_ed_Load(object sender, EventArgs e)
        {
            if (this.Estado_guarda == 1)
            {
                this.txt_codigo.Text = "0";
                this.txt_descrip.Text = "";
                this.chk_estado.Checked = true;
                this.chk_estado.Enabled = false;

                this.Text = "Nuevo ";
            }
            else
            {
                this.txt_codigo.Text = oDatos.Codigo_de.ToString();
                this.txt_descrip.Text = oDatos.Descripcion_de;
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;
                this.Text = "Modificar ";
            }
            this.Text += "Departamento";
        }       
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            oDatos.Codigo_de = Convert.ToInt32(this.txt_codigo.Text);
            oDatos.Descripcion_de = Convert.ToString(this.txt_descrip.Text.Trim().ToUpper());
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            if (oDatos.Descripcion_de == String.Empty)
            {
                this.txt_descrip.Focus();
                MessageBox.Show("Ingrese la Descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NDepartamentos.Guardar(this.Estado_guarda, this.oDatos);
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
