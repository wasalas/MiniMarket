using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuarios
    {
        public int Codigo_us { get; set; }
        public string Nombre_us { get; set; }
        public string Clave_us { get; set; }
        public byte Admin { get; set; }
        public byte Estado { get; set; }
    }
}
