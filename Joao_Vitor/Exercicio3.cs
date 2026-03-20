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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hora, valorhora, desconto, bruto, liquido, resdesconto;

            hora = double.Parse(textBox1.Text);
            valorhora = double.Parse(textBox2.Text);
            desconto = double.Parse(textBox3.Text);

            bruto = hora * valorhora;
            resdesconto = (desconto / 100) * bruto;
            liquido = bruto - resdesconto;
            label7.Text = bruto.ToString();
            label6.Text = Math.Round(liquido, 2).ToString();
            label9.Text = Math.Round(resdesconto, 2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label7.Text = "";
            label6.Text = "";
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
