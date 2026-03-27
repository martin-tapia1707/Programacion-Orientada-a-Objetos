using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            39.
            */

            int num, i;
            string valor;

            Console.Write("Pone un numero: ");
            valor = Console.ReadLine();
            num = int.Parse(valor);

            for (i = 1; i < 14; i++)
            {
                num = num * i;
                Console.WriteLine("Valor actual del numero: " + i);
            }
            Console.ReadKey();
        }
    }
}
