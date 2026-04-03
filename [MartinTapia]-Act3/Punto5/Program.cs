using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
            * es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla 
            * en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). */


            int x, y;
            string valor;

            Console.Write("Ingresa el valor de X: ");
            valor = Console.ReadLine();
            x = int.Parse(valor);

            Console.Write("Ingresa el valor de Y: ");
            valor = Console.ReadLine();
            y = int.Parse(valor);

            if (x == 0 || y == 0)
            {
                Console.Write("X e Y tienen que ser distintos de 0");
                return;
            }

            if (x > 0 && y > 0)
            {
                Console.Write("El punto se encuentra en el 1er Cuadrante");
            }
            if (x < 0 && y > 0)
            {
                Console.Write("El punto se encuentra en el 2do Cuadrante");
            }

            if (x < 0 && y < 0)
            {
                Console.Write("El punto se encuentra en el 3er Cuadrante");
            }

            if (x > 0 && y < 0)
            {
                Console.Write("El punto se encuentra en el 4to Cuadrante");
            }



        }
    }
}
