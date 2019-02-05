using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "-")
            {
                result = (firstNumber - secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "*")
            {
                result = (firstNumber * secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Can not divide by zero.";
                }
                else
                {
                    result = (firstNumber + secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }                
            }
        }
    }
}
