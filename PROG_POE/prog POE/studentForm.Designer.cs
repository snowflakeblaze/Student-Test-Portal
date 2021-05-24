namespace prog_POE
{
    partial class studentForm
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
            this.studentDashInstructionLabel = new System.Windows.Forms.Label();
            this.takeTestButton = new System.Windows.Forms.Button();
            this.viewMemoButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentDashInstructionLabel
            // 
            this.studentDashInstructionLabel.AutoSize = true;
            this.studentDashInstructionLabel.Location = new System.Drawing.Point(34, 9);
            this.studentDashInstructionLabel.Name = "studentDashInstructionLabel";
            this.studentDashInstructionLabel.Size = new System.Drawing.Size(196, 52);
            this.studentDashInstructionLabel.TabIndex = 0;
            this.studentDashInstructionLabel.Text = "This is your student dashboard, from this\r\nwindow you  may choose to\r\ntake a test" +
    " or view the memo\r\nof a test you have taken already.";
            this.studentDashInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // takeTestButton
            // 
            this.takeTestButton.Location = new System.Drawing.Point(92, 80);
            this.takeTestButton.Name = "takeTestButton";
            this.takeTestButton.Size = new System.Drawing.Size(75, 23);
            this.takeTestButton.TabIndex = 1;
            this.takeTestButton.Text = "TakeTest";
            this.takeTestButton.UseVisualStyleBackColor = true;
            this.takeTestButton.Click += new System.EventHandler(this.takeTestButton_Click);
            // 
            // viewMemoButton
            // 
            this.viewMemoButton.Location = new System.Drawing.Point(92, 139);
            this.viewMemoButton.Name = "viewMemoButton";
            this.viewMemoButton.Size = new System.Drawing.Size(75, 23);
            this.viewMemoButton.TabIndex = 2;
            this.viewMemoButton.Text = "View Memo";
            this.viewMemoButton.UseVisualStyleBackColor = true;
            this.viewMemoButton.Click += new System.EventHandler(this.viewMemoButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(15, 226);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(106, 23);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(177, 226);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 4;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.viewMemoButton);
            this.Controls.Add(this.takeTestButton);
            this.Controls.Add(this.studentDashInstructionLabel);
            this.Name = "studentForm";
            this.Text = "Student Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentDashInstructionLabel;
        private System.Windows.Forms.Button takeTestButton;
        private System.Windows.Forms.Button viewMemoButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button signOutButton;
    }
}