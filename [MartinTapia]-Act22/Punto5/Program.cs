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

        }

        public Carrera(int cod, DateTime inicio, DateTime fin)
        {
            this.codigo = cod;
            this.horaInicio = inicio;
            this.horaFin = fin;
        }

        public void Duracion()
        {
            TimeSpan duracionCarrera = horaFin - horaInicio;

            Console.WriteLine("La carrera duro " + duracionCarrera + " ");
        }
    }
    internal class Corredor
    {
        private string nombre;
        private int numeroDorsal;
        private TimeSpan tiempoTotal;



        static void Main(string[] args)
        {
        }
    }
}
