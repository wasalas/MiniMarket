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
    public partial class frmClientes_ed : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private int Estado_guarda;
        private EClientes oDatos;
        public bool GraboDatos = false;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmClientes_ed(int Opcion, EClientes Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmClientes_ed_Load(object sender, EventArgs e)
        {
            this.cbo_tip_doc_ide.DataSource = NTipos_Documentos_Identidad.Listado(1);
            this.cbo_tip_doc_ide.ValueMember = "codigo_tdi";
            this.cbo_tip_doc_ide.DisplayMember = "descripcion_tdi";

            this.cbo_sexo.DataSource = NSexos.Listado(1);
            this.cbo_sexo.ValueMember = "codigo_sx";
            this.cbo_sexo.DisplayMember = "descripcion_sx";                    
            
            /*
            this.cbo_departamentos.DataSource = NDepartamentos.Listado(1, "");
            this.cbo_departamentos.ValueMember = "codigo_de";
            this.cbo_departamentos.DisplayMember = "descripcion_de";

            this.cbo_provincias.DataSource = NProvincias.Listado(oDatos.Codigo_de, 1, "");
            this.cbo_provincias.ValueMember = "codigo_po";
            this.cbo_provincias.DisplayMember = "descripcion_po";

            this.cbo_distritos.DataSource = NDistritos.Listado(oDatos.Codigo_de, oDatos.Codigo_po, 1, "");
            this.cbo_distritos.ValueMember = "codigo_di";
            this.cbo_distritos.DisplayMember = "descripcion_di";
            */

            if (this.Estado_guarda == 1)
            {
                this.txt_codigo_cl.Text = "0";
                this.cbo_tip_doc_ide.SelectedValue = 0;
                this.txt_num_doc_ide.Text = "";
                this.txt_raz_soc.Text = "";
                this.txt_apellidos.Text = "";
                this.txt_nombres.Text = "";
                this.cbo_sexo.SelectedValue = 0;
                this.txt_email.Text = "";
                this.txt_telefonos.Text = "";
                this.txt_movil.Text = "";
                this.txt_direccion.Text = "";
                Carga_Departamentos();
                Carga_Provincias(0);
                Carga_Distritos(0,0);
                this.cbo_departamentos.SelectedIndex = -1;
                this.cbo_provincias.SelectedIndex = -1;
                this.cbo_distritos.SelectedIndex = -1;
                this.txt_observaciones.Text = "";
                this.chk_estado.Checked = true;
                this.chk_estado.Enabled = false;

                this.Text = "Nuevo ";
            }
            else
            {
                this.txt_codigo_cl.Text = oDatos.Codigo_cl.ToString();
                this.cbo_tip_doc_ide.SelectedValue = oDatos.Codigo_tdi;
                this.txt_num_doc_ide.Text = oDatos.Nro_documento_cl;
                this.txt_raz_soc.Text = oDatos.Razon_social_cl;
                this.txt_apellidos.Text = oDatos.Apellidos;
                this.txt_nombres.Text = oDatos.Nombres;
                this.cbo_sexo.SelectedValue = oDatos.Codigo_sx;                
                this.txt_email.Text = oDatos.Email;
                this.txt_telefonos.Text = oDatos.Telefonos;
                this.txt_movil.Text = oDatos.Movil;
                this.txt_direccion.Text = oDatos.Direccion;
                Carga_Departamentos();
                Carga_Provincias(oDatos.Codigo_de);
                Carga_Distritos(oDatos.Codigo_de, oDatos.Codigo_po);
                this.cbo_departamentos.SelectedValue = oDatos.Codigo_de;
                this.cbo_provincias.SelectedValue = oDatos.Codigo_po;
                this.cbo_distritos.SelectedValue = oDatos.Codigo_di;
                this.txt_observaciones.Text = oDatos.Observaciones;
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;
                this.Text = "Modificar ";
            }
            this.Text += "Cliente";

            
        }
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            oDatos.Codigo_cl = Convert.ToInt32(this.txt_codigo_cl.Text);
            oDatos.Codigo_tdi = Convert.ToInt32(this.cbo_tip_doc_ide.SelectedValue);
            oDatos.Nro_documento_cl = this.txt_num_doc_ide.Text.Trim().ToUpper();
            oDatos.Razon_social_cl = this.txt_raz_soc.Text.Trim().ToUpper();
            oDatos.Apellidos = this.txt_apellidos.Text.Trim().ToUpper();
            oDatos.Nombres = this.txt_nombres.Text.Trim().ToUpper();
            oDatos.Codigo_sx = Convert.ToInt32(this.cbo_sexo.SelectedValue);            
            oDatos.Email = this.txt_email.Text.Trim().ToUpper();
            oDatos.Telefonos = this.txt_telefonos.Text.Trim().ToUpper();
            oDatos.Movil = this.txt_movil.Text.Trim().ToUpper();
            oDatos.Direccion = this.txt_direccion.Text.Trim().ToUpper();
            oDatos.Codigo_de = Convert.ToInt32(this.cbo_departamentos.SelectedValue);
            oDatos.Codigo_po = Convert.ToInt32(this.cbo_provincias.SelectedValue);
            oDatos.Codigo_di = Convert.ToInt32(this.cbo_distritos.SelectedValue);
            oDatos.Observaciones = this.txt_observaciones.Text.Trim().ToUpper();
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            if (oDatos.Razon_social_cl == String.Empty)
            {
                txt_num_doc_ide.Focus();
                MessageBox.Show("Ingrese la Razon Social.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NClientes.Guardar(this.Estado_guarda, this.oDatos);
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
        private void Textos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void cbo_departamentos_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            int codigo_de = 0;
            if (this.cbo_departamentos.Items.Count > 0)
                codigo_de = Convert.ToInt32(this.cbo_departamentos.SelectedValue);

            Carga_Provincias(codigo_de);
            this.cbo_provincias.SelectedIndex = -1;

            Carga_Distritos(0, 0);
            this.cbo_distritos.SelectedIndex = -1;
        }
        private void cbo_provincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codigo_de = 0, codigo_po = 0;

            if (this.cbo_departamentos.Items.Count > 0)
                codigo_de = Convert.ToInt32(this.cbo_departamentos.SelectedValue);

            if (this.cbo_provincias.Items.Count > 0)
                codigo_po = Convert.ToInt32(this.cbo_provincias.SelectedValue);

            Carga_Distritos(codigo_de, codigo_po);
            this.cbo_distritos.SelectedIndex = -1;
        }
        #endregion

        // ***********************************************************************************
        #region "Mis Metodos"

        private void Carga_Departamentos()
        {
            this.cbo_departamentos.DataSource = NDepartamentos.Listado(1, "");
            this.cbo_departamentos.ValueMember = "codigo_de";
            this.cbo_departamentos.DisplayMember = "descripcion_de";
        }
        private void Carga_Provincias(int codigo_de)
        {
            this.cbo_provincias.DataSource = NProvincias.Listado(codigo_de, 1, "");
            this.cbo_provincias.ValueMember = "codigo_po";
            this.cbo_provincias.DisplayMember = "descripcion_po";
        }
        private void Carga_Distritos(int codigo_de, int codigo_po)
        {
            this.cbo_distritos.DataSource = NDistritos.Listado(codigo_de, codigo_po, 1, "");
            this.cbo_distritos.ValueMember = "codigo_di";
            this.cbo_distritos.DisplayMember = "descripcion_di";
        }
        #endregion
    }
}
