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
    public partial class Exercicio9cs : Form
    {
        public Exercicio9cs()
        {
            InitializeComponent();
        }

        private void Exercicio9cs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a= double.Parse(textBox1.Text);
            b= double.Parse(textBox2.Text);
            c= double.Parse(textBox3.Text);
            d= double.Parse(textBox4.Text);

            label14.Text = (a+b).ToString();
            label15.Text = (a+c).ToString();
        }
    }
}
