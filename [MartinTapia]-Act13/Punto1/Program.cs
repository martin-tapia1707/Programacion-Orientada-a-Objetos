using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1. Confeccionar una clase que represente un empleado. Definir como atributos su
    nombre y su sueldo. En el constructor cargar los atributos y luego en otro
    método imprimir sus datos y por último uno que imprima un mensaje si debe
    pagar impuestos (si el sueldo supera a 3000)
    */

    internal class Empleado
    {
        private string nombre;
        private int sueldo;

        public Empleado()
        {
            Console.Write("Nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Sueldo del empleado: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.Write("Nombre del empleado: ");
            Console.WriteLine(nombre);

            Console.Write("Sueldo del empleado: ");
            Console.WriteLine(sueldo);
        }

        public void Impuestos() 
        {
            if(sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado e2 = new Empleado();
            e2.Imprimir();
            e2.Impuestos();
            Console.ReadKey();
        }
    }
}
