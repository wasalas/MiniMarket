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
    public partial class frmRepConSalidasPorProducto : Form
    {
        #region "Mis Variables"
        private static frmRepConSalidasPorProducto _instancia;
        #endregion

        #region "Metodos del Form"
        public frmRepConSalidasPorProducto()
        {
            InitializeComponent();
        }
        private void frmRepConSalidaPorProducto_Load(object sender, EventArgs e) { }
        private void frmRepConSalidaPorProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }
        #endregion

        #region "Controles del Form"
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            
            Reportes.frmConSalProd frmConSPP = new Reportes.frmConSalProd();
            frmConSPP.txt_fecini.Text = Convert.ToString(dt_fecini.Value);
            frmConSPP.txt_fecfin.Text = Convert.ToString(dt_fecfin.Value);
            frmConSPP.ShowDialog();
            
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        public static frmRepConSalidasPorProducto GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmRepConSalidasPorProducto();
            else
                _instancia.Activate();
            return _instancia;
        }
        #endregion



    }
}
