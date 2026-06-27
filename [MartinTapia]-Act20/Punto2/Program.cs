using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    Actividad 2: Administración de entregas logísticas
    Problema:
    Una empresa de envíos desea registrar sus entregas mediante colaboración de
    clases.
    Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
    Despachador que contenga una lista de paquetes y un método para registrar nuevos
    paquetes.
    Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
     Todos los paquetes registrados.
     Cuántos superan los 10 kg de peso.
     Cuántos tienen destino nacional (por ejemplo, “Argentina”). 
    */

    internal class Paquete
    {
        protected int codigo;
        protected float peso;
        protected string destino;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public float Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public Paquete(int cod, float pes, string dest)
        {
            codigo = cod;
            peso = pes;
            destino = dest;
        }
    }

    internal class Despachador : Paquete
    {
        public Despachador(int cod, float pes, string dest) : base(cod, pes, dest)
        {
            codigo = cod;
            peso = pes;
            destino = dest;
        }

        List<Paquete> paquetes = new List<Paquete>();

        public void NuevoPaquete()
        {
            Console.Write("Ingrese el codigo del paquete: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso del paquete: ");
            float pes = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el destino del paquete: ");
            string dest = Console.ReadLine();

            Paquete nuevoPaquete = new Paquete(cod, pes, dest);
            paquetes.Add(nuevoPaquete);
        }

        public void ListaPaquetes()
        {
            foreach (Paquete p in paquetes)
            {
                Console.WriteLine("===*===* LISTA DE PAQUETES *===*===");
                Console.WriteLine("Codigo: " + p.Codigo);
                Console.WriteLine("Peso: " + p.Peso);
                Console.WriteLine("Destino: " + p.Destino);
            }
        }

        public void Superan10kg()
        {
            foreach (Paquete p in paquetes)
            {
                if (p.Peso > 10)
                {
                    Console.WriteLine("El paquete " + p.Codigo + " supera los 10 kg, pesa " + p.Peso + "kg ");
                }
            }
        }

        public void DestinoNacional()
        {
            int codigo;
            foreach (Paquete p in paquetes)
            {
                if (p.Destino == "Argentina")
                {
                    codigo = p.Codigo;
                    Console.WriteLine("El paquete " + codigo + " tiene destino Nacional");
                }
            }
        }

        static void Main(string[] args)
        {
            Despachador despa = new Despachador(26, 6, "Argentina");
            for (int i = 0; i < 5; i++)
            {
                despa.NuevoPaquete();
            }
            despa.ListaPaquetes();
            despa.Superan10kg();
            despa.DestinoNacional();
            Console.ReadKey();
        }
    }
}
