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
    public class NEntrada_Productos
    {
        public static DataTable Listado_Enc(int estado, string texto)
        {
            DEntrada_Productos oDatos = new DEntrada_Productos();
            return oDatos.Listado_Enc(estado, texto);
        }
        public static DataTable Listado_Det(int codigo_ep)
        {
            DEntrada_Productos oDatos = new DEntrada_Productos();
            return oDatos.Listado_Det(codigo_ep);
        }
        public static string Guardar(int opt_guarda, EEnc_Entrada_Productos oEntidad, DataTable dtDetalle)
        {
            DEntrada_Productos oDatos = new DEntrada_Productos();
            return oDatos.Guardar(opt_guarda, oEntidad, dtDetalle);
        }
        public static string Eliminar(int codigo)
        {
            DEntrada_Productos oDatos = new DEntrada_Productos();
            return oDatos.Eliminar(codigo);
        }
    }
}
