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
    public class DEntrada_Productos
    {
        public DataTable Listado_Enc(int estado, string texto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Enc_Entrada_Productos", SqlCon);
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

        public DataTable Listado_Det(int codigo_ep)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Det_Entrada_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_ep", SqlDbType.Int).Value = codigo_ep;
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

        public string Guardar(int opcion, EEnc_Entrada_Productos oEntidad, DataTable dtDetalle)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Entrada_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@opt_guarda", SqlDbType.Int).Value = opcion;
                Comando.Parameters.Add("@codigo_ep", SqlDbType.Int).Value = oEntidad.Codigo_ep;
                Comando.Parameters.Add("@codigo_tde", SqlDbType.Int).Value = oEntidad.Codigo_tde;
                Comando.Parameters.Add("@nro_documento_ep", SqlDbType.VarChar).Value = oEntidad.Nro_documento_ep;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = oEntidad.Codigo_pv;
                Comando.Parameters.Add("@fecha_ep", SqlDbType.Date).Value = oEntidad.Fecha_ep;
                Comando.Parameters.Add("@codigo_al", SqlDbType.Int).Value = oEntidad.Codigo_al;
                Comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = oEntidad.Observaciones;
                Comando.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = oEntidad.Subtotal;
                Comando.Parameters.Add("@igv", SqlDbType.Decimal).Value = oEntidad.Igv;
                Comando.Parameters.Add("@total_importe", SqlDbType.Decimal).Value = oEntidad.Total_importe;
                Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dtDetalle;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo guardar la información";
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
        public string Eliminar(int codigo_ep)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spEliminar_Entrada_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_ep", SqlDbType.Int).Value = codigo_ep;
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
