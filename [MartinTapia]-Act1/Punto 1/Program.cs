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

            /* Punto 1 - Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula 
         * multiplicando el valor del lado por cuatro). */

            int parametro, perimetro;
            string linea;

            Console.Write("Ingresa un parametro para determinar el tamaño del lado ");
            linea = Console.ReadLine();
            parametro = int.Parse(linea);

            Console.Write("El valor de cada lado sera de ");
            Console.WriteLine(linea);
            perimetro = parametro * 4;

            Console.Write("Perfecto, el perimetro del cuadrado es de ");
            Console.WriteLine(perimetro);

            Console.ReadKey();

        }
    }
}
