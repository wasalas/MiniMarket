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
    public class NUsuarios
    {
        public static DataTable Listado(int estado, string texto)
        {
            DUsuarios oDatos = new DUsuarios();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EUsuarios oEntidad)
        {
            DUsuarios oDatos = new DUsuarios();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DUsuarios oDatos = new DUsuarios();
            return oDatos.Eliminar(codigo);
        }
    }
}
