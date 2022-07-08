using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class DSalida_Productos
    {
        public DataTable Listado_Enc(int estado, string texto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Enc_Salida_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = estado;
                Comando.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listado_Det(int codigo_sp)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Det_Salida_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_sp", SqlDbType.Int).Value = codigo_sp;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Guardar(int opcion, EEnc_Salida_Productos oEntidad, DataTable dtDetalle)
        {
            string Codigo_Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Salida_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@opt_guarda", SqlDbType.Int).Value = opcion;

                //Comando.Parameters.Add("@codigo_sp", SqlDbType.Int).Value = oEntidad.Codigo_sp;
                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo_sp";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Direction = ParameterDirection.InputOutput;
                ParCodigo.Value = oEntidad.Codigo_sp;
                Comando.Parameters.Add(ParCodigo);

                Comando.Parameters.Add("@codigo_tde", SqlDbType.Int).Value = oEntidad.Codigo_tde;
                Comando.Parameters.Add("@nro_documento_sp", SqlDbType.VarChar).Value = oEntidad.Nro_documento_sp;
                Comando.Parameters.Add("@codigo_cl", SqlDbType.Int).Value = oEntidad.Codigo_cl;
                Comando.Parameters.Add("@fecha_sp", SqlDbType.Date).Value = oEntidad.Fecha_sp;
                Comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = oEntidad.Observaciones;
                Comando.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = oEntidad.Subtotal;
                Comando.Parameters.Add("@igv", SqlDbType.Decimal).Value = oEntidad.Igv;
                Comando.Parameters.Add("@total_importe", SqlDbType.Decimal).Value = oEntidad.Total_importe;
                Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dtDetalle;

                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Codigo_Rpta = Convert.ToString(ParCodigo.Value).Trim().ToUpper();
            }
            catch (Exception ex)
            {
                Codigo_Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Codigo_Rpta;
        }

        public string Eliminar(int codigo_sp)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spEliminar_Salida_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_sp", SqlDbType.Int).Value = codigo_sp;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo desactivar.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
