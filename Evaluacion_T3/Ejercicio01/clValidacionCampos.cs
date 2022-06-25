using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio01
{
    public class clValidacionCampos
    {
        private string vNombreCampo;
        private string vDato;
        private string vObligatorio; //S:Si es obligatorio/ N:No es Obligatorio
        private string vEspacioBlanco; // S: Acepta espacios en blanco / N: No acepta espacios en blanco
        private string vTipoCampo; // N: Acepta solo datos numericos / A: Acepta datos alfanumericos / T: Acepta todo tipo de datos

        public clValidacionCampos()
        { }
        public clValidacionCampos(string vNombreCampo, string vDato,string vObligatorio, string vEspacioBlanco, string vTipoCampo)
        {
            this.vNombreCampo = vNombreCampo;
            this.vDato= vDato;
            this.vObligatorio = vObligatorio;
            this.vEspacioBlanco = vEspacioBlanco;
            this.vTipoCampo = vTipoCampo;
        }

        public string VNombreCampo { get => vNombreCampo; set => vNombreCampo = value; }
        public string VDato { get => vDato; set => vDato = value; }
        public string VObligatorio { get => vObligatorio; set => vObligatorio = value; }
        public string VEspacioBlanco { get => vEspacioBlanco; set => vEspacioBlanco = value; }
        public string VTipoCampo { get => vTipoCampo; set => vTipoCampo = value; }

        public Boolean ValidarCampos()
        {
            if (vObligatorio == "S")
            {
                if (vDato == "" || vDato == null)
                {
                    MessageBox.Show("El campo " + vNombreCampo + " es obligatorio.", "Alerta");
                    return false;
                }
            }
            if (VTipoCampo == "N")
            {
                int resultado = 0;                
                bool esNumerico;

                esNumerico = Int32.TryParse(VDato, out resultado);
                

                if (esNumerico == false)
                {
                    MessageBox.Show("El campo " + vNombreCampo + " debe ser Numérico.", "Alerta");
                    return false;
                }

                if (resultado <= 0)
                {
                    MessageBox.Show("El campo " + vNombreCampo + " debe ser mayor que 0.", "Alerta");
                    return false;
                }

            }
            if (vEspacioBlanco == "N")
            {
                if (VDato.Contains(" "))
                {
                    MessageBox.Show("El campo " + vNombreCampo + " No permite espacios en blanco.", "Alerta");
                    return false;
                }
            }
            return true;
        }
    }
}
