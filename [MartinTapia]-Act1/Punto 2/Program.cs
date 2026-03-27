using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Punto 2 - Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del
         * tercero y el cuarto. */

            int num1, num2, num3, num4, suma, producto;
            string valor;

            Console.Write("Inserte el valor del 1° Numero: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);

            Console.Write("Inserte el valor del 2° Numero: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);

            suma = (num1 + num2);

            Console.Write("Inserte el valor del 3° Numero: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);

            Console.Write("Inserte el valor del 4° Numero: ");
            valor = Console.ReadLine();
            num4 = int.Parse(valor);

            producto = (num3 * num4);


            Console.WriteLine("Resultado de ambas cuentas: ");
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Producto: " + producto);

            Console.ReadKey();

        }
    }
}
