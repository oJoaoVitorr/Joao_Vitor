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
    public partial class Exercicio14 : Form
    {
        public Exercicio14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, media;
            num1= int.Parse(textBox1.Text);
            num2= int.Parse(textBox2.Text);
            media = (num1+ num2) / 2;

            label5.Text = "A média entre " + num1 + " e " + num2 + " é:";
            label4.Text = media.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text= "";
            label5.Text = "A média entre A e B é:";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
