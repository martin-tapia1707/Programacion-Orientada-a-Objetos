using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
    ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    nuevamente. 
    */
    internal class Ordenacion
    {
        private string[] paises;
        private int[] habitantes;

        public void Cargar()
        {
            paises = new string[5];
            habitantes = new int[5];
            for(int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del país: ");
                paises[i] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de habitantes: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarAlfa()
        {
            for(int i = 0; i < paises.Length - 1;i ++)
            {
                for(int j = i + 1; j < paises.Length; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string aux = paises[i];
                        paises[i] = paises[j];
                        paises[j] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for(int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        public void OrdenarHabitantes()
        {
            for(int i = 0; i < habitantes.Length - 1; i++)
            {
                for(int j = i + 1; j < habitantes.Length; j++)
                {
                    if(habitantes[i] < habitantes[j])
                    {
                        int aux = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = aux;
                    }
                }
            }
        }

        public void ImprimirHab()
        {
            for (int i = 0; i < habitantes.Length; i++)
            {

                Console.WriteLine(habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            Ordenacion orden = new Ordenacion();
            orden.Cargar();
            orden.OrdenarAlfa();
            orden.Imprimir();
            orden.OrdenarHabitantes();
            orden.ImprimirHab();
            Console.ReadKey();
        }
    }
}
