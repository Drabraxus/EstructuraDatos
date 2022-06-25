
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class clPila
    {
        clNodo Tope;
        public void Apilar(clBackUp nclBackUp)
        {
            clNodo nodo = new clNodo();
            nodo.Datos = nclBackUp;

            if (Tope == null){
                Tope = nodo;
            }
            else {
                nodo.siguiente = Tope;
                Tope = nodo;
            }
        }

        public String Mostrar()
        {
            string retorno = string.Empty;
            clNodo nodo = Tope;
            while (nodo != null)
            {
                retorno += nodo.Datos.ToString() + Environment.NewLine;
                nodo = nodo.siguiente;

            }
            return retorno;
        }

        public clBackUp Extraer()
        {
            clBackUp dato = Tope.Datos;
            return dato;
        }

        public void Desapilar()
        {
            clBackUp dato = Tope.Datos;
            Tope = Tope.siguiente;
        }

        public void Limpiar()
        {
            clNodo nodo = Tope;
            while (nodo != null){
                Desapilar();
                nodo = nodo.siguiente;
            }
        }

        public int Cantidad()
        {
            int vCantidad = 0;
            clNodo nodo = Tope;
            while (nodo != null)
            {
                vCantidad++;
                nodo = nodo.siguiente;

            }
            return vCantidad;
        }
    }
}
