using UTEid.src.Services;

namespace UTEid.src.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            // Glassmorphism effect
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // 1. Validate empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ tất cả thông tin!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Check password match
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Mật khẩu xác nhận không khớp!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var auth = new AuthService();

            try
            {
                // 3. Check duplicate username
                if (auth.CheckUserExists(username))
                {
                    MessageBox.Show(
                        "Tên tài khoản này đã tồn tại!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // 4. Check duplicate email
                if (auth.CheckEmailExists(email))
                {
                    MessageBox.Show(
                        "Email này đã được sử dụng cho tài khoản khác!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // 5. Create user (password is BCrypt-hashed inside CreateUser)
                auth.CreateUser(username, email, password);

                MessageBox.Show(
                    "Đăng ký thành công! Hệ thống đã ghi nhận Email của bạn.",
                    "Chúc mừng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi kết nối: " + ex.Message,
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Toggle password visibility
        private void TogglePasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        // Toggle confirm password visibility
        private void ToggleConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            confirmPasswordTextBox.UseSystemPasswordChar = !confirmPasswordTextBox.UseSystemPasswordChar;
        }

        // Navigate back to login
        private void BackToLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // ==============================================================
        // UNUSED EVENT HANDLERS (required by designer)
        // ==============================================================
        private void GlassPanel_Paint(object sender, PaintEventArgs e) { }
        private void UsernameLabel_Click(object sender, EventArgs e) { }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }
        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
