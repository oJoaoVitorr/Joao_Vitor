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
    public partial class Exercicio17 : Form
    {
        public Exercicio17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Int1, Int2, res, quo;

            Int1= int.Parse(textBox1.Text);
            Int2= int.Parse(textBox2.Text);

            quo = Int1 / Int2;
            res= Int1 % Int2;

            label4.Text = quo.ToString();
            label5.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            label5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
