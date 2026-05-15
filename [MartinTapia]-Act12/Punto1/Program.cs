using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Sistema de Logística: Envíos por Sucursal
    Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
    cantidad diferente de paquetes por día dependiendo de su demanda.
    ● Definir un vector de tipo string para los nombres de las 3 sucursales.
    ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
    represente el peso (en kg) de cada paquete enviado.
    ● Métodos:
    1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
    paquetes se enviaron hoy para definir el tamaño de su fila.
    2. Cargar el peso de cada paquete.
    3. Imprimir el peso de todos los paquetes organizados por sucursal.
    4. Calcular e informar el peso total despachado por cada sucursal.
    5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
    pertenece. 
    */
    internal class Logistica
    {
        private string[] nombres;
        private float[][] sucursales;
        private int cantidad = 0;

        public void Cargar()
        {
            nombres = new string[3];
            sucursales = new float[3][];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingresa el nombre de la sucursal: ");
                nombres[f] = Console.ReadLine();
                Console.Write("Cuantos paquetes envio " + nombres[f] + "?: ");
                cantidad = int.Parse(Console.ReadLine());
                sucursales[f] = new float[cantidad];
                for (int c = 0; c < sucursales[f].Length; c++)
                {
                    Console.Write("Determinar el peso del " + (c + 1) + "° paquete: ");
                    sucursales[f][c] = float.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sucursales.Length; f++)
            {
                Console.WriteLine(nombres[f]);
                for (int c = 0; c < sucursales[f].Length; c++)
                {
                    Console.Write(sucursales[f][c] + "kg - ");
                }
                Console.WriteLine();
            }
        }

        public void PesoTotal()
        {
            float total = 0;

            for (int f = 0; f < sucursales.Length; f++)
            {
                for (int c = 0; c < sucursales[f].Length; c++)
                {
                    total = total + sucursales[f][c];
                }

                Console.WriteLine("El peso total de los paquetes que " + nombres[f] + " envio: " + total);

                total = 0;
            }
        }

        public void MasPesado()
        {
            float mayor = sucursales[0][0];
            int sucursalMayor = 0;

            for (int f = 0; f < sucursales.Length; f++)
            {
                for (int c = 0; c < sucursales[f].Length; c++)
                {
                    if (sucursales[f][c] > mayor)
                    {
                        mayor = sucursales[f][c];
                        sucursalMayor = f;
                    }
                }
            }

            Console.WriteLine("El paquete mas pesado pesa: " + mayor + " y es de la sucursal: " + nombres[sucursalMayor]);
        }

        static void Main(string[] args)
        {
            Logistica lg2 = new Logistica();
            lg2.Cargar();
            lg2.Imprimir();
            lg2.PesoTotal();
            lg2.MasPesado();
            Console.ReadKey();
        }
    }
}
