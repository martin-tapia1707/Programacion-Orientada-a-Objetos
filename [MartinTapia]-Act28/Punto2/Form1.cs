using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    /*
    2. Conversor de Temperatura
    ● Consigna: Disponer un TextBox para el ingreso numérico y dos RadioButton:
    "Celsius a Fahrenheit" y "Fahrenheit a Celsius". Al presionar un Button, realizar la
    fórmula correspondiente y mostrar el resultado en un Label.     
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(textBox1.Text);
            double celsius;
            double fahrenheit;

            if(radioButton1.Checked)
            {
                celsius = (temperatura * 9 / 5) + 32;
                label1.Text = "Temperatura: " + celsius;
            } else
            {
                fahrenheit = (temperatura - 32) * 5 / 9;
                label1.Text = "Temperatura: " + fahrenheit;
            }

        }
    }
}
