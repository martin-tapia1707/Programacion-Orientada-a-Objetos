using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Punto 5 - Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia
             * se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio). */

            double radio, circunferencia, area;
            string valor;

            Console.Write("Inserta el radio de la circunferencia: ");
            valor = Console.ReadLine();
            radio = double.Parse(valor);

            circunferencia = radio * 2 * 3.1416;
            Console.Write("La circunferencia es de: ");
            Console.WriteLine(circunferencia);

            area = radio * radio * 3.1416;

            Console.Write("El area de la circunferencia es de: ");
            Console.WriteLine(area);

            Console.ReadKey();

        }
    }
}
