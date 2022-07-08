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
    public partial class frmEntradaProductos_ed : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private int Estado_guarda;
        private EEnc_Entrada_Productos oDatos;
        public EDet_Entrada_Productos oDatosDet;
        public bool GraboDatos = false;
        private int Cantidad_registros;
        private DataTable dtDetalle = new DataTable();
        private DataTable dtProductos = new DataTable();
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmEntradaProductos_ed(int Opcion, EEnc_Entrada_Productos Datos)
        {
            InitializeComponent();
            this.Estado_guarda = Opcion;
            this.oDatos = Datos;
        }
        private void frmEntradaProductos_ed_Load(object sender, EventArgs e)
        {
            this.cbo_tip_doc_ep.DataSource = NTipos_Documentos_Emision.Listado(1);
            this.cbo_tip_doc_ep.ValueMember = "codigo_tde";
            this.cbo_tip_doc_ep.DisplayMember = "descripcion_tde";

            this.cbo_proveedor.DataSource = NProveedores.Listado(1, "");
            this.cbo_proveedor.ValueMember = "codigo_pv";
            this.cbo_proveedor.DisplayMember = "razon_social_pv";

            this.cbo_almacen.DataSource = NAlmacenes.Listado(1, "");
            this.cbo_almacen.ValueMember = "codigo_al";
            this.cbo_almacen.DisplayMember = "descripcion_al";
            this.cbo_almacen.Enabled = false;

            this.dtProductos = NProductos.Listado(1, "");
            this.cbo_productos.DataSource = this.dtProductos;
            this.cbo_productos.ValueMember = "codigo_pr";
            this.cbo_productos.DisplayMember = "descripcion_pr";
            this.cbo_productos.SelectedValue = -1;

            this.txt_cantidad.Text = "0.00";
            this.txt_precio.Text = "0.00";
            this.txt_total.Text = "0.00";

            if (this.Estado_guarda == 1)
            {
                this.txt_codigo_ep.Text = "0";
                this.cbo_tip_doc_ep.SelectedValue = -1;
                this.txt_num_doc_ep.Text = "";
                this.cbo_proveedor.SelectedValue = -1;
                //this.dt_Fecha_ep = new System.Windows.Forms.DateTimePicker();                
                this.cbo_almacen.SelectedValue = 1;
                this.txt_observaciones.Text = "";

                this.Text = "Nueva ";
            }
            else
            {
                this.txt_codigo_ep.Text = oDatos.Codigo_ep.ToString();
                this.cbo_tip_doc_ep.SelectedValue = oDatos.Codigo_tde;
                this.txt_num_doc_ep.Text = oDatos.Nro_documento_ep;
                this.cbo_proveedor.SelectedValue = oDatos.Codigo_pv;
                this.dt_Fecha_ep.Value = oDatos.Fecha_ep;
                this.cbo_almacen.SelectedValue = oDatos.Codigo_al;
                this.txt_observaciones.Text = oDatos.Observaciones;

                this.Text = "Modificar ";
            }
            this.Text += "Entrada de Productos";
            Carga_Detalle();

            this.cbo_productos.Enabled = this.Estado_guarda == 1 ? true : false;
            this.txt_cantidad.Enabled = this.Estado_guarda == 1 ? true : false;
            this.txt_precio.Enabled = this.Estado_guarda == 1 ? true : false;
            this.txt_total.Enabled = false;
            this.btn_add.Enabled = this.Estado_guarda == 1 ? true : false;
            this.btn_del.Enabled = this.Estado_guarda == 1 ? true : false;

            if (this.Estado_guarda != 1 && oDatos.Estado == 0)
                {
                    // documento anulado
                    gb_Datos_generales.Enabled = false;
                btn_guardar.Enabled = false;
            }
        }
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"

        private void dgDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow yFila = dtDetalle.Rows[e.RowIndex];
            decimal yCantidad = Convert.ToDecimal(yFila["cantidad"]);
            decimal yPu_cpmra = Convert.ToDecimal(yFila["pu_compra"]);
            yFila["total"] = decimal.Round(yCantidad * yPu_cpmra, 2);
            this.dtDetalle.AcceptChanges();
            this.Calcula_Total_Importe();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            decimal nCantidad = Convert.ToDecimal("0.00");
            decimal nPrecio = Convert.ToDecimal("0.00");
            decimal nTotal = Convert.ToDecimal("0.00");

            int nIndex;
            int xCodigo_pr;

            nIndex = cbo_productos.SelectedIndex;
            xCodigo_pr = nIndex >= 0 ? (int)dtProductos.Rows[nIndex]["codigo_pr"] : 0;

            nCantidad = Convert.ToDecimal(this.txt_cantidad.Text);
            nPrecio = Convert.ToDecimal(this.txt_precio.Text);
            nTotal = Convert.ToDecimal(this.txt_total.Text);

            if (nIndex == -1)
            {
                MessageBox.Show("Seleccione un Producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_productos.Focus();
                return;
            }
            if (nCantidad == 0)
            {
                MessageBox.Show("Ingrese la Cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }
            if (nPrecio == 0)
            {
                MessageBox.Show("Ingrese el Precio Unitario de Compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precio.Focus();
                return;
            }
            if (nTotal == 0)
            {
                MessageBox.Show("El total no puede ser Cero, Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_total.Focus();
                return;
            }
            if (Existe_Producto(xCodigo_pr))
            {
                MessageBox.Show("Producto ya ingresado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_productos.Focus();
                return;
            }

            DataRow xFila = dtDetalle.NewRow();
            xFila["codigo_pr"] = xCodigo_pr;
            xFila["descripcion_pr"] = dtProductos.Rows[nIndex]["descripcion_pr"];
            xFila["descripcion_ma"] = dtProductos.Rows[nIndex]["descripcion_ma"];
            xFila["descripcion_um"] = dtProductos.Rows[nIndex]["descripcion_um"];
            xFila["descripcion_ca"] = dtProductos.Rows[nIndex]["descripcion_ca"];
            xFila["cantidad"] = nCantidad;
            xFila["pu_compra"] = nPrecio;
            xFila["total"] = nTotal;
            this.dtDetalle.Rows.Add(xFila);

            this.Contar_Registros();
            this.Calcula_Total_Importe();
            MessageBox.Show("Item agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txt_cantidad.Text = "0.00";
            this.txt_precio.Text = "0.00";
            this.txt_total.Text = "0.00";
            this.cbo_productos.SelectedValue = -1;

            this.cbo_productos.Focus();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            string sDescripcion_pr;

            this.Contar_Registros();

            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sDescripcion_pr = Convert.ToString(dgDatos.CurrentRow.Cells["descripcion_pr"].Value);
            string mensaje = "¿Está seguro de Eliminar el producto.? \n" + sDescripcion_pr;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            dgDatos.Rows.Remove(dgDatos.CurrentRow);
            dgDatos.Refresh();
            dtDetalle.AcceptChanges();
            this.Calcula_Total_Importe();


        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            dtDetalle.AcceptChanges();
            this.Contar_Registros();

            if (this.Cantidad_registros == 0)
            {
                this.cbo_productos.Focus();
                MessageBox.Show("Ingrese por lo menos un item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            oDatos.Codigo_ep = Convert.ToInt32(this.txt_codigo_ep.Text);
            oDatos.Codigo_tde = Convert.ToInt32(this.cbo_tip_doc_ep.SelectedValue);
            oDatos.Nro_documento_ep = this.txt_num_doc_ep.Text.Trim();
            oDatos.Codigo_pv = Convert.ToInt32(this.cbo_proveedor.SelectedValue);
            oDatos.Fecha_ep = this.dt_Fecha_ep.Value;
            oDatos.Codigo_al = Convert.ToInt32(this.cbo_almacen.SelectedValue);
            oDatos.Observaciones = this.txt_observaciones.Text.Trim();

            oDatos.Subtotal = Convert.ToDecimal(this.txt_subtotal.Text);
            oDatos.Igv = Convert.ToDecimal(this.txt_igv.Text);
            oDatos.Total_importe = Convert.ToDecimal(this.txt_importe_total.Text);

            if (oDatos.Nro_documento_ep == String.Empty)
            {
                txt_num_doc_ep.Focus();
                MessageBox.Show("Ingrese El numero de documewnto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro de guardar los datos.", "Confirmacion.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Rpta = NEntrada_Productos.Guardar(this.Estado_guarda, this.oDatos, dtDetalle);
                if (Rpta.Equals("OK"))
                {
                    MessageBox.Show("Datos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GraboDatos = true;
                    this.Close();
                }
                else
                    MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            this.Calcula_Total_Producto();
        }
        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            this.Calcula_Total_Producto();
        }

        #endregion

        // ***********************************************************************************
        #region "Mis Metodos"
        private void Carga_Detalle()
        {
            if (this.Estado_guarda == 1)
            {
                this.dtDetalle = new DataTable();
                this.dtDetalle.Columns.Add("codigo_pr", System.Type.GetType("System.Int32"));
                this.dtDetalle.Columns.Add("descripcion_pr", System.Type.GetType("System.String"));
                this.dtDetalle.Columns.Add("descripcion_ma", System.Type.GetType("System.String"));
                this.dtDetalle.Columns.Add("descripcion_um", System.Type.GetType("System.String"));
                this.dtDetalle.Columns.Add("descripcion_ca", System.Type.GetType("System.String"));
                this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
                this.dtDetalle.Columns.Add("pu_compra", System.Type.GetType("System.Decimal"));
                this.dtDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"));
                this.dtDetalle.AcceptChanges();

                dgDatos.DataSource = this.dtDetalle;
            }
            else
            {
                this.dtDetalle = NEntrada_Productos.Listado_Det(oDatos.Codigo_ep);
                dgDatos.DataSource = this.dtDetalle;
            }

            ts_estado.Items[0].Text = "";
            ts_estado.Items[1].Text = "";
            Formato_Grid();
            this.Contar_Registros();
            this.Calcula_Total_Importe();
        }
        private void Calcula_Total_Producto()
        {
            decimal nCantidad, nPrecio, nTotal;

            nCantidad = Convert.ToDecimal(this.txt_cantidad.Text);
            nPrecio = Convert.ToDecimal(this.txt_precio.Text);
            nTotal = decimal.Round(nCantidad * nPrecio, 2);

            txt_total.Text = nTotal.ToString("#0.00");
        }
        private void Calcula_Total_Importe()
        {
            decimal nSubTotal = 0, nIgv = 0, nTotal_Importe = 0;

            if (Cantidad_registros != 0)
            {
                dtDetalle.AcceptChanges();
                foreach (DataRow dataRow in dtDetalle.Rows)
                {
                    nTotal_Importe = decimal.Round(nTotal_Importe + Convert.ToDecimal(dataRow["total"]), 2);
                }
                nSubTotal = decimal.Round(nTotal_Importe / Convert.ToDecimal(1.18), 2);
                nIgv = decimal.Round(nTotal_Importe - nSubTotal, 2);
            }
            txt_subtotal.Text = nSubTotal.ToString("#0.00");
            txt_igv.Text = nIgv.ToString("#0.00");
            txt_importe_total.Text = nTotal_Importe.ToString("#0.00");
        }
        private bool Existe_Producto(int nCodigo_pr)
        {
            bool bExiste = false;
            foreach (DataRow dataRow in dtDetalle.Rows)
            {
                if (Convert.ToInt32(dataRow["codigo_pr"]) == nCodigo_pr)
                {
                    bExiste = true;
                    break;
                }
            }
            return bExiste;
        }
        private void Contar_Registros()
        {
            this.Cantidad_registros = dgDatos.Rows.Count;
            ts_estado.Items[2].Text = "Total registros : " + this.Cantidad_registros;
        }
        private void Formato_Grid()
        {
            dgDatos.ReadOnly = this.Estado_guarda == 1 ? false : true;

            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 70;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].ReadOnly = true;

            dgDatos.Columns[1].HeaderText = "PRODUCTO";
            dgDatos.Columns[1].Width = 200;
            dgDatos.Columns[1].ReadOnly = true;

            dgDatos.Columns[2].HeaderText = "MARCA";
            dgDatos.Columns[2].Width = 90;
            dgDatos.Columns[2].ReadOnly = true;

            dgDatos.Columns[3].HeaderText = "UNIDADES";
            dgDatos.Columns[3].Width = 90;
            dgDatos.Columns[3].ReadOnly = true;

            dgDatos.Columns[4].HeaderText = "CATEGORIA";
            dgDatos.Columns[4].Width = 90;
            dgDatos.Columns[4].ReadOnly = true;

            dgDatos.Columns[5].HeaderText = "CANTIDAD";
            dgDatos.Columns[5].Width = 90;
            dgDatos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[5].ReadOnly = false;
            if (this.Estado_guarda == 1)
                dgDatos.Columns[5].HeaderCell.Style.BackColor = Color.White;

            dgDatos.Columns[6].HeaderText = "PU COMPRA";
            dgDatos.Columns[6].Width = 95;
            dgDatos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[6].ReadOnly = false;
            if (this.Estado_guarda == 1)
                dgDatos.Columns[6].HeaderCell.Style.BackColor = Color.White;

            dgDatos.Columns[7].HeaderText = "SUB TOTAL";
            dgDatos.Columns[7].Width = 95;
            dgDatos.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[7].ReadOnly = true;
        }
        private void Mayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        #endregion
    }
}
