namespace UTEid.src.Views
{
    partial class RegisterForm
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
            emailLabel = new Label();
            emailTextBox = new TextBox();
            backToLoginLink = new LinkLabel();
            toggleConfirmPasswordButton = new PictureBox();
            togglePasswordButton = new PictureBox();
            registerButton = new Button();
            confirmPasswordTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            glassPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toggleConfirmPasswordButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)togglePasswordButton).BeginInit();
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
            glassPanel.Controls.Add(emailLabel);
            glassPanel.Controls.Add(emailTextBox);
            glassPanel.Controls.Add(backToLoginLink);
            glassPanel.Controls.Add(toggleConfirmPasswordButton);
            glassPanel.Controls.Add(togglePasswordButton);
            glassPanel.Controls.Add(registerButton);
            glassPanel.Controls.Add(confirmPasswordTextBox);
            glassPanel.Controls.Add(passwordTextBox);
            glassPanel.Controls.Add(usernameTextBox);
            glassPanel.Controls.Add(confirmPasswordLabel);
            glassPanel.Controls.Add(passwordLabel);
            glassPanel.Controls.Add(usernameLabel);
            glassPanel.Location = new Point(200, 30);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new Size(400, 385);
            glassPanel.TabIndex = 1;
            glassPanel.Paint += GlassPanel_Paint;
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
            usernameLabel.Click += UsernameLabel_Click;
            //
            // usernameTextBox
            //
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.Location = new Point(50, 40);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 34);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += UsernameTextBox_TextChanged;
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
            // emailTextBox
            //
            emailTextBox.Font = new Font("Segoe UI", 12F);
            emailTextBox.Location = new Point(50, 110);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 34);
            emailTextBox.TabIndex = 2;
            //
            // passwordLabel
            //
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            passwordLabel.Location = new Point(50, 155);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(107, 23);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "PASSWORD";
            //
            // passwordTextBox
            //
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.Location = new Point(50, 180);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 34);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += PasswordTextBox_TextChanged;
            //
            // togglePasswordButton
            //
            togglePasswordButton.BackColor = Color.White;
            togglePasswordButton.BackgroundImage = Properties.Resources.eye;
            togglePasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            togglePasswordButton.Cursor = Cursors.Hand;
            togglePasswordButton.Location = new Point(315, 185);
            togglePasswordButton.Name = "togglePasswordButton";
            togglePasswordButton.Size = new Size(25, 23);
            togglePasswordButton.TabIndex = 7;
            togglePasswordButton.TabStop = false;
            togglePasswordButton.Click += TogglePasswordButton_Click;
            //
            // confirmPasswordLabel
            //
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.Transparent;
            confirmPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            confirmPasswordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            confirmPasswordLabel.Location = new Point(50, 225);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(187, 23);
            confirmPasswordLabel.TabIndex = 5;
            confirmPasswordLabel.Text = "CONFIRM PASSWORD";
            //
            // confirmPasswordTextBox
            //
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F);
            confirmPasswordTextBox.Location = new Point(50, 250);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(300, 34);
            confirmPasswordTextBox.TabIndex = 6;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.TextChanged += ConfirmPasswordTextBox_TextChanged;
            //
            // toggleConfirmPasswordButton
            //
            toggleConfirmPasswordButton.BackColor = Color.White;
            toggleConfirmPasswordButton.BackgroundImage = Properties.Resources.eye;
            toggleConfirmPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            toggleConfirmPasswordButton.Cursor = Cursors.Hand;
            toggleConfirmPasswordButton.Location = new Point(315, 255);
            toggleConfirmPasswordButton.Name = "toggleConfirmPasswordButton";
            toggleConfirmPasswordButton.Size = new Size(25, 23);
            toggleConfirmPasswordButton.TabIndex = 8;
            toggleConfirmPasswordButton.TabStop = false;
            toggleConfirmPasswordButton.Click += ToggleConfirmPasswordButton_Click;
            //
            // registerButton
            //
            registerButton.BackColor = Color.FromArgb(0, 120, 215);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(50, 300);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(300, 45);
            registerButton.TabIndex = 7;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterButton_Click;
            //
            // backToLoginLink
            //
            backToLoginLink.AutoSize = true;
            backToLoginLink.BackColor = Color.Transparent;
            backToLoginLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            backToLoginLink.LinkColor = Color.FromArgb(0, 51, 102);
            backToLoginLink.Location = new Point(90, 355);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(215, 20);
            backToLoginLink.TabIndex = 8;
            backToLoginLink.TabStop = true;
            backToLoginLink.Text = "You have an account? Click here";
            backToLoginLink.LinkClicked += BackToLoginLink_LinkClicked;
            //
            // RegisterForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(glassPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Register";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toggleConfirmPasswordButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)togglePasswordButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoBox;
        private Panel glassPanel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label confirmPasswordLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private Button registerButton;
        private PictureBox toggleConfirmPasswordButton;
        private PictureBox togglePasswordButton;
        private LinkLabel backToLoginLink;
        private Label emailLabel;
        private TextBox emailTextBox;
    }
}
