using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
     Implementar propiedades y un constructor que cargue valores.
     Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    nombre en pantalla y Console.CursorVisible para ocultar el cursor.
     Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    consola. 
    */
    internal class ElementoPantalla
    {
        string nombre;
        int posX;
        int posY;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int PosX
        {
            set { posX = value; }
            get { return posX; }
        }

        public int PosY
        {
            set { posY = value; }
            get { return posY; }
        }

        public ElementoPantalla(string nombre, int x, int y)
        {
            this.Nombre = nombre;
            this.PosX = x;
            this.PosY = y;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(PosX, PosY);
            Console.WriteLine(Nombre);
        }

        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];

            for(int i = 0; i < elementos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("============================");
                Console.Write("Inserta el nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Inserta la coordenada X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Inserta la coordenada Y: ");
                int y = int.Parse(Console.ReadLine());

                elementos[i] = new ElementoPantalla(nombre, x, y);
            }

            Console.Clear();
            Console.CursorVisible = false;
            
            for(int j = 0; j < elementos.Length; j++)
            {
                elementos[j].Mostrar();
            }

            Console.ReadKey();
        }
    }
}
