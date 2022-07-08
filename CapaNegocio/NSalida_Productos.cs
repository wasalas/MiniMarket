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
    public class NSalida_Productos
    {
        public static DataTable Listado_Enc(int estado, string texto)
        {
            DSalida_Productos oDatos = new DSalida_Productos();
            return oDatos.Listado_Enc(estado, texto);
        }
        public static DataTable Listado_Det(int codigo_sp)
        {
            DSalida_Productos oDatos = new DSalida_Productos();
            return oDatos.Listado_Det(codigo_sp);
        }
        public static string Guardar(int opt_guarda, EEnc_Salida_Productos oEntidad, DataTable dtDetalle)
        {
            DSalida_Productos oDatos = new DSalida_Productos();
            return oDatos.Guardar(opt_guarda, oEntidad, dtDetalle);
        }
        public static string Eliminar(int codigo)
        {
            DSalida_Productos oDatos = new DSalida_Productos();
            return oDatos.Eliminar(codigo);
        }
    }
}
