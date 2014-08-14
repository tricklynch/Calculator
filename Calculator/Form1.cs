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
        int patrick2;
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
        private void fixerUpper(string patrick)
        {
            label1.Text = patrick + label1.Text;
        }

        private void AdditionClick(object sender, EventArgs e)
        {
            //if (!label1.Text.Last().Equals("+") || !label1.Text.Last().Equals("-") || !label1.Text.Last().Equals("x") || !label1.Text.Last().Equals("/") || !label1.Text.Last().Equals(".")) 
            //{
                updateScreen("+");
            //}
            
        }

        private void SubtractionClick(object sender, EventArgs e)
        {
          //  if ( !label1.Text.Last().Equals("."))
           // {
                updateScreen("-");
          //  }
        }

        private void MultiplicationClick(object sender, EventArgs e)
        {
            /*if (!label1.Text.Last().Equals("+") || !label1.Text.Last().Equals("-") || !label1.Text.Last().Equals("x") || !label1.Text.Last().Equals("/") || !label1.Text.Last().Equals("."))
            {*/
                updateScreen("x");
            //}
        }

        private void DivisionClick(object sender, EventArgs e)
        {
          //  if (!label1.Text.Last().Equals("+") || !label1.Text.Last().Equals("-") || !label1.Text.Last().Equals("x") || !label1.Text.Last().Equals("/") || !label1.Text.Last().Equals("."))
            //{
                updateScreen("/");
            //}
        }

        private void EqualClick(object sender, EventArgs e)
        {
            double firstPart = 0;
            double secondPart = 0;
            while (label1.Text.Contains("+"))
            {
                string input = label1.Text;
                string firstInput = "";
                string secondInput = "";
                int i;
                for (i = 0; i < input.Length; i++)
                {
                    if (!input[i].Equals('+'))
                    {
                        firstInput += input[i];
                    }
                    else
                    {
                        firstPart = (double.Parse(firstInput));
                        break;
                    }
                }
                i++;
                for (; i < input.Length; i++)
                {
                    if (input[i].Equals('+'))
                    {
                        secondPart = (double.Parse(secondInput));
                        break;
                    }
                    else
                    {
                        secondInput += input[i];
                    }
                    secondPart = double.Parse(secondInput);
                }
                label1.Text = label1.Text.Remove(0, firstInput.Length + secondInput.Length + 1);
                input = input.Remove(0, firstInput.Length + secondInput.Length + 1);
                fixerUpper((firstPart + secondPart).ToString());
            }
          
        }

        private void PowerClick(object sender, EventArgs e)
        {
          //  if (!label1.Text.Last().Equals("+") || !label1.Text.Last().Equals("-") || !label1.Text.Last().Equals("x") || !label1.Text.Last().Equals("/") || !label1.Text.Last().Equals("."))
          //  {
                updateScreen("^");
          //  }
        }

        private void RightParenthese(object sender, EventArgs e)
        {
      //      if (!label1.Text.Last().Equals("+") || !label1.Text.Last().Equals("-") || !label1.Text.Last().Equals("x") || !label1.Text.Last().Equals("/") || !label1.Text.Last().Equals("."))
       //     {
                updateScreen(")");
       //     }
        }

        private void LeftParenthese(object sender, EventArgs e)
        {
          // if(!label1.Text.Last().Equals("."))
            //{
            updateScreen("(");
           // }
        }

        private void SQRTClick(object sender, EventArgs e)
        {
            updateScreen("sqrt(");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            updateScreen("cos(");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            updateScreen("tan(");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            updateScreen("sin(");
        }

        private void ClearClick(object sender, EventArgs e)
        {
            clearScreen();
        }
        private void clearScreen()
        {
            label1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            updateScreen("π");
        }
    }
}
