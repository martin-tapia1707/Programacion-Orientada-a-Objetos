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
        private DateTime duracion;

        public void RegistrarDuracion(DateTime Horas, DateTime Minutos)
        {
            duracion = (2, 20).TotalMinutes;

        }

        public void RegistrarDuracion(DateTime Minutos)
        {

        }

        static void Main(string[] args)
        {
            Entrenamiento entrenamiento2 = new Entrenamiento();
            entrenamiento2.RegistrarDuracion(DateTime.Today.AddHours(2), DateTime.Today.AddMinutes(20));
            entrenamiento2.RegistrarDuracion(DateTime.Today.AddMinutes(40));

            Console.ReadKey();
        }
    }
}
