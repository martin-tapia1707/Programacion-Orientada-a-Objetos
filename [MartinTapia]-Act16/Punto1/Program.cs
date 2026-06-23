using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Confeccionar una clase Persona que tenga como atributos el nombre y la
    edad (definir las propiedades para poder acceder a dichos atributos). Definir
    un método para imprimirlos. Plantear una segunda clase Empleado que
    herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
    método para imprimir su sueldo. Definir un objeto de la clase Persona y
    llamar a sus métodos y propiedades. También crear un objeto de la clase
    Empleado y llamar a sus métodos y propiedades. 
    */
    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public Persona()
        {
            Console.Write("Inserte el nombre la persona: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de " + nombre + ": ");
            edad = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene una edad de " + Edad);
        }

    }

    public class Empleado : Persona
    {
        protected int sueldo;

        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public Empleado()
        {
            Console.Write("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
        }
        
        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene un sueldo de " + Sueldo);
        }

        static void Main(string[] args)
        {
            Persona persona2 = new Persona();
            persona2.Imprimir();
            Empleado empleado1 = new Empleado();
            empleado1.Imprimir();
            Console.ReadKey();
        }
    }
}


