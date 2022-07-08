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
    public class NTipos_Documentos_Identidad
    {
        public static DataTable Listado(int estado)
        {
            DTipos_Documentos_Identidad oDatos = new DTipos_Documentos_Identidad();
            return oDatos.Listado(estado);
        }        
    }
}
