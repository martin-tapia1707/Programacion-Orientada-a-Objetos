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

            /* 3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número 
            tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero) */

            int numero, digitos;
            string valor;

            Console.Write("Inserte un numero porfavor: ");
            valor = Console.ReadLine();
            numero = int.Parse(valor);

            if (numero > 9)
            {
                Console.WriteLine("El numero insertado es de dos digitos");
            } else {
                Console.WriteLine("El numero insertado es de un solo digito");
            }

            Console.ReadKey();

        }
    }
}
