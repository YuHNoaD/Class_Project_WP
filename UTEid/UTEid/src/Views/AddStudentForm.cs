using System.Data;
using System.Data.SqlClient;
using UTEid.src.Services;
using UTEid.src.Utils;

namespace UTEid.src.Views
{
    public partial class AddStudentForm : Form
    {
        private byte[] _selectedPicture = null;

        public AddStudentForm()
        {
            InitializeComponent();
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            dobPicker.Value = new DateTime(2000, 1, 1);
            genderComboBox.SelectedIndex = 0;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string mssvText = mssvTextBox.Text.Trim();
            string fname = fnameTextBox.Text.Trim();
            string lname = lnameTextBox.Text.Trim();
            DateTime dob = dobPicker.Value;
            string gender = genderComboBox.SelectedItem?.ToString() ?? "Nam";
            string phone = phoneTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string hometown = hometownTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(mssvText))
            {
                MessageBox.Show("Vui long nhap MSSV!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mssvTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Vui long nhap Ho va ten dem!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fnameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Vui long nhap Ten!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lnameTextBox.Focus();
                return;
            }
            if (!int.TryParse(mssvText, out int mssv))
            {
                MessageBox.Show("MSSV phai la so nguyen!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mssvTextBox.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(phone) && !System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10,11}$"))
            {
                MessageBox.Show("So dien thoai khong hop le!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTextBox.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(email) && !Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email khong hop le!", "Canh bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                return;
            }

            try
            {
                var db = new DatabaseService();
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("sp_AddStudent", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MSSV", mssv);
                        cmd.Parameters.AddWithValue("@Fname", fname);
                        cmd.Parameters.AddWithValue("@Lname", lname);
                        cmd.Parameters.AddWithValue("@Dob", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address",
                            string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@Hometown",
                            string.IsNullOrEmpty(hometown) ? (object)DBNull.Value : hometown);
                        cmd.Parameters.AddWithValue("@Email",
                            string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@Picture",
                            _selectedPicture != null ? (object)_selectedPicture : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                MessageBox.Show("Them sinh vien thanh cong!", "Thanh cong",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("MSSV da ton tai! Vui long nhap MSSV khac.", "Loi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Loi co so du lieu: " + ex.Message, "Loi he thong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi he thong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowsePictureButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chon anh dai dien";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var image = Image.FromFile(openFileDialog.FileName);
                        pictureBox.Image = image;
                        _selectedPicture = ImageToByteArray(image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Khong the tai anh: " + ex.Message, "Loi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GlassPanel_Paint(object sender, PaintEventArgs e) { }
        private void TitleLabel_Click(object sender, EventArgs e) { }
        private void MssvLabel_Click(object sender, EventArgs e) { }
        private void MssvTextBox_TextChanged(object sender, EventArgs e) { }
        private void FnameLabel_Click(object sender, EventArgs e) { }
        private void FnameTextBox_TextChanged(object sender, EventArgs e) { }
        private void LnameLabel_Click(object sender, EventArgs e) { }
        private void LnameTextBox_TextChanged(object sender, EventArgs e) { }
        private void DobLabel_Click(object sender, EventArgs e) { }
        private void DobPicker_ValueChanged(object sender, EventArgs e) { }
        private void GenderLabel_Click(object sender, EventArgs e) { }
        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void PhoneLabel_Click(object sender, EventArgs e) { }
        private void PhoneTextBox_TextChanged(object sender, EventArgs e) { }
        private void AddressLabel_Click(object sender, EventArgs e) { }
        private void AddressTextBox_TextChanged(object sender, EventArgs e) { }
        private void HometownLabel_Click(object sender, EventArgs e) { }
        private void HometownTextBox_TextChanged(object sender, EventArgs e) { }
        private void EmailLabel_Click(object sender, EventArgs e) { }
        private void EmailTextBox_TextChanged(object sender, EventArgs e) { }
        private void PictureLabel_Click(object sender, EventArgs e) { }
        private void PictureBox_Click(object sender, EventArgs e) { }
    }
}