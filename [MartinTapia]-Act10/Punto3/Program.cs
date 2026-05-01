using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
    cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
    etc.) 
    */

    internal class Matrices
    {
        private int[,] matriz;
        private int n = 0;
        private int m = 0;

        public void Cargar()
        {
            Console.Write("Dale un valor a n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Dale un valor a m: ");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            for(int f = 0; f < n; f++)
            {
                for(int c = 0; c < m; c ++)
                {
                    Console.Write("Ingresa los componentes de la matriz: ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
        Console.WriteLine(matriz[0, 0] + " - " + matriz[0, m-1]);
        Console.WriteLine(matriz[n-1, 0] + " - " + matriz[n-1, m-1]);
        }

        static void Main(string[] args)
        {
            Matrices m2 = new Matrices();
            m2.Cargar();
            m2.Imprimir();
        }
    }
}
