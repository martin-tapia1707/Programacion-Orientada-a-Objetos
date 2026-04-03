using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1. Realizar un programa que pida cargar una
             * fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad. */

            int dia, mes;
            string valor;

            Console.WriteLine("Inserta un dia del 1 al 31");
            valor = Console.ReadLine();
            dia = int.Parse(valor);

            Console.WriteLine("Ahora inserta un mes del 1 al 12: ");
            valor = Console.ReadLine();
            mes = int.Parse(valor);

            Console.WriteLine("La fecha insertada es: " + dia + "/" + mes);

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("Es navidad");
            }

        }
    }
}
