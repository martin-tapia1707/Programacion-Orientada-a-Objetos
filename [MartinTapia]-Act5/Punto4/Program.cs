using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            4. Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor. 
            */

            int mañana, tarde, noche;
            float promMañana, promTarde, promNoche;

            promMañana = 0;
            promNoche = 0;
            promTarde = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese la edad de los estudiantes del turno mañana: ");
                mañana = int.Parse(Console.ReadLine());

                promMañana = promMañana + mañana;
            }

            Console.WriteLine("* * * * AHORA LOS DEL TURNO TARDE * * * *");

            for (int z = 0; z < 30; z++)
            {
                Console.Write("Ingrese la edad de los estudiantes del turno tarde: ");
                tarde = int.Parse(Console.ReadLine());

                promTarde = promTarde + tarde;
            }

            Console.WriteLine("* * * * AHORA LOS DEL TURNO NOCHE * * * *");

            for (int x = 0; x < 15; x++)
            {
                Console.Write("Ingrese la edad de los estudiantes del turno noche: ");
                noche = int.Parse(Console.ReadLine());
                promNoche = promNoche + noche;
            }

            promMañana = (promMañana / 20);
            promTarde = (promTarde / 30);
            promNoche = (promNoche / 15);

            Console.WriteLine("El promedio del turno mañana es: " + promMañana);
            Console.WriteLine("El promedio del turno tarde es: " + promTarde);
            Console.WriteLine("El promedio del turno noche es: " + promNoche);

            if(promMañana < promTarde && promMañana < promNoche)
            {
                Console.Write("El turno con menor promedio de edad es el turno Mañana con: " + promMañana);
            }
            
            if(promTarde < promNoche && promTarde < promMañana)
            {
                Console.Write("El turno con menor promedio de edad es el turno Tarde con: " + promTarde);
            }

            if(promNoche < promTarde && promNoche < promMañana)
            {
                Console.Write("El turno con menor promedio de edad es el turno Noche con: " + promNoche);
            }







            Console.ReadKey();

        }
    }
}
