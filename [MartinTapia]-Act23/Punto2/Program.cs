using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2-
    Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
    drones de entrega en vuelo de regreso a la base.
     Crear la clase Dron que contenga los atributos privados: codigo (string) y
    nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
    Su constructor debe recibir cod y bat.
     Crear la clase CentroControl que administre una lista de objetos
    List<Dron>.
     Métodos en CentroControl:

    1. Un constructor que cargue por teclado una lista inicial de 4 drones
    ingresando sus códigos y baterías.
    2. ListarFlota(): Mostrar la lista de drones en pantalla.
    3. RemoverDronesBajos(): Recorrer la lista y remover por
    completo de la flota a todos aquellos drones cuyo nivel de batería
    sea menor o igual al 15% (ya que requieren mantenimiento
    automático urgente).
    4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
    cantidad de drones operativos utilizando la propiedad .Count. 
    */

    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            set { codigo = value; } 
            get { return codigo; }
        }

        public int NivelBateria
        {
            set { codigo = value; }
            get { return nivelBateria; }
        }

        public Dron(string cod, int bat)
        {
            this.codigo = cod;
            this.nivelBateria = bat;
        }
    }
    class CentroControl 
    {
        List<Dron> drones = new List<Dron>();

        public CentroControl()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.Write("Codigo de dron: ");
                string codDron = Console.ReadLine();
                Console.Write("Nivel bateria: ");
                int nivBat = int.Parse(Console.ReadLine());

                CentroControl centro2 = new CentroControl(codDron, nivBat);
                drones.Add(centro2);
            }
        }

        public void ListaFlota()
        {
            foreach(Dron dron in drones)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Codigo: " + dron.Codigo);
                Console.WriteLine("Nivel Bateria: " + dron.NivelBateria);
            }
        }

        public void RemoverDronesBajos()
        {
            foreach(Dron dron in drones)
            {
                if(dron.NivelBateria =< 15)
                {
                    dron.RemoveAt(dron); // corregir remove despues
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se removio al dron" + dron.Codigo + " para darle mantenimiento..");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void MostrarDronesRestantes()
        {
            cantDrones = 0;

            foreach(Dron dron in drones)
            {
                Console.Write("Codigo: " + dron.Codigo);
                Console.WriteLine("Nivel bateria: " + dron.NivelBateria); 
            }

            for(int i = 0; i < drones.Count; i++)
            {
                // imprimir cantidad drones actualizada despues
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CentroControl centro2 = new CentroControl();
            centro2.ListaFlota();
            centro2.RemoverDronesBajos();
            centro2.MostrarDronesRestantes();
        }
    }
}
