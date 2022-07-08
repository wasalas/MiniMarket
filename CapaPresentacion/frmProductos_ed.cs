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
    public partial class frmProductos_ed : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private int Estado_guarda;
        private EProductos oDatos;
        public bool GraboDatos = false;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmProductos_ed(int Opcion, EProductos Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmProductos_ed_Load(object sender, EventArgs e)
        {
            cbo_marcas.DataSource = NMarcas.Listado(1, "");
            cbo_marcas.ValueMember = "codigo_ma";
            cbo_marcas.DisplayMember = "descripcion_ma";

            cbo_unidades.DataSource = NUnidad_Medida.Listado(1, "");
            cbo_unidades.ValueMember = "codigo_um";
            cbo_unidades.DisplayMember = "descripcion_um";

            cbo_categorias.DataSource = NCategorias.Listado(1, "");
            cbo_categorias.ValueMember = "codigo_ca";
            cbo_categorias.DisplayMember = "descripcion_ca";

            if (this.Estado_guarda == 1)
            {
                this.txt_codigo.Text = "0";
                this.txt_descrip.Text = "";
                cbo_marcas.SelectedValue = 0;
                cbo_unidades.SelectedValue = 0;
                cbo_categorias.SelectedValue = 0;
                this.txt_stock_min.Text = "0.00";
                this.txt_stock_max.Text = "0.00";
                this.txt_pu_venta.Text = "0.00";
                this.chk_estado.Checked = true;

                this.chk_estado.Enabled = false;
                this.Text = "Nuevo ";
            }
            else
            {
                this.txt_codigo.Text = oDatos.Codigo_pr.ToString();
                this.txt_descrip.Text = oDatos.Descripcion_pr;
                cbo_marcas.SelectedValue = oDatos.Codigo_ma;
                cbo_unidades.SelectedValue = oDatos.Codigo_um;
                cbo_categorias.SelectedValue = oDatos.Codigo_ca;
                this.txt_stock_min.Text = oDatos.Stock_min.ToString();
                this.txt_stock_max.Text = oDatos.Stock_max.ToString();
                this.txt_pu_venta.Text = oDatos.Pu_venta.ToString();
                this.chk_estado.Checked = oDatos.Estado == 1 ? true : false;

                this.Text = "Modificar ";
            }
            this.Text += "Producto";          
            
        }
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";

            oDatos.Codigo_pr = Convert.ToInt32(this.txt_codigo.Text);
            oDatos.Descripcion_pr = Convert.ToString(this.txt_descrip.Text.Trim().ToUpper());
            oDatos.Codigo_ma = Convert.ToInt32(cbo_marcas.SelectedValue);
            oDatos.Codigo_um = Convert.ToInt32(cbo_unidades.SelectedValue);
            oDatos.Codigo_ca = Convert.ToInt32(cbo_categorias.SelectedValue);
            oDatos.Stock_min = Convert.ToDecimal(txt_stock_min.Text);
            oDatos.Stock_max = Convert.ToDecimal(txt_stock_max.Text);
            oDatos.Pu_venta =decimal.Round( Convert.ToDecimal(txt_pu_venta.Text),2);
            oDatos.Estado = Convert.ToByte(this.chk_estado.Checked ? 1 : 0);

            if (oDatos.Descripcion_pr == String.Empty)
            {
                this.txt_descrip.Focus();
                MessageBox.Show("Ingrese la Descripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oDatos.Codigo_ma == 0)
            {
                this.cbo_marcas.Focus();
                MessageBox.Show("Seleccione una Marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oDatos.Codigo_um == 0)
            {
                this.cbo_unidades.Focus();
                MessageBox.Show("Seleccione una Unidad de Medida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oDatos.Codigo_ca == 0)
            {
                this.cbo_categorias.Focus();
                MessageBox.Show("Seleccione una Categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NProductos.Guardar(this.Estado_guarda, this.oDatos);
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
