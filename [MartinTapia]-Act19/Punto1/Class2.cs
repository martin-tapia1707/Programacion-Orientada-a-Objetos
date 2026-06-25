using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        public int TotalCliente()
        {
            int precio = 0;

            if(TipoHabitacion == "Simple")
            {
                precio = 5000;
            }
            if(TipoHabitacion == "Doble")
            {
                precio = 8000;
            }
            if(TipoHabitacion == "Suite")
            {
                precio = 12000;
            }

            int total = 0;

            total = (precio * CantidadNoches);

            return total;
        }
    }
}
