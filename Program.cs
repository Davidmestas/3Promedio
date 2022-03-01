using System;

namespace _3Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             *Instituto Tecnologico de Puebla
             *Materia: Programacion 2
             *Profesor: Nicolas Sanchez Sanchez
             *
             *INTEGRANTES:
             *Mestas Castro David Israel 18221803
             *Maria del Carmen Castro 19221983
             *
             */

            // 3) Calcular la media

            double Matematicas, Euskera, Programacion, Ingles, Algebra, Sumanotas, Media;

            Console.WriteLine("Calificacion Matematicas");
            Matematicas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificacion Matematicas");
            Euskera = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificacion Matematicas");
            Programacion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificacion Matematicas");
            Ingles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificacion Matematicas");
            Algebra = Convert.ToDouble(Console.ReadLine());

            Sumanotas = Matematicas + Euskera + Programacion + Ingles + Algebra;
            Media = Sumanotas / 5;

            Console.WriteLine("La suma de todas las notas es {0}", Sumanotas);
            Console.WriteLine("La media es {0}", Media);

            // 4) Comprobar si el alumno aprobo el curso

            if (Media >= 5.0)
            {

                Console.WriteLine("Aprobado");

            }
            else
            {
                
                Console.WriteLine("Reprobado");

            }
            Console.ReadKey();





        }
    }
}
