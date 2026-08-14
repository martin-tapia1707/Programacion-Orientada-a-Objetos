using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    /*
    10-
    Un estacionamiento medido administra el ingreso y la salida de los vehículos que
    utilizan su playa por orden de llegada.
     Crear la clase Ticket que contenga como atributos privados: patente
    (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
    constructor que reciba pat y hs.
     Crear la clase GestionEstacionamiento que administre una lista
    dinámica de tickets (List).
     Métodos en GestionEstacionamiento:
    o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
    agregarlo al final de la lista utilizando .Add().
    o ProcesarSalida(): Si la lista no está vacía, simular la salida del
    primer vehículo de la lista (mostrar sus datos en consola) y
    removerlo de la colección mediante .RemoveAt(0). Si está vacía,
    advertir que no hay vehículos esperando salida.
    o MostrarVehiculosEstacionados(): Listar todos los vehículos
    alojados en la playa y la cantidad total de unidades presentes
    utilizando la propiedad .Count. 
    */
    
    class Ticket
    {
        private string patente;
        private int horasEstadia;
        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public int HorasEstadia
        {
            set { horasEstadia = value; }
            get { return horasEstadia; }
        }
        public Ticket(string pat, int hs)
        {
            this.patente = pat;
            this.horasEstadia = hs;
        }
    }

    class GestionEstacionamiento
    {
        List<Ticket> tickets = new List<Ticket>();
        public void RegistrarIngreso()
        {
            Console.Write("Ingrese la patente del vehículo: ");
            string patente = Console.ReadLine();
            Console.Write("Ingrese las horas de estadía: ");
            int horasEstadia = int.Parse(Console.ReadLine());
            Ticket tick = new Ticket(patente, horasEstadia);
            tickets.Add(tick);
        }

        public void ProcesarSalida()
        {
            for(int i = 0; i <  tickets.Count; i++)
            {
                if(tickets.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Patente: " + tickets[i].Patente + " /// Horas de estadía: " + tickets[i].HorasEstadia);
                    Console.WriteLine("Se retiro y proceso al vehiculo con patente: " + tickets[i].Patente);
                    tickets.RemoveAt(0);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if(tickets.Count <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No hay vehiculos esperando salida");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=========================");
            Console.WriteLine("VEHICULOS ESTACIONADOS");
            Console.WriteLine("=========================");
            foreach (Ticket tick in tickets)
            {
                Console.WriteLine("Patente: " + tick.Patente);
                Console.WriteLine("Horas: " + tick.HorasEstadia);
                Console.WriteLine("---------------------");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cantidad total de vehículos estacionados: " + tickets.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GestionEstacionamiento gestion = new GestionEstacionamiento();
            gestion.RegistrarIngreso();
            gestion.RegistrarIngreso();
            gestion.ProcesarSalida();
            gestion.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
