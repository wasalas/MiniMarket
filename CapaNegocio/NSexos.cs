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
    public class NSexos
    {
        public static DataTable Listado(int estado)
        {
            DSexos oDatos = new DSexos();
            return oDatos.Listado(estado);
        }
    }
}
