using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{

    /*
    4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    ordenado de menor a mayor y de mayor a menor. 
    */

    internal class Verificar
    {
        private int[] vector;

        public void Cargar()
        {
            vector = new int[10];
            for (int n = 0; n < 10; n++)
            {
                Console.Write("Inserta los valores del vector: ");
                vector[n] = int.Parse(Console.ReadLine());
            }
        }

        public void MenorMayor()
        {
            int comprobante = 0;
            // Esto para verificar si el vector esta ordenado de menor a mayor
            for (int n = 0; n < 9; n++)
            {
                if (vector[n] < vector[n + 1])
                {
                comprobante++;
                }
            }

            if (comprobante == 9) // si llega a 9 es porque estaba todo en orden
            {
                Console.WriteLine("El vector esta ordenado de menor a mayor");

            } else
            {
                Console.WriteLine("El vector no esta ordenado de menor a mayor");
            }
        }

        public void MayorMenor() { 
            int comprobante = 0;
            for (int n = 0; n < 9; n++)
            {
                if (vector[n] > vector[n + 1])
                {
                    comprobante++;
                }
            }
            if (comprobante == 9) // si llega a 9 es porque estaba todo en orden
            {
                Console.WriteLine("El vector esta ordenado de mayor a menor");
            }
            else
            {
                Console.WriteLine("El vector no esta ordenado de mayor a menor");
            }
        }


        static void Main(string[] args)
        {
            Verificar verificar = new Verificar();
            verificar.Cargar();
            verificar.MenorMayor();
            verificar.MayorMenor();
            Console.ReadKey();
        }
    }
}
