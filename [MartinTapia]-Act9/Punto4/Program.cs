using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
    sus nombres y puntajes promedio obtenidos (de 1 a 10).
    Cargar sus datos en vectores paralelos, mostrar docente con calificación más
    alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
    calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
    desaprobaron (tomando como base que se aprueba con una nota mayor o igual
    a 6) 
    */

    internal class PruebaDocente
    {
        private string[] profesor;
        private float[] nota;
        private string[] repeMejor;
        private string[] repePeor;

        public void Cargar()
        {
            profesor = new string[6];
            nota = new float[6];

            for(int i = 0; i < profesor.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre de el profesor: ");
                profesor[i] = Console.ReadLine();
                Console.WriteLine("Ingresa la nota del profesor: ");
                nota[i] = int.Parse(Console.ReadLine());

                if (nota[i] > 10)
                {
                    Console.WriteLine("Valor ingresado no valido");
                    return;
                }
            }
        }

        public void Promedio()
        {
            float total = 0;
            float promedio = 0;

            for (int i = 0; i < profesor.Length;i++)
            {
                total = total + nota[i];
            }

            promedio = (total / 6);

            Console.WriteLine("El promedio de puntajes obtenidos es de: " + promedio);
        }

        public void Calificaciones()
        {
            float mayor = nota[0];
            float menor = nota[0];

            for ( int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] > mayor)
                {
                    mayor = nota[i];
                }

                if (nota[i] < menor)
                {
                    menor = nota[i];
                }
            }

            int repeticionMejor = 0;
            for (int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] == mayor)
                {
                    repeticionMejor++;
                }
            }

            int repeticionPeor = 0;
            for (int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] == menor)
                {
                    repeticionPeor++;
                }
            }

            repeMejor = new string[repeticionMejor];
            int aux1 = 0;
            repePeor = new string[repeticionPeor];
            int aux2 = 0;

            for (int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] == mayor)
                {
                    repeMejor[aux1] = profesor[i];
                    aux1++;
                }


            }

            Console.WriteLine("El/los docentes que sacaron la mejor nota son: " + repeticionMejor + " con " + mayor);
            for (int i = 0; i < repeMejor.Length; i++)
            {
                Console.WriteLine(repeMejor[i]);
            }

            for (int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] == menor)
                {
                    repePeor[aux2] = profesor[i];
                    aux2++;
                }
            }

            Console.WriteLine("El/los docentes que sacaron la peor nota son: " + repeticionPeor + " con " + menor);
            for (int i = 0; i < repePeor.Length; i++)
            {
                Console.WriteLine(repePeor[i]);
            }         

        }

        public void Ordenamiento()
        {
            for (int i = 0; i < profesor.Length - 1; i++)
            {
                for (int j = i +1; j < profesor.Length; j++)
                {
                    if (nota[i] < nota[j])
                    {
                        float aux = nota[i];
                        nota[i] = nota[j];
                        nota[j] = aux;
                    }
                }
            }

            for (int i = 0; i < profesor.Length; i++)
            {
                if (nota[i] > 5)
                {
                    Console.WriteLine("El profesor " + profesor[i] + " aprobo con una nota de " + nota[i]);
                } else
                {
                    Console.WriteLine("El profesor " + profesor[i] + " reprobo con una nota de " + nota[i]);
                }
            }


        }

        static void Main(string[] args)
        {
            PruebaDocente pruebadoc2 = new PruebaDocente();
            pruebadoc2.Cargar();
            pruebadoc2.Promedio();
            pruebadoc2.Calificaciones();
            pruebadoc2.Ordenamiento();

            Console.ReadKey();
        }
    }
}
