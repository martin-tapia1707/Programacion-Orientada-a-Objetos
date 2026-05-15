using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Gestión de Complejo de Cine
    Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
    asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
    ● Definir una matriz irregular de 4 filas para representar los asientos.
    ● Métodos:
    1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
    intervención del operador).
    2. Crear un método de "Venta de Entradas" que permita cargar la edad del
    espectador en un asiento específico (fila y columna).
    3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
    en cada asiento.
    4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
    5. Informar cuál es el promedio de edad de los espectadores de todo el
    complejo. 
    */
    internal class Cine
    {
        private int[][] salas;

        public void Cargar()
        {
            salas = new int[4][];
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }

        public void Venta()
        {
            for(int f = 0; f < salas.Length; f++)
            {
                for(int c = 0; c < salas[f].Length; c++)
                {
                    Console.Write("Ingrese la edad del espectador de la sala " + (f+1) + " asiento " + (c+1) + ": ");
                    salas[f][c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Mapa()
        {
            Console.WriteLine("MAPA DE OCUPACION");
            for(int f = 0; f < salas.Length; f++)
            {
                Console.WriteLine("SALA N°" + (f+1) );
                for(int c = 0; c < salas[f].Length; c++)
                {
                    Console.Write(salas[f][c] + " - ");
                }
                Console.WriteLine();
            }
        }

        public void Menores()
        {
            int cantidad = 0;
            for(int f = 0; f < salas.Length; f++)
            {

                Console.WriteLine("MENORES DE EDAD EN LA SALA N° " + (f+1) );
                for(int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] < 18)
                    {
                        Console.Write(salas[f][c] + " - ");
                        cantidad++;
                    }      
                }
                Console.WriteLine();
                Console.WriteLine("La sala tiene " + cantidad + " menores de edad");
                cantidad = 0;
            }
        }

        public void Promedio()
        {
            float promedio = 0;

            for(int f = 0; f < salas.Length; f++)
            {
                for(int c = 0; c < salas[f].Length; c++)
                {
                    promedio = promedio + salas[f][c];
                }
            }
            promedio = (promedio / 45);
            Console.WriteLine("El promedio de edad de los espectadores de todo el complejo es de: " + promedio);
        }

        static void Main(string[] args)
        {
            Cine cine2 = new Cine();
            cine2.Cargar();
            cine2.Venta();
            cine2.Mapa();
            cine2.Menores();
            cine2.Promedio();
            Console.ReadKey();
        }
    }
}






