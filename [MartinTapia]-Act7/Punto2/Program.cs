using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
    2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    tercer vector del mismo tamaño. Sumar componente a componente. 
    */

    internal class SumaVectores
    {
        private float[] Vector1;
        private float[] Vector2;
        private float[] Vector3;


        public void CargarValores()
        {
            Console.WriteLine("VECTOR 1");
            Vector1 = new float[4];
            for (int n = 0; n < 4; n++) // vector 1 de cuatro valores
            {
                Console.Write("Ingresa el valor: ");
                Vector1[n] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("VECTOR 2");
            Vector2 = new float[4];
            for (int n = 0; n < 4; n++) // vector 2 de cuatro valores
            {
                Console.Write("Ingresa el valor: ");
                Vector2[n] = float.Parse(Console.ReadLine());
            }

        }

        public void SumarVectores()
        {
            Vector3 = new float[4];
            for (int n = 0; n < 4; n++) // aca sumo los vectores
            {
                Vector3[n] = Vector1[n] + Vector2[n];
            }

            Console.Write("Tercer vector: ");
            for (int n = 0; n < 4; n++)
            {
                Console.Write(Vector3[n]);
            }
        }

        static void Main(string[] args)
        {

            SumaVectores eje2 = new SumaVectores();
            eje2.CargarValores();
            eje2.SumarVectores();
            Console.ReadKey();

        }
    }
}



