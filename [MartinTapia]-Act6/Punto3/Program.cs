using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empleado
    {
        /*
        Confeccionar una clase que represente un empleado.Definir como atributos su
        nombre y su sueldo.Confeccionar los métodos para la carga, otro para imprimir
        sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        (si el sueldo supera a 3000).
        */

        int sueldo;
        string valor, nombre;

        public void Cargar() { 
        
        Console.WriteLine("Ingrese el nombre del empleado: ");
        nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese el sueldo del empleado: ");
        valor = Console.ReadLine();
        sueldo = int.Parse(valor);

        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Empleado:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Salario: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Cargar();
            empleado1.Imprimir();
            empleado1.Impuestos();
            Console.ReadKey();
        }
    }
}
