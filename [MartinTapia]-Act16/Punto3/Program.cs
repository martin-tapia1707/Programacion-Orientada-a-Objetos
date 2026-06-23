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

        public Vehiculo(string Marca, float VelMax)
        {
            marca = Marca;
            velocidadMaxima = VelMax;
        }

        public class Auto : Vehiculo
        {
            int cantidadPuertas;

            public Auto(string Marca, float VelMax, int CantPuertas) : base(Marca, VelMax)
            {
                cantidadPuertas = CantPuertas;
            }

            public void Imprimir()
            {
                Console.WriteLine("-- VEHICULO: AUTO --");
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Velocidad Maxima: " + velocidadMaxima);
                Console.WriteLine("Cantidad de puertas: " + cantidadPuertas);
            }

        }

        public class Moto : Vehiculo
        {
            float cilindrada;

            public Moto(string Marca, float VelMax, float Cilindrada) : base(Marca, VelMax)
            {
                cilindrada = Cilindrada;
            }

            public void Imprimir()
            {
                Console.WriteLine("-- VEHICULO: MOTO --");
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Velocidad Maxima: " + velocidadMaxima);
                Console.WriteLine("Cilindrada: " + cilindrada);
            }

            static void Main(string[] args)
            {
                Auto auto2 = new Auto("Toyota", 210, 4);
                auto2.Imprimir();
                Moto moto2 = new Moto("Honda", 180, 250);
                moto2.Imprimir();
                Console.ReadKey();
            }
        }
    }
}

