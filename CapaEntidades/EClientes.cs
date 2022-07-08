using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EClientes
    {        
        public int Codigo_cl { get; set; }
        public int Codigo_tdi { get; set; }
        public string Nro_documento_cl { get; set; }
        public string Razon_social_cl { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Codigo_sx { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
        public string Movil { get; set; }
        public string Direccion { get; set; }
        public int Codigo_de { get; set; }
        public int Codigo_po { get; set; }
        public int Codigo_di { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
    }
}
