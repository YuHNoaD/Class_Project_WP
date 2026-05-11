namespace UTEid
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoBox = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            tempPanel = new Panel();
            forgotPasswordLabel = new LinkLabel();
            signUpLabel = new LinkLabel();
            picEye = new PictureBox();
            passLabel = new Label();
            userLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            tempPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.BackgroundImage = Properties.Resources.LogoUTE;
            logoBox.BackgroundImageLayout = ImageLayout.Stretch;
            logoBox.Location = new Point(24, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(90, 80);
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // tempPanel
            // 
            tempPanel.Anchor = AnchorStyles.None;
            // Màu trắng xám mờ (Alpha = 210) tạo hiệu ứng kính Glassmorphism
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            // Thêm viền mảnh để tạo ranh giới sắc nét cho tấm kính
            tempPanel.BorderStyle = BorderStyle.FixedSingle;
            tempPanel.Controls.Add(forgotPasswordLabel);
            tempPanel.Controls.Add(signUpLabel);
            tempPanel.Controls.Add(picEye);
            tempPanel.Controls.Add(passLabel);
            tempPanel.Controls.Add(userLabel);
            tempPanel.Controls.Add(txtUsername);
            tempPanel.Controls.Add(btnLogin);
            tempPanel.Controls.Add(txtPassword);
            tempPanel.Location = new Point(200, 60);
            tempPanel.Name = "tempPanel";
            tempPanel.Size = new Size(400, 320);
            tempPanel.TabIndex = 4;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            // Chuyển sang Xanh Navy đậm
            userLabel.ForeColor = Color.FromArgb(0, 51, 102);
            userLabel.Location = new Point(50, 25);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(107, 23);
            userLabel.TabIndex = 4;
            userLabel.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(50, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 34);
            txtUsername.TabIndex = 1;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            // Chuyển sang Xanh Navy đậm
            passLabel.ForeColor = Color.FromArgb(0, 51, 102);
            passLabel.Location = new Point(50, 105);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(107, 23);
            passLabel.TabIndex = 5;
            passLabel.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(50, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // picEye
            // 
            picEye.BackColor = Color.White;
            picEye.BackgroundImage = Properties.Resources.eye;
            picEye.BackgroundImageLayout = ImageLayout.Stretch;
            picEye.Cursor = Cursors.Hand;
            picEye.Location = new Point(315, 140);
            picEye.Name = "picEye";
            picEye.Size = new Size(25, 23);
            picEye.TabIndex = 6;
            picEye.TabStop = false;
            picEye.Click += picEye_Click;
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.BackColor = Color.Transparent;
            forgotPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            // Link chuyển sang Xanh Navy
            forgotPasswordLabel.LinkColor = Color.FromArgb(0, 51, 102);
            forgotPasswordLabel.Location = new Point(230, 175);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(120, 20);
            forgotPasswordLabel.TabIndex = 8;
            forgotPasswordLabel.TabStop = true;
            forgotPasswordLabel.Text = "Forgot password?";
            forgotPasswordLabel.LinkClicked += forgotPasswordLabel_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.BackColor = Color.Transparent;
            signUpLabel.Font = new Font("Segoe UI", 9F);
            // Link chuyển sang Xanh Navy
            signUpLabel.LinkColor = Color.FromArgb(0, 51, 102);
            signUpLabel.Location = new Point(55, 275);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(289, 20);
            signUpLabel.TabIndex = 7;
            signUpLabel.TabStop = true;
            signUpLabel.Text = "Don't have an account? Create an account";
            signUpLabel.LinkClicked += signUpLabel_LinkClicked;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tempPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Login";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            tempPanel.ResumeLayout(false);
            tempPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoBox;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel tempPanel;
        private Label passLabel;
        private Label userLabel;
        private PictureBox picEye;
        private LinkLabel signUpLabel;
        private LinkLabel forgotPasswordLabel;
    }
}