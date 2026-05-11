using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UTEid
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            //tempPanel.BackColor = Color.FromArgb(0, 255, 255, 255);
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            // Mặc định giấu mật khẩu khi mở form đăng ký
            txtRegPass.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtRegUser.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            string pass = txtRegPass.Text;
            string confirmPass = txtConfirmPass.Text;

            // 1. Kiểm tra rỗng tất cả các trường
            if (user == "" || email == "" || pass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra khớp mật khẩu
            if (pass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MY_DB db = new MY_DB();

            try
            {
                // 3. Kiểm tra trùng Username
                if (db.CheckUserExists(user))
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Kiểm tra trùng Email
                if (db.CheckEmailExists(email))
                {
                    MessageBox.Show("Email này đã được sử dụng cho tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 5. Lưu xuống Database (đã có băm mật khẩu trong CreateUser)
                db.CreateUser(user, email, pass);

                MessageBox.Show("Đăng ký thành công! Hệ thống đã ghi nhận Email của bạn.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Quay về Login
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đảo trạng thái con mắt ở ô Mật khẩu
        private void picEye_Click(object sender, EventArgs e)
        {
            txtRegPass.UseSystemPasswordChar = !txtRegPass.UseSystemPasswordChar;
        }

        // Đảo trạng thái con mắt ở ô Nhập lại mật khẩu
        private void picEye1_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = !txtConfirmPass.UseSystemPasswordChar;
        }

        
       
        // ==========================================
        // CÁC HÀM KHÔNG SỬ DỤNG THÌ CỨ ĐỂ TRỐNG
        // ==========================================
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void usernameLabel_Click(object sender, EventArgs e) { }
        private void txtRegUser_TextChanged(object sender, EventArgs e) { }
        private void txtRegPass_TextChanged(object sender, EventArgs e) { }
        private void txtConfirmPass_TextChanged(object sender, EventArgs e) { }

        // Nút quay lại thủ công (Nếu người dùng đổi ý không muốn đăng ký nữa)
        private void linkBackToLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}