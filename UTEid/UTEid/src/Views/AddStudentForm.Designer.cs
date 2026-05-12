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
            titleLabel = new Label();
            mssvLabel = new Label();
            mssvTextBox = new TextBox();
            fnameLabel = new Label();
            fnameTextBox = new TextBox();
            lnameLabel = new Label();
            lnameTextBox = new TextBox();
            dobLabel = new Label();
            dobPicker = new DateTimePicker();
            genderLabel = new Label();
            genderComboBox = new ComboBox();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            hometownLabel = new Label();
            hometownTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            pictureLabel = new Label();
            pictureBox = new PictureBox();
            browsePictureButton = new Button();
            addButton = new Button();
            cancelButton = new Button();
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
            // titleLabel
            //
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 51, 102);
            titleLabel.Location = new Point(200, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(280, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "THEM SINH VIEN MOI";
            titleLabel.Click += TitleLabel_Click;
            //
            // mssvLabel
            //
            mssvLabel.AutoSize = true;
            mssvLabel.BackColor = Color.Transparent;
            mssvLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mssvLabel.ForeColor = Color.FromArgb(0, 51, 102);
            mssvLabel.Location = new Point(40, 70);
            mssvLabel.Name = "mssvLabel";
            mssvLabel.Size = new Size(50, 19);
            mssvLabel.TabIndex = 1;
            mssvLabel.Text = "MSSV";
            mssvLabel.Click += MssvLabel_Click;
            //
            // mssvTextBox
            //
            mssvTextBox.Font = new Font("Segoe UI", 11F);
            mssvTextBox.Location = new Point(150, 66);
            mssvTextBox.Name = "mssvTextBox";
            mssvTextBox.Size = new Size(200, 27);
            mssvTextBox.TabIndex = 1;
            mssvTextBox.TextChanged += MssvTextBox_TextChanged;
            //
            // fnameLabel
            //
            fnameLabel.AutoSize = true;
            fnameLabel.BackColor = Color.Transparent;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fnameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            fnameLabel.Location = new Point(40, 115);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(70, 19);
            fnameLabel.TabIndex = 3;
            fnameLabel.Text = "Ho & dem";
            fnameLabel.Click += FnameLabel_Click;
            //
            // fnameTextBox
            //
            fnameTextBox.Font = new Font("Segoe UI", 11F);
            fnameTextBox.Location = new Point(150, 111);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(200, 27);
            fnameTextBox.TabIndex = 2;
            fnameTextBox.TextChanged += FnameTextBox_TextChanged;
            //
            // lnameLabel
            //
            lnameLabel.AutoSize = true;
            lnameLabel.BackColor = Color.Transparent;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            lnameLabel.Location = new Point(40, 160);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(35, 19);
            lnameLabel.TabIndex = 5;
            lnameLabel.Text = "Ten";
            lnameLabel.Click += LnameLabel_Click;
            //
            // lnameTextBox
            //
            lnameTextBox.Font = new Font("Segoe UI", 11F);
            lnameTextBox.Location = new Point(150, 156);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(200, 27);
            lnameTextBox.TabIndex = 3;
            lnameTextBox.TextChanged += LnameTextBox_TextChanged;
            //
            // dobLabel
            //
            dobLabel.AutoSize = true;
            dobLabel.BackColor = Color.Transparent;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dobLabel.ForeColor = Color.FromArgb(0, 51, 102);
            dobLabel.Location = new Point(40, 205);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(80, 19);
            dobLabel.TabIndex = 7;
            dobLabel.Text = "Ngay sinh";
            dobLabel.Click += DobLabel_Click;
            //
            // dobPicker
            //
            dobPicker.CustomFormat = "dd/MM/yyyy";
            dobPicker.Font = new Font("Segoe UI", 11F);
            dobPicker.Format = DateTimePickerFormat.Custom;
            dobPicker.Location = new Point(150, 200);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(200, 27);
            dobPicker.TabIndex = 4;
            dobPicker.ValueChanged += DobPicker_ValueChanged;
            //
            // genderLabel
            //
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            genderLabel.ForeColor = Color.FromArgb(0, 51, 102);
            genderLabel.Location = new Point(40, 250);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(70, 19);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gioi tinh";
            genderLabel.Click += GenderLabel_Click;
            //
            // genderComboBox
            //
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Font = new Font("Segoe UI", 11F);
            genderComboBox.Items.AddRange(new object[] { "Nam", "Nu", "Khac" });
            genderComboBox.Location = new Point(150, 245);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(200, 28);
            genderComboBox.TabIndex = 5;
            genderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            //
            // phoneLabel
            //
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(0, 51, 102);
            phoneLabel.Location = new Point(40, 295);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(100, 19);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "So dien thoai";
            phoneLabel.Click += PhoneLabel_Click;
            //
            // phoneTextBox
            //
            phoneTextBox.Font = new Font("Segoe UI", 11F);
            phoneTextBox.Location = new Point(150, 291);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 27);
            phoneTextBox.TabIndex = 6;
            phoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            //
            // addressLabel
            //
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addressLabel.ForeColor = Color.FromArgb(0, 51, 102);
            addressLabel.Location = new Point(40, 340);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(60, 19);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Dia chi";
            addressLabel.Click += AddressLabel_Click;
            //
            // addressTextBox
            //
            addressTextBox.Font = new Font("Segoe UI", 11F);
            addressTextBox.Location = new Point(150, 336);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 27);
            addressTextBox.TabIndex = 7;
            addressTextBox.TextChanged += AddressTextBox_TextChanged;
            //
            // hometownLabel
            //
            hometownLabel.AutoSize = true;
            hometownLabel.BackColor = Color.Transparent;
            hometownLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            hometownLabel.ForeColor = Color.FromArgb(0, 51, 102);
            hometownLabel.Location = new Point(40, 385);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new Size(80, 19);
            hometownLabel.TabIndex = 15;
            hometownLabel.Text = "Que quan";
            hometownLabel.Click += HometownLabel_Click;
            //
            // hometownTextBox
            //
            hometownTextBox.Font = new Font("Segoe UI", 11F);
            hometownTextBox.Location = new Point(150, 381);
            hometownTextBox.Name = "hometownTextBox";
            hometownTextBox.Size = new Size(200, 27);
            hometownTextBox.TabIndex = 8;
            hometownTextBox.TextChanged += HometownTextBox_TextChanged;
            //
            // emailLabel
            //
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 51, 102);
            emailLabel.Location = new Point(40, 430);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 19);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email";
            emailLabel.Click += EmailLabel_Click;
            //
            // emailTextBox
            //
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(150, 426);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 27);
            emailTextBox.TabIndex = 9;
            emailTextBox.TextChanged += EmailTextBox_TextChanged;
            //
            // pictureLabel
            //
            pictureLabel.AutoSize = true;
            pictureLabel.BackColor = Color.Transparent;
            pictureLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pictureLabel.ForeColor = Color.FromArgb(0, 51, 102);
            pictureLabel.Location = new Point(380, 70);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(100, 19);
            pictureLabel.TabIndex = 19;
            pictureLabel.Text = "Anh dai dien";
            pictureLabel.Click += PictureLabel_Click;
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
            browsePictureButton.Text = "CHON ANH";
            browsePictureButton.UseVisualStyleBackColor = false;
            browsePictureButton.Click += BrowsePictureButton_Click;
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
            addButton.Text = "THEM";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
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
            cancelButton.Text = "HUY";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
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
            Text = "UTEid - Them Sinh Vien";
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