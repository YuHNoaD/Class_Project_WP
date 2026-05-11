namespace UTEid
{
    partial class forgotPasswordForm
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
            linkBackToLogin = new LinkLabel();
            picEye1 = new PictureBox();
            picEye = new PictureBox();
            btnResetPass = new Button();
            txtConfirmNewPass = new TextBox();
            txtNewPass = new TextBox();
            confirmLabel = new Label();
            passLabel = new Label();
            btnVerifyOTP = new Button();
            txtOTP = new TextBox();
            otpLabel = new Label();
            btnSendOTP = new Button();
            txtEmail = new TextBox();
            emailLabel = new Label();
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
            // Nền trắng xám mờ (Alpha 210)
            tempPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            tempPanel.BorderStyle = BorderStyle.FixedSingle;
            tempPanel.Controls.Add(linkBackToLogin);
            tempPanel.Controls.Add(picEye1);
            tempPanel.Controls.Add(picEye);
            tempPanel.Controls.Add(btnResetPass);
            tempPanel.Controls.Add(txtConfirmNewPass);
            tempPanel.Controls.Add(txtNewPass);
            tempPanel.Controls.Add(confirmLabel);
            tempPanel.Controls.Add(passLabel);
            tempPanel.Controls.Add(btnVerifyOTP);
            tempPanel.Controls.Add(txtOTP);
            tempPanel.Controls.Add(otpLabel);
            tempPanel.Controls.Add(btnSendOTP);
            tempPanel.Controls.Add(txtEmail);
            tempPanel.Controls.Add(emailLabel);
            // Căn giữa Form, chiều cao 385px
            tempPanel.Location = new Point(200, 30);
            tempPanel.Name = "tempPanel";
            tempPanel.Size = new Size(400, 385);
            tempPanel.TabIndex = 1;
            tempPanel.Paint += tempPanel_Paint;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 51, 102); // Xanh Navy
            emailLabel.Location = new Point(50, 15);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(61, 23);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(50, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 34); // Thu nhỏ ngang
            txtEmail.TabIndex = 1;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BackColor = Color.FromArgb(0, 120, 215);
            btnSendOTP.Cursor = Cursors.Hand;
            btnSendOTP.FlatAppearance.BorderSize = 0;
            btnSendOTP.FlatStyle = FlatStyle.Flat;
            btnSendOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSendOTP.ForeColor = Color.White;
            btnSendOTP.Location = new Point(270, 40); // Đặt ngang hàng txtEmail
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(80, 34);
            btnSendOTP.TabIndex = 2;
            btnSendOTP.Text = "SEND";
            btnSendOTP.UseVisualStyleBackColor = false;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // otpLabel
            // 
            otpLabel.AutoSize = true;
            otpLabel.BackColor = Color.Transparent;
            otpLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            otpLabel.ForeColor = Color.FromArgb(0, 51, 102);
            otpLabel.Location = new Point(50, 85);
            otpLabel.Name = "otpLabel";
            otpLabel.Size = new Size(95, 23);
            otpLabel.TabIndex = 3;
            otpLabel.Text = "OTP CODE";
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 12F);
            txtOTP.Location = new Point(50, 110);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(215, 34); // Thu nhỏ ngang
            txtOTP.TabIndex = 4;
            // 
            // btnVerifyOTP
            // 
            btnVerifyOTP.BackColor = Color.FromArgb(0, 120, 215);
            btnVerifyOTP.Cursor = Cursors.Hand;
            btnVerifyOTP.FlatAppearance.BorderSize = 0;
            btnVerifyOTP.FlatStyle = FlatStyle.Flat;
            btnVerifyOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerifyOTP.ForeColor = Color.White;
            btnVerifyOTP.Location = new Point(270, 110); // Đặt ngang hàng txtOTP
            btnVerifyOTP.Name = "btnVerifyOTP";
            btnVerifyOTP.Size = new Size(80, 34);
            btnVerifyOTP.TabIndex = 5;
            btnVerifyOTP.Text = "VERIFY";
            btnVerifyOTP.UseVisualStyleBackColor = false;
            btnVerifyOTP.Click += btnVerifyOTP_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            passLabel.ForeColor = Color.FromArgb(0, 51, 102);
            passLabel.Location = new Point(50, 155);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(150, 23);
            passLabel.TabIndex = 6;
            passLabel.Text = "NEW PASSWORD";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 12F);
            txtNewPass.Location = new Point(50, 180);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(300, 34); // Full 300px
            txtNewPass.TabIndex = 7;
            txtNewPass.UseSystemPasswordChar = true;
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
            picEye.TabIndex = 8;
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
            confirmLabel.TabIndex = 9;
            confirmLabel.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirmNewPass
            // 
            txtConfirmNewPass.Font = new Font("Segoe UI", 12F);
            txtConfirmNewPass.Location = new Point(50, 250);
            txtConfirmNewPass.Name = "txtConfirmNewPass";
            txtConfirmNewPass.Size = new Size(300, 34); // Full 300px
            txtConfirmNewPass.TabIndex = 10;
            txtConfirmNewPass.UseSystemPasswordChar = true;
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
            picEye1.TabIndex = 11;
            picEye1.TabStop = false;
            picEye1.Click += picEye1_Click;
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.FromArgb(0, 120, 215);
            btnResetPass.Cursor = Cursors.Hand;
            btnResetPass.FlatAppearance.BorderSize = 0;
            btnResetPass.FlatStyle = FlatStyle.Flat;
            btnResetPass.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnResetPass.ForeColor = Color.White;
            btnResetPass.Location = new Point(50, 300);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(300, 45); // Full 300px
            btnResetPass.TabIndex = 12;
            btnResetPass.Text = "RESET PASSWORD";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.AutoSize = true;
            linkBackToLogin.BackColor = Color.Transparent;
            linkBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            linkBackToLogin.LinkColor = Color.FromArgb(0, 51, 102);
            linkBackToLogin.Location = new Point(100, 355);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(187, 20);
            linkBackToLogin.TabIndex = 13;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Remembered? Back to login";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // forgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tempPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "forgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Forgot Password";
            Load += forgotPasswordForm_Load;
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
        private Label emailLabel;
        private TextBox txtEmail;
        private Button btnSendOTP;
        private Label otpLabel;
        private TextBox txtOTP;
        private Button btnVerifyOTP;
        private Label passLabel;
        private TextBox txtNewPass;
        private PictureBox picEye;
        private Label confirmLabel;
        private TextBox txtConfirmNewPass;
        private PictureBox picEye1;
        private Button btnResetPass;
        private LinkLabel linkBackToLogin;
    }
}