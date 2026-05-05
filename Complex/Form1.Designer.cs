namespace Complex
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
            this.realTB = new System.Windows.Forms.TextBox();
            this.imaginaryTB = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Multify = new System.Windows.Forms.Button();
            this.Set2 = new System.Windows.Forms.Button();
            this.Set1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // realTB
            // 
            this.realTB.Location = new System.Drawing.Point(513, 119);
            this.realTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.realTB.Name = "realTB";
            this.realTB.Size = new System.Drawing.Size(192, 22);
            this.realTB.TabIndex = 0;
            this.realTB.TextChanged += new System.EventHandler(this.realTB_TextChanged);
            // 
            // imaginaryTB
            // 
            this.imaginaryTB.Location = new System.Drawing.Point(513, 203);
            this.imaginaryTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imaginaryTB.Name = "imaginaryTB";
            this.imaginaryTB.Size = new System.Drawing.Size(187, 22);
            this.imaginaryTB.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(235, 267);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(188, 44);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(513, 267);
            this.Substract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(188, 44);
            this.Substract.TabIndex = 3;
            this.Substract.Text = "Substract";
            this.Substract.UseVisualStyleBackColor = true;
            // 
            // Multify
            // 
            this.Multify.Location = new System.Drawing.Point(800, 267);
            this.Multify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multify.Name = "Multify";
            this.Multify.Size = new System.Drawing.Size(188, 44);
            this.Multify.TabIndex = 4;
            this.Multify.Text = "Multify";
            this.Multify.UseVisualStyleBackColor = true;
            this.Multify.Click += new System.EventHandler(this.button3_Click);
            // 
            // Set2
            // 
            this.Set2.Location = new System.Drawing.Point(800, 192);
            this.Set2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Set2.Name = "Set2";
            this.Set2.Size = new System.Drawing.Size(188, 44);
            this.Set2.TabIndex = 5;
            this.Set2.Text = "Set No 2";
            this.Set2.UseVisualStyleBackColor = true;
            // 
            // Set1
            // 
            this.Set1.Location = new System.Drawing.Point(800, 108);
            this.Set1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Set1.Name = "Set1";
            this.Set1.Size = new System.Drawing.Size(188, 44);
            this.Set1.TabIndex = 6;
            this.Set1.Text = "Set No 1";
            this.Set1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Real";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imaginary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(267, 345);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            this.statusLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Set1);
            this.Controls.Add(this.Set2);
            this.Controls.Add(this.Multify);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.imaginaryTB);
            this.Controls.Add(this.realTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ComplexNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox realTB;
        private System.Windows.Forms.TextBox imaginaryTB;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multify;
        private System.Windows.Forms.Button Set2;
        private System.Windows.Forms.Button Set1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
    }
}

