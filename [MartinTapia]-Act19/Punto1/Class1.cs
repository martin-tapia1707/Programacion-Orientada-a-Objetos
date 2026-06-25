using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        private string nombrecliente;

        public string NombreCliente
        {
            set
            {
                nombrecliente = value;
            }
            get
            {
                return nombrecliente;
            }
        }

        private int cantidadnoches;

        public int CantidadNoches
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Minimo 1 noche");
                } else
                {
                    cantidadnoches = value;
                }
            }
            get
            {
                return cantidadnoches;
            }
        }

        private string tipohabitacion;

        public string TipoHabitacion
        {
            set
            {
                tipohabitacion = value;
            }
            get
            {
                return tipohabitacion;
            }
        }

        public ReservaHotel()
        {
            Console.Write("Nombre del cliente: ");
            NombreCliente = Console.ReadLine();
            Console.Write("Cantidad de noches?: ");
            CantidadNoches = int.Parse(Console.ReadLine());
            Console.Write("Tipo de habitacion? (Simple, Doble, Suite) : ");
            TipoHabitacion = Console.ReadLine();
        }

    }
}
