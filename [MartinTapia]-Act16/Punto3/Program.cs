using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Crear una clase base Vehículo que contenga atributos marca y
    velocidadMaxima.
    Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
    una debe tener un constructor que reciba los valores de los atributos base
    mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    Auto, cilindrada en Moto).
    Crear un objeto de cada clase y mostrar todos sus datos por consola.
    */
    public class Vehiculo
    {
        protected string marca;
        protected float velocidadMaxima;

        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }

        public float VelocidadMax
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
    }

    public class Auto : Vehiculo
    {
        int cantidadPuertas;

        public int CantidadPuertas
        {
            set
            {
                CantidadPuertas = value;
            }
            get
            {
                return cantidadPuertas;
            }
        }

        public Auto()
        {
            Console.Write("Marca del auto: ");
            Marca = Console.ReadLine();
            Console.Write("Velocidad maxima del auto: ");
            VelocidadMax = float.Parse(Console.ReadLine());
            Console.Write("Cantidad de puertas del auto: ");
            CantidadPuertas = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("-- VEHICULO: AUTO --");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad Maxima: " + VelocidadMax);
            Console.WriteLine("Cantidad de puertas: " + CantidadPuertas);
        }

    }

    public class Moto : Vehiculo
    {
        float cilindrada;

        public float Cilindrada
        {
            set
            {
                cilindrada = value;
            }
            get
            {
                return cilindrada;
            }
        }

        public Moto()
        {
            Console.Write("Marca de la moto: ");
            Marca = Console.ReadLine();
            Console.Write("Velocidad maxima de la moto: ");
            VelocidadMax = float.Parse(Console.ReadLine());
            Console.Write("Cilindrada de la moto: ");
            Cilindrada = float.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("-- VEHICULO: MOTO --");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad Maxima: " + VelocidadMax);
            Console.WriteLine("Cilindrada: " + Cilindrada);
        }

        static void Main(string[] args)
        {
            Auto auto2 = new Auto();
            Moto moto2 = new Moto();
            Console.ReadKey();
        }
    }
}


