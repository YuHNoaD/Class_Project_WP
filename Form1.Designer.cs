namespace ComplexNumber
{
    partial class Form1
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
            this.realLabel = new System.Windows.Forms.Label();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.realTextBox = new System.Windows.Forms.TextBox();
            this.imaginaryTextBox = new System.Windows.Forms.TextBox();
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.mutiplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // realLabel
            // 
            this.realLabel.AutoSize = true;
            this.realLabel.Location = new System.Drawing.Point(55, 85);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(36, 16);
            this.realLabel.TabIndex = 0;
            this.realLabel.Text = "Real";
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.AutoSize = true;
            this.imaginaryLabel.Location = new System.Drawing.Point(55, 181);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(66, 16);
            this.imaginaryLabel.TabIndex = 1;
            this.imaginaryLabel.Text = "Imaginary";
            this.imaginaryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(55, 395);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 16);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Notice:";
            this.statusLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // realTextBox
            // 
            this.realTextBox.Location = new System.Drawing.Point(169, 79);
            this.realTextBox.Name = "realTextBox";
            this.realTextBox.Size = new System.Drawing.Size(156, 22);
            this.realTextBox.TabIndex = 3;
            // 
            // imaginaryTextBox
            // 
            this.imaginaryTextBox.Location = new System.Drawing.Point(169, 175);
            this.imaginaryTextBox.Name = "imaginaryTextBox";
            this.imaginaryTextBox.Size = new System.Drawing.Size(156, 22);
            this.imaginaryTextBox.TabIndex = 4;
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(375, 78);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(95, 23);
            this.firstButton.TabIndex = 5;
            this.firstButton.Text = "Set No 1";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(375, 174);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(95, 23);
            this.secondButton.TabIndex = 6;
            this.secondButton.Text = "Set No 2";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(209, 300);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(107, 23);
            this.substractButton.TabIndex = 8;
            this.substractButton.Text = "Substract";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // mutiplyButton
            // 
            this.mutiplyButton.Location = new System.Drawing.Point(384, 295);
            this.mutiplyButton.Name = "mutiplyButton";
            this.mutiplyButton.Size = new System.Drawing.Size(75, 33);
            this.mutiplyButton.TabIndex = 9;
            this.mutiplyButton.Text = "Mutify";
            this.mutiplyButton.UseVisualStyleBackColor = true;
            this.mutiplyButton.Click += new System.EventHandler(this.mutiplyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mutiplyButton);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.imaginaryTextBox);
            this.Controls.Add(this.realTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.realLabel);
            this.Name = "Form1";
            this.Text = "ComplexNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox realTextBox;
        private System.Windows.Forms.TextBox imaginaryTextBox;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button mutiplyButton;
    }
}

