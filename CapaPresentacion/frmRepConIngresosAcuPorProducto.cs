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
    public partial class frmRepConIngresosAcuPorProducto : Form
    {
        #region "Mis Variables"
        private static frmRepConIngresosAcuPorProducto _instancia;
        #endregion

        #region "Metodos del Form"
        public frmRepConIngresosAcuPorProducto()
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
            Reportes.frmConIngAcuProd frmConIAPP = new Reportes.frmConIngAcuProd();
            frmConIAPP.txt_fecini.Text = Convert.ToString(dt_fecini.Value);
            frmConIAPP.txt_fecfin.Text = Convert.ToString(dt_fecfin.Value);
            frmConIAPP.ShowDialog();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        public static frmRepConIngresosAcuPorProducto GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmRepConIngresosAcuPorProducto();
            else
                _instancia.Activate();
            return _instancia;
        }
        #endregion



    }
}
