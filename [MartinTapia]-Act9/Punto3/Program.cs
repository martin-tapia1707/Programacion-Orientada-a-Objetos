using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{

    /*
    3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
    carrera de 100 metros. El programa debe cargar los datos en dos vectores
    paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
    atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
    promedio.
    */
    internal class PromedioAtletas
    {
        private string[] atleta;
        private float[] tiempo;

        public void Cargar()
        {
            atleta = new string[5];
            tiempo = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa el nombre del atleta: ");
                atleta[i] = Console.ReadLine();
                Console.Write("Ingresa el tiempo del atleta: ");
                tiempo[i] = float.Parse(Console.ReadLine());
            }
        }

        public void Promedio()
        {
            float total = 0;
            float promedio = 0;

            for (int i = 0; i < 5; i ++)
            {
                total = total + tiempo[i];
            }

            promedio = (total / 5);


            Console.WriteLine("El promedio de los tiempos es: " + promedio);

           for (int i = 0; i < 5; i ++)
            {
                if (tiempo[i] < promedio)
                {
                    Console.WriteLine("El atleta " + atleta[i] + " supero el promedio");
                }
            }

        }

        public void Tiempos()
        {
            float menor = tiempo[0];
            int pos1 = 0;
            float mayor = tiempo[0];
            int pos2 = 0;

            for(int i = 0; i <  tiempo.Length; i ++)
            {
                if(tiempo[i] > mayor)
                {
                    mayor = tiempo[i];
                    pos1 = i;
                }
                if (tiempo[i] < menor) 
                {
                    menor = tiempo[i];
                    pos2 = i;
                }
            }

            Console.WriteLine("El atleta con mejor tiempo es: " + atleta[pos2] + " con " + menor + "s");
            Console.WriteLine("El atelta con peor tiempo es: " + atleta[pos1] + " con " + mayor + "s");

        }

        static void Main(string[] args)
        {
            PromedioAtletas promedio2 = new PromedioAtletas();
            promedio2.Cargar();
            promedio2.Promedio();
            promedio2.Tiempos();
            Console.ReadKey();
        }
    }
}
