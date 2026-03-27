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

            /* 4. Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
            Datos a tener en cuenta para la entrega: */

            int num1, num2, num3;

            Console.Write("Inserta el primer numero porfavor: ");
            num1 = int.Parse( Console.ReadLine() );

            Console.Write("Inserta el segundo numero porfavor: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Inserta el tercer numero porfavor: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3 && num2 != num1)
            {

                if(num1 > num2 && num1 > num3) { Console.WriteLine("El numero mayor indicado es: " + num1); }

                if (num2 > num1 && num2 > num3) { Console.WriteLine("El numero mayor indicado es: " + num2); }

                if (num3 > num1 && num3 > num2) { Console.WriteLine("El numero mayor indicado es: " + num3); }
            }

            Console.ReadKey();

        }
    }
}
