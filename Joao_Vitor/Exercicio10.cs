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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double comp, lar, alt, vol;
            comp= double.Parse(textBox1.Text);
            lar= double.Parse(textBox3.Text);
            alt= double.Parse(textBox2.Text);

            vol = comp* lar * alt;

            label6.Text=vol.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
