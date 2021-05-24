namespace prog_POE
{
    partial class changePasswordForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmChangeButton = new System.Windows.Forms.Button();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(64, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(174, 26);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "please input your current password \r\nand your new password to update.";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Location = new System.Drawing.Point(13, 67);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.currentPasswordLabel.TabIndex = 1;
            this.currentPasswordLabel.Text = "Current Password:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(13, 111);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 2;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(13, 157);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(119, 13);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Confirm New Password:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmChangeButton
            // 
            this.confirmChangeButton.Location = new System.Drawing.Point(197, 226);
            this.confirmChangeButton.Name = "confirmChangeButton";
            this.confirmChangeButton.Size = new System.Drawing.Size(75, 23);
            this.confirmChangeButton.TabIndex = 5;
            this.confirmChangeButton.Text = "Update";
            this.confirmChangeButton.UseVisualStyleBackColor = true;
            this.confirmChangeButton.Click += new System.EventHandler(this.confirmChangeButton_Click_1);
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Location = new System.Drawing.Point(172, 59);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentPasswordTextBox.TabIndex = 6;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(172, 104);
            this.newPasswordTextBox.MaxLength = 30;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTextBox.TabIndex = 7;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(172, 150);
            this.confirmPassTextBox.MaxLength = 30;
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPassTextBox.TabIndex = 8;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.confirmChangeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "changePasswordForm";
            this.Text = "Update Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmChangeButton;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox confirmPassTextBox;
    }
}