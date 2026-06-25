using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        private string nombre;
        private int puntaje;
        
        public void Partida()
        {
            Console.Write("Ingrese el nombre del jugador: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el puntaje que hizo " + nombre + ": ");
            puntaje = int.Parse(Console.ReadLine());

            if(puntaje > PuntajeMaximo)
            {
                PuntajeMaximo = puntaje;
                Console.WriteLine(nombre + " supero el puntaje maximo de " + NombreJuego + " estableciendo un nuevo record con " + puntaje + " puntos ");
            }
        }
        
    }
}
