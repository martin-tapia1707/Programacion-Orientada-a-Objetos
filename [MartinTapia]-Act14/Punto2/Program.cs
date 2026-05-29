using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
    2. Control de Vuelos
    Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
    Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
    Agregar los siguientes métodos en la clase Vuelo:
    Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
    Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
    Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
    */

    internal class Pasajero
    {

        private string nombre;
        private int dni;
        private float equipajekilos;

        public Pasajero()
        {
            Console.Write("Ingrese el nombre del pasajero: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el dni del pasajero: ");
            dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso de su equipaje: ");
            equipajekilos = float.Parse(Console.ReadLine());
        }

        public string DatoNombre()
        {
            return nombre;
        }
        public int DatoDNI()
        {
            return dni;
        }
        public float DatoEquipaje()
        {
            return equipajekilos;
        }

    }

    internal class Vuelo
    {
        private Pasajero[] pasajero;

        public Vuelo()
        {
            pasajero = new Pasajero[3];
            for(int i = 0; i < pasajero.Length; i++)
            {
                pasajero[i] = new Pasajero();
            }
        }

        public void DatosListado()
        {
            Console.WriteLine("DATOS LISTADOS DE TODOS LOS PASAJEROS: ");
            for (int i = 0; i < pasajero.Length; i++)
            {
                Console.WriteLine("Pasajero N°" + (i+1) + " Nombre: " + pasajero[i].DatoNombre() + " DNI: " + pasajero[i].DatoDNI() + " Equipaje(KG): " + pasajero[i].DatoEquipaje());
            }
        }

        public void PesoTotal()
        {
            float total = 0;

            for(int i = 0; i < pasajero.Length; i++)
            {
                total = (total + pasajero[i].DatoEquipaje());
            }

            Console.WriteLine("El peso total que carga el avion es de " + total);
        }

        public void PesoProhibido()
        {
            float prohibido = pasajero[0].DatoEquipaje();

            for(int i = 0; i < pasajero.Length; i++)
            {
                if (pasajero[i].DatoEquipaje() > 23)
                {
                    Console.WriteLine("El pasajero " + pasajero[i].DatoNombre() + " " + pasajero[i].DatoDNI() + " excede el limite permitido de equipaje");
                }
            }
        }

        static void Main(string[] args)
        {
            Vuelo v2 = new Vuelo();
            v2.DatosListado();
            v2.PesoTotal();
            v2.PesoProhibido();
            Console.ReadKey();
        }
    }
}
