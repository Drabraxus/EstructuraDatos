using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        clPila PilaBackups = new clPila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try {
                if (PilaBackups.Cantidad() >= 10)
                {
                    MessageBox.Show("NO puede registrar mas de 10 Bases", "Alerta");
                }
                else {
                    clBackUp nclaBackUp = new clBackUp(txtNombreBKP.Text);
                    PilaBackups.Apilar(nclaBackUp);
                    LimpiarCampos(2);
                    txtLIstaBackups.Text = PilaBackups.Mostrar();
                }                
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void LimpiarCampos(int vLimpiar)
        {
            txtNombreBKP.Clear();
            if (vLimpiar == 2)
            {
                lblUltimoBKP.Text = "";
                lblFechaUltimoBKP.Text = "";
            }
        }

        private void btnUtilizar_Click(object sender, EventArgs e)
        {
            try{
                if (PilaBackups.Cantidad() == 0){
                    MessageBox.Show("No se tienen BackUps Registrados", "Alerta");
                }
                else {
                    lblUltimoBKP.Text = PilaBackups.Extraer().VNombreBackUp;
                    lblFechaUltimoBKP.Text = PilaBackups.Extraer().VFechaBackUp.ToString();
                    PilaBackups.Desapilar();
                    LimpiarCampos(1);
                    txtLIstaBackups.Text = PilaBackups.Mostrar();
                }
                
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try{
                PilaBackups.Limpiar();
                LimpiarCampos(2);
                txtLIstaBackups.Text = PilaBackups.Mostrar();                
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
