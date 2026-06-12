using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Fábrica de Computadoras (Herencia y Constructores con base)
    Crear una clase base llamada Computadora que contenga los atributos Marca y
    MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
    Luego, definir dos clases derivadas de la clase base:
     Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
     Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
    Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola. 
    */
    public class Computadora
    {
        public Computadora(string marca, int memoriaram)
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Memoria RAM: " + memoriaram);
        }
    }

    public class Notebook : Computadora
    {
        public Notebook(string marca, int memoriaram, double tamanopantalla) : base(marca, memoriaram)
        {
            Console.WriteLine("Tamaño Pantalla: " + tamanopantalla);
        }
    }

    public class Escritorio : Computadora
    {
        public Escritorio(string marca, int memoriaram, float potenciafuente) : base(marca, memoriaram)
        {
            Console.WriteLine("Potencia Fuente: " + potenciafuente + "W");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=-=-= Notebook =-=-=");
            Notebook notebook2 = new Notebook("Sarmiento", 4, 11.6);
            Console.WriteLine("=-=-= Escritorio =-=-=");
            Escritorio escritorio2 = new Escritorio("Lenovo", 8, 120);

            Console.ReadKey();
        }
    }
}
