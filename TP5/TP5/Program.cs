using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    internal class Program
    {
        /*  Escribir un programa que calcule la suma de los N primeros números naturales. El valor de N se leerá por teclado. */

        static void Main(string[] args)
        {
            int suma=0, cantidad;

            Console.Write("Ingrese la cantidad de numeros naturales para la suma: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("La suma de los numeros comprendidos entre 1 y "+cantidad+" es: " + suma);

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
