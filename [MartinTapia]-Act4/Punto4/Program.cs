using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num_cuenta, saldo, total_acreedor;

            total_acreedor = 0;
            saldo = 0;

                do {

                            Console.Write("Inserte el numero de cuenta: ");
                            num_cuenta = int.Parse(Console.ReadLine());
                            Console.WriteLine("El numero de cuenta es: " + num_cuenta);

                if (num_cuenta > 0)
                {
                    Console.WriteLine("Inserta un saldo para la cuenta: ");
                    saldo = int.Parse(Console.ReadLine());

                    if (saldo > 0)
                    {
                        Console.WriteLine("Estado de la cuenta: Acreedor");
                        total_acreedor = total_acreedor + saldo;
                    }

                    if (saldo < 0)
                    {
                        Console.WriteLine("Estado de la cuenta: Deudor");
                    }

                    if (saldo == 0)
                    {
                        Console.WriteLine("Estado de la cuenta: Nulo");
                    }
                }

                    } while (num_cuenta > 0);

                    Console.WriteLine("La suma total de los salarios acreedores es: " + total_acreedor);

            Console.ReadKey();


        }
    }
}
