using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Program
    {
        /*  Realizar un programa que muestre la cantidad de números que son múltiplos de 2 o de 3 comprendidos entre 1 y 100. */

        static void Main(string[] args)
        {
            int cont2 = 0, cont3 = 0;


            for (int i = 1;i <= 100;i++)
            {
                if (i % 2 == 0) 
                {
                    cont2=cont2 + 1;
                }
                
                if (i % 3 == 0) 
                {
                    cont3=cont3 + 1;
                }

            }

            Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");

            Console.WriteLine(cont2+" numeros son múltiplos de 2, entre 1 y 100");
            Console.WriteLine();
            Console.WriteLine(cont3+" numeros son múltiplos de 3, entre 1 y 100");
        
            Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");



            Console.ReadKey();
        }
    }
}
