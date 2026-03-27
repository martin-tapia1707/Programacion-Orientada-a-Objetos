using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Punto 3 - Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio. */

            int num1, num2, num3, num4, suma, promedio;
            string valor;

            Console.Write("Insertar valor primer numero: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);

            Console.Write("Insertar valor segundo numero: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);

            Console.Write("Insertar valor tercer numero: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);

            Console.Write("Insertar valor cuarto numero: ");
            valor = Console.ReadLine();
            num4 = int.Parse(valor);

            suma = num1 + num2 + num3 + num4;
            Console.Write("La suma de los 4 numeros es: ");
            Console.WriteLine(suma);

            promedio = suma / 4;
            Console.Write("Ahora vamos con el promedio: ");
            Console.WriteLine(promedio);

            Console.ReadKey();

        }
    }
}
