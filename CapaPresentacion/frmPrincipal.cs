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
    public partial class frmPrincipal : Form
    {
        // ***********************************************************************************
        #region "Metodos del Form"
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // nada aun
        }
        #endregion

        // ***********************************************************************************
        #region "Metodos del Menu"
        private void Menu_Categorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCat = frmCategorias.GetInstancia();
            frmCat.MdiParent = this;
            frmCat.Show();
        }
        private void Menu_Marcas_Click(object sender, EventArgs e)
        {
            frmMarcas frmMar = frmMarcas.GetInstancia();
            frmMar.MdiParent = this;
            frmMar.Show();
        }
        private void Menu_UnidadMedida_Click(object sender, EventArgs e)
        {
            frmUndMedida frmUnd = frmUndMedida.GetInstancia();
            frmUnd.MdiParent = this;
            frmUnd.Show();
        }
        private void Menu_Rubros_Click(object sender, EventArgs e)
        {
            frmRubros frmRub = frmRubros.GetInstancia();
            frmRub.MdiParent = this;
            frmRub.Show();
        }
        private void Menu_Almacenes_Click(object sender, EventArgs e)
        {
            frmAlmacen frmAlm = frmAlmacen.GetInstancia();
            frmAlm.MdiParent = this;
            frmAlm.Show();
        }
        private void Menu_Ubicacion_Click(object sender, EventArgs e)
        {
            frmDepartamentos frmDep = frmDepartamentos.GetInstancia();
            frmDep.MdiParent = this;
            frmDep.Show();
        }        
        private void Menu_Productos_Click(object sender, EventArgs e)
        {
            frmProductos frmPro = frmProductos.GetInstancia();
            frmPro.MdiParent = this;
            frmPro.Show();
        }
        private void Menu_Clientes_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = frmClientes.GetInstancia();
            frmCli.MdiParent = this;
            frmCli.Show();
        }
        private void Menu_Proveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProv = frmProveedores.GetInstancia();
            frmProv.MdiParent = this;
            frmProv.Show();
        }
        private void Menu_EntradaProductos_Click(object sender, EventArgs e)
        {
            frmEntradaProductos frmEntProd = frmEntradaProductos.GetInstancia();
            frmEntProd.MdiParent = this;
            frmEntProd.Show();
        }
        private void Menu_SalidaProductos_Click(object sender, EventArgs e)
        {
            frmSalidaProductos frmSalProd = frmSalidaProductos.GetInstancia();
            frmSalProd.MdiParent = this;
            frmSalProd.Show();
        }       
        private void Menu_ConsolidadoIngresoPorProducto_Click(object sender, EventArgs e)
        {
            frmRepConIngresosPorProducto frmRepConIngPro = frmRepConIngresosPorProducto.GetInstancia();
            frmRepConIngPro.MdiParent = this;
            frmRepConIngPro.Show();            
        }
        private void Menu_ConsolidadoSalidaPorProducto_Click(object sender, EventArgs e)
        {
            frmRepConSalidasPorProducto frmRepConSalPro = frmRepConSalidasPorProducto.GetInstancia();
            frmRepConSalPro.MdiParent = this;
            frmRepConSalPro.Show();
        }
        private void Menu_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        // ***********************************************************************************
        #region "Botones del Form"
        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            Menu_Categorias_Click(sender, e);
        }
        private void btn_Marcas_Click(object sender, EventArgs e)
        {
            Menu_Marcas_Click(sender, e);
        }
        private void btn_UnidadMedida_Click(object sender, EventArgs e)
        {
            Menu_UnidadMedida_Click(sender, e);
        }
        private void btn_Rubros_Click(object sender, EventArgs e)
        {
            Menu_Rubros_Click(sender, e);
        }
        private void btn_Almacen_Click(object sender, EventArgs e)
        {
            Menu_Almacenes_Click(sender, e);
        }
        private void btn_ubicacion_Click(object sender, EventArgs e)
        {
            Menu_Ubicacion_Click(sender, e);
        }        
        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Menu_Productos_Click(sender, e);
        }
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Menu_Clientes_Click(sender, e);
        }
        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Menu_Proveedores_Click(sender, e);
        }
        private void btn_entrada_productos_Click(object sender, EventArgs e)
        {
            Menu_EntradaProductos_Click(sender, e);
        }
        private void btn_salida_productos_Click(object sender, EventArgs e)
        {
            Menu_SalidaProductos_Click(sender, e);
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Menu_Salir_Click(sender, e);
        }
        #endregion

        private void Menu_ConsolidadoIngAcuPorProd_Click(object sender, EventArgs e)
        {
            frmRepConIngresosAcuPorProducto frmRepConIngAcPro = frmRepConIngresosAcuPorProducto.GetInstancia();
            frmRepConIngAcPro.MdiParent = this;
            frmRepConIngAcPro.Show();
        }

        private void Menu_ConsolidadoSalAcuPorProd_Click(object sender, EventArgs e)
        {
            frmRepConSalidasAcuPorProducto frmRepConSalAcPro = frmRepConSalidasAcuPorProducto.GetInstancia();
            frmRepConSalAcPro.MdiParent = this;
            frmRepConSalAcPro.Show();
        }
    }
}
