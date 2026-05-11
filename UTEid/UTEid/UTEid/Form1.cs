using System.Data.SqlClient;

namespace UTEid
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            // Đã sửa: Alpha 210 để tạo hiệu ứng kính mờ (Glassmorphism), màu nền trắng xám
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // CÁC THIẾT LẬP CƠ BẢN
            txtPassword.UseSystemPasswordChar = true;

            //// ==============================================================
            //// SCRIPT TẠO DỮ LIỆU MẪU (Chỉ chạy 1 lần rồi Xóa/Comment lại)
            //// ==============================================================
            //try
            //{
            //    MY_DB db = new MY_DB();

            //    // TẠO MỚI (Tạo 50 tài khoản chuẩn chỉ)
            //    for (int i = 24110101; i <= 24110150; i++)
            //    {
            //        string mssv = i.ToString();
            //        string defaultPass = "123456";

            //        // Tự động băm mật khẩu
            //        string hashPass = BCrypt.Net.BCrypt.HashPassword(defaultPass);
            //        // Tự động nối chuỗi tạo email
            //        string email = mssv + "@student.hcmute.edu.vn";

            //        // Lệnh Insert đầy đủ 3 cột: username, password, email
            //        SqlCommand cmdInsert = new SqlCommand("INSERT INTO log_in (username, password, email) VALUES (@u, @p, @e)", db.getConnection());
            //        cmdInsert.Parameters.AddWithValue("@u", mssv);
            //        cmdInsert.Parameters.AddWithValue("@p", hashPass);
            //        cmdInsert.Parameters.AddWithValue("@e", email);

            //        db.openConnection();
            //        cmdInsert.ExecuteNonQuery();
            //        db.closeConnection();
            //    }

            //    MessageBox.Show("Đã tạo thành công 50 tài khoản có đầy đủ Email và Hash Password!", "Database Seeding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi trong quá trình tạo data: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // ==============================================================
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu người dùng nhập
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // 2. Lớp phòng thủ 1: Kiểm tra rỗng
            if (user.Trim() == "" || pass.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Khởi tạo đối tượng từ file MY_DB.cs
            MY_DB db = new MY_DB();

            // 4. Gọi hàm VerifyUser để kiểm tra đối chiếu với SQL Server
            if (db.VerifyUser(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công! Sẵn sàng vào Main Menu.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==============================================================
        // CÁC SỰ KIỆN GIAO DIỆN
        // ==============================================================

        private void logoBox_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void tempPanel_Paint(object sender, PaintEventArgs e) { }
        private void userLabel_Click(object sender, EventArgs e) { }
        private void passLabel_Click(object sender, EventArgs e) { }

        private void picEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.TopLevel = false;
            regForm.FormBorderStyle = FormBorderStyle.None;
            regForm.Dock = DockStyle.Fill;
            regForm.BackColor = this.BackColor;

            this.Controls.Add(regForm);
            regForm.BringToFront();
            regForm.Show();
        }

        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPasswordForm forgotForm = new forgotPasswordForm();
            forgotForm.TopLevel = false;
            forgotForm.FormBorderStyle = FormBorderStyle.None;
            forgotForm.Dock = DockStyle.Fill;
            forgotForm.BackColor = this.BackColor;

            this.Controls.Add(forgotForm);
            forgotForm.BringToFront();
            forgotForm.Show();
        }
    }
}