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
    public class NProveedores
    {
        public static DataTable Listado(int estado, string texto)
        {
            DProveedores oDatos = new DProveedores();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EProveedores oEntidad)
        {
            DProveedores oDatos = new DProveedores();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DProveedores oDatos = new DProveedores();
            return oDatos.Eliminar(codigo);
        }
    }
}
