using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        private string nombrejuego;

        public string NombreJuego
        {
            set
            {
                nombrejuego = value;
            }
            get
            {
                return nombrejuego;
            }
        }

        private int puntajemaximo;

        public int PuntajeMaximo
        {
            set
            {
                puntajemaximo = value;
            }
            get
            {
                return puntajemaximo;
            }
        }

        private int niveldificultad;

        public int NivelDificultad
        {
            set
            {
                if(value > 0 && value < 6)
                {
                    niveldificultad = value;
                } else
                {
                    Console.WriteLine("Ingresar una dificultad entre 1 y 5");
                }
            }
            get
            {
                return niveldificultad;
            }
        }

        public JuegoArcade()
        {
            Console.Write("Ingresar nombre del juego: ");
            NombreJuego = Console.ReadLine();
            Console.Write("Ingresar puntaje maximo de " + NombreJuego + ": ");
            PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write("Ingresar dificultad(1-5): ");
            NivelDificultad = int.Parse(Console.ReadLine());
        }
    }
}
