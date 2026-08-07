using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*
    4-

    Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
    vinculados a una red hogareña.
     Crear la clase DispositivoInteligente que contenga como atributos
    privados: nombreDispositivo (string) y consumoWatts (double). Definir
    sus propiedades y un constructor que reciba nom y watts.
     Crear la clase colaboradora PanelDomotico que administre un objeto
    List<DispositivoInteligente>.
     Métodos en PanelDomotico:
    1. Un constructor que permita al usuario cargar dinámicamente
    dispositivos por teclado. El sistema preguntará después de cada
    carga si se desea agregar otro dispositivo.
    2. MostrarDispositivos(): Listar todos los dispositivos
    configurados junto a sus consumos.
    3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
    Watts totales que consume la casa sumando los valores de la lista.
    4. DesconectarDispositivo(): Solicitar al usuario el nombre de
    un dispositivo y, si existe en la lista, removerlo de forma dinámica
    para simular su apagado remoto. 
    */

    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            set { nombreDispositivo = value; }
            get { return nombreDispositivo; }
        }
        public double ConsumoWatts
        {
            set {  consumoWatts = value; }
            get { return  consumoWatts; }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            this.nombreDispositivo = nom;
            this.consumoWatts = watts;
        }

    }

    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            bool cargar = true;

            do
            {
                Console.Write("Ingrese el nombre del dispositivo: ");
                string nom = Console.ReadLine();
                Console.Write("Ingrese el consumo de watts: ");
                double watts = double.Parse(Console.ReadLine());

                DispositivoInteligente dispo = new DispositivoInteligente(nom, watts);
                dispositivos.Add(dispo);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("¿Desea cargar otro dispositivo? (Si/No): ");
                Console.ForegroundColor = ConsoleColor.White;

                string ans = Console.ReadLine();

                if(ans == "Si") { cargar = true; } 
                if(ans == "No") { cargar = false; }
            } while (cargar == true);
        }

        public void MostrarDispositivos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine("LISTA DE DISPOSITIVOS");
            Console.WriteLine("==================================");
            foreach (DispositivoInteligente dispo in dispositivos)
            {
                Console.WriteLine("- Nombre: " + dispo.NombreDispositivo);
                Console.WriteLine("- Consumo(Watts): " + dispo.ConsumoWatts + "W");
                Console.WriteLine("-- * -- * --");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CalcularConsumoTotal()
        {
            double consumoTotal = 0;

            foreach(DispositivoInteligente dispo in dispositivos)
            {
                consumoTotal = consumoTotal + dispo.ConsumoWatts;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El consumo total de la casa es de " + consumoTotal + "W.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DesconectarDispositivo()
        {
            string dispositivo;

            // solo funciona respetando las mayusculas, recuerdo que habia una etiqueta de lowercase pero no la recuerdo para usarla en el ejercicio
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Inserte el nombre de un dispositivo para desconectarlo: ");
            Console.ForegroundColor = ConsoleColor.White;
            dispositivo = Console.ReadLine();

            for(int i = 0; i < dispositivos.Count; i++)
            {
                if(dispositivo == dispositivos[i].NombreDispositivo)
                {
                    dispositivos.RemoveAt(i);

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Se ha desconectado el dispositivo..");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PanelDomotico paneldom = new PanelDomotico();
            paneldom.MostrarDispositivos();
            paneldom.CalcularConsumoTotal();
            paneldom.DesconectarDispositivo();
        }
    }
}
