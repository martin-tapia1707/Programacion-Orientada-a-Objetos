using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Armar tres clases: Animal, Mamífero y Perro.
    La clase Animal debe tener un atributo especie.
    La clase Mamífero, que hereda de Animal, debe tener un atributo
    tipoAlimentacion.
    La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    Cada clase debe tener un constructor que reciba los datos correspondientes
    y los imprima indicando a qué clase pertenecen. Los datos deben ser
    asignados previamente
    Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
    constructores. 
    */
    public class Animal
    {
        public Animal(string especie)
        {
            Console.WriteLine("Especie: " + especie + " (Clase Animal)");
        }

    }

    public class Mamifero : Animal
    {
        public Mamifero(string especie, string tipoAlimentacion) : base(especie)
        {
            Console.WriteLine("Tipo Alimentacion: " + tipoAlimentacion + " (Clase Mamifero)");
        }

    }

    public class Perro : Mamifero
    {

        public Perro(string especie, string tipoAlimentacion, string nombre) : base(especie, tipoAlimentacion)
        {
            Console.WriteLine("Nombre: " + nombre + " (Clase Perro)");
        }

        static void Main(string[] args)
        {
            Perro perro1 = new Perro("Canis lupus", "Alimento balanceado", "Titan");
            Console.ReadKey();
        }
    }
}