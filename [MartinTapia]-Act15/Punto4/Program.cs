using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Línea de Ensamblaje Robótico
    En una planta de fabricación automatizada, cada robot industrial realiza tareas de
    ensamblaje complejas divididas en operaciones secundarias de duración variable.
    ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
    1. ModeloRobot.
    2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
    fila representa una de las 4 fases principales del proceso (Estructura,
    Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
    completar las distintas subtareas de esa fase (por ejemplo, en la fase de
    Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
    1).
    3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
    cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

    (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
    una de ellas.

    ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
    RobotEnsamblador. Implementar en PlantaIndustrial:
    1. Un constructor que cargue la información de los 3 robots instalados en la
    planta.
    2. Un método que muestre un reporte detallado con los tiempos de operación
    de cada robot fase por fase.
    3. Un método que calcule el promedio general de tiempo por tarea de cada
    robot y declare al "Robot más Eficiente" (aquel que registre el promedio de
    tiempo por operación más bajo de la planta). 
    */
    internal class RobotEnsamblador
    {
        private string ModeloRobot;
        private float[][] tiemposOperacion = new float[4][];

        public RobotEnsamblador()
        {
            Console.Write("Cual es el modelo del robot?: ");
            ModeloRobot = Console.ReadLine();

            int subtareas = 0;

            for (int i = 0; i < tiemposOperacion.Length; i++) 
            {
                Console.Write("Cuantas subtareas tiene la fase " + (i + 1) + "?: ");
                subtareas = int.Parse(Console.ReadLine());
                tiemposOperacion[i] = new float[subtareas];
            }

            for(int f = 0; f < tiemposOperacion.Length; f++)
            {
                Console.WriteLine("Fase N°" + (f+1));
                for(int c = 0; c < tiemposOperacion[f].Length; c++)
                {
                    Console.Write("Cuanto tardo " + ModeloRobot + " en cumplir las subtareas: ");
                    tiemposOperacion[f][c] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string DatoModelo()
        {
            return ModeloRobot;
        }

        public float[][] DatoTiempo()
        {
            return tiemposOperacion;
        }

    }

    internal class PlantaIndustrial
    {
        private RobotEnsamblador[] robot = new RobotEnsamblador[3];

        public PlantaIndustrial()
        {
            for (int i = 0; i < robot.Length; i++)
            {
                robot[i] = new RobotEnsamblador();
            }
        }

        public void TiempoXFase()
        {
            for(int i = 0; i < robot.Length; i++)
            {
                float[][] tiempo = robot[i].DatoTiempo();

                Console.WriteLine("MODELO DE ROBOT: " + robot[i].DatoModelo());
                for(int f = 0; f < tiempo.Length; f++)
                {
                    Console.WriteLine("Fase N° " + (f + 1));
                    for(int c = 0; c < tiempo[f].Length; c++)
                    {
                        Console.Write(tiempo[f][c] + "s - ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void MasEficiente()
        {
            // RECORRIDO PARA DARLE VALOR A MENOR

            float menor = 0;
            float promedio = 0;
            int cantidadTareas = 0;

            float[][] tiempo = robot[0].DatoTiempo();

            for (int f = 0; f < tiempo.Length; f++)
            {
                for (int c = 0; c < tiempo[f].Length; c++)
                {
                    promedio += tiempo[f][c];
                    cantidadTareas++;
                }
            }

            menor = promedio / cantidadTareas;

            // RECORRIDO TOTAL

            int pos = 0;

            for (int i = 0; i < robot.Length; i++)
            {
                promedio = 0;
                cantidadTareas = 0;
                tiempo = robot[i].DatoTiempo();

                for(int f = 0; f < tiempo.Length; f++)
                {
                    for(int c = 0; c < tiempo[f].Length; c++)
                    {
                        promedio = promedio + tiempo[f][c];
                        cantidadTareas++;
                    }
                }

                promedio = promedio / cantidadTareas;

                Console.WriteLine("Promedio de " + robot[i].DatoModelo() + ": " + promedio + "seg");

                if(promedio < menor)
                {
                    menor = promedio;
                    pos = i;
                }
            }

            Console.WriteLine("El robot mas eficiente es: " + robot[pos].DatoModelo() + " con un promedio de: " + menor + "seg ");

        }

        static void Main(string[] args)
        {
            PlantaIndustrial pi2 = new PlantaIndustrial();
            pi2.TiempoXFase();
            pi2.MasEficiente();
            Console.ReadKey();
        }
    }
}
