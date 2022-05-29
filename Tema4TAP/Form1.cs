using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        double firstdigit;
        string abbb;
        bool isoptr = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if(textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
            //textBox.Text = button.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int index = textBox.Text.Length;
            index--;
            textBox.Text = textBox.Text.Remove(index);
            if(textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = result * -1;
            textBox.Text = result.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            switch (abbb)
            {
                case "+":
                    textBox.Text = (firstdigit + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (firstdigit - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (firstdigit * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (firstdigit / double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Log10(result);
            textBox.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Sqrt(result);
            textBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Sinh(result);
            textBox.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Cosh(result);
            textBox.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Tanh(result);
            textBox.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Sin(result);
            textBox.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Cos(result);
            textBox.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Tan(result);
            textBox.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            result = Math.PI;
            textBox.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Exp(result);
            textBox.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Pow(result,2);
            textBox.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = 1/result;
            textBox.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Pow(result, 3);
            textBox.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = (firstdigit % double.Parse(textBox.Text));
            textBox.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Log(result);
            textBox.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = result / 100;
            textBox.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Ceiling(result);
            textBox.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox.Text);
            result = Math.Floor(result);
            textBox.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
