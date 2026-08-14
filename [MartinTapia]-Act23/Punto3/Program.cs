using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3-
    Un centro de conservación marina registra de forma dinámica las especies de
    mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
     Crear la clase MonitoreoCostero que contenga como atributo privado
    una lista de cadenas de texto List<string> especiesDetectadas.
     Métodos en MonitoreoCostero:
    1. CargarAvistamientos(): Solicitar por teclado nombres de
    especies marinas avistadas (ej: "Ballena Franca", "Lobo Marino",
    "Delfín") y agregarlos a la lista utilizando .Add(). La carga finaliza
    cuando el usuario ingresa la palabra "FIN".
    2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
    organizada alfabéticamente de la A a la Z utilizando el método
    .Sort().
    3. MostrarReporteInvertido(): Imprimir la lista organizada de la
    Z a la A combinando .Sort() con el método .Reverse().
    4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
    animal y, utilizando los métodos de búsqueda de listas, informar si la
    especie fue divisada en la costa durante el día. 
    */

    class MonitoreoCostero
    {
        private List<string> especiesDetectadas = new List<string>();

        public void CargarAvistamientos()
        {
            string nom;
            do
            {
                Console.Write("Nombre de especie avistada: ");
                nom = Console.ReadLine();
                
                if(nom != "FIN") 
                { 
                    especiesDetectadas.Add(nom);
                }

            } while (nom != "FIN");
        }

        public void MostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================");
            Console.WriteLine("LISTA DE AVISTAMIENTOS");
            Console.WriteLine("============================");
            foreach (string nom in especiesDetectadas)
            {
                Console.WriteLine("- " + nom);
            }
        }

        public void MostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("============================");
            Console.WriteLine("LISTA DE AVISTAMIENTOS (INVERTIDO)");
            Console.WriteLine("============================");
            foreach (string nom in especiesDetectadas)
            {
                Console.WriteLine("- " + nom);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void BuscarEspecie()
        {
            bool avistado = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            // solo funciona respetando las mayusculas, recuerdo que habia una etiqueta de lowercase pero no la recuerdo para usarla en el ejercicio
            Console.Write("Ingrese el nombre de un animal..: ");
            Console.ForegroundColor = ConsoleColor.White;
            string animal = Console.ReadLine();

            foreach(string i in especiesDetectadas)
            {
                if(animal == i)
                {
                    avistado = true;
                } 
                else
                {
                    avistado = false;
                }
            }
            if (avistado == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡La especie fue avistada durante el dia!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if(avistado == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se avisto a la especie todavia...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MonitoreoCostero mon = new MonitoreoCostero();
            mon.CargarAvistamientos();
            mon.MostrarReporteOrdenado();
            mon.MostrarReporteInvertido();
            mon.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
