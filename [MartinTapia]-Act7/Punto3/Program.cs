using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{

    /*
    3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
    un videojuego. El programa debe:
     Mostrar la puntuación más alta y la más baja.
     Calcular el promedio de puntuación.
     Contar cuántas veces superó los 500 puntos. 
    */

    internal class Videojuego
    {
        private float[] puntuaciones;

        public void IngresarPuntacion()
        {
            puntuaciones = new float[6];
            for (int n = 0; n < 6; n++)
            {
                Console.Write("Ingresa las puntuaciónes: ");
                puntuaciones[n] = float.Parse(Console.ReadLine());
            }    
        }

        public void MostrarPuntuacion()
        {
            float mayor = puntuaciones[0];
            float menor = puntuaciones[0];

            for (int n = 0; n < 6; n++) // calculo mayor, arranca de posicion 0
            {
                if (puntuaciones[n] > mayor)
                {
                    mayor = puntuaciones[n];
                }
            }

            for (int n = 0; n < 6; n++) // lo mismo pero menor 
            {
                if (puntuaciones[n] < menor)
                {
                    menor = puntuaciones[n];
                }
            }

            Console.WriteLine("La puntuación más alta es: " + mayor);
            Console.WriteLine("La puntuación más baja es: " + menor);
        }

        public void PromedioPuntuacion()
        {
            float promedio = 0;

            for (int n = 0; n < 6; n++)
            {
                promedio = promedio + puntuaciones[n];
            }
            promedio = promedio / 6;
            Console.WriteLine("El promedio de las puntuaciones es: " + promedio);
        }

        public void Puntuacion500()
        {
            int record = 0;
            for (int n = 0; n < 6; n++)
            {
                if (puntuaciones[n] > 500)
                {
                    record++;
                }
            }

            Console.WriteLine("El jugador supero los 500 puntos " + record + " veces");
        }

        static void Main(string[] args)
        {
            Videojuego juego = new Videojuego();
            juego.IngresarPuntacion();
            juego.MostrarPuntuacion();
            juego.PromedioPuntuacion();
            juego.Puntuacion500();
            Console.ReadKey();
        }
    }
}
