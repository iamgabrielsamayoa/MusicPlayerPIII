using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class clsListaCircularBase
    {
        private Nodo lc;

        public clsListaCircularBase()
        {
            lc = null;
        }

        public clsListaCircularBase insertar(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (lc != null)//lista no vacia
            {
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;
            }

            lc = nuevo;
            return this;
        }

        public void eliminar(int entrada)
        {
            Nodo actual;
            bool encontrado = false;
            //bucle de busqueda
            actual = lc;
            while ((actual.enlace != lc) && (!encontrado))
            {
                encontrado = (actual.enlace.dato.Equals(entrada));
                if (!encontrado)
                {
                    actual = actual.enlace;
                }
            }


            encontrado = (actual.enlace.dato.Equals( entrada));
            //Enlace de nodo con el siguiente
            if (encontrado)
            {
                Nodo p;
                p = actual.enlace;
                if (lc == lc.enlace)
                {
                    lc = null;
                }
                else
                {
                    if (p == lc)
                    {
                        lc = actual; //se borra el elemento referenciado lc
                    }
                    actual.enlace = p.enlace;
                }
                p = null;
            }



        }

        public void recorrer()
        {
            Nodo p;
            if (lc != null)
            {
                p = lc.enlace; // siguiente nodo al de acceso
                do
                {
                   Console.WriteLine("\t" + p.dato);
                    p = p.enlace;
                } while (p != lc.enlace);
            }
            else
                Console.WriteLine("\t Lista Circular vacía.");
        }
    }
}
