using Punto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*
    1.
    Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
    CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
    generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
    generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
    imprimir estos datos básicos.
    Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
    un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
    en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
    Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
    En el programa principal (Main):
    ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
    ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
    puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
    muestra de información.
    */

    public class DispositivoEnergia
    {
        private string CodigoIdentificador;
        private double GeneracionKwh;


        public string CodIdentificador
        {
            set
            {
                CodigoIdentificador = value;
            }
            get
            {
                return CodigoIdentificador;
            }
        }

        public double GenKilowatts
        {
            set
            {
                if (value > 0)
                {
                    GeneracionKwh = value;
                }
                else
                {
                    GeneracionKwh = 0;
                }
            }
            get
            {
                return GeneracionKwh;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Codigo Identificador: " + CodIdentificador);
            Console.WriteLine("Generacion Kilowatts-hora: " + GenKilowatts);
        }

    }

    public class PanelSolar : DispositivoEnergia
    {

        private double AreaMetros;

        public double AreaMts
        {
            set
            {
                if (value > 0)
                {
                    AreaMetros = value;
                }
                else
                {
                    Console.Write("El valor tiene que ser mayor a 0");
                }
            }
            get
            {
                return AreaMetros;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Codigo Identificador: " + CodIdentificador);
            Console.WriteLine("Generacion Kilowatts-hora: " + GenKilowatts);
            Console.WriteLine("Area en Metros cuadrados " + AreaMts);
        }

        public static void Main(string[] args)
        {
            DispositivoEnergia ds2 = new DispositivoEnergia();
            Console.WriteLine("<--=-- Objeto DispositivoEnergia --=-->");
            ds2.CodIdentificador = "1234";
            ds2.GenKilowatts = 10;
            ds2.Imprimir();

            PanelSolar panel2 = new PanelSolar();
            Console.Write("Ingrese un codigo identificador: ");
            panel2.CodIdentificador = Console.ReadLine();
            Console.Write("Ingrese la generacion Kw/h: ");
            panel2.GenKilowatts = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el area en metros: ");
            panel2.AreaMts = double.Parse(Console.ReadLine());

            Console.WriteLine("<--=-- Objeto PanelSolar --=-->");
            panel2.Imprimir();

            Console.ReadKey();
        }
    }
}
