using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Plantear una clase Producto y otra clase Inventario.
    La clase Producto debe tener como atributos privados el nombre, precio y
    stock. Definir propiedades para acceder a estos atributos, asegurando que el
    stock no pueda ser negativo y el precio sea mayor a cero.
    La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
    método para mostrar todos los productos ordenados de menor a mayor en
    base al precio, además, mostrar el producto más caro y más barato del
    inventario.
    */
    public class Producto
    {
        protected string nombre;
        protected int precio;
        protected int stock;

        public Producto()
        {
            Console.Write("Definir el nombre del producto: ");
            nombre = Console.ReadLine();

            Console.Write("Definir el precio del producto: ");
            precio = int.Parse(Console.ReadLine());

            Console.Write("Inserta el stock del producto: ");
            stock = int.Parse(Console.ReadLine());
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
    }

    public class Inventario
    {
        private Producto[] productos = new Producto[3];

        public Inventario()
        {
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto();
            }
        }

        public void Ordenamiento()
        {
            int aux = 0;
            string aux2;
            int aux3 = 0;
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 1; j < productos.Length; j++)
                {
                    if (productos[i].Precio > productos[j].Precio)
                    {
                        aux = productos[i].Precio;
                        productos[i].Precio = productos[j].Precio;
                        productos[j].Precio = aux;

                        aux2 = productos[i].Nombre;
                        productos[i].Nombre = productos[j].Nombre;
                        productos[j].Nombre = aux2;

                        aux3 = productos[i].Stock;
                        productos[i].Stock = productos[j].Stock;
                        productos[j].Stock = aux3;

                    }
                }
            }

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("-- PRODUCTO " + (i + 1) + " --");
                Console.WriteLine("Nombre: " + productos[i].Nombre);
                Console.WriteLine("Precio: " + productos[i].Precio);
                Console.WriteLine("Stock: " + productos[i].Stock);
            }
        }

        static void Main(string[] args)
        {
            Inventario inv2 = new Inventario();
            inv2.Ordenamiento();
            Console.ReadKey();
        }
    }
}


