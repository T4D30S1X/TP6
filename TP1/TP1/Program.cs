using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        /* Escribir un programa que calcule el cuadrado de los 9 primeros números naturales e imprima por 
pantalla el número seguido de su cuadrado. Ejemplo: “2 elevado al cuadrado es igual a 4”, y así 
sucesivamente. */

        static void Main(string[] args)
        {
            double cuadrado;

            Console.WriteLine("\n--------------------------------------------------------------------------------------------");

            for (int i = 1;i <= 9;i++)
            {
                cuadrado = Math.Pow(i, 2);


                Console.WriteLine("\n"+i + " elevado al cuadrado es igual a " + cuadrado);

            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
