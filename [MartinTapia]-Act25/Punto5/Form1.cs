using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto5
{
    /*
    5. Solicitar el ingreso de una clave de hasta 10 caracteres en un control de
    tipo TextBox (inicializar la propiedad MaxLength con el valor 10)
    Mostrar en un cuadro de mensajes la clave ingresada al presionar un
    botón. 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}
