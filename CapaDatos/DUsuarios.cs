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
    public class DUsuarios
    {
        public DataTable Listado(int estado, string texto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Usuarios", SqlCon);
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
        public string Guardar(int opcion, EUsuarios oEntidad)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Usuarios", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@opt_guarda", SqlDbType.Int).Value = opcion;
                Comando.Parameters.Add("@codigo_us", SqlDbType.Int).Value = oEntidad.Codigo_us;
                Comando.Parameters.Add("@nombre_us", SqlDbType.VarChar).Value = oEntidad.Nombre_us;
                Comando.Parameters.Add("@clave_us", SqlDbType.VarChar).Value = oEntidad.Clave_us;
                Comando.Parameters.Add("@admin", SqlDbType.Bit).Value = oEntidad.Admin;
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = oEntidad.Estado;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo guardar la información";
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
        public string Eliminar(int codigo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spEliminar_Usuarios", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_us", SqlDbType.Int).Value = codigo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar.";
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
