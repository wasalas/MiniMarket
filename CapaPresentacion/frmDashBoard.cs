using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDashBoard : Form
    {
        #region "Mis Variables"
        private Form activeForm = null;
        #endregion

        #region "Metodos del Form"
        public frmDashBoard()
        {
            InitializeComponent();
        }
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            Apaga_Paneles();
        }

        #endregion

        #region "Controles del Form"
        private void btn_procesos_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = !pnl_procesos.Visible;
            pnl_reportes.Visible = false;
            pnl_tablas.Visible = false;
            pnl_sistema.Visible = false;
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = !pnl_reportes.Visible;
            pnl_tablas.Visible = false;
            pnl_sistema.Visible = false;
        }

        private void btn_tablas_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = false;
            pnl_tablas.Visible = !pnl_tablas.Visible;
            pnl_sistema.Visible = false;
        }

        private void btn_sistema_Click(object sender, EventArgs e)
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = false;
            pnl_tablas.Visible = false;
            pnl_sistema.Visible = !pnl_sistema.Visible;
        }

        private void btn_cerrar_sistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_cuerpo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }
        private void Apaga_Paneles()
        {
            pnl_procesos.Visible = false;
            pnl_reportes.Visible = false;
            pnl_tablas.Visible = false;
            pnl_sistema.Visible = false;
        }
        #endregion

        private void btn_marcas_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrada_prod_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEntradaProductos());
            this.lbl_subtitulo.Text = "Entrada de Productos";
            this.lbl_subtitulo.Visible = true;
        }

        private void btn_salida_prod_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSalidaProductos());
            this.lbl_subtitulo.Text = "Salida de Productos";
            this.lbl_subtitulo.Visible = true;
        }
    }
}
