using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    Actividad 1: Sistema de control de vuelos
    Problema:
    Una aerolínea administra los vuelos programados mediante un sistema orientado a
    objetos.
    Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    destino y duración en horas. Luego definir una clase derivada VueloInternacional que
    herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    desde consola y luego:
     Mostrar los vuelos registrados y el país de destino.
     Informar cuál es el vuelo con mayor duración.
     Mostrar el orden de ejecución de los constructores.     
    */

    internal class Vuelo
    {
        protected int numerovuelo;
        protected string destino;
        protected int duracion;

        public Vuelo(int numvuelo, string dest, int durac)
        {
            numerovuelo = numvuelo;
            destino = dest;
            duracion = durac;
            Console.WriteLine("Constructor Vuelo");
        }

        public int NumeroVuelo
        {
            set { numerovuelo = value; }
            get { return numerovuelo; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
    }

    internal class VueloInternacional : Vuelo
    {
        protected string paisdestino;

        public VueloInternacional(int numvuelo, string dest, int durac, string paisdest) : base(numvuelo, dest, durac)
        {
            paisdestino = paisdest;
            Console.WriteLine("Constructor VueloInternacional");
        }

        public string PaisDestino
        {
            set { paisdestino = value; }
            get { return paisdestino; }
        }

        static void Main(string[] args)
        {

            List<VueloInternacional> vuelos = new List<VueloInternacional>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese su numero de vuelo: ");
                int numvuelo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el destino: ");
                string dest = Console.ReadLine();
                Console.Write("Ingrese la duracion (En horas): ");
                int durac = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el pais: ");
                string paisdest = Console.ReadLine();

                VueloInternacional newVuelo = new VueloInternacional(numvuelo, dest, durac, paisdest);
                vuelos.Add(newVuelo);

                Console.WriteLine("Vuelo registrado exitosamente");
            }

            Console.WriteLine("============ LISTA DE VUELOS ============");

            foreach (VueloInternacional v in vuelos)
            {
                Console.WriteLine("< * = * - Vuelo N°" + v.NumeroVuelo + " - * = * >");
                Console.WriteLine("Destino: " + v.Destino);
                Console.WriteLine("Pais: " + v.PaisDestino);
                Console.WriteLine("Duracion: " + v.Duracion);
            }

            Console.WriteLine("==================");

            int mayor = 0;
            int nvuelo = 0;

            foreach (VueloInternacional v in vuelos)
            {
                if (v.Duracion > mayor)
                {
                    mayor = v.Duracion;
                    nvuelo = v.NumeroVuelo;
                }
            }

            Console.WriteLine("El numero con la mayor duracion es el N°" + nvuelo + " con una duracion de " + mayor);

            Console.ReadKey();
        }
    }
}

