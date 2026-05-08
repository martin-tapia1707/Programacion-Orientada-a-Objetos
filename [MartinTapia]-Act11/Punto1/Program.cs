using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
    1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
    dato las temperaturas medias mensuales de dichos paises.
    Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    mensuales.
    Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    memoria.
    a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
    mismas.
    c. Calcular la temperatura media trimestral de cada país.
    d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    e. Imprimir el nombre del país con la temperatura media trimestral mayor. 
    */

    internal class MediaTrimestral
    {

        private string[] paises;
        private float[,] temperatura;
        private float[] media;

        public void Cargar()
        {
            paises = new string[4];
            temperatura = new float[4, 3];
            for(int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre del " + (f+1) + "° pais: ");
                paises[f] = Console.ReadLine();

                for(int c = 0; c < temperatura.GetLength(1); c++)
                {
                    Console.Write("Ingresa la temperatura mensual de " + paises[f] + ": ");
                    temperatura[f, c] = float.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for(int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f]);

                for(int c = 0; c < temperatura.GetLength(1); c++)
                {
                    Console.WriteLine("La temperatura mensual de " + paises[f] + " fue: " + temperatura[f, c]);
                }
            }
        }

        public void MediaTrim()
        {
            float mediaM = 0;
            media = new float[4];

            for(int f = 0; f < paises.Length; f++)
            {
                for(int c = 0; c < temperatura.GetLength(1); c++)
                {
                    mediaM = mediaM + temperatura[f, c];
                }
                mediaM = (mediaM / 3);
                
                media[f] = mediaM;

                Console.WriteLine("La temperatura media trimestral de " + paises[f] + " es de " + mediaM);
                mediaM = 0;
            }
        }

        public void MayorMedia()
        {
            float mayor = media[0];

            for(int i = 0; i < media.Length; i++)
            {
                if (media[i] > mayor)
                {
                    mayor = media[i];
                }
            }

            for(int j = 0; j < media.Length; j++)
            {
                if (media[j] == mayor)
                {
                    Console.WriteLine("El pais con la temperatura media trimestral mayor es " + paises[j] + " con " + mayor);
                }
            }

        }

        static void Main(string[] args)
        {
            MediaTrimestral mt2 = new MediaTrimestral();
            mt2.Cargar();
            mt2.Imprimir();
            mt2.MediaTrim();
            mt2.MayorMedia();
            Console.ReadKey();
        }
    }
}
