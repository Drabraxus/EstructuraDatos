using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class clCliente
    {
        private string vZona;
        private string vNombre;
        private DateTime vFecha;

        public clCliente()
        { }

        public clCliente(string vZona, string vNombre)
        {
            this.vZona = vZona;
            this.vNombre = vNombre;
            this.vFecha = DateTime.Now;
        }

        public clCliente(string vZona, string vNombre, DateTime vFecha)
        {
            this.vZona = vZona;
            this.vNombre = vNombre;
            this.vFecha = vFecha;
        }

        public string VZona { get => vZona; set => vZona = value; }
        public string VNombre { get => vNombre; set => vNombre = value; }
        public DateTime VFecha { get => vFecha; set => vFecha = value; }

        public override string ToString()
        {
            return $"{VNombre} - {VZona} - {VFecha}";
        }
    }
}
