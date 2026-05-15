using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Academia de Gastronomía: Recetario Dinámico
    Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
    una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
    ● Definir un vector para los nombres de los alumnos.
    ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
    presentado.
    ● Métodos:
    1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
    de cada alumno.
    2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
    3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
    4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado"
    (promedio >= 70) o "Reprobado".
    5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
    valor máximo de la matriz). 
    */
    internal class Academia
    {
        private string[] alumnos;
        private int[][] puntaje;

        public void Definir()
        {
            puntaje = new int[3][];
            alumnos = new string[3];
            puntaje[0] = new int[2];
            puntaje[1] = new int[4];
            puntaje[2] = new int[3];
        }

        public void Cargar()
        {

            for(int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno: ");
                alumnos[i] = Console.ReadLine();
            }

            for(int f = 0; f < puntaje.Length; f++)
            {
                for(int c = 0; c < puntaje[f].Length; c++)
                {
                    do
                    {

                        Console.WriteLine("Ingresar el puntaje(0-100) que tendra " + alumnos[f] + " en el plato N°" + (c + 1));
                        puntaje[f][c] = int.Parse(Console.ReadLine());

                    } while (puntaje[f][c] < 0 || puntaje[f][c] > 100);
                }
            }
        }

        public void Listado()
        {
            for(int f = 0; f < puntaje.Length; f++)
            {
                Console.WriteLine("Puntajes que recibieron los platos de: " + alumnos[f]);
                for (int c = 0; c < puntaje[f].Length; c++)
                {
                    Console.Write(puntaje[f][c] + " - ");
                }
                Console.WriteLine();
            }
        }

        public void Promedio()
        {
            float promedio = 0;
            for(int f = 0; f < puntaje.Length; f++)
            {

                for(int c = 0; c < puntaje[f].Length; c++)
                {
                    promedio = promedio + puntaje[f][c];
                }
                promedio = promedio / puntaje[f].Length;
                Console.WriteLine("El promedio de " + alumnos[f] + " es de " + promedio);

                if(promedio >= 70)
                {
                    Console.WriteLine("Aprobado");
                } else
                {
                    Console.WriteLine("Reprobado");
                }

                promedio = 0;
            }
        }

        public void MayorPuntaje()
        {
            int mayor = puntaje[0][0];
            int pos = 0;

            for(int f = 0; f < puntaje.Length; f++)
            {
                for(int c = 0; c < puntaje[f].Length; c++)
                {
                    if (puntaje[f][c] > mayor)
                    {
                        mayor = puntaje[f][c];
                        pos = f;
                    }
                }
            }

            Console.WriteLine("El alumno " + alumnos[pos] + " obtuvo el puntaje individual mas alto con " + mayor);
        }

        static void Main(string[] args)
        {
            Academia aca2 = new Academia();
            aca2.Definir();
            aca2.Cargar();
            aca2.Listado();
            aca2.Promedio();
            aca2.MayorPuntaje();
            Console.ReadKey();
        }
    }
}
