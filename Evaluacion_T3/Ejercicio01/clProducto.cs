using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class clProducto
    {
        private string vCodigo;
        private string vDescripcion;
        private double vPrecio;
        private string vCategoria;
        private bool vEstado;

        public clProducto()
        { 
        }

        public clProducto(string vCodigo, string vDescripcion, double vPrecio, string vCategoria, bool vEstado)
        {
            this.vCodigo = vCodigo;
            this.vDescripcion = vDescripcion;
            this.vPrecio = vPrecio;
            this.vCategoria = vCategoria;
            this.vEstado = vEstado;
        }

        public string VCodigo { get => vCodigo; set => vCodigo = value; }
        public string VDescripcion { get => vDescripcion; set => vDescripcion = value; }
        public double VPrecio { get => vPrecio; set => vPrecio = value; }
        public string VCategoria { get => vCategoria; set => vCategoria = value; }
        public bool VEstado { get => vEstado; set => vEstado = value; }

        public override string ToString()
        {
            return $"{VCodigo}";
        }
    }
}
