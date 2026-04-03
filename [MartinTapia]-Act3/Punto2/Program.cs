using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Se ingresan tres valores por teclado, si todos son iguales
             * se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.*/

            int num1, num2, num3, resultado1, resultado2;
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

            resultado1 = (num1 + num2);
            resultado2 = (resultado1 * num3);

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine(resultado2);
            }


        }
    }
}
