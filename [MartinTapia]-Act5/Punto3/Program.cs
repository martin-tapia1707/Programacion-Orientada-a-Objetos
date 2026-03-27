using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.
            */

            int valor, positivo, negativo, multiplo15, pares;

            positivo = 0;
            negativo = 0;
            multiplo15 = 0;
            pares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Inserta 10 valores: ");
                valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    negativo++;
                }
                else
                {
                    positivo++;
                }

                if(valor % 15 == 0) // 15 30 45 60 75 90..
                {
                    multiplo15++;
                }

                if (valor % 2 == 0)
                {
                    pares = valor + pares;
                }

            }

            Console.WriteLine("Cantidad de negativos: " + negativo);
            Console.WriteLine("Cantidad de positivos: " + positivo);
            Console.WriteLine("Cantidad de multiplos de 15: " + multiplo15);
            Console.WriteLine("Cantidad acumulada de numeros pares: " + pares);



            Console.ReadKey();

        }
    }
}
