using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class PuntoPlano
    {

        /*
        1. Desarrollar una clase que represente un punto en el plano y tenga los
        siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
        positivas, si x<0 e y>0 segundo cuadrante, etc.) 
        */

        float x, y;

        public void CargarValores()
        {
            Console.WriteLine("Inserta el valor de X: ");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Inserta el valor de Y: ");
            y = float.Parse(Console.ReadLine());
        }

        public void Cuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el Primer Cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el Segundo Cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el Tercer Cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el Cuarto Cuadrante");
            }

        }

        static void Main(string[] args)
        {

            PuntoPlano puntoplano1 = new PuntoPlano();
            puntoplano1.CargarValores();
            puntoplano1.Cuadrante();
            Console.ReadKey();

        }


    }
}
