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
    public class NStock_Productos
    {
        public static DataTable Listado_PorProducto(int codigo)
        {
            DStock_Productos oDatos = new DStock_Productos();
            return oDatos.Listado_PorProducto(codigo);
        
        }
       
    }
}
