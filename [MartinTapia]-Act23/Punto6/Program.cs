using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    /*
    6-
    Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    para organizar la consulta de ejemplares por parte de los lectores.
     Crear la clase Libro que contenga como atributos privados: titulo
    (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
    un constructor que reciba tit y anio.
     Crear la clase BibliotecaCentral que administre una lista de objetos
    List.
     Métodos en BibliotecaCentral:
    1. CargarCatalogo(): Solicitar por teclado títulos y años de
    publicación para agregar libros a la lista mediante .Add(). La carga
    finaliza cuando el usuario ingresa la palabra "FIN" como título.
    2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    junto a la cantidad total de obras registradas mediante la propiedad
    .Count.
    3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
    imprimir en consola únicamente aquellos libros cuyo año de
    publicación sea menor a dicho valor.
    4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    los métodos de búsqueda y remoción de listas, eliminarlo de la
    colección si se encuentra presente. 
    */
    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo;  }
        }

        public int AnioPublicacion
        {
            set { anioPublicacion = value; }
            get { return  anioPublicacion; }
        }

        public Libro(string tit, int anio)
        {
            this.titulo = tit;
            this.anioPublicacion = anio;
        }

    }

    class BibliotecaCentral
    {
        List<Libro> libros = new List<Libro>();

        public void CargarCatalogo()
        {
            string tit;
            do
            {
                Console.Write("Titulo del libro: ");
                tit = Console.ReadLine();
                Console.Write("Anio de publicacion: ");
                int anio = int.Parse(Console.ReadLine()); 

                Libro lib = new Libro(tit, anio);

                if (tit != "FIN") 
                {
                    libros.Add(lib);
                }

            } while (tit != "FIN");
        }

        public void ListarCatalogo()
        {
            int cantObras = 0;
            foreach(Libro libro in libros)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=============================");
                Console.WriteLine("Titulo: " + libro.Titulo);
                Console.WriteLine("Año Publicacion: " + libro.AnioPublicacion);
                Console.ForegroundColor = ConsoleColor.White;
            }
            for(int i = 0; i < libros.Count; i++)
            {
                cantObras++;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cantidad total de Obras registradas: " + cantObras);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void FiltrarPorAnio()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Ingresa un año: ");
            int anioSolicitado = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("========== LIBROS CON ANIOS MENORES A " + anioSolicitado);
            foreach (Libro libro in libros)
            {
                if(libro.AnioPublicacion < anioSolicitado)
                {
                    Console.WriteLine(libro.Titulo + " /// " + libro.AnioPublicacion);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void RemoverLibro()
        {
            Console.Write("Inserte el titulo de un libro para que sea eliminado: ");
            string eliminar = Console.ReadLine();

            for(int i = 0; i < libros.Count; i++)
            {
                if (libros[i].Titulo == eliminar)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(libros[i].Titulo + " fue eliminado con exito del catalogo");
                    libros.Remove(libros[i]);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================================");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (Libro libro in libros)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Titulo: " + libro.Titulo);
                Console.WriteLine("Año Publicacion: " + libro.AnioPublicacion);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BibliotecaCentral biblio2 = new BibliotecaCentral();
            biblio2.CargarCatalogo();
            biblio2.ListarCatalogo();
            biblio2.FiltrarPorAnio();
            biblio2.RemoverLibro();
            Console.ReadKey();
        }
    }
}
