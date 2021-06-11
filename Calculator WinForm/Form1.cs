using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        Double value = 0.0;
        string text = "";
        bool operatorpress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumbersClick(object sender, EventArgs e)
        {
            if ((ResultTxtBox.Text == "0") || (operatorpress))
            {
                ResultTxtBox.Clear();
            }
            operatorpress = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!ResultTxtBox.Text.Contains(","))
                {
                    ResultTxtBox.Text = ResultTxtBox.Text + button.Text;
                }
            }
            else
            {
                ResultTxtBox.Text = ResultTxtBox.Text + button.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ResultTxtBox.Text = "0";
        }

        private void oppress(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultTxtBox.Text.EndsWith("*") || ResultTxtBox.Text.EndsWith("-") || ResultTxtBox.Text.EndsWith("/") || ResultTxtBox.Text.EndsWith("+"))
            {
                return;
            }
            if (value != 0)
            {
                value = double.Parse(ResultTxtBox.Text);

                text = button.Text;
                ResultTxtBox.Text += text;
                label1.Text = value + " " + text;
                 operatorpress= true;
            }
            else
            {
                text = button.Text;
                value = double.Parse(ResultTxtBox.Text);
                ResultTxtBox.Text += text;
                label1.Text = value + " " + text;
                operatorpress = true;
            }
        }

        private void op_result(object sender, EventArgs e)
        {
            try
            {
                if (ResultTxtBox.Text.Length <= 7)
                {
                    switch (text)
                    {
                        case "+":
                            {
                                ResultTxtBox.Text = (value + Double.Parse(ResultTxtBox.Text)).ToString();
                                value = 0;

                                break;
                            }
                        case "-":
                            {
                                ResultTxtBox.Text = (value - Double.Parse(ResultTxtBox.Text)).ToString();
                                value = 0;

                                break;
                            }
                        case "/":
                            {
                                if (ResultTxtBox.Text != "0")
                                {
                                    ResultTxtBox.Text = (value / Double.Parse(ResultTxtBox.Text)).ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Can not  divide by zero");
                                }
                                value = 0;
                                break;
                            }
                        case "*":
                            {
                                ResultTxtBox.Text = (value * Double.Parse(ResultTxtBox.Text)).ToString();
                                value = 0;

                                break;
                            }
                        default:
                            {


                                break;
                            }
                    }
                    value = double.Parse(ResultTxtBox.Text);
                    label1.Text = "";
                    operatorpress = false;
                }
                else
                {
                    MessageBox.Show("Number is very High");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ResultTxtBox.Text = "0";
            value = 0;
        }

        private void Btnf_Click(object sender, EventArgs e)
        {


            if (ResultTxtBox.Text.Length > 0)
            {
                ResultTxtBox.Text = ResultTxtBox.Text.Remove(ResultTxtBox.Text.Length - 1, 1);
            }

        }

        private void Btnminus_Click(object sender, EventArgs e)
        {
            if ((double.Parse(ResultTxtBox.Text)) >= 0)
            {
                ResultTxtBox.Text = (System.Math.Abs(double.Parse(ResultTxtBox.Text)) * (-1)).ToString();
            }
            else
            {
                ResultTxtBox.Text = (System.Math.Abs(double.Parse(ResultTxtBox.Text)) * (1)).ToString();

            }
        }
    }
}
