﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimlpeCalculator
{
    public partial class Form1 : Form

    {
        double num1, num2, result;
        char op;
    
        public Form1()
        {
          
            InitializeComponent();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = '/';
            textBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = '*';
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (op)
            {

                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel= true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }
    }
}
