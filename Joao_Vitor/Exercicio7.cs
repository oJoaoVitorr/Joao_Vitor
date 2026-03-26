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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void Exercicio7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double horas, vel, combustivel, distancia;
            horas = double.Parse(textBox1.Text);
            vel = double.Parse(textBox2.Text);

            distancia = horas * vel;
            combustivel = distancia / 12;

            label7.Text= vel.ToString()+"Km/h";
            label6.Text = distancia.ToString()+"km";
            label9.Text = Math.Round(combustivel, 2).ToString()+"L";
            label11.Text = horas.ToString()+"h";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label7.Text = "";
            label6.Text ="";
            label9.Text ="";
            label11.Text ="";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
