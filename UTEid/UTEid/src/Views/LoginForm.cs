using UTEid.src.Services;

namespace UTEid.src.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Glassmorphism effect: semi-transparent white-gray panel
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // 1. Validate empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Tên đăng nhập và mật khẩu không được để trống!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Verify against database
            var auth = new AuthService();
            if (auth.VerifyUser(username, password))
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Login Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu!",
                    "Login Error",
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

        // Navigate to Register form
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                BackColor = this.BackColor
            };

            this.Controls.Add(registerForm);
            registerForm.BringToFront();
            registerForm.Show();
        }

        // Navigate to Forgot Password form
        private void ForgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgotPasswordForm = new ForgotPasswordForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                BackColor = this.BackColor
            };

            this.Controls.Add(forgotPasswordForm);
            forgotPasswordForm.BringToFront();
            forgotPasswordForm.Show();
        }

        // ==============================================================
        // UNUSED EVENT HANDLERS (required by designer)
        // ==============================================================
        private void LogoBox_Click(object sender, EventArgs e) { }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }
        private void GlassPanel_Paint(object sender, PaintEventArgs e) { }
        private void UsernameLabel_Click(object sender, EventArgs e) { }
        private void PasswordLabel_Click(object sender, EventArgs e) { }
    }
}
