using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class NProductos
    {
        public static DataTable Listado(int estado, string texto)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Listado(estado, texto);
        }
        public static DataTable ListadoConStock(int estado, string texto)
        {
            DProductos oDatos = new DProductos();
            return oDatos.ListadoConStock(estado, texto);
        }
        public static string Guardar(int opt_guarda, EProductos oEntidad)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Eliminar(codigo);
        }
    }
}
