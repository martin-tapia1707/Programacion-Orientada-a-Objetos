using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*
    5-
    Un taller mecánico automatizado administra la recepción y egreso de automóviles
    que se encuentran en el sector de reparaciones.
     Crear la clase Vehiculo que contenga como atributos privados: patente
    (string) y costoReparacion (double). Definir sus propiedades
    correspondientes y un constructor que reciba pat y costo.
     Crear la clase GestionTaller que administre una lista de objetos List.
     Métodos en GestionTaller:
    o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
    reparación de un vehículo para agregarlo a la lista mediante .Add().
    o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
    recorriendo la lista, informar si el vehículo está en el taller y mostrar
    su costo asociado.
    o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
    vehículo en la lista y, si existe, removerlo de la colección mediante
    .Remove() confirmando la entrega del automóvil.

    o CalcularRecaudacionPendiente(): Listar los vehículos
    actualmente en reparación, la cantidad total de unidades alojadas en
    el taller mediante la propiedad .Count y la suma total acumulada por
    cobrar. 
    */

    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }

        public double CostoReparacion
        {
            set { costoReparacion = value; }
            get { return costoReparacion; }
        }
        
        public Vehiculo(string pat, double costo)
        {
            this.patente = pat;
            this.costoReparacion = costo;
        }

    }

    class GestionTaller
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            Console.Write("Ingresar patente de vehiculo: ");
            string pat = Console.ReadLine();
            Console.Write("Ingresar costo de reparacion: $");
            double costo = double.Parse(Console.ReadLine());

            Vehiculo nuevo = new Vehiculo(pat, costo);
            vehiculos.Add(nuevo);
        }

        public void BuscarVehiculo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Buscar dispositivo(Ingresar patente): ");
            Console.ForegroundColor = ConsoleColor.White;
            string pat = Console.ReadLine();
            bool esta = false;

            foreach(Vehiculo patente in vehiculos)
            {
                if(pat == patente.Patente)
                {
                    esta = true;
                }

                if(esta == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("El dispositivo si esta en el taller");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Su costo asociado es de: $" + patente.CostoReparacion);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if(esta == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El dispositivo no se encuentra en este taller");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void EntregarVehiculo()
        {
            Console.Write("Insertar patente de vehiculo a entregar: ");
            string pat = Console.ReadLine();

            for(int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Patente == pat)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Se ha retirado al vehiculo " + vehiculos[i].Patente + " del taller");
                    Console.ForegroundColor = ConsoleColor.White;
                    vehiculos.Remove(vehiculos[i]);
                }
            }
        }

        public void CalcularRecaudacionPendiente()
        {
            int cantidadTotal = 0;
            double sumaTotal = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("Lista de dispositivos en reparacion");
            Console.WriteLine("====================================");
            foreach(Vehiculo taller in vehiculos)
            {
                Console.WriteLine("- Patente: " + taller.Patente);
            }
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < vehiculos.Count; i++)
            {
                cantidadTotal++;
                sumaTotal = sumaTotal + vehiculos[i].CostoReparacion;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hay un total de " + cantidadTotal + " unidades en reparacion");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La suma total por cobrar es de $" + sumaTotal);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GestionTaller gestion = new GestionTaller();
            gestion.IngresarVehiculo();
            gestion.IngresarVehiculo();
            gestion.IngresarVehiculo();
            gestion.BuscarVehiculo();
            gestion.EntregarVehiculo();
            gestion.CalcularRecaudacionPendiente();
        }
    }
}
