using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto8
{
    /*
    8. Validador de Credenciales y Formato
    ● Consigna: Solicitar usuario y contraseña mediante TextBox (usando
    UseSystemPasswordChar = true). Un CheckBox "Acepto términos" debe habilitar
    (Enabled = true) el Button "Ingresar". Si la clave coincide con "admin123", mostrar
    éxito en una Label; de lo contrario, mostrar advertencia. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = "admin123";

            if(button1.Enabled = true && textBox2.Text == contraseña)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Inicio de sesión exitoso.";
            }
            if(textBox2.Text != contraseña)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Contraseña incorrecta. Te quedan 3 intentos";
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
