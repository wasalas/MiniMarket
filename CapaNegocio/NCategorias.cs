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
    public class NCategorias
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DCategorias oDatos = new DCategorias();
            return oDatos.Listado(estado, texto );
        }
        public static string Guardar(int opt_guarda, ECategorias oEntidad)
        {
            DCategorias oDatos = new DCategorias();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DCategorias oDatos = new DCategorias();
            return oDatos.Eliminar(codigo);
        }        
    }
}
