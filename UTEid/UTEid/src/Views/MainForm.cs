using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTEid.src.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void FilterGuna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // Tạo một bản sao (instance) của Form AddStudentForm
            AddStudentForm fAdd = new AddStudentForm();

            // Hiển thị Form dưới dạng hộp thoại (người dùng phải đóng mới quay lại Form chính được)
            fAdd.ShowDialog();
        }
    }
}
