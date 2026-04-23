using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1. Se desea desarrollar un programa que permita registrar los nombres y las
    calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
    nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
    estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
    máxima o mínima. 
    */
    internal class Calificaciones
    {
        private string[] estudiante;
        private int[] nota;
        private string[] repeMax;
        private string[] repeMin;

        public void Cargar()
        {
            estudiante = new string[6];
            nota = new int[6];
            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                estudiante[i] = Console.ReadLine();
                Console.Write("Ingrese la nota del estudiante: ");
                nota[i] = int.Parse(Console.ReadLine());
            }
        }

        public void NotaAlta()
        {
            // saca nota alta

            int mayor = nota[0];

            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] > mayor)
                {
                    mayor = nota[i];
                }
            }

            // repite
            int repeticionMayor = 0;
            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] == mayor)
                {
                    repeticionMayor++;
                }
            }

            repeMax = new string[repeticionMayor];
            int aux = 0;


            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] == mayor)
                {
                    repeMax[aux] = estudiante[i];
                    aux++;
                }
            }

            Console.WriteLine("Los alumnos que sacaron la nota mas alta son " + repeticionMayor + " teniendo una nota de: " + mayor);
            for (int k = 0; k < repeMax.Length; k++)
            {
                Console.WriteLine(repeMax[k]);
            }

        }

        public void NotaBaja()
        {

            int menor = nota[0];

            // saca nota menor

            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] < menor)
                {
                    menor = nota[i];

                }
            }

            // repeticiones

            int repeticionMenor = 0;
            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] == menor)
                {
                    repeticionMenor++;
                }
            }
            repeMin = new string[repeticionMenor];

            int aux = 0;
            for (int i = 0; i < estudiante.Length; i++)
            {
                if (nota[i] == menor)
                {
                    repeMin[aux] = estudiante[i];
                    aux++;
                }
            }

            Console.WriteLine("Los alumnos que sacaron la nota mas baja son " + repeticionMenor + " teniendo una nota de: " + menor);
            for (int k = 0; k < repeMin.Length; k++)
            {
                Console.WriteLine(repeMin[k]);
            }
        }

        static void Main(string[] args)
        {
            Calificaciones calificaciones2 = new Calificaciones();
            calificaciones2.Cargar();
            calificaciones2.NotaAlta();
            calificaciones2.NotaBaja();
            Console.ReadKey();
        }
    }
}
