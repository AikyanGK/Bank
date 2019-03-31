namespace LA4_Carreon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogInButton = new System.Windows.Forms.Button();
            this.PinLabel = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.AccNumTextBox = new System.Windows.Forms.TextBox();
            this.AccNumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxForm1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(191, 185);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(100, 23);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinLabel.Location = new System.Drawing.Point(154, 143);
            this.PinLabel.Name = "PinLabel";
            this.PinLabel.Size = new System.Drawing.Size(31, 15);
            this.PinLabel.TabIndex = 5;
            this.PinLabel.Text = "Pin:";
            // 
            // PinTextBox
            // 
            this.PinTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinTextBox.Location = new System.Drawing.Point(191, 138);
            this.PinTextBox.Multiline = true;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(100, 20);
            this.PinTextBox.TabIndex = 3;
            this.PinTextBox.TextChanged += new System.EventHandler(this.PinTextBox_TextChanged);
            // 
            // AccNumTextBox
            // 
            this.AccNumTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumTextBox.Location = new System.Drawing.Point(191, 112);
            this.AccNumTextBox.Multiline = true;
            this.AccNumTextBox.Name = "AccNumTextBox";
            this.AccNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccNumTextBox.TabIndex = 2;
            this.AccNumTextBox.TextChanged += new System.EventHandler(this.AccNumTextBox_TextChanged);
            // 
            // AccNumLabel
            // 
            this.AccNumLabel.AutoSize = true;
            this.AccNumLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumLabel.Location = new System.Drawing.Point(70, 117);
            this.AccNumLabel.Name = "AccNumLabel";
            this.AccNumLabel.Size = new System.Drawing.Size(115, 15);
            this.AccNumLabel.TabIndex = 4;
            this.AccNumLabel.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Savings Account for Faculty/Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupBoxForm1
            // 
            this.GroupBoxForm1.Controls.Add(this.LogInButton);
            this.GroupBoxForm1.Controls.Add(this.AccNumLabel);
            this.GroupBoxForm1.Controls.Add(this.PinLabel);
            this.GroupBoxForm1.Controls.Add(this.label1);
            this.GroupBoxForm1.Controls.Add(this.AccNumTextBox);
            this.GroupBoxForm1.Controls.Add(this.PinTextBox);
            this.GroupBoxForm1.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxForm1.Location = new System.Drawing.Point(39, 24);
            this.GroupBoxForm1.Name = "GroupBoxForm1";
            this.GroupBoxForm1.Size = new System.Drawing.Size(412, 258);
            this.GroupBoxForm1.TabIndex = 7;
            this.GroupBoxForm1.TabStop = false;
            this.GroupBoxForm1.Text = "Adamson University";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 294);
            this.Controls.Add(this.GroupBoxForm1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adamson University";
            this.GroupBoxForm1.ResumeLayout(false);
            this.GroupBoxForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.TextBox AccNumTextBox;
        private System.Windows.Forms.Label AccNumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxForm1;
    }
}

