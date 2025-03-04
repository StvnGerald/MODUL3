using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODUL3
{
    public partial class Form1 : Form
    {
        int Temp;
        int hasil;
        string input;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = button1.Text;
            textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = button2.Text;
            textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = button3.Text;
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = button4.Text;
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = button5.Text;
            textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = button6.Text;
            textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string input = button7.Text;
            textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = button8.Text;
            textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = button9.Text;
            textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string input = button10.Text;
            textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Temp = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int hasil = int.Parse(textBox1.Text) + Temp;
            string hasil2 = hasil.ToString();
            textBox1.Text = hasil2;
            textBox1.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
