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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both numbers are mendatory");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);

                int sum = num1 + num2;

                //MessageBox.Show(sum.ToString());
                label4.Text = "Sum is "+sum.ToString();
                label4.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            int sub = num1 - num2;

            //MessageBox.Show(sum.ToString());
            label4.Text = "Subtraction is " + sub.ToString();
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            int mul = num1 * num2;
            //MessageBox.Show(sum.ToString());
            label4.Text = "Multiplication is " + mul.ToString();
            label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            if(num2==0)
            {
                MessageBox.Show("Divide by Zero is not allowed");
            }
            else
            {
                int div = num1 / num2;
                //MessageBox.Show(sum.ToString());
                label4.Text = "Division is " + div.ToString();
                label4.Visible = true;
            }          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            double exp = Math.Pow(num1, num2);
            //MessageBox.Show(sum.ToString());
            label4.Text = "Exponent is " + exp.ToString();
            label4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            int rem = num1 % num2;
            //MessageBox.Show(sum.ToString());
            label4.Text = "Remainder is " + rem.ToString();
            label4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
