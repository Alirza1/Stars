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
        bool startNumber = true;
        string sign = string.Empty;
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                if (startNumber == false)
                {
                    sumLbl.Text += bt.Text;
                }
                else
                {
                    sumLbl.Text = bt.Text;
                    startNumber = false;
                }
            }

        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                Operation(bt.Text);
            }
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(result.Text);
            sumLbl.Text = String.Empty;
            switch (sign)
            {
                case "+":
                    result.Text = Convert.ToString(num1 + num2);
                    break;
                case "*":
                    result.Text = Convert.ToString(num1 * num2);
                    break;
                case "-":
                    result.Text = Convert.ToString(num1 - num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        result.Text = "cannot be divide by 0";
                    }
                    else
                    {
                        result.Text = Convert.ToString(num1 / num2);
                    }
                    break;
            }
            sign = String.Empty;
            startNumber = true;
        }

        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(result.Text);
            sumLbl.Text = result.Text;
            sumLbl.Text += sign;
            this.sign = sign;
            startNumber = true;
        }
    }
}
