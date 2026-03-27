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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
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
            label16.Text = (a+d).ToString();
            label17.Text = (b+c).ToString();
            label18.Text = (b+d).ToString();
            label19.Text = (c+d).ToString();
            label20.Text = (a*b).ToString();
            label21.Text = (a*c).ToString();
            label22.Text = (a*d).ToString();
            label23.Text = (b*c).ToString();
            label24.Text = (b*d).ToString();
            label25.Text = (c*d).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
