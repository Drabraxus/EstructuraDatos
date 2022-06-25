using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class clABB
    {
        public clNodo Raiz;
        public String InOrder;
        public String PreOrder;
        public String PostOrder;
        public String Formato;

        public int TotalNodos;
        public int TotalNodosIzq;
        public int TotalNodosDer;

        public void Agregar(clProducto nclProducto)
        {
            try {
                clNodo nodo = new clNodo();
                nodo.Datos = nclProducto;

                if (Raiz == null){
                    Raiz = nodo;
                }
                else{
                    clNodo NodoRecorrido = Raiz;
                    clNodo NodoDisponible = null;

                    while (NodoRecorrido != null) {
                        NodoDisponible = NodoRecorrido;
                        if (nclProducto.VCodigo == NodoRecorrido.Datos.VCodigo)
                        {
                            return;//sale de la funcion
                        }
                        else if (string.Compare(nclProducto.VCodigo, NodoRecorrido.Datos.VCodigo)==-1)
                        {
                            NodoRecorrido = NodoRecorrido.Izquierdo;
                        }
                        else
                        {
                            NodoRecorrido = NodoRecorrido.Derecho;
                        }
                    }
                    if (string.Compare(nclProducto.VCodigo,NodoDisponible.Datos.VCodigo)==-1)
                    {
                        NodoDisponible.Izquierdo = nodo;
                    }
                    else
                    {
                        NodoDisponible.Derecho = nodo;
                    }
                }
                TotalNodos = 0;
                TotalNodosIzq = 0;
                TotalNodosDer = 0;
                ContarNodos(Raiz);
            }
            catch (Exception e){ 
            
            }
        }

        public void RecorrerInOrder(clNodo nodo) 
        {
            if (nodo != null)
            {
                RecorrerInOrder(nodo.Izquierdo);
                InOrder += nodo.Datos + " -> ";
                RecorrerInOrder(nodo.Derecho);
            }
        }

        public void RecorrerPreOrder(clNodo nodo) 
        {        
            if (nodo != null)
            {
                PreOrder += nodo.Datos + " -> ";
                RecorrerPreOrder(nodo.Izquierdo);
                RecorrerPreOrder(nodo.Derecho);
            }
        }

        public void RecorrerPostOrder(clNodo nodo) 
        {
            if (nodo != null)
            {
                RecorrerPostOrder(nodo.Izquierdo);
                RecorrerPostOrder(nodo.Derecho);
                PostOrder += nodo.Datos + " -> ";
            }
        }

        public void RecorrerFormato(clNodo nodo)
        {
            if (nodo != null)
            {
                if (nodo.Izquierdo != null)
                    Formato += nodo.Datos + " ->" + nodo.Izquierdo.Datos + Environment.NewLine;

                if (nodo.Derecho != null)
                    Formato += nodo.Datos + " ->" + nodo.Derecho.Datos + Environment.NewLine;

                RecorrerFormato(nodo.Izquierdo);
                RecorrerFormato(nodo.Derecho);
            }
        }

        public void ContarNodos(clNodo nodo)
        {
            try{

                if (nodo == null)
                {
                    TotalNodos = 0;
                    TotalNodosIzq = 0;
                    TotalNodosDer = 0;
                    return;
                }
                    

                TotalNodos = 1;

                if (nodo.Izquierdo != null)
                {                     
                    TotalNodosIzq++;
                    ContarNodos(nodo.Izquierdo);
                }

                if (nodo.Derecho != null)
                {                  
                    TotalNodosDer++;
                    ContarNodos(nodo.Derecho);
                }

                TotalNodos = 1 + TotalNodosIzq + TotalNodosDer;
            }
            catch (Exception ex) { 
            
            }
        }

        public clProducto BuscarProducto(string vBuscarCodigo)
        {
            clProducto nclProductoEncontrado = new clProducto();
            try
            {
                clNodo nodo = Raiz;
                
                while (nodo != null)
                {
                    if (nodo.Datos.VCodigo == vBuscarCodigo)
                    {
                        nclProductoEncontrado.VCodigo = nodo.Datos.VCodigo;
                        nclProductoEncontrado.VDescripcion = nodo.Datos.VDescripcion;
                        nclProductoEncontrado.VPrecio = nodo.Datos.VPrecio;
                        nclProductoEncontrado.VCategoria = nodo.Datos.VCategoria;
                        nclProductoEncontrado.VEstado = nodo.Datos.VEstado;
                        return nclProductoEncontrado;
                    }                   

                    if (string.Compare(vBuscarCodigo, nodo.Datos.VCodigo) == -1)
                    {
                        nodo = nodo.Izquierdo ;
                    }
                    else
                    {
                        nodo = nodo.Derecho;
                    }
                }
            }
            catch (Exception ex) {
                
            }
            return nclProductoEncontrado;
        }

        public void EliminarNodo(string vBuscarCodigo)
        {
            clNodo nodoAElimar = Raiz;
            clNodo nodoPadre = null;
            Boolean EsIzquierda = false;

            try {
                while (nodoAElimar != null && nodoAElimar.Datos.VCodigo != vBuscarCodigo)
                {
                    nodoPadre = nodoAElimar;
                    if (string.Compare(vBuscarCodigo, nodoAElimar.Datos.VCodigo) == -1)
                    {
                        nodoAElimar = nodoAElimar.Izquierdo;
                        EsIzquierda = true;
                    }
                    else
                    {
                        nodoAElimar = nodoAElimar.Derecho;
                        EsIzquierda = false;
                    }
                }
                if (nodoAElimar == null)
                {
                    //return false;
                    Console.WriteLine("No hay dato a eliminar");
                }
                else if (nodoAElimar.Izquierdo == null && nodoAElimar.Derecho == null)
                {
                    if (nodoAElimar == Raiz)
                    {
                        Raiz = null;
                    }
                    if (EsIzquierda)
                    {
                        nodoPadre.Izquierdo = null;
                    }
                    else
                    {
                        nodoPadre.Derecho = null;
                    }
                }
                else if (nodoAElimar.Derecho == null)
                {
                    if (nodoAElimar == Raiz)
                    {
                        Raiz = Raiz.Izquierdo;
                    }
                    if (EsIzquierda)
                    {
                        nodoPadre.Izquierdo = nodoAElimar.Izquierdo;
                    }
                    else
                    {
                        nodoPadre.Derecho = nodoAElimar.Izquierdo;
                    }
                }
                else if (nodoAElimar.Izquierdo == null)
                {
                    if (nodoAElimar == Raiz)
                    {
                        Raiz = Raiz.Derecho;
                    }
                    if (EsIzquierda)
                    {
                        nodoPadre.Izquierdo = nodoAElimar.Derecho;
                    }
                    else
                    {
                        nodoPadre.Derecho = nodoAElimar.Derecho;
                    }
                }
                else
                {
                    clNodo nodoReemplazo = ObtnerNodoReemplazoDeSubArbolDerecho(nodoAElimar);
                    if (nodoAElimar == Raiz)
                    {
                        Raiz = nodoReemplazo;
                    }
                    if (EsIzquierda)
                    {
                        nodoPadre.Izquierdo = nodoReemplazo;
                    }
                    else
                    {
                        nodoPadre.Derecho = nodoReemplazo;
                    }
                    nodoReemplazo.Izquierdo = nodoAElimar.Izquierdo;
                }
                TotalNodos = 0;
                TotalNodosIzq = 0;
                TotalNodosDer = 0;
                ContarNodos(Raiz);
                //return true;
            }
            catch (Exception ex) { 
            
            }
            
        }

        private clNodo ObtnerNodoReemplazoDeSubArbolDerecho(clNodo nodoEliminar)
        {
            clNodo nodoAuxiliar = nodoEliminar.Derecho;
            clNodo reemplazo = nodoEliminar;
            clNodo reemplazopadre = nodoEliminar;

            while (nodoAuxiliar != null)
            {
                reemplazopadre = reemplazo;
                reemplazo = nodoAuxiliar;
                nodoAuxiliar = nodoAuxiliar.Izquierdo;
            }

            if (reemplazo != nodoEliminar.Derecho)
            {
                reemplazopadre.Izquierdo = reemplazo.Derecho;
                reemplazo.Derecho = nodoEliminar.Derecho;
            }
            return reemplazo;
        }
    }
}
