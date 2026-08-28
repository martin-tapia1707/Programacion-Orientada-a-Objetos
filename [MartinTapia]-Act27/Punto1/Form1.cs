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
    Actividad 1: Registro de Usuario Simple
    Problema:
    Se desea crear un formulario para registrar usuarios en un sistema.
    Requisitos:
    ● Mostrar etiquetas (Label) para "Nombre", "Apellido" y "Correo".
    ● Permitir que el usuario escriba los datos en TextBox.
    ● Incluir un botón "Registrar" que, al presionarlo, muestra en un Label un mensaje con
    los datos ingresados concatenados. 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre: " + textBox1.Text + " Apellido: " + textBox2.Text + " Correo electrónico: " + textBox3.Text;
        }
    }
}
