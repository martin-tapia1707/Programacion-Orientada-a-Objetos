using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1. Personal de un Gimnasio (Herencia Simple y Propiedades)
    Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
    método para imprimir estos datos básicos.
    Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    para imprimir todos los datos del profesor (incluyendo los heredados).
    En el programa principal (Main):
     Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
    llamar a su método de impresión.
     Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
    que puede acceder tanto a sus métodos propios como a los de la clase base.
    */

    class PersonaGimnasio
    {
        private string nombre;
        private int dni;

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

        public int DNI
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("=-=-=-=-= Objeto PersonaGimnasio =-=-=-=-=");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + DNI);
        }
    }

    class Profesor : PersonaGimnasio
    {
        string especialidad;

        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }

        public void DatosProf()
        {
            Console.WriteLine("=-=-=-=-=-= Objeto: Profesor =-=-=-=-=-=");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Especialidad: " + Especialidad);
        }

        static void Main(string[] args)
        {
            PersonaGimnasio pg2 = new PersonaGimnasio();
            pg2.Nombre = ("Pepe");
            pg2.DNI = 53676789;
            pg2.Imprimir();

            Profesor pf2 = new Profesor();
            pf2.Nombre = ("Fulano");
            pf2.DNI = 48983904;
            pf2.Especialidad = ("Aerobics");
            pf2.DatosProf();

            Console.ReadKey();
        }
    }
}
