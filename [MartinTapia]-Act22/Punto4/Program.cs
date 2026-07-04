using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    Actividad 4: Gestión de vuelos
    Problema:

    Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
     Usar la palabra clave this en el constructor para diferenciar los parámetros de
    los atributos.
     Crear un método para calcular la duración del vuelo (TimeSpan).
     Cargar un vector con 4 vuelos y mostrar:
    1. El código y duración del vuelo más largo.
    2. El código del vuelo que salga más temprano. 
    */

    internal class Vuelo
    {
        private int codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public Vuelo(int codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan Duracion()
        {
            TimeSpan duracion = horaLlegada - horaSalida;
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4]; // cambiar a 4, testeo con 1

            for(int i = 0; i < vuelos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("==========================================");
                Console.Write("Ingresa el codigo del vuelo: ");
                int vuelo = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la hora de salida: ");
                DateTime horaSalida = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingresa la hora de llegada: ");
                DateTime horaLlegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo(vuelo, horaSalida, horaLlegada);
            }

            // vuelo mas largo

            TimeSpan mayor = vuelos[0].Duracion();
            int pos = 0;
            for(int j = 0; j < vuelos.Length; j++)
            {
                if (vuelos[j].Duracion() > mayor)
                {
                    mayor = vuelos[j].Duracion();
                    pos = j;
                }
            }

            Console.WriteLine("El vuelo " + vuelos[pos].codigo + " es el vuelo mas largo, ya que dura " + mayor);

            // vuelo que mas temprano sale

            DateTime menor = vuelos[0].horaSalida;
            pos = 0;
            for(int k = 0; k < vuelos.Length; k++)
            {
                if (menor > vuelos[k].horaSalida)
                {
                    menor = vuelos[k].horaSalida;
                    pos = k;
                }
            }

            Console.WriteLine("El vuelo " + vuelos[pos].codigo + " es el vuelo que mas temprano sale, ya que sale a las " +  menor);

            Console.ReadKey();

        }
    }
}
