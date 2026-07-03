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

            vuelos[0] = new Vuelo(1, DateTime.Today.AddHours(10), DateTime.Today.AddHours(18));
            vuelos[1] = new Vuelo(2, DateTime.Today.AddHours(5), DateTime.Today.AddHours(14)); // testeo vuelos para ver si andan mis metodos
            vuelos[2] = new Vuelo(3, DateTime.Today.AddHours(9), DateTime.Today.AddHours(15));  // despues hacer mejor el constructor
            vuelos[3] = new Vuelo(4, DateTime.Today.AddHours(16), DateTime.Today.AddHours(22));

            // vuelo mas largo

            TimeSpan mayor = vuelos[0].Duracion();
            int pos = 0;
            for(int j = 0; j < vuelos.Length; j++)
            {
                if (vuelos[j].Duracion() > mayor)
                {
                    mayor = vuelos[j].Duracion();
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
                }
            }

            Console.WriteLine("El vuelo " + vuelos[pos].codigo + " es el vuelo que mas temprano sale, ya que dura " +  menor);

            Console.ReadKey();

        }
    }
}
