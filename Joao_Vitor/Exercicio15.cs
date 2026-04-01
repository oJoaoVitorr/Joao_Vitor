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
    public partial class Exercicio15 : Form
    {
        public Exercicio15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumA, NumB;
            NumA = int.Parse(textBox1.Text);
            NumB = int.Parse(textBox2.Text);

            label4.Text = NumB.ToString()+" "+NumA.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
