using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                pictureBox1.ImageLocation = "C:\\Users\\alumno.ET26\\Downloads\\/arbol.jpg";
            }

            if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox1.ImageLocation = "C:\\Users\\alumno.ET26\\Downloads\\/desierto.jpg";
            }

            if (comboBox1.SelectedIndex == 2) 
            {
                pictureBox1.ImageLocation = "C:\\Users\\alumno.ET26\\Downloads\\/jungla.jpg";
            }
        }
    }
}
