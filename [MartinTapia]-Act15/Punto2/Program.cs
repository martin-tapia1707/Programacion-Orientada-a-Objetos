using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
       2. Logística de Puerto Espacial
    Una estación de acoplamiento registra el peso de los contenedores transportados en las
    bodegas de carga de las naves espaciales que llegan al puerto.
    ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    NombreNave y su constructor para cargarlo.
    ● Crear la clase colaboradora PuertoControl que contenga:
    ○ Un vector de 3 objetos de la clase NaveEspacial.
    ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    cada fila representa a una nave, el tamaño de la fila es la cantidad de
    bodegas que posee esa nave, y los valores almacenados son los pesos (en
    toneladas) de los contenedores que transporta cada bodega.

    En PuertoControl, definir los siguientes métodos:

    1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    irregular) y cargue el peso del contenedor asignado a cada bodega.
    2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    espacial.
    3. Un método que identifique e informe qué nave transporta el contenedor individual
    más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    irregular).
    4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    total (la suma de todos sus contenedores).
    */
    internal class NaveEspacial
    {
        private string nombrenave;

        public NaveEspacial() 
        {
            Console.Write("Ingresa el nombre de la nave: ");
            nombrenave = Console.ReadLine();
        }

        public string DatoNombre()
        {
            return nombrenave;
        }

    }

    internal class PuertoControl
    {
        private NaveEspacial[] nave = new NaveEspacial[3];
        private double[][] pesoContenedores = new double[3][];

        public PuertoControl()
        {
            for(int i = 0; i < nave.Length; i ++)
            {
                nave[i] = new NaveEspacial();
            }

            int bodegas = 0;
             
            for(int j = 0; j < nave.Length; j++)
            {
                Console.Write("Cuantas bodegas activas posee " + nave[j].DatoNombre() + ": ");
                bodegas = int.Parse(Console.ReadLine());
                pesoContenedores[j] = new double[bodegas];
            }

            for(int f = 0; f < pesoContenedores.Length; f++)
            {
                Console.WriteLine(nave[f].DatoNombre());
                for(int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.Write("Carga el peso del contenedor asignado: ");
                    pesoContenedores[f][c] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void PesosPorNave()
        {
            for(int f = 0; f < pesoContenedores.Length; f++)
            {
                Console.WriteLine("Pesos de la nave: " + nave[f].DatoNombre());
                for(int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.Write(pesoContenedores[f][c] + " - ");
                }
                Console.WriteLine();
            }
        }

        public void ContenedorPesado()
        {
            double mayor = pesoContenedores[0][0];
            int pos = 0;

            for(int f = 0; f < pesoContenedores.Length; f++)
            {
                for(int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    if(mayor < pesoContenedores[f][c])
                    {
                        mayor = pesoContenedores[f][c];
                        pos = f;
                    }
                }
            }

            Console.WriteLine("El contenedor individual mas pesado es de: " + mayor + " y pertenece a la nave: " + nave[pos].DatoNombre());
        }

        public void MenorPesoAcumulado()
        {
            double menor = 0;
            for (int c = 0; c < pesoContenedores[0].Length; c++) // recorri total primera nave y de ahi comparo
            {
                menor += pesoContenedores[0][c];
            } 
            double total = 0;
            int pos = 0;

            for(int f = 0; f < pesoContenedores.Length; f++)
            {
                for(int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    total = total + pesoContenedores[f][c];
                }

                if(total < menor)
                {
                    menor = total;
                    pos = f;
                }

                total = 0;
            }

            Console.WriteLine("La nave que transporta menor peso acumulado es: " + nave[pos].DatoNombre() + " con " + menor + "T "); 
        }

        static void Main(string[] args)
        {
            PuertoControl pt2 = new PuertoControl();
            pt2.PesosPorNave();
            pt2.ContenedorPesado();
            pt2.MenorPesoAcumulado();
            Console.ReadKey();
        }
    }
}
