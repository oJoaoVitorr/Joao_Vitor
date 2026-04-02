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
    public partial class Exercicio18 : Form
    {
        public Exercicio18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bruto, liquido, imp, ps, nbruto;

            bruto = double.Parse(textBox1.Text);
            ps = bruto * 0.10;
            nbruto = bruto - ps;
            imp = nbruto * 0.05;

            liquido = bruto - imp - ps;

            label7.Text= Math.Round(ps, 2).ToString();
            label4.Text= Math.Round(liquido, 2).ToString();
            label5.Text= Math.Round(imp, 2).ToString();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label4.Text = string.Empty;
            label7.Text = string.Empty;
            label5.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
