using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class RandomClass1
    {
        public int GeneraNum()
        {
            int b = 0;
            Random ran = new Random();
            int a = ran.Next(10); //Seleccionamos el rango en base a las canciones con las que contamos
            if (a == b)
            {
                a = ran.Next(10);
            }
            b = a;
            return a;
        }
        public string generaTokenAlfanumerico(int longitudToken)
        {
            Random aleatorio = new Random();
            String abcdario = "abcdefghijklmnñopqrstuvwxyz0123456789";
            //String abcdario = "abcdef";
            // declaramos la longitud del token a generar
            //int longitudToken = 3;

            //declaramos la variable token de tipo string que contiene el token
            String token = "";
            // hacemos un ciclo de 0 al tamano del token que queremos generar.
            for (int i = 0; i < longitudToken; i++)
            {
                int a = aleatorio.Next(abcdario.Length); // pregunta, porque 26? //usar . length para evitar errores
                token = token + abcdario[a]; // String es un arreglo de tipo char, por lo que podemos acceder aun valor por ubicacion
            }
            //APUNTE CADA NUMERO SE META A UN ARREGLO Y LOS PIDEN A TRAVES DEL ARREGLO EJE 5
            //EL EJE 6 PUEDE HACERSE ENTRE 1-20 PARA PRACTICAR 
            //
            return token;
        }

        internal string generaTokenAlfanumerico()
        {
            throw new NotImplementedException();
        }
    }
}
