using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _MartinTapia__Act26
{
    internal static class Program
    {
        /*
        1. Disponer tres objetos de la clase CheckBox con nombres de navegadores web.
        Cuando se presione un botón mostrar en el título del Form los programas
        seleccionados. 
        */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
