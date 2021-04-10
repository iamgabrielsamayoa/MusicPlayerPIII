using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooclsCarro

{
    class clsCarroBase
    {
        protected String marca = ""; //variable o propiedad
        protected String Color = "";//Puede ser usada por clase hijo
        protected int añoCreación = 1900;
        protected int VelocidadMaxima = 300;
        protected int velocidad = 0;
        protected bool encendido = false;

        // validar que no pase la velocidad maxima.

        //Constructor, se usara en todos 
        //al instanciarlo hacemos el constructor y darle ciertos atributos
        //Estos son atributos que debo darle al crearlo y que no cambiaran
        public clsCarroBase(String marcaCarro, String ColorCarro, int yearCreate)
        {
            marca = marcaCarro;
            Color = ColorCarro;
            añoCreación = yearCreate;
        }

        public void acelerar()
        {

            velocidad += 10;

        }

        public void encenderCarro()
        {
            encendido = true;
        }


        public int obtenerVelocidad()
        {
            return velocidad;
        }

        public void frenar()
        {
            velocidad = 0;
        }

        public String GetDatos()
        {
            String datosCarro = "Marca = " + marca + " color=" + Color + " Año del Carro=" + añoCreación;
            return datosCarro;
        }
        public void apagar()
        {
            if (encendido == true) 
         { 
            encendido = false;
        }
        }

    }
    class ClsPickUp : clsCarroBase
    {

        public ClsPickUp(string marcaCarro, string ColorCarro, int yearCreate) : base(marcaCarro, ColorCarro, yearCreate)
        {
            marca = marcaCarro;
            Color = ColorCarro;
            añoCreación = yearCreate;
            VelocidadMaxima = 120;
        }




    }
}
