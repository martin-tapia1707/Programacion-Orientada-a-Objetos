using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
    2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
    métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
    */
    internal class Cuadrado
    {

    float lado, perimetro, superficie;
    string valor;

        public void CargarValor()
        {
            Console.WriteLine("Cargar el valor del lado del cuadrado: ");
            valor = Console.ReadLine();
            lado = float.Parse(valor);
        }

        public void Perimetro()
        {
            perimetro = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
        }

        public void Superficie()
        {
            superficie = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: " + superficie);
        }

        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.CargarValor();
            cuadrado1.Perimetro();
            cuadrado1.Superficie();
            Console.ReadKey();
        }
    }
}
