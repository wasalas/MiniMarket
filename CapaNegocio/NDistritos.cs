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
    public class NDistritos
    {
        public static DataTable Listado(int codigo_de, int codigo_po, int estado, string texto)
        {
            DDistritos oDatos = new DDistritos();
            return oDatos.Listado(codigo_de, codigo_po, estado, texto);
        }
        public static string Guardar(int opt_guarda, EDistritos oEntidad)
        {
            DDistritos oDatos = new DDistritos();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DDistritos oDatos = new DDistritos();
            return oDatos.Eliminar(codigo);
        }
    }
}
