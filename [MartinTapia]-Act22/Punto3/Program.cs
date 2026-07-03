using System;
using System.Collections.Generic;
using System.Linq;
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

        public void RegistrarDuracion(DateTime Horas, DateTime Minutos)
        {

        }

        public void RegistrarDuracion(DateTime Minutos)
        {

        }

        static void Main(string[] args)
        {
            Entrenamiento entrenamiento2 = new Entrenamiento();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("* === * === * === * === * === * === * === *");
            Console.Write("Ingresa el nombre del deportista: ");
            string deportista = Console.ReadLine();
            Console.Write("Ingresa cuantas horas duro su entrenamiento: ");
            DateTime hora = DateTime.Parse(Console.ReadLine());
            Console.Write("y cuantos minutos duro su entrenamiento?: ");
            DateTime minutos = DateTime.Parse(Console.ReadLine());


            //entrenamiento2.RegistrarDuracion(DateTime.Today.AddHours(2), DateTime.Today.AddMinutes(20));
            //entrenamiento2.RegistrarDuracion(DateTime.Today.AddMinutes(40));

            

            Console.ReadKey();
        }
    }
}
