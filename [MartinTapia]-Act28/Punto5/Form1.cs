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
                pictureBox1.ImageLocation = "https://s1.significados.com/foto/arbol-og.jpg";
            }

            if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxJQVHkHJkf5sK8En-Gt1QuX97oO-jF9oYf5Y2WWIFbw&s=10";
            }

            if (comboBox1.SelectedIndex == 2) 
            {
                pictureBox1.ImageLocation = "https://cdn0.ecologiaverde.com/es/posts/3/2/3/que_es_una_jungla_7323_2_600.jpg";
            }
        }
    }
}
