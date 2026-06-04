using Punto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1. Monitoreo Clínico de Pacientes
    En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
    cardíaco de los pacientes.
    ● Plantear una clase llamada Paciente que tenga como atributos privados:
    1. Nombre (de tipo string).
    2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
    registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
    clave de cada día: mañana, mediodía, tarde y noche).
    3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
    teclado de las 12 lecturas cardíacas.

    ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
    objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
    carga de los 3 pacientes. Implementar los siguientes métodos dentro de
    SalaMonitoreo:
    1. Un método que imprima la grilla de lecturas cardíacas completa de cada
    paciente organizada por día y momento.
    2. Un método que calcule e imprima el promedio de pulsaciones de cada
    paciente a lo largo de todo su monitoreo.
    3. Un método que verifique si algún paciente registró un evento de taquicardia
    severa (cualquier lectura individual que sea estrictamente mayor a 120
    pulsaciones), mostrando por consola su nombre y la lectura detectada. 
    */

    internal class Paciente
    {

        private string nombre;
        private int[,] ritmoCardiaco;

        public Paciente()
        {
            ritmoCardiaco = new int[3, 4];
            Console.Write("Ingrese el nombre del paciente: ");
            nombre = Console.ReadLine();
            for (int f = 0; f < ritmoCardiaco.GetLength(0); f++)
            {
                Console.WriteLine("DIA " + (f+1));
                for (int c = 0; c < ritmoCardiaco.GetLength(1); c++)
                {
                    Console.Write("Ingrese la " + (c + 1) + "° lectura cardiaca de " + nombre + ": ");
                    ritmoCardiaco[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string DatoNombre()
        {
            return nombre;
        }

        public int[,] DatoRitCard()
        {
            return ritmoCardiaco;
        }

    }

    internal class SalaMonitoreo
    {

        private Paciente[] paciente = new Paciente[3];

        public SalaMonitoreo() 
        { 
            for(int i = 0; i < paciente.Length; i++)
            {
                paciente[i] = new Paciente();
            }
        }
        
    public void GrillaOrganizada()
    {
            for(int i = 0; i < paciente.Length;i++)
            {
                Console.WriteLine("Paciente: " + paciente[i].DatoNombre());

                int[,] matriz = paciente[i].DatoRitCard();

                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    Console.WriteLine("Dia " + (f + 1) + ": ");
                    for(int c = 0; c < matriz.GetLength(1); c++)
                    {
                        Console.Write(matriz[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
    }

    public void Promedio()
        {
            float promedio = 0;

            for(int i = 0; i < paciente.Length; i++)
            {
                Console.WriteLine("Paciente: " + paciente[i].DatoNombre());
                int[,] matriz = paciente[i].DatoRitCard();

                for(int f = 0; f < matriz.GetLength(0); f++)
                {
                    for(int c = 0; c < matriz.GetLength(1); c++)
                    {
                        promedio = promedio + matriz[f, c];
                    }
                }

                promedio = promedio / 12;

                Console.WriteLine("Promedio de todo su ritmo cardiaco durante todo el monitoreo: " + promedio);
            }
        }

    public void Taquicardia()
        {
            for(int i = 0; i < paciente.Length; i++)
            {
                int[,] matriz = paciente[i].DatoRitCard();

                for(int f = 0; f < matriz.GetLength(0); f++)
                {
                    for(int c = 0; c < matriz.GetLength(1); c++)
                    {
                        if (matriz[f, c] > 120)
                        {
                            Console.WriteLine("Paciente: " + paciente[i].DatoNombre() + "presento un evento de taquicardia severa");
                            Console.WriteLine(matriz[f, c]);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
        SalaMonitoreo sm2 = new SalaMonitoreo();
        sm2.GrillaOrganizada();
        sm2.Promedio();
        sm2.Taquicardia();
        Console.ReadKey();
        }
    }
}
