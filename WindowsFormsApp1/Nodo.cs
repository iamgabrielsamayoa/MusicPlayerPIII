using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Nodo
    {
        public string dato;
        public Nodo enlace;
        public Nodo adelante;
        public Nodo atras;

        public Nodo(string entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }

        //lista simple
        //public Nodo(string x)
        //{
        //    this.dato = x;
        //    this.enlace = null;
        //}


        //Lista circular method
        //Hacemos sobrecarga de metodos para poder crear otro constructor
        public Nodo(string entrada, int c)
        {
            dato = entrada;
            enlace = this;
        }

        public Nodo(string x, Nodo n)
        {

            dato = x;
            enlace = n;
        }

        public string getDato()
        {
            return dato;
        }

        public Nodo getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }

       
    }
}

