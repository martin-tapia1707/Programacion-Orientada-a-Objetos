using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
    realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
    vectores paralelos, ordenar los datos de mayor a menor según las ventas,
    imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
    el que menos vendió de los 5 empleados. 
    */
    internal class VendedoresLista
    {
        private string[] vendedores;
        private int[] totalventas;


        public void Cargar()
        {
            vendedores = new string[5];
            totalventas = new int[5];
            for (int i = 0; i < vendedores.Length; i++)
            {
                Console.Write("Ingrese el nombre del vendedor: ");
                vendedores[i] = Console.ReadLine();
                Console.Write("Ingrese el total de ventas del vendedor: ");
                totalventas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < totalventas.Length - 1; i++)
            {
                for (int j = i + 1; j < totalventas.Length; j++)
                {
                    if (totalventas[i] < totalventas[j])
                    {
                        int aux = totalventas[i];
                        totalventas[i] = totalventas[j];
                        totalventas[j] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                Console.WriteLine(vendedores[i] + ": " + totalventas[i] + " ventas");
            }

            Console.WriteLine("El vendedor que menos vendió fue: " + vendedores[4] + " con un total de ventas de: " + totalventas[4]);

        }



        static void Main(string[] args)
        {
            VendedoresLista vendedores2 = new VendedoresLista();

            vendedores2.Cargar();
            vendedores2.Ordenar();
            vendedores2.Imprimir();
            Console.ReadKey();
        }
    }
}
