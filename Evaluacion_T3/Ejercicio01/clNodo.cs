using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class clNodo
    {
        public clProducto Datos { get; set; }
        public clNodo Izquierdo { get; set; }
        public clNodo Derecho { get; set; }
    }
}
