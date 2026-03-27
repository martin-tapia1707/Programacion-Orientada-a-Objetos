using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 2. Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado" */

            float nota1, nota2, nota3, nota4, nota5, nota6, promedio;
            string valor;

            Console.Write("Inserta tu primera nota: ");
            valor = Console.ReadLine();
            nota1 = float.Parse(valor);

            Console.Write("Inserta tu segunda nota: ");
            valor = Console.ReadLine();
            nota2 = float.Parse(valor);

            Console.Write("Inserta tu tercera nota: ");
            valor = Console.ReadLine();
            nota3 = float.Parse(valor);

            Console.Write("Inserta tu cuarta nota: ");
            valor = Console.ReadLine();
            nota4 = float.Parse(valor);

            Console.Write("Inserta tu quinta nota: ");
            valor = Console.ReadLine();
            nota5 = float.Parse(valor);

            Console.Write("Inserta tu sexta nota: ");
            valor = Console.ReadLine();
            nota6 = float.Parse(valor);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

            if (promedio >= 7) {
                Console.WriteLine("Promocionado");
            }
            
            Console.ReadKey();

        }
    }
}
