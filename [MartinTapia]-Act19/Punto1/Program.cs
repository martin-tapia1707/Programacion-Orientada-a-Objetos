using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Plantear una clase parcial ReservaHotel.
    En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
    TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
    noches sea mayor a 0. Estos valores son cargados desde la consola.
    En el segundo archivo, agregar un método que calcule el total a pagar según la
    habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
    noche).
    Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más. 
    */  

    internal class Carga
    {
        ReservaHotel[] reservas = new ReservaHotel[3];

        public Carga()
        {
            for(int i = 0; i <  reservas.Length; i++) 
            {
                reservas[i] = new ReservaHotel();
            }
        }

        public void PagoClientes()
        {
            for(int i = 0; i < reservas.Length; i++)
            {
                Console.WriteLine("El cliente " + reservas[i].NombreCliente + " pagara " + reservas[i].TotalCliente());
            }
        }

        public void MayorPago()
        {
            int mayor = reservas[0].TotalCliente();
            int pos = 0;

            for(int i = 0; i < reservas.Length; i++)
            {
                if (reservas[i].TotalCliente() > mayor)
                {
                    mayor = reservas[i].TotalCliente();
                    pos = i;
                }
            }

            Console.WriteLine("El cliente que paga mas es " + reservas[pos].NombreCliente + " con un valor de " + mayor);
        }

        static void Main(string[] args)
        {
            Carga carga67 = new Carga();
            carga67.PagoClientes();
            carga67.MayorPago();
            Console.ReadKey();
        }
    }
}
