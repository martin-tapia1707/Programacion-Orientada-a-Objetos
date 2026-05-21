using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Plantear una clase Club y otra clase Socio.
    La clase Socio debe tener los siguientes atributos privados: nombre y la
    antigüedad en el club (en años). En el constructor pedir la carga del nombre y
    su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
    Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
    antigüedad en el club. 
    */
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Cargar el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write("Cargar antigüedad en años del socio: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public string RetornarNombre()
        {
            return nombre;
        }

        public int RetornarAnt()
        {
            return antiguedad;
        }


    }

    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void Responsabilidad()
        {
            if (socio1.RetornarAnt() > socio2.RetornarAnt() && socio1.RetornarAnt() > socio3.RetornarAnt())
            {
                Console.WriteLine("Nombre del socio mas antiguo " + socio1.RetornarNombre());
            }
            if(socio2.RetornarAnt() > socio1.RetornarAnt() && socio2.RetornarAnt() > socio3.RetornarAnt())
            {
                Console.WriteLine("Nombre del socio mas antiguo " + socio2.RetornarNombre());
            }
            if(socio3.RetornarAnt() > socio1.RetornarAnt() && socio3.RetornarAnt() > socio2.RetornarAnt())
            {
                Console.WriteLine("Nombre del socio mas antiguo " + socio3.RetornarNombre());
            }

        }

        static void Main(string[] args)
        {
            Club c2 = new Club();
            c2.Responsabilidad();
            Console.ReadKey();
        }
    }
}
