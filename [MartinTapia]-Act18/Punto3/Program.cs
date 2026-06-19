using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*
    3. Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
    AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
    realice su asignación.
    Luego, definir dos clases derivadas de la clase base:
    ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    soportada en atmósferas).
    ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
    tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    clase SondaExploradora mediante el uso explícito de la palabra clave base.
    En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    parámetros unificados por consola. 
    */
    internal class SondaExploradora
    {
        protected string Modelo;
        protected int AutonomiaMinutos;

        public SondaExploradora(string model, int autminutos)
        {
            Modelo = model;
            AutonomiaMinutos = autminutos;
        }


    }
    internal class SondaSubmarina : SondaExploradora
    {
        protected int PresionMaximaAtm;

        public SondaSubmarina(string model, int autminutos, int presionmaxima) : base (model, autminutos)
        {
            PresionMaximaAtm = presionmaxima;
            Console.WriteLine("La sonda submarina " + model + " tiene una autonomia en minutos de " + autminutos + " y una presion maxima soportada en atmosferas de " + presionmaxima);
        }
    }

    internal class RoverTerrestre : SondaExploradora
    {
        protected int CantidadRuedas;

        public RoverTerrestre(string model, int autminutos, int cantruedas) : base (model, autminutos)
        {
            CantidadRuedas = cantruedas;
            Console.WriteLine("El rover terrestre " + model + " tiene una autonomia en minutos de " + autminutos + " y una cantidad de ruedas de " + cantruedas);
        }

        static void Main(string[] args)
        {
            SondaSubmarina ssm2 = new SondaSubmarina("Triton660/9 AVA", 720, 20);
            RoverTerrestre rt2 = new RoverTerrestre("Ascento", 90, 4);
            Console.ReadKey();
        }
    }
}
