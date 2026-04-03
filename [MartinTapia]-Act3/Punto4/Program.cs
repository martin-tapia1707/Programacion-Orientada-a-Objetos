using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            4. Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10, 
               imprimir en pantalla la leyenda "Alguno de los números es menor a diez".*/

            int num1, num2, num3;
            string valor;

            Console.Write("Ingresa el primer valor: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);

            Console.Write("Ingresa el segundo valor: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);

            Console.Write("Ingresa el tercer valor: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno de los numeros son menores a diez");
            }


        }
    }
}
