using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /* - Un docente de Programación tiene un listado de 3 notas registradas por cada uno de sus N estudiantes. 
La nota final se compone de un trabajo práctico Integrador (35%), una Exposición (25%) y un Parcial (40%). 
El docente requiere los siguientes informes claves de sus estudiantes:

▪ Nota promedio final de los estudiantes que reprobaron el curso. Un estudiante reprueba el curso si 
tiene una nota final inferior a 6.5.
▪ Porcentaje de alumnos que tienen una nota de integrador mayor a 7.5.
▪ La mayor nota obtenida en las exposiciones.
▪ Total, de estudiantes que obtuvieron en el Parcial entre 4.0 y 7.5.

El programa pedirá la cantidad de alumnos que tiene el docente y en cada alumno pedirá las 3 notas y 
calculará todos informes claves que requiere el docente. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int alumnos,reprobados  = 0,contador  = 0,contador2  = 0;
            string nombre, alumnoM = "";
            float nota1, nota2, nota3, TPI, EXP, PAR, suma,aux, sumaRP = 0, mayor = 0, promedio = 0,porcentaje= 0;

            Console.Write("Ingrese la cantidad de Alumnos del curso: ");
            alumnos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alumnos; i++)
            {
                Console.Write("\n\nIngrese el nombre del alumno numero " + i + " : ");
                nombre=Console.ReadLine();

                do 
                {
                    Console.Write("\nIngrese la nota del Trabajo Practico Integrador del alumno " + nombre + " : ");
                    nota1 = float.Parse(Console.ReadLine());

                    if (nota1 < 7.5)
                    {
                        contador++;
                    }

                    TPI = (float)(nota1 * 0.35);

                } while (nota1 < 0 || nota1 > 10) ;
            
                do 
                {
                    Console.Write("\nIngrese la nota de la Exposición del alumno " + nombre + " : ");
                    nota2 = float.Parse(Console.ReadLine());

                    if (nota2 > mayor)
                    {
                        mayor = nota2;
                        alumnoM = nombre;

                    }

                    EXP = (float)(nota2 * 0.25);

                } while (nota2 < 0 || nota2 > 10);
            

                do 
                {
                    Console.Write("\nIngrese la nota del Parcial del alumno " + nombre + " : ");
                    nota3 = float.Parse(Console.ReadLine());

                    if (nota3 > 4.0 && nota3 < 7.5)
                    {
                        contador2++;
                    }

                    PAR = (float)(nota3 * 0.40);

                    suma = PAR + EXP + TPI;

                    if (suma < 6.5)
                    {
                        reprobados++;
                        sumaRP = sumaRP + suma;
                    }

                } while (nota3 < 0 || nota3 > 10);
     
            }

            aux = alumnos - contador;
            promedio = sumaRP / reprobados;
            porcentaje = aux * 100 / alumnos;   

            Console.Write("\n\n\n----------------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("\nNota promedio final de los alumnos que reprobaron el curso: " + promedio );
            Console.WriteLine("\nPorcentaje de alumnos que tienen una nota de integrador mayor a 7,5 : " + porcentaje + "%");
            Console.WriteLine("\nLa mayor nota obtenida en las exposiciones es: " + mayor + " del alumno \"" + alumnoM+ "\""); 
            Console.WriteLine("\nTotal de alumnos que obtuvieron una nota entre 4.0 y 7.5 en el parcial: " + contador2 );
            Console.Write("\n----------------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();


        }
    }
}
