using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    El valor acumulado de todos los elementos del vector.
    El valor acumulado de los elementos del vector que sean mayores a 36.
    Cantidad de valores mayores a 50. 
    */

    internal class ValorVectores
    {

        private int[] valor;

        public void CargarValores()
        {
            valor = new int[8];
            for (int n = 0; n < 8; n++)
            {
                Console.Write("Inserte los valores: ");
                valor[n] = int.Parse(Console.ReadLine());
            }
        }

        public void ValorAcumulado()
        {
            int suma, mayor50, mayor36;
            suma = 0;
            mayor36 = 0;
            mayor50 = 0;

            for (int n = 0; n < 8; n++)
            {
                if (valor[n] >= 36)
                {
                    mayor36 = mayor36 + valor[n]; // sumo mayores 36
                    suma = suma + valor[n]; // aunque sea mayor a 36 sumo para el total
                }
                else
                {
                    suma = suma + valor[n]; // sumo valores normales para el total
                }

                if (valor[n] > 50)
                {
                    mayor50++;
                }

            }
            Console.WriteLine("El valor acumulado de todos los elementos del vector es: " + suma);
            Console.WriteLine("El valor acumulado de los valores mayores a 36 es: " + mayor36);
            Console.WriteLine("La cantidad de valores mayores a 50 es: " + mayor50);
        }

        static void Main(string[] args)
        {

            ValorVectores vv2 = new ValorVectores();
            vv2.CargarValores();
            vv2.ValorAcumulado();

            Console.ReadKey();
        }
    }
}
