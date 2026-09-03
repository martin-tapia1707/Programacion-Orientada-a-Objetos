using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{

    /*
    1. Calculadora de Promedio de Notas
    ● Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button
    &quot;Calcular&quot;. Convertir los valores con int.Parse() o double.Parse() y mostrar en una
    Label el promedio. Si la nota es mayor o igual a 6, cambiar el color del texto de la
    etiqueta a verde; de lo contrario, a rojo. 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prom;

            if(double.Parse(textBox1.Text) > 10 || double.Parse(textBox2.Text) > 10 || double.Parse(textBox3.Text) > 10)
            {
                MessageBox.Show("Inserte valores validos (1-10) para poder promediar correctamente");
            } else
            {
                prom = ( double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) );
                prom = prom / 3;

                if(prom >= 6)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "Aprobado: " + prom;
                } else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Reprobado: " + prom;
                }
            }

        }
    }
}
