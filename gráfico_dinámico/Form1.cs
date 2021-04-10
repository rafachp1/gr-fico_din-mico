using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gráfico_dinámico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }





        graficar obj_graficar  = new graficar();
        private void timer1_Tick(object sender, EventArgs e)
        {
            obj_graficar.p_x_set(int.Parse(textBox1.Text));
            obj_graficar.grafica(chart1);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
