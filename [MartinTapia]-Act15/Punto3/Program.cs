using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Geolocalización de Reservas Naturales
    Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
    especies protegidas en cuadrículas de territorio.
    ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
    NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
    mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
    cantidad de animales avistados en cada sector). El constructor de la clase debe
    cargar por teclado el nombre y rellenar el mapa de avistamientos.
    ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
    objetos de la clase ReservaNatural.
    La clase CentroEcologico debe implementar los siguientes métodos:
    1. Un constructor que solicite la carga secuencial de las 3 reservas.
    2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    registró en toda su superficie (la suma de toda su matriz rectangular).
    3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
    columna]) que registró la mayor concentración de avistamientos de toda la red de
    reservas, indicando a qué reserva pertenece. 
    */
    internal class ReservaNatural
    {

        string NombreReserva;
        int[,] avistamientos = new int[3, 3];

        public ReservaNatural()
        {
            Console.Write("Nombre del animal avistado: ");
            NombreReserva = Console.ReadLine();
            for(int f = 0; f < avistamientos.GetLength(0); f++)
            {
                for(int c = 0; c < avistamientos.GetLength(1); c++)
                {
                    Console.Write("Cantidad de animales avistados por sector: ");
                    avistamientos[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string DatoNombre()
        {
            return NombreReserva;
        }
        public int[,] DatoAvistados()
        {
            return avistamientos;
        }

    }
    internal class CentroEcologico
    {
        private ReservaNatural[] resnatural = new ReservaNatural[3];

        public CentroEcologico()
        {
            for(int i = 0; i < resnatural.Length; i++)
            {
                resnatural[i] = new ReservaNatural();
            }
        }

        public void AvistamientosTotales()
        {
            int total = 0;

            for(int i = 0; i < resnatural.Length; i++)
            {
                int[,] avist = resnatural[i].DatoAvistados();

                for(int f = 0; f < avist.GetLength(0); f++)
                {
                    for(int c = 0; c < avist.GetLength(1); c++)
                    {
                        total += avist[f, c];
                    }    
                }
                Console.WriteLine("Cantidad de avistamientos totales por: " + resnatural[i].DatoNombre() + ": " + total);
                total = 0;
            }
        }

        public void MayorAvistamiento()
        {
            int mayor = 0;
            int pos = 0;

            for(int i = 0; i < resnatural.Length; i++)
            {
                int[,] avist = resnatural[i].DatoAvistados();

                for(int f = 0; f < avist.GetLength(0); f++)
                {
                    for(int c = 0; c < avist.GetLength(1); c++)
                    {
                        if (avist[f, c] > mayor)
                        {
                            mayor = avist[f, c];
                            pos = f;
                        }
                    }
                }
            }

            Console.WriteLine("La mayor red de avistamientos fue de: " + mayor + " perteneciente a la reserva " + resnatural[pos].DatoNombre());


        }

        static void Main(string[] args)
        {
            CentroEcologico ce2 = new CentroEcologico();
            ce2.AvistamientosTotales();
            ce2.MayorAvistamiento();
            Console.ReadKey();
        }
    }
}
