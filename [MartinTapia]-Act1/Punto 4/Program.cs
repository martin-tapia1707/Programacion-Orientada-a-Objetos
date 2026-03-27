using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Punto 4 - Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. 
                     * Mostrar lo que debe abonar el comprador. */

            int articulo, cantidad, abono;
            string valor;

            Console.Write("Inserta el precio de el articulo: $");
            valor = Console.ReadLine();
            articulo = int.Parse(valor);

            Console.Write("¿Cuanto vas a llevar? ");
            valor = Console.ReadLine();
            cantidad = int.Parse(valor);

            abono = articulo * cantidad;
            Console.Write("Tenes que abonar: $");
            Console.WriteLine(abono);

            Console.ReadKey();


        }
    }
}
