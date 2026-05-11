namespace UTEid.src.Views
{
    partial class ForgotPasswordForm
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
            glassPanel = new Panel();
            backToLoginLink = new LinkLabel();
            toggleConfirmPasswordButton = new PictureBox();
            toggleNewPasswordButton = new PictureBox();
            resetPasswordButton = new Button();
            confirmNewPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            otpTextBox = new TextBox();
            emailTextBox = new TextBox();
            verifyOtpButton = new Button();
            sendOtpButton = new Button();
            confirmPasswordLabel = new Label();
            newPasswordLabel = new Label();
            otpLabel = new Label();
            emailLabel = new Label();
            instructionLabel = new Label();
            forgotPasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            glassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toggleConfirmPasswordButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleNewPasswordButton).BeginInit();
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
            // glassPanel
            //
            glassPanel.Anchor = AnchorStyles.None;
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            glassPanel.BorderStyle = BorderStyle.FixedSingle;
            glassPanel.Controls.Add(backToLoginLink);
            glassPanel.Controls.Add(toggleConfirmPasswordButton);
            glassPanel.Controls.Add(toggleNewPasswordButton);
            glassPanel.Controls.Add(resetPasswordButton);
            glassPanel.Controls.Add(confirmNewPasswordTextBox);
            glassPanel.Controls.Add(newPasswordTextBox);
            glassPanel.Controls.Add(otpTextBox);
            glassPanel.Controls.Add(emailTextBox);
            glassPanel.Controls.Add(verifyOtpButton);
            glassPanel.Controls.Add(sendOtpButton);
            glassPanel.Controls.Add(confirmPasswordLabel);
            glassPanel.Controls.Add(newPasswordLabel);
            glassPanel.Controls.Add(otpLabel);
            glassPanel.Controls.Add(emailLabel);
            glassPanel.Controls.Add(instructionLabel);
            glassPanel.Controls.Add(forgotPasswordLabel);
            glassPanel.Location = new Point(150, 20);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new Size(500, 410);
            glassPanel.TabIndex = 1;
            glassPanel.Paint += GlassPanel_Paint;
            //
            // forgotPasswordLabel
            //
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.BackColor = Color.Transparent;
            forgotPasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            forgotPasswordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            forgotPasswordLabel.Location = new Point(95, 10);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(310, 31);
            forgotPasswordLabel.TabIndex = 0;
            forgotPasswordLabel.Text = "FORGOT PASSWORD";
            //
            // instructionLabel
            //
            instructionLabel.AutoSize = true;
            instructionLabel.BackColor = Color.Transparent;
            instructionLabel.Font = new Font("Segoe UI", 9F);
            instructionLabel.ForeColor = Color.Gray;
            instructionLabel.Location = new Point(50, 45);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(400, 20);
            instructionLabel.TabIndex = 1;
            instructionLabel.Text = "Enter your registered email to receive an OTP code.";
            //
            // emailLabel
            //
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 51, 102);
            emailLabel.Location = new Point(50, 75);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(61, 23);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "EMAIL";
            //
            // emailTextBox
            //
            emailTextBox.Font = new Font("Segoe UI", 12F);
            emailTextBox.Location = new Point(50, 100);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 34);
            emailTextBox.TabIndex = 1;
            //
            // sendOtpButton
            //
            sendOtpButton.BackColor = Color.FromArgb(0, 120, 215);
            sendOtpButton.Cursor = Cursors.Hand;
            sendOtpButton.FlatAppearance.BorderSize = 0;
            sendOtpButton.FlatStyle = FlatStyle.Flat;
            sendOtpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sendOtpButton.ForeColor = Color.White;
            sendOtpButton.Location = new Point(365, 100);
            sendOtpButton.Name = "sendOtpButton";
            sendOtpButton.Size = new Size(85, 34);
            sendOtpButton.TabIndex = 2;
            sendOtpButton.Text = "SEND OTP";
            sendOtpButton.UseVisualStyleBackColor = false;
            sendOtpButton.Click += SendOtpButton_Click;
            //
            // otpLabel
            //
            otpLabel.AutoSize = true;
            otpLabel.BackColor = Color.Transparent;
            otpLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            otpLabel.ForeColor = Color.FromArgb(0, 51, 102);
            otpLabel.Location = new Point(50, 145);
            otpLabel.Name = "otpLabel";
            otpLabel.Size = new Size(101, 23);
            otpLabel.TabIndex = 5;
            otpLabel.Text = "OTP CODE";
            //
            // otpTextBox
            //
            otpTextBox.Font = new Font("Segoe UI", 12F);
            otpTextBox.Location = new Point(50, 170);
            otpTextBox.Name = "otpTextBox";
            otpTextBox.Size = new Size(300, 34);
            otpTextBox.TabIndex = 3;
            //
            // verifyOtpButton
            //
            verifyOtpButton.BackColor = Color.FromArgb(0, 120, 215);
            verifyOtpButton.Cursor = Cursors.Hand;
            verifyOtpButton.FlatAppearance.BorderSize = 0;
            verifyOtpButton.FlatStyle = FlatStyle.Flat;
            verifyOtpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            verifyOtpButton.ForeColor = Color.White;
            verifyOtpButton.Location = new Point(365, 170);
            verifyOtpButton.Name = "verifyOtpButton";
            verifyOtpButton.Size = new Size(85, 34);
            verifyOtpButton.TabIndex = 4;
            verifyOtpButton.Text = "VERIFY";
            verifyOtpButton.UseVisualStyleBackColor = false;
            verifyOtpButton.Click += VerifyOtpButton_Click;
            //
            // newPasswordLabel
            //
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.BackColor = Color.Transparent;
            newPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            newPasswordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            newPasswordLabel.Location = new Point(50, 215);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(149, 23);
            newPasswordLabel.TabIndex = 7;
            newPasswordLabel.Text = "NEW PASSWORD";
            //
            // newPasswordTextBox
            //
            newPasswordTextBox.Font = new Font("Segoe UI", 12F);
            newPasswordTextBox.Location = new Point(50, 240);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(300, 34);
            newPasswordTextBox.TabIndex = 5;
            newPasswordTextBox.UseSystemPasswordChar = true;
            //
            // toggleNewPasswordButton
            //
            toggleNewPasswordButton.BackColor = Color.White;
            toggleNewPasswordButton.BackgroundImage = Properties.Resources.eye;
            toggleNewPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            toggleNewPasswordButton.Cursor = Cursors.Hand;
            toggleNewPasswordButton.Location = new Point(315, 245);
            toggleNewPasswordButton.Name = "toggleNewPasswordButton";
            toggleNewPasswordButton.Size = new Size(25, 23);
            toggleNewPasswordButton.TabIndex = 8;
            toggleNewPasswordButton.TabStop = false;
            toggleNewPasswordButton.Click += ToggleNewPasswordButton_Click;
            //
            // confirmPasswordLabel
            //
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.Transparent;
            confirmPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            confirmPasswordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            confirmPasswordLabel.Location = new Point(50, 285);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(187, 23);
            confirmPasswordLabel.TabIndex = 9;
            confirmPasswordLabel.Text = "CONFIRM PASSWORD";
            //
            // confirmNewPasswordTextBox
            //
            confirmNewPasswordTextBox.Font = new Font("Segoe UI", 12F);
            confirmNewPasswordTextBox.Location = new Point(50, 310);
            confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            confirmNewPasswordTextBox.Size = new Size(300, 34);
            confirmNewPasswordTextBox.TabIndex = 6;
            confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            //
            // toggleConfirmPasswordButton
            //
            toggleConfirmPasswordButton.BackColor = Color.White;
            toggleConfirmPasswordButton.BackgroundImage = Properties.Resources.eye;
            toggleConfirmPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            toggleConfirmPasswordButton.Cursor = Cursors.Hand;
            toggleConfirmPasswordButton.Location = new Point(315, 315);
            toggleConfirmPasswordButton.Name = "toggleConfirmPasswordButton";
            toggleConfirmPasswordButton.Size = new Size(25, 23);
            toggleConfirmPasswordButton.TabIndex = 10;
            toggleConfirmPasswordButton.TabStop = false;
            toggleConfirmPasswordButton.Click += ToggleConfirmPasswordButton_Click;
            //
            // resetPasswordButton
            //
            resetPasswordButton.BackColor = Color.FromArgb(0, 120, 215);
            resetPasswordButton.Cursor = Cursors.Hand;
            resetPasswordButton.FlatAppearance.BorderSize = 0;
            resetPasswordButton.FlatStyle = FlatStyle.Flat;
            resetPasswordButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            resetPasswordButton.ForeColor = Color.White;
            resetPasswordButton.Location = new Point(50, 355);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(300, 40);
            resetPasswordButton.TabIndex = 7;
            resetPasswordButton.Text = "RESET PASSWORD";
            resetPasswordButton.UseVisualStyleBackColor = false;
            resetPasswordButton.Click += ResetPasswordButton_Click;
            //
            // backToLoginLink
            //
            backToLoginLink.AutoSize = true;
            backToLoginLink.BackColor = Color.Transparent;
            backToLoginLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            backToLoginLink.LinkColor = Color.FromArgb(0, 51, 102);
            backToLoginLink.Location = new Point(200, 385);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(100, 20);
            backToLoginLink.TabIndex = 9;
            backToLoginLink.TabStop = true;
            backToLoginLink.Text = "Back to Login";
            backToLoginLink.LinkClicked += BackToLoginLink_LinkClicked;
            //
            // ForgotPasswordForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(glassPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Forgot Password";
            Load += ForgotPasswordForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toggleConfirmPasswordButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleNewPasswordButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoBox;
        private Panel glassPanel;
        private Label forgotPasswordLabel;
        private Label instructionLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button sendOtpButton;
        private Label otpLabel;
        private TextBox otpTextBox;
        private Button verifyOtpButton;
        private Label newPasswordLabel;
        private TextBox newPasswordTextBox;
        private PictureBox toggleNewPasswordButton;
        private Label confirmPasswordLabel;
        private TextBox confirmNewPasswordTextBox;
        private PictureBox toggleConfirmPasswordButton;
        private Button resetPasswordButton;
        private LinkLabel backToLoginLink;
    }
}
