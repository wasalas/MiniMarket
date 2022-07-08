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
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private static frmProveedores _instancia;
        private EProveedores oDatos = new EProveedores();
        private int Cantidad_registros;
        private int Estado_guarda;
        bool estado;
        string texto_buscar;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void frmProveedores_FormClosed(object sender, FormClosedEventArgs e)
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
                MessageBox.Show("Seleccione un item a desactivar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (oDatos.Estado != 1)
            {
                MessageBox.Show("Registro ya desactivado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Eliminar(oDatos.Codigo_pv, oDatos.Razon_social_pv);
        }
        private void btn_reporte_Click(object sender, EventArgs e)
        {
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("No existen datos para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reportes.frmRepProveedores frm = new Reportes.frmRepProveedores();
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

            dgDatos.DataSource = NProveedores.Listado(p_estado, this.texto_buscar);
            this.Cantidad_registros = dgDatos.Rows.Count;

            ts_estado.Items[0].Text = "Estado : " + (estado ? "Activos" : "Inactivos");
            ts_estado.Items[1].Text = "   ";
            ts_estado.Items[2].Text = "Total registros : " + this.Cantidad_registros;
            FormatoGrid();
        }
        private void Editar()
        {
            frmProveedores_ed frm = new frmProveedores_ed(this.Estado_guarda, oDatos);
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

            string mensaje = "¿Está seguro de desactivar.? \n" + this.oDatos.Razon_social_pv;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            string msg_elimino;
            msg_elimino = NProveedores.Eliminar(oDatos.Codigo_pv);
            if (msg_elimino == "OK")
            {
                MessageBox.Show("Se desactivó satisfactoriamente el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                oDatos.Codigo_pv = 0;
                oDatos.Codigo_tdi = 0;
                oDatos.Nro_documento_pv = "";
                oDatos.Razon_social_pv = "";
                oDatos.Nombres = "";
                oDatos.Apellidos = "";
                oDatos.Codigo_sx = 0;
                oDatos.Codigo_ru = 0;
                oDatos.Email = "";
                oDatos.Telefonos = "";
                oDatos.Movil = "";
                oDatos.Direccion = "";
                oDatos.Codigo_de = 0;
                oDatos.Codigo_po = 0;
                oDatos.Codigo_di = 0;
                oDatos.Observaciones = "";
                oDatos.Estado = 0;
            }
            else
            {
                oDatos.Codigo_pv = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_pv"].Value);
                oDatos.Codigo_tdi = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_tdi"].Value);
                oDatos.Nro_documento_pv = Convert.ToString(dgDatos.CurrentRow.Cells["nro_documento_pv"].Value);
                oDatos.Razon_social_pv = Convert.ToString(dgDatos.CurrentRow.Cells["razon_social_pv"].Value);
                oDatos.Nombres = Convert.ToString(dgDatos.CurrentRow.Cells["nombres"].Value);
                oDatos.Apellidos = Convert.ToString(dgDatos.CurrentRow.Cells["apellidos"].Value);
                oDatos.Codigo_sx = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_sx"].Value);
                oDatos.Codigo_ru = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_ru"].Value);
                oDatos.Email = Convert.ToString(dgDatos.CurrentRow.Cells["email"].Value);
                oDatos.Telefonos = Convert.ToString(dgDatos.CurrentRow.Cells["telefonos"].Value);
                oDatos.Movil = Convert.ToString(dgDatos.CurrentRow.Cells["movil"].Value);
                oDatos.Direccion = Convert.ToString(dgDatos.CurrentRow.Cells["direccion"].Value);
                oDatos.Codigo_de = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_de"].Value);
                oDatos.Codigo_po = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_po"].Value);
                oDatos.Codigo_di = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_di"].Value);
                oDatos.Observaciones = Convert.ToString(dgDatos.CurrentRow.Cells["observaciones"].Value);
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);
            }
        }
        private void FormatoGrid()
        {

            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 70;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].Visible = true;

            dgDatos.Columns[1].HeaderText = "TIP DOC";
            dgDatos.Columns[1].Width = 70;
            dgDatos.Columns[1].Visible = true;

            dgDatos.Columns[2].HeaderText = "NUM DOC";
            dgDatos.Columns[2].Width = 100;
            dgDatos.Columns[2].Visible = true;

            dgDatos.Columns[3].HeaderText = "RAZON SOCIAL";
            dgDatos.Columns[3].Width = 300;
            dgDatos.Columns[3].Visible = true;

            dgDatos.Columns[4].HeaderText = "APELLIDOS";
            dgDatos.Columns[4].Width = 100;
            dgDatos.Columns[4].Visible = true;

            dgDatos.Columns[5].HeaderText = "NOMBRES";
            dgDatos.Columns[5].Width = 100;
            dgDatos.Columns[5].Visible = true;

            dgDatos.Columns[6].HeaderText = "SEXO";
            dgDatos.Columns[6].Width = 100;
            dgDatos.Columns[6].Visible = false;

            dgDatos.Columns[7].HeaderText = "RUBRO";
            dgDatos.Columns[7].Width = 100;
            dgDatos.Columns[7].Visible = true;

            dgDatos.Columns[8].HeaderText = "EMAIL";
            dgDatos.Columns[8].Width = 100;
            dgDatos.Columns[8].Visible = false;

            dgDatos.Columns[9].HeaderText = "TELEFONOS";
            dgDatos.Columns[9].Width = 100;
            dgDatos.Columns[9].Visible = false;

            dgDatos.Columns[10].HeaderText = "CELULAR";
            dgDatos.Columns[10].Width = 100;
            dgDatos.Columns[10].Visible = false;

            dgDatos.Columns[11].HeaderText = "DIRECCION";
            dgDatos.Columns[11].Width = 130;
            dgDatos.Columns[11].Visible = true;

            dgDatos.Columns[12].HeaderText = "DISTRITO";
            dgDatos.Columns[12].Width = 100;
            dgDatos.Columns[12].Visible = true;

            dgDatos.Columns[13].HeaderText = "OBS";
            dgDatos.Columns[13].Width = 100;
            dgDatos.Columns[13].Visible = false;

            dgDatos.Columns[14].HeaderText = "ESTADO";
            dgDatos.Columns[14].Width = 100;
            dgDatos.Columns[14].Visible = false;

            dgDatos.Columns[15].HeaderText = "COD TIP DOC";
            dgDatos.Columns[15].Width = 100;
            dgDatos.Columns[15].Visible = false;

            dgDatos.Columns[16].HeaderText = "COD SEXO";
            dgDatos.Columns[16].Width = 100;
            dgDatos.Columns[16].Visible = false;

            dgDatos.Columns[17].HeaderText = "COD RUBRO";
            dgDatos.Columns[17].Width = 100;
            dgDatos.Columns[17].Visible = false;

            dgDatos.Columns[18].HeaderText = "COD DEPTO";
            dgDatos.Columns[18].Width = 100;
            dgDatos.Columns[18].Visible = false;

            dgDatos.Columns[19].HeaderText = "COD PROV";
            dgDatos.Columns[19].Width = 100;
            dgDatos.Columns[19].Visible = false;

            dgDatos.Columns[20].HeaderText = "COD DIS";
            dgDatos.Columns[20].Width = 100;
            dgDatos.Columns[20].Visible = false;
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
        public static frmProveedores GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmProveedores();
            else
                _instancia.Activate();

            return _instancia;
        }
        #endregion
        
    }
}
