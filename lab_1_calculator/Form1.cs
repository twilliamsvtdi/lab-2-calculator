using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty())
            {
                var num1 = int.Parse(tbNum1.Text);
                var num2 = int.Parse(tbNum2.Text);
                tbResult.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("Please that all values are valid!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty())
            {
                var num1 = int.Parse(tbNum1.Text);
                var num2 = int.Parse(tbNum2.Text);
                tbResult.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("Please that all values are valid!");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty())
            {
                var num1 = int.Parse(tbNum1.Text);
                var num2 = int.Parse(tbNum2.Text);
                tbResult.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("Please that all values are valid!");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isDivisorZero())
            {
                var num1 = int.Parse(tbNum1.Text);
                var num2 = int.Parse(tbNum2.Text);
                tbResult.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("Please that all values are valid!");
            }
        }

        bool isTextboxEmpty()
        {
            return String.IsNullOrEmpty(tbNum1.Text) || 
                String.IsNullOrEmpty(tbNum1.Text);
        }

        bool isDivisorZero()
        {
            return int.Parse(tbNum2.Text) == 0;
        }
    }
}
