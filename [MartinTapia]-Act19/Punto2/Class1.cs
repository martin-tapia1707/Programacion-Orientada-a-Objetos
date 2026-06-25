using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        private string titulo;

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

        private string autor;

        public string Autor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }

        private int paginas;

        public int Paginas
        {
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Minimo 10 paginas");
                } else
                {
                    paginas = value;
                }
            }
            get
            {
                return paginas;
            }
        }

        public Libro()
        {
            Console.Write("Ingresa el titulo: ");
            Titulo = Console.ReadLine();
            Console.Write("Ingresa el autor: ");
            Autor = Console.ReadLine();
            Console.Write("Ingresa la cantidad de paginas: ");
            Paginas = int.Parse(Console.ReadLine());
        }
    }
}
