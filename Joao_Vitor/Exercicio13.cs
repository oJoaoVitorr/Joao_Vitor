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
    public partial class Exercicio13 : Form
    {
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            soma = (num2*num2) + (num1*num1);

            label4.Text = (num1*num1).ToString();
            label5.Text = (num2 * num2).ToString();
            label8.Text = soma.ToString();
            label3.Text = "O quadrado de " + num1 + " é:";
            label6.Text = "O quadrado de " + num2 +" é:";
            label9.Text = "A soma de " + num1 * num1 + " e " + num2 * num2 + " é:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label8.Text = "";
            label6.Text = "O quadrado de B é:";
            label3.Text = "O quadrado de A é:";
            label9.Text = "A soma de x e y é:";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
