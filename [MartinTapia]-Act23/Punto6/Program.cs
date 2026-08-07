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
            foreach(Libro libro in libros)
            {
                Console.WriteLine("Titulo: " + libro.Titulo);
                Console.WriteLine("Año Publicacion: " + libro.AnioPublicacion);
            }
            for(int i = 0; i < libros.Count; i++)
            {

            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
