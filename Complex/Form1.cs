using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex
{
    public partial class Form1 : Form
    {
        private ComplexNumber num1;
        private ComplexNumber num2;

        public Form1()
        {
            InitializeComponent();
            Set1.Click += Set1_Click;
            Set2.Click += Set2_Click;
            add.Click += Add_Click;
            Substract.Click += Substract_Click;
            Multify.Click += Multify_Click;
        }

        private void Set1_Click(object sender, EventArgs e)
        {
            try
            {
                int real = int.Parse(realTB.Text);
                int imaginary = int.Parse(imaginaryTB.Text);
                num1 = new ComplexNumber(real, imaginary);
                statusLabel.Text = $"Number 1 set: {num1}";
            }
            catch
            {
                statusLabel.Text = "Invalid input! Please enter valid numbers.";
            }
        }

        private void Set2_Click(object sender, EventArgs e)
        {
            try
            {
                int real = int.Parse(realTB.Text);
                int imaginary = int.Parse(imaginaryTB.Text);
                num2 = new ComplexNumber(real, imaginary);
                statusLabel.Text = $"Number 2 set: {num2}";
            }
            catch
            {
                statusLabel.Text = "Invalid input! Please enter valid numbers.";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (num1 != null && num2 != null)
            {
                ComplexNumber result = ComplexNumber.Add(num1, num2);
                statusLabel.Text = $"Result: {num1} + {num2} = {result}";
            }
            else
            {
                statusLabel.Text = "Please set both numbers first!";
            }
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            if (num1 != null && num2 != null)
            {
                ComplexNumber result = ComplexNumber.Subtract(num1, num2);
                statusLabel.Text = $"Result: {num1} - {num2} = {result}";
            }
            else
            {
                statusLabel.Text = "Please set both numbers first!";
            }
        }

        private void Multify_Click(object sender, EventArgs e)
        {
            if (num1 != null && num2 != null)
            {
                ComplexNumber result = ComplexNumber.Multiply(num1, num2);
                statusLabel.Text = $"Result: {num1} * {num2} = {result}";
            }
            else
            {
                statusLabel.Text = "Please set both numbers first!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void realTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
