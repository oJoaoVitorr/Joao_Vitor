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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1(); //cria uma instancia de objeto para o Exercicio1
            ex1.FormClosed += (s, args) => this.Show(); //Adiciona um evento para mostrar o Form1 novamente quando o Exercicio1 for fechado
            this.Hide();
            ex1.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2(); 
            ex2.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio3 ex3 = new Exercicio3();
            ex3.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercicio4 ex4 = new Exercicio4();
            ex4.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exercicio5 ex5 = new Exercicio5();
            ex5.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exercicio6 ex6 = new Exercicio6();
            ex6.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exercicio7 ex7 = new Exercicio7();
            ex7.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exercicio8 ex8 = new Exercicio8();
            ex8.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Exercicio9 ex9 = new Exercicio9();
            ex9.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Exercicio10 ex10 = new Exercicio10();
            ex10.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Exercicio11 ex11 = new Exercicio11();
            ex11.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Exercicio12 ex12 = new Exercicio12();
            ex12.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Exercicio13 ex13 = new Exercicio13();
            ex13.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex13.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Exercicio14 ex14 = new Exercicio14();
            ex14.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex14.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Exercicio15 ex15 = new Exercicio15();
            ex15.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex15.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Exercicio16 ex16 = new Exercicio16();
            ex16.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex16.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Exercicio17 ex17 = new Exercicio17();
            ex17.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex17.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Exercicio18 ex18 = new Exercicio18();
            ex18.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex18.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Exercicio19 ex19 = new Exercicio19();
            ex19.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex19.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Exercicio20 ex20 = new Exercicio20();
            ex20.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex20.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Exercicio21 ex21 = new Exercicio21();
            ex21.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex21.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
