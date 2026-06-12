using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Catálogo de Películas (Encapsulación, Validación y Composición)
    Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    asegurando mediante validaciones lógicas que:
     La duración en minutos sea estrictamente mayor a cero (0).
     La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
    un valor por defecto de 1).
    La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
    películas ordenadas de mayor a menor en base a su duración. Además, el método debe
    informar el título de la película con mejor calificación y cuál es la película más corta del
    catálogo. 
    */
    
    class Pelicula
    {

        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public int DuracionMinutos
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("LA PELICULA ACTUAL DEBE SER MAS LARGA!");

                } 
                else 
                {
                    duracionMinutos = value;
                }           
            }
            get
            {
                return duracionMinutos;
            }
        }

        public int Calificacion
        {
            set
            {
                if(value < 0 || value > 5)
                {
                    calificacion = 1;
                } 
                else
                {
                    calificacion = value;
                }
            }
            get
            {
                return calificacion;
            }
        }

    }

    class Catalogo
    {
        private Pelicula[] pelicula = new Pelicula[3];

        public Catalogo() 
        {
            for(int i = 0; i < pelicula.Length; i++)
            {
                pelicula[i] = new Pelicula();  
            }

            for(int j = 0; j < pelicula.Length; j++)
            {
                Console.Write("Inserte el titulo de la pelicula: ");
                pelicula[j].Titulo = Console.ReadLine();
                Console.Write("Inserte la duracion en minutos de la pelicula: ");
                pelicula[j].DuracionMinutos = int.Parse(Console.ReadLine());
                if (pelicula[j].DuracionMinutos <= 0)
                {
                    break;
                }
                Console.Write("Inserte la calificacion de la pelicula: ");
                pelicula[j].Calificacion = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenamiento()
        {
            // ordenamiento duracion

            int aux = 0;
            string aux2 = "";
            int aux3 = 0;

            for(int i = 0; i < pelicula.Length - 1; i++)
            {
                for(int j = 1; j < pelicula.Length; j++)
                {
                    if (pelicula[i].DuracionMinutos < pelicula[j].DuracionMinutos)
                    {
                        aux = pelicula[i].DuracionMinutos;
                        pelicula[i].DuracionMinutos = pelicula[j].DuracionMinutos;
                        pelicula[j].DuracionMinutos = aux;

                        aux2 = pelicula[i].Titulo;
                        pelicula[i].Titulo = pelicula[j].Titulo;
                        pelicula[j].Titulo = aux2;

                        aux3 = pelicula[i].Calificacion;
                        pelicula[i].Calificacion = pelicula[j].Calificacion;
                        pelicula[j].Calificacion = aux3;
                    }
                }
            }

            Console.WriteLine("<-*- Duracion de Peliculas: Mayor a Menor -*->");
            for(int f = 0; f < pelicula.Length; f++)
            {
                Console.WriteLine("--- Pelicula N°" + (f + 1) + " ---");
                Console.WriteLine("Titulo: " + pelicula[f].Titulo);
                Console.WriteLine("Duracion: " + pelicula[f].DuracionMinutos);
                Console.WriteLine("Calificacion: " + pelicula[f].Calificacion);
            }

            // calificacion

            int mayor = pelicula[0].Calificacion;
            int pos = 0;

            for(int m = 0; m < pelicula.Length; m++)
            {
                if(mayor < pelicula[m].Calificacion)
                {
                    mayor = pelicula[m].Calificacion;
                    pos = m;
                }
            }

            Console.WriteLine("La pelicula con mejor calificacion es: " + pelicula[pos].Titulo + " con una calificacion de " + mayor);

            // mas corta del catalogo

            Console.WriteLine("La pelicula mas corta del catalogo es: " + pelicula[2].Titulo + " con una duracion de " + pelicula[2].DuracionMinutos);
        }

        static void Main(string[] args)
        {
            Catalogo catalogo2 = new Catalogo();
            catalogo2.Ordenamiento();
            Console.ReadKey();
        }
    }
}
