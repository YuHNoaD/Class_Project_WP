namespace UTEid.src.Views
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            glassPanel = new Panel();
            cancelButton = new Button();
            addButton = new Button();
            browsePictureButton = new Button();
            pictureBox = new PictureBox();
            pictureLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            hometownTextBox = new TextBox();
            hometownLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            genderComboBox = new ComboBox();
            genderLabel = new Label();
            dobPicker = new DateTimePicker();
            dobLabel = new Label();
            lnameTextBox = new TextBox();
            lnameLabel = new Label();
            fnameTextBox = new TextBox();
            fnameLabel = new Label();
            mssvTextBox = new TextBox();
            mssvLabel = new Label();
            titleLabel = new Label();
            glassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // glassPanel
            // 
            glassPanel.Anchor = AnchorStyles.None;
            glassPanel.AutoScroll = true;
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            glassPanel.BorderStyle = BorderStyle.FixedSingle;
            glassPanel.Controls.Add(cancelButton);
            glassPanel.Controls.Add(addButton);
            glassPanel.Controls.Add(browsePictureButton);
            glassPanel.Controls.Add(pictureBox);
            glassPanel.Controls.Add(pictureLabel);
            glassPanel.Controls.Add(emailTextBox);
            glassPanel.Controls.Add(emailLabel);
            glassPanel.Controls.Add(hometownTextBox);
            glassPanel.Controls.Add(hometownLabel);
            glassPanel.Controls.Add(addressTextBox);
            glassPanel.Controls.Add(addressLabel);
            glassPanel.Controls.Add(phoneTextBox);
            glassPanel.Controls.Add(phoneLabel);
            glassPanel.Controls.Add(genderComboBox);
            glassPanel.Controls.Add(genderLabel);
            glassPanel.Controls.Add(dobPicker);
            glassPanel.Controls.Add(dobLabel);
            glassPanel.Controls.Add(lnameTextBox);
            glassPanel.Controls.Add(lnameLabel);
            glassPanel.Controls.Add(fnameTextBox);
            glassPanel.Controls.Add(fnameLabel);
            glassPanel.Controls.Add(mssvTextBox);
            glassPanel.Controls.Add(mssvLabel);
            glassPanel.Controls.Add(titleLabel);
            glassPanel.Location = new Point(60, 20);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new Size(680, 610);
            glassPanel.TabIndex = 0;
            glassPanel.Paint += GlassPanel_Paint;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(180, 50, 50);
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(380, 500);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 45);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "HỦY";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 150, 100);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(150, 500);
            addButton.Name = "addButton";
            addButton.Size = new Size(200, 45);
            addButton.TabIndex = 11;
            addButton.Text = "THÊM";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // browsePictureButton
            // 
            browsePictureButton.BackColor = Color.FromArgb(80, 80, 80);
            browsePictureButton.Cursor = Cursors.Hand;
            browsePictureButton.FlatAppearance.BorderSize = 0;
            browsePictureButton.FlatStyle = FlatStyle.Flat;
            browsePictureButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browsePictureButton.ForeColor = Color.White;
            browsePictureButton.Location = new Point(420, 300);
            browsePictureButton.Name = "browsePictureButton";
            browsePictureButton.Size = new Size(190, 30);
            browsePictureButton.TabIndex = 10;
            browsePictureButton.Text = "CHỌN ẢNH";
            browsePictureButton.UseVisualStyleBackColor = false;
            browsePictureButton.Click += BrowsePictureButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.WhiteSmoke;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(420, 95);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(190, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
            pictureBox.Click += PictureBox_Click;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.BackColor = Color.Transparent;
            pictureLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pictureLabel.ForeColor = Color.FromArgb(0, 51, 102);
            pictureLabel.Location = new Point(459, 69);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(112, 23);
            pictureLabel.TabIndex = 19;
            pictureLabel.Text = "Ảnh đại diện";
            pictureLabel.Click += PictureLabel_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(150, 426);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 32);
            emailTextBox.TabIndex = 9;
            emailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 51, 102);
            emailLabel.Location = new Point(37, 430);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 23);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email";
            emailLabel.Click += EmailLabel_Click;
            // 
            // hometownTextBox
            // 
            hometownTextBox.Font = new Font("Segoe UI", 11F);
            hometownTextBox.Location = new Point(150, 381);
            hometownTextBox.Name = "hometownTextBox";
            hometownTextBox.Size = new Size(200, 32);
            hometownTextBox.TabIndex = 8;
            hometownTextBox.TextChanged += HometownTextBox_TextChanged;
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.BackColor = Color.Transparent;
            hometownLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            hometownLabel.ForeColor = Color.FromArgb(0, 51, 102);
            hometownLabel.Location = new Point(37, 385);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new Size(87, 23);
            hometownLabel.TabIndex = 15;
            hometownLabel.Text = "Quê quán";
            hometownLabel.Click += HometownLabel_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 11F);
            addressTextBox.Location = new Point(150, 336);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 32);
            addressTextBox.TabIndex = 7;
            addressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addressLabel.ForeColor = Color.FromArgb(0, 51, 102);
            addressLabel.Location = new Point(37, 340);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(65, 23);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Địa chỉ";
            addressLabel.Click += AddressLabel_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 11F);
            phoneTextBox.Location = new Point(150, 291);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 32);
            phoneTextBox.TabIndex = 6;
            phoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(0, 51, 102);
            phoneLabel.Location = new Point(37, 295);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(116, 23);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Số điện thoại";
            phoneLabel.Click += PhoneLabel_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Font = new Font("Segoe UI", 11F);
            genderComboBox.Items.AddRange(new object[] { "Nam", "Nu", "Khac" });
            genderComboBox.Location = new Point(150, 245);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(200, 33);
            genderComboBox.TabIndex = 5;
            genderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            genderLabel.ForeColor = Color.FromArgb(0, 51, 102);
            genderLabel.Location = new Point(37, 250);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(80, 23);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Giới tính";
            genderLabel.Click += GenderLabel_Click;
            // 
            // dobPicker
            // 
            dobPicker.CustomFormat = "dd/MM/yyyy";
            dobPicker.Font = new Font("Segoe UI", 11F);
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(150, 200);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(200, 32);
            dobPicker.TabIndex = 4;
            dobPicker.ValueChanged += DobPicker_ValueChanged;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.BackColor = Color.Transparent;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dobLabel.ForeColor = Color.FromArgb(0, 51, 102);
            dobLabel.Location = new Point(37, 204);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(89, 23);
            dobLabel.TabIndex = 7;
            dobLabel.Text = "Ngày sinh";
            dobLabel.Click += DobLabel_Click;
            // 
            // lnameTextBox
            // 
            lnameTextBox.Font = new Font("Segoe UI", 11F);
            lnameTextBox.Location = new Point(150, 156);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(200, 32);
            lnameTextBox.TabIndex = 3;
            lnameTextBox.TextChanged += LnameTextBox_TextChanged;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.BackColor = Color.Transparent;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            lnameLabel.Location = new Point(37, 161);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(37, 23);
            lnameLabel.TabIndex = 5;
            lnameLabel.Text = "Tên";
            lnameLabel.Click += LnameLabel_Click;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Font = new Font("Segoe UI", 11F);
            fnameTextBox.Location = new Point(150, 111);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(200, 32);
            fnameTextBox.TabIndex = 2;
            fnameTextBox.TextChanged += FnameTextBox_TextChanged;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.BackColor = Color.Transparent;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fnameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            fnameLabel.Location = new Point(37, 116);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(74, 23);
            fnameLabel.TabIndex = 3;
            fnameLabel.Text = "Họ đệm";
            fnameLabel.Click += FnameLabel_Click;
            // 
            // mssvTextBox
            // 
            mssvTextBox.Font = new Font("Segoe UI", 11F);
            mssvTextBox.Location = new Point(150, 66);
            mssvTextBox.Name = "mssvTextBox";
            mssvTextBox.Size = new Size(200, 32);
            mssvTextBox.TabIndex = 1;
            mssvTextBox.TextChanged += MssvTextBox_TextChanged;
            // 
            // mssvLabel
            // 
            mssvLabel.AutoSize = true;
            mssvLabel.BackColor = Color.Transparent;
            mssvLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mssvLabel.ForeColor = Color.FromArgb(0, 51, 102);
            mssvLabel.Location = new Point(37, 71);
            mssvLabel.Name = "mssvLabel";
            mssvLabel.Size = new Size(57, 23);
            mssvLabel.TabIndex = 1;
            mssvLabel.Text = "MSSV";
            mssvLabel.Click += MssvLabel_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 51, 102);
            titleLabel.Location = new Point(200, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(299, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "THÊM SINH VIÊN MỚI";
            titleLabel.Click += TitleLabel_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 650);
            Controls.Add(glassPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Thêm sinh viên";
            Load += AddStudentForm_Load;
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel glassPanel;
        private Label titleLabel;
        private Label mssvLabel;
        private TextBox mssvTextBox;
        private Label fnameLabel;
        private TextBox fnameTextBox;
        private Label lnameLabel;
        private TextBox lnameTextBox;
        private Label dobLabel;
        private DateTimePicker dobPicker;
        private Label genderLabel;
        private ComboBox genderComboBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label hometownLabel;
        private TextBox hometownTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label pictureLabel;
        private PictureBox pictureBox;
        private Button browsePictureButton;
        private Button addButton;
        private Button cancelButton;
    }
}