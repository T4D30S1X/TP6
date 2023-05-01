using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    internal class Program
    {
        /* Siguiendo el ejercicio 20 de los ejercicios principales, ahora deberemos hacer lo mismo pero que la 
           cadena se muestre al revés. Por ejemplo, si tenemos la cadena: “Hola Mundo”, deberemos mostrar “o d n u M a l o H”. */

        static void Main(string[] args)
        {

            string frase;
            char letra;         

            Console.Write("Ingrese una frase: ");
            frase= Console.ReadLine();

            Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");

           for (int i = frase.Length; i >0; i--) 
            {
            letra =frase.ElementAt<char>(i-1);
            Console.Write(letra+ " ");
            }

            Console.WriteLine("\n\n----------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
