using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        double total1=0;
        double total2 = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

             plus = true;
             minus = false;
             multi = false;
             divide = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                total2 = total1 + double.Parse(textBox1.Text);
            }
           
            else if(minus==true)
            {
                total2 = total1 - double.Parse(textBox1.Text);
            }

            else if (divide == true)
            {
                total2 = total1 / double.Parse(textBox1.Text);
            }

            else if (multi == true)
            {
                total2 = total1 * double.Parse(textBox1.Text);
            }

            textBox1.Text = total2.ToString();
            total1 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }

        bool plus = false;
        bool minus = false;
        bool multi = false;
        bool divide = false;

        private void button15_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();
            plus = false;
            minus = true;
            multi = false;
            divide = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            plus = false;
            minus = false;
            multi = true;
            divide = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();

            plus = false;
            minus = false;
            multi = false;
            divide = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        
    }
}
