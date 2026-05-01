using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
    componentes por columna (es decir primero ingresar toda la primer
    columna, luego la segunda columna y así sucesivamente)
    Imprimir luego la matriz. 
    */
    internal class Matrices
    {
        private int[,] matriz;
        
        public void Cargar()
        {
            matriz = new int[2, 5];

            for(int f = 0; f < 2; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    Console.Write("Ingresa los componentes de la matriz: ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void Imprimir()
        {
            for(int f = 0; f < 2; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matrices m2 = new Matrices();
            m2.Cargar();
            m2.Imprimir();
        }
    }
}
