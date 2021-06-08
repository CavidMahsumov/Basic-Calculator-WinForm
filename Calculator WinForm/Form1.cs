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
            if (value != 0)
            {
                Btnequal.PerformClick();
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
            switch (text)
            {
                case "+":
                    {
                        ResultTxtBox.Text = (value + Double.Parse(ResultTxtBox.Text)).ToString();

                        break;
                    }
                case "-":
                    {
                        ResultTxtBox.Text = (value - Double.Parse(ResultTxtBox.Text)).ToString();

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
                            MessageBox.Show("No divide by zero");
                        }
                        break;
                    }
                case "*":
                    {
                        ResultTxtBox.Text = (value * Double.Parse(ResultTxtBox.Text)).ToString();

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
    }
}
