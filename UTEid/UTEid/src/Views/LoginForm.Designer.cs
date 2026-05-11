namespace UTEid.src.Views
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            glassPanel = new Panel();
            forgotPasswordLink = new LinkLabel();
            signUpLink = new LinkLabel();
            togglePasswordButton = new PictureBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            glassPanel.SuspendLayout();
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
            logoBox.Click += LogoBox_Click;
            //
            // glassPanel
            //
            glassPanel.Anchor = AnchorStyles.None;
            glassPanel.BackColor = Color.FromArgb(210, 245, 245, 245);
            glassPanel.BorderStyle = BorderStyle.FixedSingle;
            glassPanel.Controls.Add(forgotPasswordLink);
            glassPanel.Controls.Add(signUpLink);
            glassPanel.Controls.Add(togglePasswordButton);
            glassPanel.Controls.Add(passwordLabel);
            glassPanel.Controls.Add(usernameLabel);
            glassPanel.Controls.Add(usernameTextBox);
            glassPanel.Controls.Add(loginButton);
            glassPanel.Controls.Add(passwordTextBox);
            glassPanel.Location = new Point(200, 60);
            glassPanel.Name = "glassPanel";
            glassPanel.Size = new Size(400, 320);
            glassPanel.TabIndex = 4;
            glassPanel.Paint += GlassPanel_Paint;
            //
            // usernameLabel
            //
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            usernameLabel.Location = new Point(50, 25);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(107, 23);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "USERNAME";
            usernameLabel.Click += UsernameLabel_Click;
            //
            // usernameTextBox
            //
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.Location = new Point(50, 55);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 34);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            //
            // passwordLabel
            //
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 51, 102);
            passwordLabel.Location = new Point(50, 105);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(107, 23);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "PASSWORD";
            passwordLabel.Click += PasswordLabel_Click;
            //
            // passwordTextBox
            //
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.Location = new Point(50, 135);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 34);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += PasswordTextBox_TextChanged;
            //
            // togglePasswordButton
            //
            togglePasswordButton.BackColor = Color.White;
            togglePasswordButton.BackgroundImage = Properties.Resources.eye;
            togglePasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            togglePasswordButton.Cursor = Cursors.Hand;
            togglePasswordButton.Location = new Point(315, 140);
            togglePasswordButton.Name = "togglePasswordButton";
            togglePasswordButton.Size = new Size(25, 23);
            togglePasswordButton.TabIndex = 6;
            togglePasswordButton.TabStop = false;
            togglePasswordButton.Click += TogglePasswordButton_Click;
            //
            // forgotPasswordLink
            //
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.BackColor = Color.Transparent;
            forgotPasswordLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            forgotPasswordLink.LinkColor = Color.FromArgb(0, 51, 102);
            forgotPasswordLink.Location = new Point(230, 175);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(120, 20);
            forgotPasswordLink.TabIndex = 8;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot password?";
            forgotPasswordLink.LinkClicked += ForgotPasswordLink_LinkClicked;
            //
            // loginButton
            //
            loginButton.BackColor = Color.FromArgb(0, 120, 215);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(50, 215);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(300, 45);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            //
            // signUpLink
            //
            signUpLink.AutoSize = true;
            signUpLink.BackColor = Color.Transparent;
            signUpLink.Font = new Font("Segoe UI", 9F);
            signUpLink.LinkColor = Color.FromArgb(0, 51, 102);
            signUpLink.Location = new Point(55, 275);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(289, 20);
            signUpLink.TabIndex = 7;
            signUpLink.TabStop = true;
            signUpLink.Text = "Don't have an account? Create an account";
            signUpLink.LinkClicked += SignUpLink_LinkClicked;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(glassPanel);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTEid - Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            glassPanel.ResumeLayout(false);
            glassPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)togglePasswordButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Panel glassPanel;
        private Label passwordLabel;
        private Label usernameLabel;
        private PictureBox togglePasswordButton;
        private LinkLabel signUpLink;
        private LinkLabel forgotPasswordLink;
    }
}
