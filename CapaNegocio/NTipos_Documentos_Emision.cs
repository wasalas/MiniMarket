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
    public class NTipos_Documentos_Emision
    {
        public static DataTable Listado(int estado)
        {
            DTipos_Documentos_Emision oDatos = new DTipos_Documentos_Emision();
            return oDatos.Listado(estado);
        }
    }
}
