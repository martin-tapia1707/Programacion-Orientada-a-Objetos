using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
    del vector. 
    */
    internal class VectorNMenor
    {
        private int [] vector;
        private int n;

        public void Cargar()
        {
            Console.Write("De cuantos elementos sera el vector?? ");
            n = int.Parse(Console.ReadLine());

            vector = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Inserta los valores del vector: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Menor()
        {
            int menor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine("El menor valor del vector es: " + menor);
        }

        public void Imprimir()
        {
            for (int i = 0; i < vector.Length; i++) // dos vueltas para comparar dos valores del vector
            {
                for (int k = i+1; k < vector.Length; k++)
                {
                    if (vector[i] == vector[k])
                    {
                        Console.WriteLine("El valor " + vector[i] + " se repite en el vector.");
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            VectorNMenor vector2 = new VectorNMenor();
            vector2.Cargar();
            vector2.Menor();
            vector2.Imprimir();
            Console.ReadKey();
        }
    }
}
