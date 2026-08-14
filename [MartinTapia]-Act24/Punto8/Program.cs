using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    /*
    8-
    Una farmacia controla el nivel de stock de sus medicamentos para evitar el
    desabastecimiento de insumos esenciales.
     Crear la clase Medicamento que contenga los atributos privados: nombre
    (string) y stock (int). Definir sus propiedades correspondientes. Su
    constructor debe recibir nom y stk.
     Crear la clase ControlFarmacia que administre una lista de objetos List.
     Métodos en ControlFarmacia:
    o Un constructor que cargue por teclado una lista inicial de 4
    medicamentos ingresando sus nombres y stock.
    o ListarStock(): Mostrar la lista de medicamentos en pantalla.

    o RemoverAgotados(): Recorrer la lista y remover por completo de
    la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
    o MostrarMedicamentosDisponibles(): Imprimir la lista
    actualizada y la cantidad de productos disponibles en el inventario
    utilizando la propiedad .Count. 
    */

    class Medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Stock
        {
            set { stock = value;  } 
            get { return stock; }
        }

        public Medicamento(string nom, int stk)
        {
            this.nombre = nom;
            this.stock = stk;
        }
    }

    class ControlFarmacia
    {
        List<Medicamento> medicamentos = new List<Medicamento>();

        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del medicamento: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el stock del medicamento: ");
                int stock = int.Parse(Console.ReadLine());

                Medicamento medic3 = new Medicamento(nombre, stock);

                medicamentos.Add(medic3);
            }
        }

        public void ListarStock()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=========================");
            Console.WriteLine("LISTA DE MEDICAMENTOS");
            Console.WriteLine("=========================");
            foreach(Medicamento medic in medicamentos)
            {
                Console.WriteLine("Nombre: " + medic.Nombre);
                Console.WriteLine("Stock: " + medic.Stock);
                Console.WriteLine("---------------------");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void RemoverAgotados()
        {

            for(int i = 0; i < medicamentos.Count; i++)
            {
                if (medicamentos[i].Stock == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El medicamento " + medicamentos[i].Nombre + " no tiene stock suficiente, por lo tanto sera eliminado");
                    Console.ForegroundColor = ConsoleColor.White;
                    medicamentos.Remove(medicamentos[i]);
                }
            }
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===================================");
            Console.WriteLine("Lista de medicamentos disponibles");
            Console.WriteLine("===================================");
            foreach (Medicamento medic in medicamentos)
            {
                Console.WriteLine("Nombre: " + medic.Nombre);
                Console.WriteLine("Stock: " + medic.Stock);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("Cantidad de medicamentos disponibles: " + medicamentos.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ControlFarmacia cf2 = new ControlFarmacia();
            cf2.ListarStock();
            cf2.RemoverAgotados();
            cf2.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
