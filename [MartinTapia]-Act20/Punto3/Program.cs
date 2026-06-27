using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    Actividad 3: Estadísticas de visitas a zonas arqueológicas
    Problema:
    Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    arqueológicas durante 4 semanas.
    Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
    días. Luego:
     Calcular el total de visitas por zona y almacenarlo en un vector.
     Mostrar los datos en forma tabular.
     Agregar estos resultados a una lista llamada zonasVisitadas que contenga
    nombres de zonas y total de visitas.
     Determinar cuál fue la zona más visitada.  
    */
    internal class ZonaArq
    {
        private int[,] visitas = new int[3, 4];
        private int[] totalvisitas = new int[3];
        private string[] nombrezona = new string[3];

        public ZonaArq()
        {
            for (int i = 0; i < nombrezona.Length; i++)
            {
                Console.Write("Primero inserta el nombre de la zona " + (i + 1) + ": ");
                nombrezona[i] = Console.ReadLine();
            }

            for (int f = 0; f < visitas.GetLength(0); f++)
            {
                for (int c = 0; c < visitas.GetLength(1); c++)
                {
                    Console.Write("Carga la cantidad de visitas en la (Semana " + (c + 1) + ") a la (Zona " + nombrezona[f] + "): ");
                    visitas[f, c] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("=== * === * === * === * === * === * === * === * ===");
            }
        }

        public void TotalVisitas()
        {
            int total = 0;
            for (int f = 0; f < visitas.GetLength(0); f++)
            {
                for (int c = 0; c < visitas.GetLength(1); c++)
                {
                    total += visitas[f, c];
                }
                totalvisitas[f] = total;
                total = 0;
            }

            //Console.WriteLine("Prueba, se sumo bien???");
            //for(int i = 0; i < totalvisitas.Length; i++)
            //{
            //    Console.WriteLine(totalvisitas[i]);
            //}
        }

        public void Datos()
        {
            Console.WriteLine("* === * === * > DATOS ZONA ARQUELOGICA < * === * === *");
            Console.Write("Nombre Zonas: [");
            for (int i = 0; i < nombrezona.Length; i++)
            {
                Console.Write(nombrezona[i] + " - ");
            }
            Console.WriteLine("]");

            for (int f = 0; f < visitas.GetLength(0); f++)
            {
                for (int c = 0; c < visitas.GetLength(1); c++)
                {
                    Console.WriteLine("Cantidad de visitas en la (Semana " + (c + 1) + ") a la (Zona: " + (nombrezona[f]) + "): " + visitas[f, c]);
                }
                Console.WriteLine("=== * === * === * === * === * === * === * === * ===");
            }
        }

            List<(string nombre, int visitas)> zonasVisitadas = new List<(string, int)>();

        public void DatosLista()
        {
            for(int i = 0; i < nombrezona.Length; i++)
            {
                zonasVisitadas.Add((nombrezona[i], totalvisitas[i]));
            }

            foreach(var zonas in zonasVisitadas)
            {
                Console.WriteLine("* === * === * === * === *");
                Console.WriteLine("Zona: " + zonas.nombre); 
                Console.WriteLine("Total Visitas: " + zonas.visitas);
            }
        }


        public void ZonaMasVisitada()
        {
            int mayor = zonasVisitadas[0].visitas;
            string nombre;
            foreach(var zonas in zonasVisitadas)
            {
                if (zonas.visitas > mayor)
                {
                    mayor = zonas.visitas;
                }
            }

            // repetidos

            foreach(var zonas in zonasVisitadas)
            {
                if(zonas.visitas == mayor)
                {
                    Console.WriteLine("La zona mas visitada es " + zonas.nombre + " con " + mayor);
                }
            }
        }

        static void Main(string[] args)
        {
            ZonaArq arq2 = new ZonaArq();
            arq2.TotalVisitas();
            arq2.Datos();
            arq2.DatosLista();
            arq2.ZonaMasVisitada();
        }
    }
}
