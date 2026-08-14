using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{

    /*
    7-
    Un restaurante automatizado procesa la comanda de una mesa para controlar la
    preparación y el cobro de los platos pedidos.
     Crear la clase Plato que contenga como atributos privados: nombrePlato
    (string) y precio (double). Definir sus propiedades correspondientes y un
    constructor que reciba nom y pre.
     Crear la clase GestionComandas que administre una lista de objetos List.
     Métodos en GestionComandas:
    o AgregarPlato():Solicitar por teclado los datos de un plato y
    agregarlo a la lista utilizando .Add().
    o MostrarComanda(): Listar todos los platos agregados hasta el
    momento junto a la cantidad total de ítems pedidos utilizando la
    propiedad .Count.
    o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
    total a cobrar sumando los precios de la lista.
    o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
    se encuentra en la lista, removerlo mediante .Remove() para
    actualizar la comanda.  
    */

    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            set { nombrePlato = value; }
            get { return nombrePlato; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public Plato(string nom, double pre)
        {
            this.nombrePlato = nom;
            this.precio = pre;
        }
    }
    class GestionComandas
    {
        List<Plato> platos = new List<Plato>();

        public void AgregarPlato()
        {
            Console.Write("Ingrese el nombre del plato: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del plato: $");
            double precio = double.Parse(Console.ReadLine());
            Plato plato = new Plato(nombre, precio);
            platos.Add(plato);
        }

        public void MostrarComanda()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("====================================");
            Console.WriteLine("PLATOS PEDIDOS:");
            Console.WriteLine("====================================");
            foreach (Plato plato in platos)
            {
                Console.WriteLine("Nombre: " + plato.NombrePlato);
                Console.WriteLine("Precio: " + plato.Precio);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("Cantidad total de ítems pedidos: " + platos.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CalcularTotalMesa()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            double total = 0;
            foreach (Plato plato in platos)
            {
                total = total + plato.Precio;
            }
            Console.WriteLine("Monto total a cobrar: $" + total);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CancelarPlato()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese el nombre del plato a cancelar: ");
            string nombre = Console.ReadLine();

            for(int i = 0; i < platos.Count; i++)
            {
                if (nombre == platos[i].NombrePlato)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Plato " + platos[i].NombrePlato + " eliminado de la comanda");
                    platos.Remove(platos[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GestionComandas gest2 = new GestionComandas();
            gest2.AgregarPlato();
            gest2.AgregarPlato();
            gest2.AgregarPlato();
            gest2.MostrarComanda();
            gest2.CalcularTotalMesa();
            gest2.CancelarPlato();


            Console.ReadKey();
        }
    }
}
