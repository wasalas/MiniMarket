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
    public partial class frmUsuarios : Form
    {
        // ***********************************************************************************
        #region "Mis Variables"
        private static frmUsuarios _instancia;
        private EUsuarios oDatos = new EUsuarios();
        private int Cantidad_registros;
        private int Estado_guarda;
        bool estado;
        string texto_buscar;
        #endregion

        // ***********************************************************************************
        #region "Metodos del Form"
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }
        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
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
            Eliminar();
        }
        private void btn_reporte_Click(object sender, EventArgs e)
        {            
            ObtenerDatosForm();
            if (this.Cantidad_registros == 0)
            {
                MessageBox.Show("No existen datos para el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Reportes.frmRepUsuarios frm = new Reportes.frmRepUsuarios();
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

            dgDatos.DataSource = NUsuarios.Listado(p_estado, this.texto_buscar);
            this.Cantidad_registros = dgDatos.Rows.Count;

            ts_estado.Items[0].Text = "Estado : " + (estado ? "Activos" : "Inactivos");
            ts_estado.Items[1].Text = "   ";
            ts_estado.Items[2].Text = "Total registros : " + this.Cantidad_registros;
            FormatoGrid();
        }
        private void Editar()
        {
            frmUsuarios_ed frm = new frmUsuarios_ed(this.Estado_guarda, oDatos);
            frm.ShowDialog();

            if (frm.GraboDatos == true)
            {
                CargaDatos();
                BuscarEnGrid(oDatos.Codigo_us);
            }
        }
        private void Eliminar()
        {
            ObtenerDatosForm();

            string mensaje = "¿Está seguro de desactivar.? \n" + this.oDatos.Nombre_us;
            DialogResult Rpta = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rpta != DialogResult.Yes)
                return;

            string msg_elimino;
            msg_elimino = NMarcas.Eliminar(oDatos.Codigo_us);
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

            estado = this.chkEsatdo.Checked;
            texto_buscar = this.txt_buscar.Text.ToUpper().Trim();

            if (this.Cantidad_registros == 0)
            {
                oDatos.Codigo_us = 0;
                oDatos.Nombre_us = "";
                oDatos.Clave_us = "";
                oDatos.Admin = 0;
                oDatos.Estado = 0;
            }
            else
            {
                oDatos.Codigo_us = Convert.ToInt32(dgDatos.CurrentRow.Cells["codigo_us"].Value);
                oDatos.Nombre_us = Convert.ToString(dgDatos.CurrentRow.Cells["nombre_us"].Value);
                oDatos.Clave_us = Convert.ToString(dgDatos.CurrentRow.Cells["clave_us"].Value);
                oDatos.Admin = Convert.ToByte(dgDatos.CurrentRow.Cells["admin"].Value);
                oDatos.Estado = Convert.ToByte(dgDatos.CurrentRow.Cells["estado"].Value);                
            }
        }
        private void FormatoGrid()
        {
            dgDatos.Columns[0].HeaderText = "CODIGO";
            dgDatos.Columns[0].Width = 100;
            dgDatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgDatos.Columns[1].HeaderText = "NOMBRE";
            dgDatos.Columns[1].Width = 300;

            dgDatos.Columns[2].HeaderText = "CLAVE";
            dgDatos.Columns[2].Width = 100;
            dgDatos.Columns[2].Visible = false;

            dgDatos.Columns[3].HeaderText = "ADMIN";
            dgDatos.Columns[3].Width = 100;
            dgDatos.Columns[3].Visible = true;

            dgDatos.Columns[4].HeaderText = "ESTADO";
            dgDatos.Columns[4].Width = 100;
            dgDatos.Columns[4].Visible = false;

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
        public static frmUsuarios GetInstancia()
        {
            if (_instancia == null)
                _instancia = new frmUsuarios();
            else
                _instancia.Activate();

            return _instancia;
        }
        #endregion


    }
}
