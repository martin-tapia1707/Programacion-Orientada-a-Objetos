using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto6
{
    /*
    ● Consigna: Disponer tres CheckBox con productos y precios fijos. Un Button
    "Calcular Total" debe evaluar los controles seleccionados (Checked == true), sumar
    sus costos y mostrar el monto final en un Label. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio = 0;
            if(checkBox1.Checked == true) // leche
            {
                precio += 2000;
            }
            if (checkBox2.Checked == true) // agua
            {
                precio += 1400;
            }
            if (checkBox3.Checked == true) // queso rayado
            {
                precio += 2100;
            }

            label1.Text = precio.ToString();
        }
    }
}
