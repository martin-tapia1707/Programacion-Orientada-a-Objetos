using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
/*
    1. El Sistema de Peaje.
    Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
    La clase Vehiculo debe tener los siguientes atributos privados:
    Patente (de tipo string).
    Tipo (puede ser "Auto", "Camion" o "Moto").
    Tarifa (un valor decimal que representa el costo de su pase).
    El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
    La clase CabinaPeaje debe tener como atributos privados:
    El número o identificador de la cabina.
    Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
    Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
    Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
    Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
    Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
    internal class Vehiculo
    {

        private string patente;
        private string tipo;
        private float tarifa;
        
        public Vehiculo()
        {

            Console.Write("Inserte la patente del vehiculo: ");
            patente = Console.ReadLine();
            Console.Write("Inserte el tipo de vehiculo: ");
            tipo = Console.ReadLine();
            Console.Write("Ingrese la tarifa del vehiculo: ");
            tarifa = float.Parse(Console.ReadLine());

        }

        public string DatoPatente()
        {
            return patente;
        }
        public string DatoTipo()
        {
            return tipo;
        }
        public float DatoTarifa()
        {
            return tarifa;
        }

    }

    internal class CabinaPeaje
    {

        private Vehiculo[] vehiculos;
        private int nro_cabina;

        public CabinaPeaje()
        {
            vehiculos = new Vehiculo[3];
            for(int i = 0; i < vehiculos.Length; i++)
            {
                vehiculos[i] = new Vehiculo();
                Console.Write("Inserte el numero de cabina: ");
                nro_cabina = int.Parse(Console.ReadLine());
            }
        }

        public void PatenteTipo()
        {
            for(int i = 0; i < vehiculos.Length; i++)
            {
                Console.WriteLine("VEHICULO N° " + (i + 1) + ": " + " Patente: " + vehiculos[i].DatoPatente() + " Tipo: " + vehiculos[i].DatoTipo() );
            }
        }

        public void TotalRecaudado()
        {
            float total = 0;

            for(int i = 0; i < vehiculos.Length; i++)
            {
                total = (total + vehiculos[i].DatoTarifa() ); 
            }

            Console.WriteLine("El total recaudado (acumulado) por todos los vehiculos es de: " + total);
        }

        public void TarifaMasCara()
        {
            float mayor = vehiculos[0].DatoTarifa();
            string patente = vehiculos[0].DatoPatente();

            for(int i = 0; i < vehiculos.Length; i++)
            {
                if (vehiculos[i].DatoTarifa() > mayor)
                {
                    mayor = vehiculos[i].DatoTarifa();
                    patente = vehiculos[i].DatoPatente();
                }
            }

            Console.WriteLine("El vehiculo que pago la tarifa mas cara fue el " + patente + " con " + mayor);
        }

        static void Main(string[] args)
        {
            CabinaPeaje cp2 = new CabinaPeaje();
            cp2.PatenteTipo();
            cp2.TotalRecaudado();
            cp2.TarifaMasCara();
            Console.ReadKey();
        }
    }
}
