using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net; // Thư viện băm mật khẩu bạn đang dùng

namespace UTEid
{
    public partial class forgotPasswordForm : Form
    {
        // 1. Biến toàn cục quản lý trạng thái
        private string savedOTP = "";
        private string targetEmail = "";
        private bool isPasswordHidden = true;
        private bool isConfirmPasswordHidden = true;

        // Khởi tạo đối tượng kết nối từ file MY_DB.cs của bạn
        MY_DB db = new MY_DB();

        public forgotPasswordForm()
        {
            InitializeComponent();
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);

            // Vô hiệu hóa Phase 2 & 3 khi vừa load form
            TogglePhase2(false);
            TogglePhase3(false);
        }

        private void forgotPasswordForm_Load(object sender, EventArgs e) { }

        // ========================================================== //
        //                  CÁC NÚT CHỨC NĂNG CHÍNH                   //
        // ========================================================== //

        // BƯỚC 1: GỬI MÃ OTP
        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string inputEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(inputEmail))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email có tồn tại trong bảng log_in không
            if (!CheckEmailInDatabase(inputEmail))
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo OTP 6 số ngẫu nhiên
                Random rand = new Random();
                savedOTP = rand.Next(100000, 999999).ToString();
                targetEmail = inputEmail;

                // Thực hiện gửi Mail
                SendEmail(targetEmail, savedOTP);

                MessageBox.Show("Mã OTP đã được gửi. Vui lòng kiểm tra hộp thư!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TogglePhase2(true); // Mở khóa ô nhập mã
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message, "Lỗi Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BƯỚC 2: XÁC MINH OTP
        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            string inputOTP = txtOTP.Text.Trim();

            if (inputOTP == savedOTP && !string.IsNullOrEmpty(savedOTP))
            {
                MessageBox.Show("Xác minh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TogglePhase2(false); // Khóa lại để bảo mật
                TogglePhase3(true);  // Mở khóa phần đặt mật khẩu mới
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BƯỚC 3: CẬP NHẬT MẬT KHẨU MỚI
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPass.Text;
            string confirm = txtConfirmNewPass.Text;

            if (string.IsNullOrEmpty(newPass) || newPass != confirm)
            {
                MessageBox.Show("Mật khẩu không khớp hoặc đang trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực thi cập nhật Database
            if (UpdatePasswordByEmail(targetEmail, newPass))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Quay về Login
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // ========================================================== //
        //               XỬ LÝ HIỂU ỨNG (UI HELPERS)                  //
        // ========================================================== //

        private void TogglePhase2(bool state)
        {
            txtOTP.Enabled = state;
            btnVerifyOTP.Enabled = state;
        }

        private void TogglePhase3(bool state)
        {
            txtNewPass.Enabled = state;
            txtConfirmNewPass.Enabled = state;
            btnResetPass.Enabled = state;
            picEye.Enabled = state;
            picEye1.Enabled = state;
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;
            txtNewPass.UseSystemPasswordChar = isPasswordHidden;
        }

        private void picEye1_Click(object sender, EventArgs e)
        {
            isConfirmPasswordHidden = !isConfirmPasswordHidden;
            txtConfirmNewPass.UseSystemPasswordChar = isConfirmPasswordHidden;
        }

        // ========================================================== //
        //               TƯƠNG TÁC DATABASE & SMTP                    //
        // ========================================================== //

        private bool CheckEmailInDatabase(string email)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM log_in WHERE email = @Email", db.getConnection());
            command.Parameters.AddWithValue("@Email", email);

            db.openConnection();
            int count = (int)command.ExecuteScalar();
            db.closeConnection();

            return count > 0;
        }

        private bool UpdatePasswordByEmail(string email, string newRawPassword)
        {
            // Băm mật khẩu mới bằng BCrypt tương đương hàm trong MY_DB
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newRawPassword);

            SqlCommand command = new SqlCommand("UPDATE log_in SET password = @Pass WHERE email = @Email", db.getConnection());
            command.Parameters.AddWithValue("@Pass", hashedPassword);
            command.Parameters.AddWithValue("@Email", email);

            db.openConnection();
            int rows = command.ExecuteNonQuery();
            db.closeConnection();

            return rows > 0;
        }

        private void SendEmail(string toEmail, string otpCode)
        {
            string fromEmail = "quangngo01235@gmail.com";
            string appPassword = "oxsuzhxyvptalegx";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(toEmail);
            mail.Subject = "Mã xác nhận đổi mật khẩu - UTEid";
            mail.Body = $"Mã OTP của bạn là: {otpCode}. Vui lòng không chia sẻ mã này.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };

            smtp.Send(mail);
        }

        private void tempPanel_Paint(object sender, PaintEventArgs e) { }
    }
}