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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float volume, raio, altura, pi = 3.14159F;
            altura = float.Parse(textBox1.Text);
            raio = float.Parse(textBox2.Text);
            volume = pi * (raio * raio) * altura;

            label4.Text = Math.Round(volume, 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
