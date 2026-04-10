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
    public partial class Exercicio12 : Form
    {
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            soma = num2 + num1;

            label4.Text = (soma).ToString();
            label5.Text = (soma*soma).ToString();
            label6.Text = "O quadrado de " + soma + " é:";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "O quadrado de x é:";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exercicio12_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
