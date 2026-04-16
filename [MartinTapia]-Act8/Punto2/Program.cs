using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
    2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
    algoritmo de ordenamiento alfabético.
    */
    internal class OrdenAlfabetico
    {
        private string[] paises;

        public void Almacenar()
        {
            paises = new string[5];
            for(int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del país: ");
                paises[i] = Console.ReadLine();
            }
        }

        public void Ordenar()
        {
            for(int i = 0; i < paises.Length - 1; i++)
            {
                for (int j = i + 1; j < paises.Length; j++)
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

        static void Main(string[] args)
        {
            OrdenAlfabetico orden = new OrdenAlfabetico();
            orden.Almacenar();
            orden.Ordenar();
            orden.Imprimir();
            Console.ReadKey();
        }
    }
}
