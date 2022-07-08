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
    public partial class frmRepConIngresosPorProducto : Form
    {
        #region "Mis Variables"
        private static frmRepConIngresosPorProducto _instancia;
        #endregion

        #region "Metodos del Form"
        public frmRepConIngresosPorProducto()
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
            Reportes.frmConIngProd frmConIPP = new Reportes.frmConIngProd();
            frmConIPP.txt_fecini.Text = Convert.ToString(dt_fecini.Value);
            frmConIPP.txt_fecfin.Text = Convert.ToString(dt_fecfin.Value);
            frmConIPP.ShowDialog();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        public static frmRepConIngresosPorProducto GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmRepConIngresosPorProducto();
            else
                _instancia.Activate();
            return _instancia;
        }
        #endregion



    }
}
