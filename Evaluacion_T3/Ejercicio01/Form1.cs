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
        clABB nclABB = new clABB();
        clValidacionCampos nValidacion = new clValidacionCampos();
        public Form1()
        {
            InitializeComponent();
            cboCategoria.SelectedItem = "-- Seleccionar --";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try{
                clValidacionCampos nValidarCodigo = new clValidacionCampos("Codigo", txtCodigo.Text, "S","N","A");
                if (nValidarCodigo.ValidarCampos() != false)
                {
                    clValidacionCampos nValidarDescripcion = new clValidacionCampos("Descripcion", txtDescripcio.Text, "S", "S", "T");
                    if (nValidarDescripcion.ValidarCampos() != false)
                    {
                        clValidacionCampos nValidarPrecio = new clValidacionCampos("Precio", txtPrecio.Text, "S", "N", "N");
                        if (nValidarPrecio.ValidarCampos() != false)
                        {
                            string nDato;
                            if (cboCategoria.SelectedItem.ToString() == "-- Seleccionar --")
                            {
                                nDato = "";
                            }
                            else
                            {
                                nDato = cboCategoria.SelectedItem.ToString();
                            }
                            clValidacionCampos nValidarCategoria = new clValidacionCampos("Categoria", nDato, "S", "N", "T");
                            if (nValidarCategoria.ValidarCampos() != false)
                            {
                                clProducto nclProducto = new clProducto(txtCodigo.Text, txtDescripcio.Text, Convert.ToInt32(txtPrecio.Text), cboCategoria.SelectedItem.ToString(), chkEstadoActivo.Checked);
                                nclABB.Agregar(nclProducto);
                                LlenarDatosOrder(nclABB.Raiz);
                                ContarTotalNodo();
                                LimpiarCampos(1);
                            }
                        }
                    }
                }                
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try{
                nclABB.Raiz = null;
                LlenarDatosOrder(nclABB.Raiz);               
                LimpiarCampos(2);
                nclABB.ContarNodos(nclABB.Raiz);
                ContarTotalNodo();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clProducto nclProducto = new clProducto();
                clProducto clProductoDatos = new clProducto();
                clProductoDatos = nclABB.BuscarProducto(txtCodigoBusq.Text);

                if (clProductoDatos.VCodigo != null)
                {
                    txtCodigo.Text = clProductoDatos.VCodigo.ToString();
                    txtDescripcio.Text = clProductoDatos.VDescripcion;
                    txtPrecio.Text = clProductoDatos.VPrecio.ToString();
                    cboCategoria.SelectedItem = clProductoDatos.VCategoria;
                    chkEstadoActivo.Checked = clProductoDatos.VEstado;
                }
                else
                {
                    txtCodigo.Text = txtCodigoBusq.Text;
                    txtDescripcio.Text = "El código no Existe!";
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                nclABB.EliminarNodo(txtCodigoBusq.Text);
                LlenarDatosOrder(nclABB.Raiz);
                ContarTotalNodo();
                LimpiarCampos(2);
            }
            catch (Exception ex) { 
            
            }

        }

        private void LlenarDatosOrder(clNodo Raiz)
        {
            nclABB.InOrder = "";
            nclABB.RecorrerInOrder(Raiz);

            nclABB.PreOrder = "";
            nclABB.RecorrerPreOrder(Raiz);

            nclABB.PostOrder = "";
            nclABB.RecorrerPostOrder(Raiz);

            nclABB.Formato = "";
            nclABB.RecorrerFormato(Raiz);

            txtInOrder.Text = nclABB.InOrder;
            txtPreOrder.Text = nclABB.PreOrder;
            txtPostOrder.Text = nclABB.PostOrder;
            txtFormatoW.Text = nclABB.Formato;
        }
        private void ContarTotalNodo()
        {
            lblTn.Text = nclABB.TotalNodos.ToString();
            lblTnsaIzq.Text = nclABB.TotalNodosIzq.ToString();
            lblTnsaDer.Text = nclABB.TotalNodosDer.ToString();
        }

        private void LimpiarCampos(int nivel)
        {
            if (nivel >= 1)
            {
                txtCodigo.Clear();
                txtDescripcio.Clear();
                txtPrecio.Clear();
                cboCategoria.SelectedIndex = -1;
                chkEstadoActivo.Checked = false;
            }

            if (nivel >= 2)
            { 
                txtCodigoBusq.Clear();
            }
        
        }
    }
}
