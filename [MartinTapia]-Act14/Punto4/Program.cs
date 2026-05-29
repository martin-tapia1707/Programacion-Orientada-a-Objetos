using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4. Inventario de Sucursales 
    Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
    Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
    Implementar en la clase Sucursal los siguientes métodos:
    Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
    Un método que busque y muestre el nombre del artículo más caro del local.
    Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
    */
    internal class Articulo
    {
        private string NombreArticulo;
        private int Precio;
        private int StockActual;

        public Articulo()
        {
            Console.Write("Ingrese el nombre del articulo: ");
            NombreArticulo = Console.ReadLine();
            Console.Write("Ingrese el precio de " +  NombreArticulo + ": ");
            Precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el stock actual de " + NombreArticulo + ": ");
            StockActual = int.Parse(Console.ReadLine());
        }

        public string DatoNombre()
        {
            return NombreArticulo;
        }
        public int DatoPrecio()
        {
            return Precio;
        }
        public int DatoStockActual()
        {
            return StockActual;
        }

    }
    internal class Sucursal
    {
        private Articulo[] articulo;

        public Sucursal()
        {
            articulo = new Articulo[3];
            for(int i = 0; i < articulo.Length; i++)
            {
                articulo[i] = new Articulo();
            }
        }

        public void ListaArt()
        {
            Console.WriteLine("LISTA DE ARTICULOS");
            for (int i = 0; i < articulo.Length; i++)
            {
                Console.WriteLine("Nombre: " + articulo[i].DatoNombre() + " - Valor total en inventario: " + ( articulo[i].DatoPrecio() * articulo[i].DatoStockActual() ) );
            }
        }

        public void MasCaro()
        {
            int mayor = 0;
            string nombre = "asd";

            for(int i = 0; i < articulo.Length; i++)
            {
                if(mayor < articulo[i].DatoPrecio())
                {
                    mayor = articulo[i].DatoPrecio();
                    nombre = articulo[i].DatoNombre();
                }
            }

            Console.WriteLine("El articulo mas caro del local es " + nombre + " con " + mayor);
        }

        public void PocoStock()
        {
            for(int i = 0; i < articulo.Length; i++)
            {
                if (articulo[i].DatoStockActual() <= 5)
                {
                    Console.WriteLine("El articulo " + articulo[i].DatoNombre() + " necesita reposición urgente");
                }
            }
        }

        static void Main(string[] args)
        {
            Sucursal s2 = new Sucursal();
            s2.ListaArt();
            s2.MasCaro();
            s2.PocoStock();
            Console.ReadKey();
        }
    }
}
