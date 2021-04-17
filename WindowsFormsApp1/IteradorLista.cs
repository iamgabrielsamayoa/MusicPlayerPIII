using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class IteradorLista
    {

        private Nodo actual;

        public IteradorLista(clsListaDoble ld)
        {
            actual = ld.cabeza;
        }

        public Nodo siguiente()
        {
            Nodo a;
            a = actual;
            if (actual != null)
            {
                actual = actual.adelante;
            }
            return a;
        }
    }
}
