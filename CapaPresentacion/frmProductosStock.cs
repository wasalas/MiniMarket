using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmProductosStock : Form
    {
        #region "Metodos del Form"
        public frmProductosStock(int codigo, string descripcion)
        {
            InitializeComponent();
            txt_codigo.Text =Convert.ToString( codigo);
            txt_descripcion.Text = descripcion;
        }
        private void frmProductosStock_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        #endregion

        #region "Controles del Form"
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Mis Metodos"
        private void CargaDatos()
        {
            int codigo = Convert.ToInt32(this.txt_codigo.Text);
            dgDatos.DataSource = NStock_Productos.Listado_PorProducto(codigo);
            
            int Cantidad_registros = dgDatos.Rows.Count;

            ts_estado.Items[0].Text = "";   // "Estado : " + (estado ? "Activos" : "Inactivos");
            ts_estado.Items[1].Text = "   ";
            ts_estado.Items[2].Text = "Total registros : " + Cantidad_registros;
            FormatoGrid();        
        }
        private void FormatoGrid()
        {
            int nWidth = 120;
            dgDatos.Columns[0].HeaderText = "ALMACEN";
            dgDatos.Columns[0].Width = 350;
        
            dgDatos.Columns[1].HeaderText = "STOCK";
            dgDatos.Columns[1].Width = nWidth;        

            dgDatos.Columns[2].HeaderText = "PU COMPRA";
            dgDatos.Columns[2].Width = nWidth;
        }
        #endregion

        private void btn_reporte_Click(object sender, EventArgs e)
        {            
            if (this.dgDatos.RowCount == 0)
            {
                MessageBox.Show("No existen datos para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reportes.frmRepStockProductosPorProducto frm = new Reportes.frmRepStockProductosPorProducto();
            frm.txt_codigo.Text = this.txt_codigo.Text;
            frm.txt_descripcion.Text = this.txt_descripcion.Text;
            frm.ShowDialog();
        }
    }
}
