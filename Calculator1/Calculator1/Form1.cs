using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button8_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B1.Text;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B2.Text;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B3.Text;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B4.Text;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B5.Text;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B6.Text;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B7.Text;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B8.Text;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B9.Text;
        }

        private void B0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + B0.Text;
        }

        private void BP_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void BMI_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void BDI_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void BEQ_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";
        }

        private void BC_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
