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
    public class NRubros
    {
        public static DataTable Listado(int estado, string texto)
        {
            DRubros oDatos = new DRubros();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, ERubros oEntidad)
        {
            DRubros oDatos = new DRubros();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DRubros oDatos = new DRubros();
            return oDatos.Eliminar(codigo);
        }
    }
}
