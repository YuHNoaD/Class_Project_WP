namespace UTEid.src.Views
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SidebarPanel = new Panel();
            OverviewIconButton = new FontAwesome.Sharp.IconButton();
            StudentIconButton = new FontAwesome.Sharp.IconButton();
            Line1Label = new Label();
            StudentButton = new Button();
            OverviewButton = new Button();
            CategoryManageLabel = new Label();
            CategoryGeneralLabel = new Label();
            AppTitleLabel = new Label();
            AppNameLabel = new Label();
            logoBox = new PictureBox();
            HeaderPanel = new Panel();
            SearchIconButton = new FontAwesome.Sharp.IconButton();
            FilterGuna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            AddStudentButton = new Button();
            SearchTextBox = new TextBox();
            PageTitleLabel = new Label();
            ContentPanel = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            HeaderPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.LightSeaGreen;
            SidebarPanel.Controls.Add(OverviewIconButton);
            SidebarPanel.Controls.Add(StudentIconButton);
            SidebarPanel.Controls.Add(Line1Label);
            SidebarPanel.Controls.Add(StudentButton);
            SidebarPanel.Controls.Add(OverviewButton);
            SidebarPanel.Controls.Add(CategoryManageLabel);
            SidebarPanel.Controls.Add(CategoryGeneralLabel);
            SidebarPanel.Controls.Add(AppTitleLabel);
            SidebarPanel.Controls.Add(AppNameLabel);
            SidebarPanel.Controls.Add(logoBox);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(250, 728);
            SidebarPanel.TabIndex = 0;
            // 
            // OverviewIconButton
            // 
            OverviewIconButton.BackColor = Color.LightSeaGreen;
            OverviewIconButton.FlatAppearance.BorderSize = 0;
            OverviewIconButton.FlatStyle = FlatStyle.Flat;
            OverviewIconButton.IconChar = FontAwesome.Sharp.IconChar.TableCells;
            OverviewIconButton.IconColor = Color.DarkSlateGray;
            OverviewIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OverviewIconButton.IconSize = 35;
            OverviewIconButton.Location = new Point(12, 223);
            OverviewIconButton.Name = "OverviewIconButton";
            OverviewIconButton.Size = new Size(50, 46);
            OverviewIconButton.TabIndex = 8;
            OverviewIconButton.UseVisualStyleBackColor = false;
            // 
            // StudentIconButton
            // 
            StudentIconButton.BackColor = Color.LightSeaGreen;
            StudentIconButton.FlatAppearance.BorderSize = 0;
            StudentIconButton.FlatStyle = FlatStyle.Flat;
            StudentIconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            StudentIconButton.IconColor = Color.DarkSlateGray;
            StudentIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StudentIconButton.IconSize = 35;
            StudentIconButton.Location = new Point(12, 304);
            StudentIconButton.Name = "StudentIconButton";
            StudentIconButton.Size = new Size(50, 46);
            StudentIconButton.TabIndex = 0;
            StudentIconButton.UseVisualStyleBackColor = false;
            // 
            // Line1Label
            // 
            Line1Label.BackColor = Color.Teal;
            Line1Label.BorderStyle = BorderStyle.Fixed3D;
            Line1Label.Location = new Point(3, 159);
            Line1Label.Name = "Line1Label";
            Line1Label.Size = new Size(250, 4);
            Line1Label.TabIndex = 7;
            // 
            // StudentButton
            // 
            StudentButton.FlatAppearance.BorderSize = 0;
            StudentButton.FlatStyle = FlatStyle.Flat;
            StudentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentButton.ForeColor = Color.Cyan;
            StudentButton.Location = new Point(60, 307);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(111, 35);
            StudentButton.TabIndex = 6;
            StudentButton.Text = "Sinh viên";
            StudentButton.UseVisualStyleBackColor = true;
            // 
            // OverviewButton
            // 
            OverviewButton.FlatAppearance.BorderSize = 0;
            OverviewButton.FlatStyle = FlatStyle.Flat;
            OverviewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OverviewButton.ForeColor = Color.Cyan;
            OverviewButton.Location = new Point(60, 223);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(111, 35);
            OverviewButton.TabIndex = 5;
            OverviewButton.Text = "Overview";
            OverviewButton.UseVisualStyleBackColor = true;
            // 
            // CategoryManageLabel
            // 
            CategoryManageLabel.AutoSize = true;
            CategoryManageLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryManageLabel.ForeColor = Color.Cyan;
            CategoryManageLabel.Location = new Point(12, 281);
            CategoryManageLabel.Name = "CategoryManageLabel";
            CategoryManageLabel.Size = new Size(81, 23);
            CategoryManageLabel.TabIndex = 4;
            CategoryManageLabel.Text = "QUẢN LÝ";
            // 
            // CategoryGeneralLabel
            // 
            CategoryGeneralLabel.AutoSize = true;
            CategoryGeneralLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryGeneralLabel.ForeColor = Color.Cyan;
            CategoryGeneralLabel.Location = new Point(12, 197);
            CategoryGeneralLabel.Name = "CategoryGeneralLabel";
            CategoryGeneralLabel.Size = new Size(111, 23);
            CategoryGeneralLabel.TabIndex = 3;
            CategoryGeneralLabel.Text = "TỔNG QUAN";
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.AutoSize = true;
            AppTitleLabel.BackColor = Color.Transparent;
            AppTitleLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTitleLabel.ForeColor = Color.White;
            AppTitleLabel.Location = new Point(12, 136);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(226, 23);
            AppTitleLabel.TabIndex = 0;
            AppTitleLabel.Text = "Phần mềm quản lý sinh viên";
            AppTitleLabel.Click += AppTitleLabel_Click;
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppNameLabel.ForeColor = Color.White;
            AppNameLabel.Location = new Point(104, 12);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Size = new Size(102, 41);
            AppNameLabel.TabIndex = 2;
            AppNameLabel.Text = "UTEid";
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.BackgroundImage = Properties.Resources.LogoUTE;
            logoBox.BackgroundImageLayout = ImageLayout.Stretch;
            logoBox.Location = new Point(12, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(86, 106);
            logoBox.TabIndex = 1;
            logoBox.TabStop = false;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.PaleTurquoise;
            HeaderPanel.Controls.Add(SearchIconButton);
            HeaderPanel.Controls.Add(FilterGuna2Button1);
            HeaderPanel.Controls.Add(AddStudentButton);
            HeaderPanel.Controls.Add(SearchTextBox);
            HeaderPanel.Controls.Add(PageTitleLabel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(250, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1153, 101);
            HeaderPanel.TabIndex = 1;
            // 
            // SearchIconButton
            // 
            SearchIconButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchIconButton.BackColor = Color.White;
            SearchIconButton.FlatAppearance.BorderSize = 0;
            SearchIconButton.FlatStyle = FlatStyle.Flat;
            SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            SearchIconButton.IconColor = Color.Black;
            SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchIconButton.IconSize = 15;
            SearchIconButton.Location = new Point(745, 42);
            SearchIconButton.Name = "SearchIconButton";
            SearchIconButton.Size = new Size(20, 20);
            SearchIconButton.TabIndex = 0;
            SearchIconButton.UseVisualStyleBackColor = false;
            // 
            // FilterGuna2Button1
            // 
            FilterGuna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterGuna2Button1.BackColor = Color.Transparent;
            FilterGuna2Button1.BorderColor = Color.Aquamarine;
            FilterGuna2Button1.BorderRadius = 15;
            FilterGuna2Button1.BorderThickness = 3;
            FilterGuna2Button1.CustomizableEdges = customizableEdges1;
            FilterGuna2Button1.DisabledState.BorderColor = Color.DarkGray;
            FilterGuna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            FilterGuna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            FilterGuna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FilterGuna2Button1.FillColor = Color.White;
            FilterGuna2Button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterGuna2Button1.ForeColor = Color.Black;
            FilterGuna2Button1.HoverState.CustomBorderColor = Color.White;
            FilterGuna2Button1.HoverState.ForeColor = Color.Black;
            FilterGuna2Button1.Image = Properties.Resources.filter_icon;
            FilterGuna2Button1.ImageSize = new Size(15, 15);
            FilterGuna2Button1.Location = new Point(815, 26);
            FilterGuna2Button1.Name = "FilterGuna2Button1";
            FilterGuna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            FilterGuna2Button1.Size = new Size(100, 50);
            FilterGuna2Button1.TabIndex = 0;
            FilterGuna2Button1.Text = "Lọc";
            FilterGuna2Button1.UseTransparentBackground = true;
            FilterGuna2Button1.Click += FilterGuna2Button1_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddStudentButton.BackColor = Color.MediumSeaGreen;
            AddStudentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStudentButton.ForeColor = Color.White;
            AddStudentButton.Location = new Point(959, 26);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(158, 50);
            AddStudentButton.TabIndex = 4;
            AddStudentButton.Text = "+ Thêm sinh viên";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.ForeColor = Color.Gray;
            SearchTextBox.Location = new Point(567, 40);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(204, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.Text = "Tìm kiếm sinh viên...";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // PageTitleLabel
            // 
            PageTitleLabel.AutoSize = true;
            PageTitleLabel.BackColor = Color.Transparent;
            PageTitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PageTitleLabel.ForeColor = Color.Teal;
            PageTitleLabel.Location = new Point(65, 30);
            PageTitleLabel.Name = "PageTitleLabel";
            PageTitleLabel.Size = new Size(289, 38);
            PageTitleLabel.TabIndex = 3;
            PageTitleLabel.Text = "Danh Sách Sinh Viên";
            PageTitleLabel.Click += PageTitleLabel_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(iconButton1);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(250, 101);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1153, 627);
            ContentPanel.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(779, 142);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(8, 8);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 728);
            Controls.Add(ContentPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(SidebarPanel);
            Name = "MainForm";
            Text = "MainForm";
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SidebarPanel;
        private Panel HeaderPanel;
        private Panel ContentPanel;
        private Label AppNameLabel;
        private PictureBox logoBox;
        private Label PageTitleLabel;
        private Button AddStudentButton;
        private TextBox SearchTextBox;
        private Label CategoryGeneralLabel;
        private Label AppTitleLabel;
        private Button OverviewButton;
        private Label CategoryManageLabel;
        private Button StudentButton;
        private Label Line1Label;
        private FontAwesome.Sharp.IconButton StudentIconButton;
        private FontAwesome.Sharp.IconButton OverviewIconButton;
        private FontAwesome.Sharp.IconButton SearchIconButton;
        private Guna.UI2.WinForms.Guna2Button FilterGuna2Button1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}