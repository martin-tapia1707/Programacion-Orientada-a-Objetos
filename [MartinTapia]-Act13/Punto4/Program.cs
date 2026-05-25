using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
    vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
    alumno y sus 4 calificaciones.
    Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
    Alumno.
    Agregar los siguientes métodos:
    a) Un método que imprima el nombre de cada alumno y su promedio.
    b) Un método que muestre el nombre del alumno con el promedio más
    alto.
    c) Un método que indique qué alumnos tienen al menos una nota
    desaprobada (nota menor a 6) 
    */ 
    class Alumno
    {
        private string nombre;
        private float[] notas;

        public Alumno() 
        {
            Console.Write("Ingresa el nombre del alumno: ");
            nombre = Console.ReadLine();
            notas = new float[4];

            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingresa la " + (i+1) + "° nota de " + nombre + ": ");
                notas[i] = int.Parse(Console.ReadLine());
                if (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Nota invalida, ingresela denuevo");
                    i--;
                }
            }
        }

        public string RetornarNombre() 
        {
            return nombre;
        }

        public float RetornarPromedio()
        {
            float promedio = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                promedio = promedio + notas[i];
            }
            promedio = (promedio / 4);

            return promedio;
        }

        public float[] RetornarNotas()
        {
            return notas;
        }

    }

    class Curso
    {
        private Alumno[] alumno;
        
        public Curso() 
        {
            alumno = new Alumno[3];
            for(int i = 0; i < alumno.Length; i++)
            {
                alumno[i] = new Alumno();
            }
        }

        public void Imprimir()
        {
            for(int i = 0; i < alumno.Length; i++)
            {
                Console.WriteLine("Nombre: " + alumno[i].RetornarNombre() + " Promedio: " + alumno[i].RetornarPromedio());
            }
        }

        public void PromedioMasAlto()
        {
            float mayor = alumno[0].RetornarPromedio();
            string nombre = alumno[0].RetornarNombre();

            for(int i = 0; i < alumno.Length; i++)
            {
                if(mayor < alumno[i].RetornarPromedio())
                {
                    mayor = alumno[i].RetornarPromedio();
                    nombre = alumno[i].RetornarNombre();
                }
            }

            Console.WriteLine("El alumno con el promedio mas alto es: " + nombre + " con " + mayor);

        }

        public void NotaDesaprobada()
        {
            for(int i = 0; i < alumno.Length; i++)
            {

                float[] notas = alumno[i].RetornarNotas();

                for(int j = 0; j < notas.Length; j++)
                {
                    if (notas[j] < 6)
                    {
                        Console.WriteLine("El alumno " + alumno[i].RetornarNombre() + " tiene una nota desaprobada");
                    }
                }
            }
        }

        
        static void Main(string[] args)
        {
            Curso c2 = new Curso();
            c2.Imprimir();
            c2.PromedioMasAlto();
            c2.NotaDesaprobada();
            Console.ReadKey();
        }
    }
}
