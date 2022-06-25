using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class clCola
    {
        clNodo Inicio;
        clNodo Final;

        public void Encolar(clCliente nclCliente)
        {
            clNodo nodo = new clNodo();
            nodo.Datos = nclCliente;
            if (Inicio == null){
                Inicio = nodo;
                Final = nodo;
            }
            else {
                Final.siguiente = nodo;
                Final = nodo;
            }
        }

        public String Mostrar() {
            string retorno = string.Empty;
            clNodo nodo = Inicio;
            while (nodo != null) {
                retorno += nodo.Datos.ToString() + Environment.NewLine;
                nodo = nodo.siguiente;
            }
            return retorno;
        }

        public clCliente Extraer()
        {
            clCliente dato = Inicio.Datos;
            return dato;
        }

        public void Desencolar()
        {
            clCliente dato = Inicio.Datos;
            Inicio = Inicio.siguiente;
        }

        public void Limpiar()
        {
            clNodo nodo = Inicio;
            while (nodo != null)
            {
                Desencolar();
                nodo = nodo.siguiente;
            }
        }

        public int Cantidad()
        {
            int vCantidad = 0;
            clNodo nodo = Inicio;
            while (nodo != null)
            {
                vCantidad++;
                nodo = nodo.siguiente;

            }
            return vCantidad;
        }
    }
}
