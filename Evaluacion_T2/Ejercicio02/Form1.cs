using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        clCola ColaClientes = new clCola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try {
                if (ColaClientes.Cantidad() >= 12){
                    MessageBox.Show("NO puede registrar mas de 12 Clientes", "Alerta");
                }
                else {                    
                    clCliente nclCliente = new clCliente(cboZona.SelectedItem.ToString(),txtNombre.Text);
                    ColaClientes.Encolar(nclCliente);
                    LimpiarCampos(2);
                    txtListaCliente.Text = ColaClientes.Mostrar();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }

        private void LimpiarCampos(int vLimpiar)
        {
            txtNombre.Clear();
            cboZona.SelectedIndex = -1;
            if (vLimpiar == 2)
            {
                lblZona.Text = "";
                lblNombre.Text = "";
                lblFecha.Text = "";
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try{
                if (ColaClientes.Cantidad() == 0){
                    MessageBox.Show("No se tienen Clientes Registrados", "Alerta");
                }
                else {
                    lblNombre.Text = ColaClientes.Extraer().VNombre;
                    lblZona.Text = ColaClientes.Extraer().VZona;
                    lblFecha.Text = ColaClientes.Extraer().VFecha.ToString();
                    ColaClientes.Desencolar();
                    LimpiarCampos(1);
                    txtListaCliente.Text = ColaClientes.Mostrar();
                }
                
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try{
                ColaClientes.Limpiar();
                LimpiarCampos(2);
                txtListaCliente.Text = ColaClientes.Mostrar();
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
