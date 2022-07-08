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
    public partial class frmRepConSalidasAcuPorProducto : Form
    {
        #region "Mis Variables"
        private static frmRepConSalidasAcuPorProducto _instancia;
        #endregion

        #region "Metodos del Form"
        public frmRepConSalidasAcuPorProducto()
        {
            InitializeComponent();
        }
        private void frmRepConIngresoPorProducto_Load(object sender, EventArgs e) { }
        private void frmRepConIngresoPorProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }
        #endregion

        #region "Controles del Form"
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.frmConSalAcuProd frmConSAPP = new Reportes.frmConSalAcuProd();
            frmConSAPP.txt_fecini.Text = Convert.ToString(dt_fecini.Value);
            frmConSAPP.txt_fecfin.Text = Convert.ToString(dt_fecfin.Value);
            frmConSAPP.ShowDialog();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        public static frmRepConSalidasAcuPorProducto GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmRepConSalidasAcuPorProducto();
            else
                _instancia.Activate();
            return _instancia;
        }
        #endregion



    }
}
