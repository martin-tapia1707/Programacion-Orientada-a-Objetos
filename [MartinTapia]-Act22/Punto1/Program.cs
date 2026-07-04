using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    Actividad 1: Control de horarios en un gimnasio
    Problema:
    Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
    DateTime).
     Implementar un constructor que permita cargar los datos desde consola y otro
    que cargue valores por defecto (sobrecarga de constructores).
     Incluir un método para calcular la duración de la clase usando TimeSpan.
     Crear un vector de 3 clases de gimnasio y mostrar:
    1. La clase que tenga la mayor duración.
    2. El nombre y el horario de inicio de la clase más temprana. 
    */
    class ClaseGimnasio
    {
        string nombreClase;
        DateTime horaInicio;
        DateTime horaFin;
        
        public ClaseGimnasio()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Ingresa el nombre de la clase: ");
            nombreClase = Console.ReadLine();
            Console.Write("Ingresa la hora de inicio: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingresa la hora de fin: ");
            horaFin = DateTime.Parse(Console.ReadLine());
        }

        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreClase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

        public TimeSpan Duracion() // lo retorno a ver si lo toma el main
        {
            return horaFin - horaInicio;
        }

        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];
            for(int i = 0; i < clases.Length; i++)
            {
                clases[i] = new ClaseGimnasio();
            }

            for(int j = 0; j < clases.Length; j++)
            {
                clases[j].Duracion();
            }

            TimeSpan mayor = clases[0].Duracion();
            int pos = 0;

            for(int k = 0; k < clases.Length; k++)
            {
                if (clases[k].Duracion() > mayor)
                {
                    mayor = clases[k].Duracion();
                    pos = k;
                }
            }
            Console.WriteLine("La clase " + clases[pos].nombreClase + " dura mas tiempo con " + mayor + " horas");

            DateTime menor = clases[0].horaInicio;
            pos = 0;
            for(int f = 0; f < clases.Length; f++)
            {
                if (menor > clases[f].horaInicio)
                {
                    menor = clases[f].horaInicio;
                    pos = f;
                }
            }
            Console.WriteLine("La clase que mas temprano inicia es " + clases[pos].nombreClase + " a las " + menor);
        }
    }
}
