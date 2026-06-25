using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("==== LIBRO: " + Titulo + " ==== ");
            Console.WriteLine("Autor: " + Autor);
            if(Paginas < 100)
            {
                Console.WriteLine("Duracion: Corto");
            } else
            {
                Console.WriteLine("Duracion: Largo");
            }
        }
    }
}
