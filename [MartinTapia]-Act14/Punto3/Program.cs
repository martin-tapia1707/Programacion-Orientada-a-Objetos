using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Competencia de Atletismo
    Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    Definir los siguientes métodos en la clase Carrera:
    Un constructor que cargue los datos de los 3 atletas de la carrera.
    Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
    Un método que calcule e imprima el tiempo promedio de la carrera.
    Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
    Un método que muestre a los atletas que superaron el promedio.
    */
    internal class Atleta
    {

        private string nombre;
        private float tiemposegundos;

        public Atleta()
        {
            Console.Write("Ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el tiempo de " + nombre + ": ");
            tiemposegundos = float.Parse(Console.ReadLine());
        }

        public string DatoNombre()
        {
            return nombre;
        }
        public float DatoTiempo()
        {
            return tiemposegundos;
        }

    }

    internal class Carrera
    {
        private Atleta[] atleta;

        public Carrera()
        {
            atleta = new Atleta[3];
            for (int i = 0; i < atleta.Length; i++)
            {
                atleta[i] = new Atleta();
            }
        }

        public void DatosAtletas()
        {
            Console.WriteLine("Datos de los atletas: ");
            for(int i = 0; i < atleta.Length; i++)
            {
                Console.WriteLine("ATLETA N°" + (i+1) + " Nombre: " + atleta[i].DatoNombre() + " Tiempo: " + atleta[i].DatoTiempo());
            }
        }

        public void PromedioCarrera()
        {
            float promedio = 0;
            for(int i = 0; i < atleta.Length;i++)
            {
                promedio = (promedio + atleta[i].DatoTiempo());
            }

            promedio = (promedio / atleta.Length);

            Console.WriteLine("El tiempo promedio de la carrera fue de " + promedio + " segundos");
        }

        public void Ganador()
        {
            float tiempo = atleta[0].DatoTiempo();
            string nombre = atleta[0].DatoNombre();
            for(int i = 0; i < atleta.Length; i++)
            {
                if(tiempo > atleta[i].DatoTiempo())
                {
                    tiempo = atleta[i].DatoTiempo();
                    nombre = atleta[i].DatoNombre();
                }
            }

            Console.WriteLine("El ganador de la carrera fue el atleta " + nombre + " con un tiempo de " + tiempo);
        }

        public void Promedio()
        {
            float promedio = 0;

            for(int i = 0; i < atleta.Length; i++)
            {
                promedio = (promedio + atleta[i].DatoTiempo());
            }
            promedio = promedio / atleta.Length;

            for(int j = 0;  j < atleta.Length; j++)
            {
                if (atleta[j].DatoTiempo() < promedio)
                {
                    Console.WriteLine("El atleta " + atleta[j].DatoNombre() + " supero el promedio con un tiempo de " + atleta[j].DatoTiempo());
                }
            }

        }

        static void Main(string[] args)
        {
            Carrera c2 = new Carrera();
            c2.DatosAtletas();
            c2.PromedioCarrera();
            c2.Ganador();
            c2.Promedio();
            Console.ReadKey();
        }
    }
}
