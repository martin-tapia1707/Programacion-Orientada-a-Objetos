using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1. Realizar un programa que lea por teclado dos números, 
             * si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo. */

            float numero1, numero2;
            string valor;

            Console.Write("Ingresa el primer numero porfavor: ");
            valor = Console.ReadLine();
            numero1 = float.Parse(valor);

            Console.Write("Ingresa el segundo numero porfavor: ");
            valor = Console.ReadLine();
            numero2 = float.Parse(valor);

            /* Condicional, si el primer numero es mayor, entonces se mostrara la suma y resta de ambos numeros */

            if (numero1 > numero2) {

                float suma, resta;

                suma = (numero1 +  numero2);

                resta = (numero1 - numero2);

                Console.WriteLine("La suma de ambos numeros es de: " + suma);
                Console.WriteLine("La diferencia de ambos numeros es de: " + resta);

            } else {
                float multiplicacion, division;

                multiplicacion = (numero1 * numero2);

                division = (numero1 / numero2);

                Console.WriteLine("El producto de ambos numeros es de: " + multiplicacion);
                Console.WriteLine("La division de ambos numeros es de: " + division);
            }

            Console.ReadKey();

        }
    }
}
