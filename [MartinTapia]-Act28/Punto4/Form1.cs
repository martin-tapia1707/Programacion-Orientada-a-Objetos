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
        Consigna: Crear un mini-juego donde un Button cuente cuántos clics realiza el
        usuario en 10 segundos. Al finalizar el tiempo mediante el Timer, deshabilitar el
        botón (Enabled = false) y mostrar el puntaje acumulado en un MessageBox.Show.
    */
    public partial class Form1 : Form
    {
        int contadorClicks;
        int inicio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio++; // evito 100 messageboxs al final

            if(inicio == 1)
            {
                timer1.Interval = 10000;
                timer1.Enabled = true;

                timer1.Tick += timer1_Tick;
            }

            contadorClicks++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Puntaje final: " + contadorClicks);

            inicio = 0; // se reinicia
        }
    }
}
