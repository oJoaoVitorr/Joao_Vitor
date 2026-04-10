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
            double HT, VH, PD, SB, SL, TD;

            HT = double.Parse(textBox1.Text);
           VH = double.Parse(textBox2.Text);
            PD = double.Parse(textBox3.Text);

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;
            label7.Text = SB.ToString();
            label6.Text = Math.Round(SL, 2).ToString();
            label9.Text = Math.Round(TD, 2).ToString();

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

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
