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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);

            label4.Text = (num*num).ToString();
            label5.Text = (num*num*num).ToString();
            label6.Text = "o cubo de " + num + " é:";
            label3.Text = "o quadrado de " + num +" é:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text ="";
            textBox1.Text = "";
            label6.Text = "o cubo de x é:";
            label3.Text = "o quadrado de x é:";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
