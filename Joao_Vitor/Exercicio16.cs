using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joao_Vitor
{
    public partial class Exercicio16 : Form
    {
        public Exercicio16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vel, velms;

            vel= double.Parse(textBox1.Text);
            velms = vel/3.6;

            textBox1.Text = vel.ToString()+"km/h";
            label4.Text= Math.Round(velms, 2).ToString()+"m/s";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
