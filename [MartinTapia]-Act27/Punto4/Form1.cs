using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    /*
    Actividad 4: Sistema de Opinión sobre un Producto
    Problema:
    Se quiere crear un formulario de opinión para un producto.
    Requisitos:
    ● Un Label debe indicar: "Escribe tu opinión".
    ● Incluir un TextBox grande (multilínea) donde el usuario escriba su comentario.
    ● Dos RadioButton deben permitir seleccionar sí recomiendan el producto: "Sí" o "No".
    ● Al hacer clic en el botón "Enviar", se debe mostrar un Label con el mensaje: "Opinión
    recibida: [texto] – Recomendación: [Sí/No]". 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
            label2.Text = "Opinión recibida: " + textBox1.Text + " - Recomendación: " + radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                label2.Text = "Opinión recibida: " + textBox1.Text + " - Recomendación: " + radioButton2.Text;
            }
        }
    }
}
