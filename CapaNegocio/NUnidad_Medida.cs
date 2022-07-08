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
    public class NUnidad_Medida
    {
        public static DataTable Listado(int estado, string texto)
        {
            DUnidad_Medida oDatos = new DUnidad_Medida();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EUnidad_Medida oEntidad)
        {
            DUnidad_Medida oDatos = new DUnidad_Medida();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DUnidad_Medida oDatos = new DUnidad_Medida();
            return oDatos.Eliminar(codigo);
        }
    }
}
