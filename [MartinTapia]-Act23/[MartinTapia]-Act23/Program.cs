using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MartinTapia__Act23
{

    /*

    1-
    En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
    llegada.
     Crear la clase Documento que contenga como atributos privados:
    nombreArchivo (string) y cantidadPaginas (int). Definir sus
    propiedades de solo lectura y un constructor que reciba los parámetros nom
    y pag.
     Crear la clase ServidorImpresion que administre una lista dinámica de
    documentos (List<Documento>).
     Métodos en ServidorImpresion:
    1. AgregarDocumento(): Solicitar por teclado los datos de un
    documento y agregarlo al final de la lista utilizando .Add().
    2. ImprimirSiguiente(): Si la lista no está vacía, simular la
    impresión del primer documento de la lista (mostrar sus datos en
    consola) y removerlo de la colección mediante .RemoveAt(0). Si está
    vacía, advertir que no hay trabajos pendientes.
    3. MostrarColaPendiente(): Listar todos los documentos que
    están esperando ser impresos y la cantidad total de páginas
    acumuladas en la cola de espera utilizando .Count.

    */

    internal class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            set { nombreArchivo = value; }
            get { return nombreArchivo; }
        }

        public int CantidadPaginas
        {
            set { cantidadPaginas = value; }
            get { return cantidadPaginas; }
        }

        public Documento(string nom, int pag)
        {
            this.nombreArchivo = nom;
            this.cantidadPaginas = pag;
        }

    }

    internal class ServidorImpresion
    {
        List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            Console.Write("Ingresar el nombre del archivo: ");
            string nomarch = Console.ReadLine();
            Console.Write("Ingresar la cantidad de paginas: ");
            int cantpag = int.Parse(Console.ReadLine());

            Documento datosDocumento = new Documento(nomarch, cantpag);
            documentos.Add(datosDocumento);
        }

        public void ImprimirSiguiente()
        {
            for (int i = 0; i < documentos.Count; i++)
            {
                if (documentos.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Imprimiendo archivo");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("====================================");
                    Console.WriteLine("Nombre del Archivo: " + documentos[0]);
                    Console.WriteLine("Cantidad Paginas: " + documentos[0]);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("¡Archivo impreso!");

                    documentos.RemoveAt(0);
                }

                else if (documentos.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No hay trabajos pendientes");
                }
            }
        }

        public void MostrarColaPendiente()
        {
            Console.WriteLine("Documentos en fila para imprimir..");

            for (int i = 0; i < documentos.Count; i++)
            {
                if (documentos.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("====================================");
                    Console.WriteLine("Nombre del Archivo: " + documentos[i]);
                    Console.WriteLine("Cantidad Paginas: " + documentos[i]);
                }
                else if (documentos.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No hay archivos en fila para imprimir");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ServidorImpresion svImp = new ServidorImpresion();
            svImp.AgregarDocumento();
            svImp.ImprimirSiguiente();
            svImp.MostrarColaPendiente();
        }
    }
}
