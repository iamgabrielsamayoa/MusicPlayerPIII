using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class clsListaDoble
    {


        public Nodo cabeza;//es el nodo que se llama primero

        public clsListaDoble()
        {
            cabeza = null;
        }

        public clsListaDoble insertarCabezaLista(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return null;
        }

        public clsListaDoble insertarDespues(Nodo anterior, string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;
            if (anterior.adelante != null)
            {
                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(string entrada)
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;

            //bucle de busqueda
            while ((actual != null) && (encontrado))
            {
                encontrado = (actual.dato == entrada);//al usar string debe ser equals
                if (!encontrado)
                {
                    actual = actual.adelante;
                }

            }
            //enlace de nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir cabeza del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }//3 if
                } //2nd if
                else if (actual.adelante != null)
                {
                    //no es el ultimo
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }//else if
                else
                {
                    actual.atras.adelante = null;
                }
                actual = null;
            }//1er if

        }

        public void visualizar()
        {
            Nodo n;
            n = cabeza;
            while (n != null)
            {
                Console.WriteLine(n.dato + "\n");
                n = n.adelante;
            }
        }
    }
}
