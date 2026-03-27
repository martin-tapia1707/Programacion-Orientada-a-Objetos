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

            /* 
             1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
             $500, realizar un programa que lea los sueldos que cobra cada empleado e
             informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
             de $300. Además el programa deberá informar el importe que gasta la empresa
             en sueldos al personal. 
             */


            int n, x, sueldo, cantidad, cantidad2, total;
            string valor;

            x = 0;
            cantidad = 0;
            cantidad2 = 0;
            total = 0;

            Console.Write("Cuantos empleados trabajan en la empresa?: ");
            valor = Console.ReadLine();
            n = int.Parse(valor); // Guardo empleados que trabajan


            do
            {

                Console.WriteLine("Inserta el sueldo del empleado: "); // inserto sueldo
                valor = Console.ReadLine();
                sueldo = int.Parse(valor);

                total = total + sueldo;

                x++;

                if (sueldo >= 100 && sueldo <= 300) // sube la cantidad si el empleado cobra 100-300
                {
                    cantidad++;
                }
                else // si el sueldo es mayor a 300 sube cantidad2 
                {
                    cantidad2++;
                }

                if (sueldo < 100 || sueldo > 500)
                {
                    Console.WriteLine("Sueldo no valido, inserta un sueldo de 100-500");
                    return;
                }


            } while (x < n);

            Console.WriteLine("Los empleados que cobran entre 100 y 300 son: " + cantidad); // registro resultados
            Console.WriteLine("Los empleados que cobran mas de 300 son: " + cantidad2);
            Console.WriteLine("El total gastado en la empresa es: " + total);


            Console.ReadKey();
        


    }
}
}
