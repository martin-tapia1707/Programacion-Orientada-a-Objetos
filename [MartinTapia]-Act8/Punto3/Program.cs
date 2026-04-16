using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
    (el orden lo pueden elegir ustedes). 
    */

    internal class ClaseVector
    {
        private int[] vector;
        private int n;

        public void Cargar()
        {
            Console.Write("De cuantos elementos será el vector? ");
            n = int.Parse(Console.ReadLine());

            vector = new int[n];
            
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese los valores del vector: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for(int i = 0; i < vector.Length - 1; i++)
            {
                for(int j = i + 1; j < vector.Length; j++)
                {
                    if(vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

        }

        public void Imprimir()
        {
            for(int i = 0; i < vector.Length; i ++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        static void Main(string[] args)
        {
            ClaseVector clasevector2 = new ClaseVector();
            clasevector2.Cargar();
            clasevector2.Ordenar();
            clasevector2.Imprimir();
            Console.ReadKey();
        }
    }
}
