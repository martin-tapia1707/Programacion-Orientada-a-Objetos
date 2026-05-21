using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
    constructor, calcular su suma, resta, multiplicación y división, cada una en un
    método, imprimir dichos resultados. 
    */

    internal class Operaciones
    {
        private float num1, num2;

        public Operaciones()
        {
            Console.Write("Ingresa el 1° valor: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el 2° valor: ");
            num2 = float.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            float suma = 0;
            suma = (num1 + num2);
            Console.Write("La suma de los dos valores es: ");
            Console.WriteLine(suma);
        }

        public void Resta()
        {
            float resta = 0;
            resta = (num1 - num2);
            Console.Write("La resta de los dos valores es: ");
            Console.WriteLine(resta);
        }

        public void Multiplicacion()
        {
            float multiplicacion = 0;
            multiplicacion = (num1 * num2);
            Console.Write("La multiplicacion de los dos valores es: ");
            Console.WriteLine(multiplicacion);
        }

        public void Division()
        {
            float division = 0;
            division = (num1 / num2);
            Console.Write("La division de los dos valores es: ");
            Console.WriteLine(division);
        }
 
        static void Main(string[] args)
        {
            Operaciones o2 = new Operaciones();
            o2.Suma();
            o2.Resta();
            o2.Multiplicacion();
            o2.Division();
            Console.ReadKey();
        }
    }
}
