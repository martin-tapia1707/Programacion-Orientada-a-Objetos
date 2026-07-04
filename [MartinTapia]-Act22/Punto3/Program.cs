using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    Actividad 3: Registro de entrenamientos
    Problema:
    Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
     Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
    1. Uno que reciba horas y minutos y los convierta a minutos.
    2. Otro que reciba directamente los minutos.
     Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    más corto. 
    */
    internal class Entrenamiento
    {
        private string deportista;
        private TimeSpan duracion;

        public void RegistrarDuracion(int horas, int minutos)
        {
            this.duracion = new TimeSpan(horas, minutos, 0);
            Console.WriteLine(duracion + " en horas"); //test
        }

        public void RegistrarDuracion(int minutos)
        {
            this.duracion = TimeSpan.FromMinutes(minutos);
            Console.WriteLine(duracion + " minutos"); // test
        }

        public Entrenamiento()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("* === * === * === * === * === * === * === *");
            Console.Write("Ingresa el nombre del deportista: ");
            deportista = Console.ReadLine();
            Console.Write("Ingresa cuantos minutos duro su entrenamiento: ");
            int minutos = int.Parse(Console.ReadLine());
            RegistrarDuracion(minutos);
        }

        static void Main(string[] args)
        {
            Entrenamiento[] train = new Entrenamiento[5];

            for(int i = 0; i < train.Length; i++)
            {
                train[i] = new Entrenamiento();
            }

            // entrenamiento mas largo y mas corto
            TimeSpan mayor = train[0].duracion;
            int pos = 0;
            TimeSpan menor = train[0].duracion;
            for(int j = 0; j < train.Length; j++)
            {
                if(menor > train[j].duracion)
                {
                    menor = train[j].duracion;
                    pos = j;
                }
            }

            Console.WriteLine("El entrenamiento con menor duracion es de " + menor + " minutos ");

            for(int k = 0; k < train.Length; k++)
            {
                if (train[k].duracion > mayor)
                {
                    mayor = train[k].duracion;
                    pos = k;
                }
            }

            Console.WriteLine("El entrenamiento con mayor duracion es de " + mayor + " minutos ");

            Console.ReadKey();
        }
    }
}
