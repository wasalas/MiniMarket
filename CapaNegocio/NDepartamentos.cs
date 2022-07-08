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
    public class NDepartamentos
    {
        public static DataTable Listado(int estado, string texto)
        {
            DDepartamentos oDatos = new DDepartamentos();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EDepartamentos oEntidad)
        {
            DDepartamentos oDatos = new DDepartamentos();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DDepartamentos oDatos = new DDepartamentos();
            return oDatos.Eliminar(codigo);
        }
    }
}
