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
    public class DProveedores
    {
        public DataTable Listado(int estado, string texto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Proveedores", SqlCon);
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
        public string Guardar(int opcion, EProveedores oEntidad)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Proveedores", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@opt_guarda", SqlDbType.Int).Value = opcion;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = oEntidad.Codigo_pv;
                Comando.Parameters.Add("@codigo_tdi", SqlDbType.Int).Value = oEntidad.Codigo_tdi;
                Comando.Parameters.Add("@nro_documento_pv", SqlDbType.VarChar).Value = oEntidad.Nro_documento_pv;
                Comando.Parameters.Add("@razon_social_pv", SqlDbType.VarChar).Value = oEntidad.Razon_social_pv;
                Comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = oEntidad.Apellidos;
                Comando.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oEntidad.Nombres;
                Comando.Parameters.Add("@codigo_sx", SqlDbType.Int).Value = oEntidad.Codigo_sx;
                Comando.Parameters.Add("@codigo_ru", SqlDbType.Int).Value = oEntidad.Codigo_ru;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = oEntidad.Email;
                Comando.Parameters.Add("@telefonos", SqlDbType.VarChar).Value = oEntidad.Telefonos;
                Comando.Parameters.Add("@movil", SqlDbType.VarChar).Value = oEntidad.Movil;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = oEntidad.Direccion;
                Comando.Parameters.Add("@codigo_de", SqlDbType.Int).Value = oEntidad.Codigo_de;
                Comando.Parameters.Add("@codigo_po", SqlDbType.Int).Value = oEntidad.Codigo_po;
                Comando.Parameters.Add("@codigo_di", SqlDbType.Int).Value = oEntidad.Codigo_di;
                Comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = oEntidad.Observaciones;
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
                SqlCommand Comando = new SqlCommand("spEliminar_Proveedores", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigo;
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
