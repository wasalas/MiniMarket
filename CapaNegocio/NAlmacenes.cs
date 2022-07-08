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
    public class NAlmacenes
    {
        public static DataTable Listado(int estado, string texto)
        {
            DAlmacenes oDatos = new DAlmacenes();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EAlmacenes oEntidad)
        {
            DAlmacenes oDatos = new DAlmacenes();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DAlmacenes oDatos = new DAlmacenes();
            return oDatos.Eliminar(codigo);
        }
    }
}
