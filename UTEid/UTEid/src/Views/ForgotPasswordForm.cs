using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using UTEid.src.Services;

namespace UTEid.src.Views
{
    public partial class ForgotPasswordForm : Form
    {
        private string _generatedOtp = string.Empty;
        private string _targetEmail = string.Empty;
        private bool _isNewPasswordHidden = true;
        private bool _isConfirmPasswordHidden = true;

        private readonly DatabaseService _database = new DatabaseService();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);

            // Disable OTP and reset phases on load
            SetOtpFieldsEnabled(false);
            SetNewPasswordFieldsEnabled(false);
        }

        // ========================================================== //
        //                  MAIN FUNCTIONALITY                        //
        // ========================================================== //

        // STEP 1: Send OTP code to email
        private void SendOtpButton_Click(object sender, EventArgs e)
        {
            string inputEmail = emailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(inputEmail))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsEmailRegistered(inputEmail))
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var random = new Random();
                _generatedOtp = random.Next(100000, 999999).ToString();
                _targetEmail = inputEmail;

                SendOtpEmail(_targetEmail, _generatedOtp);

                MessageBox.Show("Mã OTP đã được gửi. Vui lòng kiểm tra hộp thư!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetOtpFieldsEnabled(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message, "Lỗi Server",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // STEP 2: Verify OTP
        private void VerifyOtpButton_Click(object sender, EventArgs e)
        {
            string inputOtp = otpTextBox.Text.Trim();

            if (inputOtp == _generatedOtp && !string.IsNullOrEmpty(_generatedOtp))
            {
                MessageBox.Show("Xác minh thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetOtpFieldsEnabled(false);
                SetNewPasswordFieldsEnabled(true);
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // STEP 3: Reset password
        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmNewPasswordTextBox.Text;

            if (string.IsNullOrEmpty(newPassword) || newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp hoặc đang trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UpdatePasswordByEmail(_targetEmail, newPassword))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Chúc mừng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // ========================================================== //
        //               UI HELPERS                                   //
        // ========================================================== //

        private void SetOtpFieldsEnabled(bool enabled)
        {
            otpTextBox.Enabled = enabled;
            verifyOtpButton.Enabled = enabled;
        }

        private void SetNewPasswordFieldsEnabled(bool enabled)
        {
            newPasswordTextBox.Enabled = enabled;
            confirmNewPasswordTextBox.Enabled = enabled;
            resetPasswordButton.Enabled = enabled;
            toggleNewPasswordButton.Enabled = enabled;
            toggleConfirmPasswordButton.Enabled = enabled;
        }

        private void ToggleNewPasswordButton_Click(object sender, EventArgs e)
        {
            _isNewPasswordHidden = !_isNewPasswordHidden;
            newPasswordTextBox.UseSystemPasswordChar = _isNewPasswordHidden;
        }

        private void ToggleConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            _isConfirmPasswordHidden = !_isConfirmPasswordHidden;
            confirmNewPasswordTextBox.UseSystemPasswordChar = _isConfirmPasswordHidden;
        }

        // ========================================================== //
        //               DATABASE & EMAIL HELPERS                     //
        // ========================================================== //

        private bool IsEmailRegistered(string email)
        {
            var query = "SELECT COUNT(*) FROM log_in WHERE email = @Email";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Email", email);

            _database.OpenConnection();
            int count = (int)command.ExecuteScalar()!;
            _database.CloseConnection();

            return count > 0;
        }

        private bool UpdatePasswordByEmail(string email, string newRawPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newRawPassword);

            var query = "UPDATE log_in SET password = @PasswordHash WHERE email = @Email";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
            command.Parameters.AddWithValue("@Email", email);

            _database.OpenConnection();
            int rowsAffected = command.ExecuteNonQuery();
            _database.CloseConnection();

            return rowsAffected > 0;
        }

        private static void SendOtpEmail(string toEmail, string otpCode)
        {
            const string fromEmail = "quangngo01235@gmail.com";
            const string appPassword = "oxsuzhxyvptalegx";

            var mail = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = "Mã xác nhận đổi mật khẩu - UTEid",
                Body = $"Mã OTP của bạn là: {otpCode}. Vui lòng không chia sẻ mã này."
            };
            mail.To.Add(toEmail);

            using var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };

            smtpClient.Send(mail);
        }

        // ==============================================================
        // UNUSED EVENT HANDLERS (required by designer)
        // ==============================================================
        private void ForgotPasswordForm_Load(object sender, EventArgs e) { }
        private void GlassPanel_Paint(object sender, PaintEventArgs e) { }
    }
}
