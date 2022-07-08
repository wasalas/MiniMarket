﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmEntradaProductos : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private static frmEntradaProductos _instancia;
        private EEnc_Entrada_Productos oDatos = new EEnc_Entrada_Productos();
        private int Cantidad_registros;
        private int Estado_guarda;
        bool estado;
        string texto_buscar;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmEntradaProductos()
        {
            InitializeComponent();
        }
        private void frmEntradaProductos_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void frmEntradaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }
        #endregion

        // ***********************************************************************************
        #region "Controles del Form"
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_guarda = 1;
            Editar();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Estado_guarda = 2;
            Editar();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("Seleccione un item a Anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (oDatos.Estado != 1)
            {
                MessageBox.Show("Documento ya Anulado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Eliminar(oDatos.Codigo_ep, oDatos.Nro_documento_ep);
        }
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("No existen datos para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reportes.frmRepEntradaProductos frm = new Reportes.frmRepEntradaProductos();
            frm.chk_estado.Checked = this.estado;
            frm.txt_texto.Text = this.texto_buscar;            
            frm.ShowDialog();
            
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_buscar.Text = "";
            CargaDatos();
        }
        private void chkEsatdo_CheckedChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void dgDatos_DoubleClick(object sender, EventArgs e)
        {
            btn_modificar_Click(sender, e);
        }
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        #endregion

        // ***********************************************************************************
        #region "Mis Metodos"


        private void CargaDatos()
        {
            ObtenerDatosForm();

            byte p_estado = Convert.ToByte(estado ? 1 : 0);

            dgDatos.DataSource = NEntrada_Productos.Listado_Enc(p_estado, this.texto_buscar);
            this.Cantidad_registros = dgDatos.Rows.Count;

            ts_estado.Items[0].Text = "Estado : " + (estado ? "Activos" : "Inactivos");
            ts_estado.Items[1].Text = "   ";
            ts_estado.Items[2].Text = "Total registros : " + this.Cantidad_registros;
            FormatoGrid();
        }
        private void Editar()
        {            
            frmEntradaProductos_ed frm = new frmEntradaProductos_ed(this.Estado_guarda, oDatos);
            frm.ShowDialog();

            if (frm.GraboDatos == true)
            {
                CargaDatos();
                BuscarEnGrid(oDatos.Codigo_pv);
            }            
        }
        private void Eliminar(int codigo, string descrip)
        {
            
            ObtenerDatosForm();

            string mensaje = "¿Está seguro de anular el documento.? \n" + descrip;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            string msg_elimino;
            msg_elimino = NEntrada_Productos.Eliminar(oDatos.Codigo_ep);
            if (msg_elimino == "OK")
            {
                MessageBox.Show("Se Anuló satisfactoriamente el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaDatos();
            }
            else
                MessageBox.Show(msg_elimino, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private void ObtenerDatosForm()
        {
            dgDatos.Focus();

            estado = this.chkEstado.Checked;
            texto_buscar = this.txt_buscar.Text.ToUpper().Trim();

            if (this.Cantidad_registros == 0)
            {
                oDatos.Codigo_ep = 0;
                oDatos.Codigo_tde = 0;
                oDatos.Nro_documento_ep = "";
                //oDatos.Fecha_ep = Convert.ToDateTime("");
                oDatos.Codigo_pv = 0;
                oDatos.Codigo_al = 0;
                oDatos.Observaciones = "";
                oDatos.Subtotal = 0;
                oDatos.Igv = 0;
                oDatos.Total_importe = 0;
                oDatos.Estado = 0;
            }
            else
            {
                oDatos.Codigo_ep = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_ep"].Value);
                oDatos.Codigo_tde = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_tde"].Value);
                oDatos.Nro_documento_ep = Convert.ToString(dgDatos.CurrentRow.Cells["nro_documento_ep"].Value);
                oDatos.Fecha_ep = Convert.ToDateTime(dgDatos.CurrentRow.Cells["fecha_ep"].Value);
                oDatos.Codigo_pv = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_pv"].Value);                
                oDatos.Codigo_al = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_al"].Value);
                oDatos.Observaciones = Convert.ToString(dgDatos.CurrentRow.Cells["observaciones"].Value);
                oDatos.Subtotal = Convert.ToDecimal(dgDatos.CurrentRow.Cells["subtotal"].Value);
                oDatos.Igv = Convert.ToDecimal(dgDatos.CurrentRow.Cells["igv"].Value);
                oDatos.Total_importe = Convert.ToDecimal(dgDatos.CurrentRow.Cells["total_importe"].Value);            
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);
            }
        }
        private void FormatoGrid()
        {

            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 70;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgDatos.Columns[1].HeaderText = "TIP DOC";
            dgDatos.Columns[1].Width = 70;

            dgDatos.Columns[2].HeaderText = "NUM DOC";
            dgDatos.Columns[2].Width = 100;

            dgDatos.Columns[3].HeaderText = "FECHA";
            dgDatos.Columns[3].Width = 100;

            dgDatos.Columns[4].HeaderText = "RAZON SOCIAL";
            dgDatos.Columns[4].Width = 300;            

            dgDatos.Columns[5].HeaderText = "ALMACEN";
            dgDatos.Columns[5].Width = 100;

            dgDatos.Columns[6].HeaderText = "OBSERVACIONES";
            dgDatos.Columns[6].Width = 100;
            dgDatos.Columns[6].Visible = false;

            dgDatos.Columns[7].HeaderText = "SUB TOTAL";
            dgDatos.Columns[7].Width = 100;

            dgDatos.Columns[8].HeaderText = "IGV";
            dgDatos.Columns[8].Width = 100;

            dgDatos.Columns[9].HeaderText = "TOTAL";
            dgDatos.Columns[9].Width = 100;

            dgDatos.Columns[10].Visible = false;
            dgDatos.Columns[11].Visible = false;
            dgDatos.Columns[12].Visible = false;
            dgDatos.Columns[13].Visible = false;

        }
        private void BuscarEnGrid(int codigo_buscar)
        {
            // Modificar: se posiciona en la fila modificada
            // Nuevo    : <<...No implementado...>>

            int fil = 0;    // Row
            int col = 0;
            for (fil = 0; fil < dgDatos.RowCount; fil++)
            {
                if (Convert.ToInt32(dgDatos[col, fil].Value) == codigo_buscar)
                {
                    dgDatos.CurrentCell = dgDatos[col, fil];  //dgDatos.Rows[fil].Cells[0];
                    return;
                }
            }
        }
        public static frmEntradaProductos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmEntradaProductos();
            else
                _instancia.Activate();

            return _instancia;
        }
        #endregion

    }
}
