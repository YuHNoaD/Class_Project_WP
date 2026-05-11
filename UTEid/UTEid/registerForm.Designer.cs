using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UTEid
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoBox = new PictureBox();
            tempPanel = new Panel();
            emailLabel = new Label();
            txtRegEmail = new TextBox();
            linkBackToLogin = new LinkLabel();
            picEye1 = new PictureBox();
            picEye = new PictureBox();
            btnRegister = new Button();
            txtConfirmPass = new TextBox();
            txtRegPass = new TextBox();
            txtRegUser = new TextBox();
            confirmLabel = new Label();
            passLabel = new Label();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            tempPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye1).BeginInit();
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
            // Kính mờ (Alpha = 210)
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            tempPanel.BorderStyle = BorderStyle.FixedSingle;
            tempPanel.Controls.Add(emailLabel);
            tempPanel.Controls.Add(txtRegEmail);
            tempPanel.Controls.Add(linkBackToLogin);
            tempPanel.Controls.Add(picEye1);
            tempPanel.Controls.Add(picEye);
            tempPanel.Controls.Add(btnRegister);
            tempPanel.Controls.Add(txtConfirmPass);
            tempPanel.Controls.Add(txtRegPass);
            tempPanel.Controls.Add(txtRegUser);
            tempPanel.Controls.Add(confirmLabel);
            tempPanel.Controls.Add(passLabel);
            tempPanel.Controls.Add(usernameLabel);
            // Căn giữa, kéo dài chiều cao lên 385px
            tempPanel.Location = new Point(200, 30);
            tempPanel.Name = "tempPanel";
            tempPanel.Size = new Size(400, 385);
            tempPanel.TabIndex = 1;
            tempPanel.Paint += panel1_Paint;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            usernameLabel.Location = new Point(50, 15);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(107, 23);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "USERNAME";
            // 
            // txtRegUser
            // 
            txtRegUser.Font = new Font("Segoe UI", 12F);
            txtRegUser.Location = new Point(50, 40);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(300, 34);
            txtRegUser.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 51, 102);
            emailLabel.Location = new Point(50, 85);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(61, 23);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "EMAIL";
            // 
            // txtRegEmail
            // 
            txtRegEmail.Font = new Font("Segoe UI", 12F);
            txtRegEmail.Location = new Point(50, 110);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(300, 34);
            txtRegEmail.TabIndex = 2;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            passLabel.ForeColor = Color.FromArgb(0, 51, 102);
            passLabel.Location = new Point(50, 155);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(107, 23);
            passLabel.TabIndex = 3;
            passLabel.Text = "PASSWORD";
            // 
            // txtRegPass
            // 
            txtRegPass.Font = new Font("Segoe UI", 12F);
            txtRegPass.Location = new Point(50, 180);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.Size = new Size(300, 34);
            txtRegPass.TabIndex = 4;
            txtRegPass.UseSystemPasswordChar = true;
            // 
            // picEye
            // 
            picEye.BackColor = Color.White;
            picEye.BackgroundImage = Properties.Resources.eye;
            picEye.BackgroundImageLayout = ImageLayout.Stretch;
            picEye.Cursor = Cursors.Hand;
            picEye.Location = new Point(315, 185);
            picEye.Name = "picEye";
            picEye.Size = new Size(25, 23);
            picEye.TabIndex = 7;
            picEye.TabStop = false;
            picEye.Click += picEye_Click;
            // 
            // confirmLabel
            // 
            confirmLabel.AutoSize = true;
            confirmLabel.BackColor = Color.Transparent;
            confirmLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            confirmLabel.ForeColor = Color.FromArgb(0, 51, 102);
            confirmLabel.Location = new Point(50, 225);
            confirmLabel.Name = "confirmLabel";
            confirmLabel.Size = new Size(187, 23);
            confirmLabel.TabIndex = 5;
            confirmLabel.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 12F);
            txtConfirmPass.Location = new Point(50, 250);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(300, 34);
            txtConfirmPass.TabIndex = 6;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // picEye1
            // 
            picEye1.BackColor = Color.White;
            picEye1.BackgroundImage = Properties.Resources.eye;
            picEye1.BackgroundImageLayout = ImageLayout.Stretch;
            picEye1.Cursor = Cursors.Hand;
            picEye1.Location = new Point(315, 255);
            picEye1.Name = "picEye1";
            picEye1.Size = new Size(25, 23);
            picEye1.TabIndex = 8;
            picEye1.TabStop = false;
            picEye1.Click += picEye1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(50, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 45);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.AutoSize = true;
            linkBackToLogin.BackColor = Color.Transparent;
            linkBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            linkBackToLogin.LinkColor = Color.FromArgb(0, 51, 102);
            linkBackToLogin.Location = new Point(90, 355);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(215, 20);
            linkBackToLogin.TabIndex = 8;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "You have an account? Click here";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked_1;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tempPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Register";
            Load += registerForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            tempPanel.ResumeLayout(false);
            tempPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEye).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoBox;
        private Panel tempPanel;
        private Label usernameLabel;
        private TextBox txtRegUser;
        private Label confirmLabel;
        private Label passLabel;
        private TextBox txtRegPass;
        private TextBox txtConfirmPass;
        private Button btnRegister;
        private PictureBox picEye1;
        private PictureBox picEye;
        private LinkLabel linkBackToLogin;
        private Label emailLabel;
        private TextBox txtRegEmail;
    }
}