using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    /*
    9-
    Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
    realizar el seguimiento académico de sus materias.
     Crear la clase Estudiante que contenga como atributos privados:
    nombreCompleto (string) y calificacion (double). Definir sus propiedades
    de solo lectura y un constructor que reciba nom y cal.
     Crear la clase GestionAcademica que administre una lista de objetos
    List.
     Métodos en GestionAcademica:
    o CargarEstudiantes(): Solicitar por teclado nombres y
    calificaciones para agregar estudiantes a la lista mediante .Add(). La
    carga finaliza cuando el usuario ingresa la palabra "FIN" como
    nombre.
    o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
    junto a la cantidad total de inscriptos mediante la propiedad .Count.
    o FiltrarAprobados(): Recorrer la lista e imprimir en consola
    únicamente aquellos estudiantes cuya calificación sea mayor o igual
    a 6.0.
    o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
    utilizando los métodos de búsqueda y remoción de listas, eliminarlo
    de la colección si se encuentra presente. 
    */
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public string NombreCompleto
        {
            set { nombreCompleto = value; }
            get { return nombreCompleto; }
        }

        public double Calificacion
        {
            set { calificacion = value; }
            get { return calificacion; }
        }

        public Estudiante(string nom, double cal)
        {
            this.nombreCompleto = nom;
            this.calificacion = cal;
        }
    }

    class GestionAcademica
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        public void CargarEstudiantes()
        {
            string nombre;
            do
            {
                Console.Write("Nombre del estudiante: ");
                nombre = Console.ReadLine();
                
                if(nombre != "FIN")
                {
                    Console.Write("Calificacion del estudiante: ");
                    double calif = double.Parse(Console.ReadLine());

                    Estudiante nuevoEst = new Estudiante(nombre, calif);
                    estudiantes.Add(nuevoEst);
                }


            } while (nombre != "FIN"); 
        }

        public void ListarEstudiantes()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("====================================");
            Console.WriteLine("LISTA DE ESTUDIANTES");
            Console.WriteLine("====================================");
            foreach (Estudiante estu in estudiantes)
            {
                Console.WriteLine("Nombre: " + estu.NombreCompleto);
                Console.WriteLine("Calificacion: " + estu.Calificacion);
                Console.WriteLine("-----");
            }

            Console.WriteLine("Cantidad total de inscriptos: " + estudiantes.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void FiltrarAprobados() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====================================");
            Console.WriteLine("LISTA DE ESTUDIANTES APROBADOS");
            Console.WriteLine("====================================");
            foreach (Estudiante estu in estudiantes)
            {
                if(estu.Calificacion >= 6)
                {
                    Console.WriteLine("Nombre: " + estu.NombreCompleto);
                    Console.WriteLine("Calificacion: " + estu.Calificacion);
                    Console.WriteLine("-----");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DarDeBaja()
        {
            bool presente = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese el nombre de un estudiante para dar de baja: ");
            string baja = Console.ReadLine();
            int pos = 0;

            for(int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].NombreCompleto == baja)
                {
                    pos = i;
                    presente = true;
                }
            }

                if(presente == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El estudiante " + estudiantes[pos].NombreCompleto + " ha sido dado de baja.");
                    Console.ForegroundColor = ConsoleColor.White;

                    estudiantes.Remove(estudiantes[pos]);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No se encontro al estudiante " + estudiantes[pos].NombreCompleto + " en la lista.");
                }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GestionAcademica gest3 = new GestionAcademica();
            gest3.CargarEstudiantes();
            gest3.ListarEstudiantes();
            gest3.FiltrarAprobados();
            gest3.DarDeBaja();
            Console.ReadKey();
        }
    }
}
