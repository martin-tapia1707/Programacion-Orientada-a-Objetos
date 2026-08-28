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
    Actividad 2: Encuesta de Preferencias de Música
    Problema:
    Una aplicación quiere conocer los gustos musicales de los usuarios.
    Requisitos:
    ● Mostrar un ComboBox con 5 géneros musicales distintos.
    ● Incluir tres CheckBox que representen actividades relacionadas (por ejemplo:
    "Escuchar en vivo", "Escuchar en streaming", "Comprar discos").
    ● Al presionar un botón "Mostrar Preferencias", en un Label se debe mostrar el género
    seleccionado y las actividades marcadas. 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(checkBox1.Checked == true)
            {
                label1.Text = "Me gusta el genero " + comboBox1.Text + " y prefiero " + checkBox1.Text; 
            }
            if (checkBox2.Checked == true)
            {
                label1.Text = "Me gusta el genero " + comboBox1.Text + " y prefiero " + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                label1.Text = "Me gusta el genero " + comboBox1.Text + " y prefiero " + checkBox3.Text;
            }
        }
    }
}
