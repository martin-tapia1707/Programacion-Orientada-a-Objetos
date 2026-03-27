using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Punto 6 - 6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar por pantalla su índice 
         * de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura). */

            float peso, altura, IMC, altura2;
            string valor;

            Console.Write("Insertar Peso: ");
            valor = Console.ReadLine();
            peso = float.Parse(valor);

            Console.Write("Insertar Altura: ");
            valor = Console.ReadLine();
            altura = float.Parse(valor);

            altura2 = altura * altura;
            IMC = peso / altura2;

            Console.Write("Tu indice de masa corporal es de: ");
            Console.WriteLine(IMC);

            Console.ReadKey();

        }
    }
}
