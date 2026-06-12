using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
    Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
    herencia: Material, Herramienta y Martillo.
     La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
    Plástico).
     La clase Herramienta (que hereda de Material) debe añadir el atributo
    FuncionPrincipal.
     La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
    Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
    correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
    acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
    (ejemplo: "Constructor de la clase Material ejecutado").
    En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
    parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
    en cadena de los constructores (desde la raíz hasta la clase derivada). 
    */ 
    public class Material
    {
        public Material(string tipomaterial)
        {
            Console.WriteLine("-- Constructor Clase Material --");
            Console.WriteLine("Material: " + tipomaterial);
        }

    }

    public class Herramienta : Material
    {
        public Herramienta(string tipomaterial, string funcionprincipal) : base (tipomaterial)
        {
            Console.WriteLine("-- Constructor Herramienta --");
            Console.WriteLine("Funcion principal: " + funcionprincipal);
        }
    }
        
    public class Martillo : Herramienta
    {
        public Martillo(string tipomaterial, string funcionprincipal, string pesogramos) : base (tipomaterial, funcionprincipal)
        {
            Console.WriteLine("-- Constructor Clase Martillo --");
            Console.WriteLine("Peso Gramos: " + pesogramos);
        }
    
        static void Main(string[] args)
        {
            Martillo martillo1 = new Martillo("Acero", "Martillar", "450 gramos");
            Console.ReadKey();
        }
    }
}
