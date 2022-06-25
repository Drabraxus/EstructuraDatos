using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class clBackUp
    {
        private string vNombreBackUp;
        private DateTime vFechaBackUp;

        public clBackUp()
        { }

        public clBackUp(string vNombreBackUp)
        {
            this.vNombreBackUp = vNombreBackUp;
            this.vFechaBackUp = DateTime.Now;
        }

        public clBackUp(string vNombreBackUp, DateTime vFechaBackUp)
        {
            this.vNombreBackUp = vNombreBackUp;
            this.vFechaBackUp = vFechaBackUp;
        }

        public string VNombreBackUp { get => vNombreBackUp; set => vNombreBackUp = value; }
        public DateTime VFechaBackUp { get => vFechaBackUp; set => vFechaBackUp = value; }

        public override string ToString()
        {
            return $"{VNombreBackUp} - {VFechaBackUp}";
        }
    }
}
