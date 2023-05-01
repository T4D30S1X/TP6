using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Program
    {
        /* Realizar un programa que pida una frase y el programa deberá mostrar la frase con un espacio entre 
cada letra. Por Ejemplo, si se introduce la frase “Hola Mundo” deberá mostrar “H o l a M u n d o”. */
        static void Main(string[] args)
        {
            string frase;


            Console.WriteLine("Ingrese una frase:\n");
            frase = Console.ReadLine();



            Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");

            foreach (char letra in frase) 
            {
                Console.Write(letra+ "  ");
                
            }

            Console.WriteLine("\n\n----------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
