using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumber
{
    public partial class Form1 : Form
    {
        ComplexNumber x = new ComplexNumber();
        ComplexNumber y = new ComplexNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {

            x.Real = Int32.Parse(realTextBox.Text);
            x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "First Complex Number is: " + x;
        }
        private void secondButton_Click_1(object sender, EventArgs e)
        {
            // Lưu giá trị vào biến y thay vì x
            y.Real = Int32.Parse(realTextBox.Text);
            y.Imaginary = Int32.Parse(imaginaryTextBox.Text);

            // Xóa ô nhập và thông báo
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "Second Complex Number is: " + y;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + " + " + y + " = " + (x + y);
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + " - " + y + " = " + (x - y);
        }

        private void mutiplyButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + " * " + y + " = " + (x * y);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
