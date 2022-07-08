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
    public class NProvincias
    {
        public static DataTable Listado(int codigo_de, int estado, string texto)
        {
            DProvincias oDatos = new DProvincias();
            return oDatos.Listado(codigo_de, estado, texto);
        }
        public static string Guardar(int opt_guarda, EProvincias oEntidad)
        {
            DProvincias oDatos = new DProvincias();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DProvincias oDatos = new DProvincias();
            return oDatos.Eliminar(codigo);
        }
    }
}
