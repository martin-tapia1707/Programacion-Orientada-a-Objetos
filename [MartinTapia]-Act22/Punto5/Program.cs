using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*
    Actividad 5: Gestión de Carreras Deportivas
    Consigna:
    Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
    una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
    Se pide:
    1. Crear una clase Carrera con:
    o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
    definidos.
    o Dos constructores (uno por defecto y otro con parámetros).
    o Método para calcular la duración de la carrera usando TimeSpan.
    2. Crear una clase Corredor con:
    o Atributos: nombre, número de dorsal y tiempo total.
    o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
    horas y minutos).

    3. Mostrar en consola (usando Console.SetCursorPosition()):
    o La carrera con mayor duración.
    o El corredor más rápido.
    4. Utilizar this en los constructores o métodos donde corresponda. 
    */
    internal class Carrera
    {
        private int codigo;
        private DateTime horaInicio;
        private DateTime horaFin;

        List<Corredor> listaCorredores = new List<Corredor>();

        public Carrera()
        {
            Console.Write("Ingrese el codigo de la carrera: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la hora de inicio: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese la hora de fin: ");
            horaFin = DateTime.Parse(Console.ReadLine());
        }

        public Carrera(int cod, DateTime inicio, DateTime fin)
        {
            this.codigo = cod;
            this.horaInicio = inicio;
            this.horaFin = fin;
        }
        public int Codigo()
        {
            return codigo;
        }

        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;
        }

        public void AgregarCorredor(Corredor corredor)
        {
            listaCorredores.Add(corredor);
        }
    }
    internal class Corredor
    {
        private string nombre;
        private int numeroDorsal;
        private TimeSpan tiempoTotal;

        public Corredor(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.numeroDorsal = dorsal;
        }

        public string Nombre()
        {
            return nombre;
        }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = TimeSpan.FromMinutes(minutos);
        }

        public TimeSpan Tiempo()
        {
            return tiempoTotal;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = new TimeSpan(horas, minutos, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera(1, new DateTime(2026, 7, 3, 7, 45, 00), new DateTime(2026, 7, 3, 12, 05, 00));

                Corredor corredor1 = new Corredor("Tenna", 10);
                corredor1.RegistrarTiempo(58);
                carrera1.AgregarCorredor(corredor1);

                Corredor corredor2 = new Corredor("Asgore", 11);
                corredor2.RegistrarTiempo(28);
                carrera1.AgregarCorredor(corredor2);

                Corredor corredor3 = new Corredor("Sans", 12);
                corredor3.RegistrarTiempo(67);
                carrera1.AgregarCorredor(corredor3);

                Corredor corredor4 = new Corredor("El TimeSpanner", 13);
                corredor4.RegistrarTiempo(89);
                carrera1.AgregarCorredor(corredor4);

            Carrera carrera2 = new Carrera(1, new DateTime(2026, 7, 3, 10, 00, 00), new DateTime(2026, 7, 3, 15, 00, 00));

                Corredor corredor5 = new Corredor("Gerson", 14);
                corredor5.RegistrarTiempo(108);
                carrera2.AgregarCorredor(corredor5);

                Corredor corredor6 = new Corredor("SubZero", 15);
                corredor6.RegistrarTiempo(77);
                carrera2.AgregarCorredor(corredor6);

                Corredor corredor7 = new Corredor("Scorpion", 16);
                corredor7.RegistrarTiempo(55);
                carrera2.AgregarCorredor(corredor7);

                Corredor corredor8 = new Corredor("Titan", 17);
                corredor8.RegistrarTiempo(5);
                carrera2.AgregarCorredor(corredor8);

            // meto todos los datos en vectores

            Carrera[] carreras = new Carrera[2];
            carreras[0] = carrera1;
            carreras[1] = carrera2;

            Corredor[] corredores = new Corredor[8];
            corredores[0] = corredor1;
            corredores[1] = corredor2;
            corredores[2] = corredor3;
            corredores[3] = corredor4;
            corredores[4] = corredor5;
            corredores[5] = corredor6;
            corredores[6] = corredor7;
            corredores[7] = corredor8;

            // carrera con mayor duracion

            Carrera mayor = carreras[0];
            int pos = 0;

            for(int i = 0; i < carreras.Length; i++)
            {
                if (carreras[i].Duracion() > mayor.Duracion())
                {
                    mayor = carreras[i];
                    pos = i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("La carrera con mayor duracion es la " + mayor.Codigo() + " con " + mayor.Duracion());

            // corredor mas rapido

            Corredor menor = corredores[0];

            for(int k = 0; k < corredores.Length; k++)
            {
                if (menor.Tiempo() > corredores[k].Tiempo())
                {
                    menor = corredores[k];
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(6, 8);
            Console.WriteLine("El corredor mas rapido es " + menor.Nombre() + " que tiene un tiempo de " + menor.Tiempo());

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
