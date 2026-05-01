using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
     * 2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
    */
    internal class Matrices
    {
        private int[,] matriz;
        private int n = 0;
        private int m = 0;

        public void Cargar()
        {
            Console.WriteLine("Dale valor a n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dale valor a m: ");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            for(int f = 0; f < n; f++)
            {
                for(int c = 0; c < m; c++)
                {
                    Console.Write("Ingresa los componentes de la matriz: ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void IntercambiarFilas()
        {
            for(int c = 0; c < m; c++)
            {
                int aux = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            for(int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            Matrices m2 = new Matrices();
            m2.Cargar();
            m2.IntercambiarFilas();
            m2.Imprimir();

        }
    }
}
