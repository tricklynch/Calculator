using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double store;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateScreen("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateScreen("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateScreen("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateScreen("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateScreen("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateScreen("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateScreen("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateScreen("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateScreen("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateScreen("0");
        }

        private void DecimalClick(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
            {
                updateScreen(".");
            }
        }

        private void BackspaceClick(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
            if (label1.Text.Length == 0)
            {
                label1.Text = "0";
            }
        }

        private void updateScreen(String patrick)
        {
            if (label1.Text.Equals("0") && patrick.Equals("."))
            {
                label1.Text = "0.";
            }
            else if (label1.Text.Equals("0"))
            {
                label1.Text = patrick;
            }
            else
            {
                label1.Text = label1.Text + patrick;
            }
        }

        private void AdditionClick(object sender, EventArgs e)
        {
            updateScreen("+");
        }

        private void SubtractionClick(object sender, EventArgs e)
        {
            updateScreen("-");
        }

        private void MultiplicationClick(object sender, EventArgs e)
        {
            updateScreen("x");
        }

        private void DivisionClick(object sender, EventArgs e)
        {
            updateScreen("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void PowerClick(object sender, EventArgs e)
        {

        }

        private void RightParenthese(object sender, EventArgs e)
        {

        }

        private void LeftParenthese(object sender, EventArgs e)
        {

        }
    }
}
