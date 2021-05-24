namespace prog_POE
{
    partial class teacherForm
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
            this.teacherInstructionLabel = new System.Windows.Forms.Label();
            this.TeacherTabControl = new System.Windows.Forms.TabControl();
            this.createTestTab = new System.Windows.Forms.TabPage();
            this.createTestGroupBox = new System.Windows.Forms.GroupBox();
            this.finishCreationButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.optionDTextBox = new System.Windows.Forms.TextBox();
            this.optionCTextBox = new System.Windows.Forms.TextBox();
            this.optionBTextBox = new System.Windows.Forms.TextBox();
            this.optionATextBox = new System.Windows.Forms.TextBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.createTestButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.viewMarksTab = new System.Windows.Forms.TabPage();
            this.viewMarksTextBox = new System.Windows.Forms.TextBox();
            this.registerUserTab = new System.Windows.Forms.TabPage();
            this.addUserButton = new System.Windows.Forms.Button();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.TeacherTabControl.SuspendLayout();
            this.createTestTab.SuspendLayout();
            this.createTestGroupBox.SuspendLayout();
            this.viewMarksTab.SuspendLayout();
            this.registerUserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherInstructionLabel
            // 
            this.teacherInstructionLabel.AutoSize = true;
            this.teacherInstructionLabel.Location = new System.Drawing.Point(170, 9);
            this.teacherInstructionLabel.Name = "teacherInstructionLabel";
            this.teacherInstructionLabel.Size = new System.Drawing.Size(224, 26);
            this.teacherInstructionLabel.TabIndex = 3;
            this.teacherInstructionLabel.Text = "From this window you may register new users,\r\nview the students marks, or create " +
    "a new test.";
            this.teacherInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeacherTabControl
            // 
            this.TeacherTabControl.Controls.Add(this.createTestTab);
            this.TeacherTabControl.Controls.Add(this.viewMarksTab);
            this.TeacherTabControl.Controls.Add(this.registerUserTab);
            this.TeacherTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTabControl.Location = new System.Drawing.Point(10, 57);
            this.TeacherTabControl.Name = "TeacherTabControl";
            this.TeacherTabControl.SelectedIndex = 0;
            this.TeacherTabControl.Size = new System.Drawing.Size(551, 329);
            this.TeacherTabControl.TabIndex = 4;
            // 
            // createTestTab
            // 
            this.createTestTab.Controls.Add(this.createTestGroupBox);
            this.createTestTab.Controls.Add(this.createTestButton);
            this.createTestTab.Controls.Add(this.confirmationLabel);
            this.createTestTab.Location = new System.Drawing.Point(4, 22);
            this.createTestTab.Name = "createTestTab";
            this.createTestTab.Padding = new System.Windows.Forms.Padding(3);
            this.createTestTab.Size = new System.Drawing.Size(543, 303);
            this.createTestTab.TabIndex = 0;
            this.createTestTab.Text = "Create Test";
            this.createTestTab.UseVisualStyleBackColor = true;
            // 
            // createTestGroupBox
            // 
            this.createTestGroupBox.Controls.Add(this.finishCreationButton);
            this.createTestGroupBox.Controls.Add(this.addQuestionButton);
            this.createTestGroupBox.Controls.Add(this.optionDTextBox);
            this.createTestGroupBox.Controls.Add(this.optionCTextBox);
            this.createTestGroupBox.Controls.Add(this.optionBTextBox);
            this.createTestGroupBox.Controls.Add(this.optionATextBox);
            this.createTestGroupBox.Controls.Add(this.radioButtonD);
            this.createTestGroupBox.Controls.Add(this.radioButtonC);
            this.createTestGroupBox.Controls.Add(this.radioButtonB);
            this.createTestGroupBox.Controls.Add(this.radioButtonA);
            this.createTestGroupBox.Controls.Add(this.questionTextBox);
            this.createTestGroupBox.Controls.Add(this.questionLabel);
            this.createTestGroupBox.Location = new System.Drawing.Point(2, 3);
            this.createTestGroupBox.Name = "createTestGroupBox";
            this.createTestGroupBox.Size = new System.Drawing.Size(531, 291);
            this.createTestGroupBox.TabIndex = 2;
            this.createTestGroupBox.TabStop = false;
            this.createTestGroupBox.Text = "Test Editor";
            // 
            // finishCreationButton
            // 
            this.finishCreationButton.Location = new System.Drawing.Point(7, 261);
            this.finishCreationButton.Name = "finishCreationButton";
            this.finishCreationButton.Size = new System.Drawing.Size(75, 23);
            this.finishCreationButton.TabIndex = 14;
            this.finishCreationButton.Text = "Finalise";
            this.finishCreationButton.UseVisualStyleBackColor = true;
            this.finishCreationButton.Click += new System.EventHandler(this.finishCreationButton_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(450, 262);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.addQuestionButton.TabIndex = 13;
            this.addQuestionButton.Text = "Add Question";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // optionDTextBox
            // 
            this.optionDTextBox.Location = new System.Drawing.Point(96, 206);
            this.optionDTextBox.MaxLength = 500;
            this.optionDTextBox.Name = "optionDTextBox";
            this.optionDTextBox.Size = new System.Drawing.Size(329, 20);
            this.optionDTextBox.TabIndex = 12;
            // 
            // optionCTextBox
            // 
            this.optionCTextBox.Location = new System.Drawing.Point(96, 170);
            this.optionCTextBox.MaxLength = 500;
            this.optionCTextBox.Name = "optionCTextBox";
            this.optionCTextBox.Size = new System.Drawing.Size(329, 20);
            this.optionCTextBox.TabIndex = 11;
            // 
            // optionBTextBox
            // 
            this.optionBTextBox.Location = new System.Drawing.Point(96, 134);
            this.optionBTextBox.MaxLength = 500;
            this.optionBTextBox.Name = "optionBTextBox";
            this.optionBTextBox.Size = new System.Drawing.Size(329, 20);
            this.optionBTextBox.TabIndex = 10;
            // 
            // optionATextBox
            // 
            this.optionATextBox.Location = new System.Drawing.Point(96, 95);
            this.optionATextBox.MaxLength = 500;
            this.optionATextBox.Name = "optionATextBox";
            this.optionATextBox.Size = new System.Drawing.Size(329, 20);
            this.optionATextBox.TabIndex = 9;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonD.Location = new System.Drawing.Point(22, 209);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(33, 17);
            this.radioButtonD.TabIndex = 5;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(22, 173);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(22, 137);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(22, 98);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(96, 29);
            this.questionTextBox.MaxLength = 500;
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(225, 42);
            this.questionTextBox.TabIndex = 1;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(19, 37);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(52, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question:";
            // 
            // createTestButton
            // 
            this.createTestButton.Location = new System.Drawing.Point(217, 54);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(75, 23);
            this.createTestButton.TabIndex = 1;
            this.createTestButton.Text = "Create Test";
            this.createTestButton.UseVisualStyleBackColor = true;
            this.createTestButton.Click += new System.EventHandler(this.createTestButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(110, 12);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(318, 26);
            this.confirmationLabel.TabIndex = 0;
            this.confirmationLabel.Text = "Please be aware that if you create a new test all students answers\r\nand marks wil" +
    "l be deleted and the current test will be removed.";
            // 
            // viewMarksTab
            // 
            this.viewMarksTab.Controls.Add(this.viewMarksTextBox);
            this.viewMarksTab.Location = new System.Drawing.Point(4, 22);
            this.viewMarksTab.Name = "viewMarksTab";
            this.viewMarksTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewMarksTab.Size = new System.Drawing.Size(543, 303);
            this.viewMarksTab.TabIndex = 1;
            this.viewMarksTab.Text = "View Marks";
            this.viewMarksTab.UseVisualStyleBackColor = true;
            // 
            // viewMarksTextBox
            // 
            this.viewMarksTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMarksTextBox.Location = new System.Drawing.Point(4, 7);
            this.viewMarksTextBox.Multiline = true;
            this.viewMarksTextBox.Name = "viewMarksTextBox";
            this.viewMarksTextBox.ReadOnly = true;
            this.viewMarksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewMarksTextBox.Size = new System.Drawing.Size(533, 290);
            this.viewMarksTextBox.TabIndex = 0;
            // 
            // registerUserTab
            // 
            this.registerUserTab.Controls.Add(this.addUserButton);
            this.registerUserTab.Controls.Add(this.accountTypeComboBox);
            this.registerUserTab.Controls.Add(this.surnameTextBox);
            this.registerUserTab.Controls.Add(this.usernameTextBox);
            this.registerUserTab.Controls.Add(this.nameTextBox);
            this.registerUserTab.Controls.Add(this.accountTypeLabel);
            this.registerUserTab.Controls.Add(this.usernameLabel);
            this.registerUserTab.Controls.Add(this.surnameLabel);
            this.registerUserTab.Controls.Add(this.nameLabel);
            this.registerUserTab.Location = new System.Drawing.Point(4, 22);
            this.registerUserTab.Name = "registerUserTab";
            this.registerUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerUserTab.Size = new System.Drawing.Size(543, 303);
            this.registerUserTab.TabIndex = 2;
            this.registerUserTab.Text = "Register User";
            this.registerUserTab.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(451, 274);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(86, 23);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "Add New User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(172, 131);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountTypeComboBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(172, 58);
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(172, 94);
            this.usernameTextBox.MaxLength = 30;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(172, 25);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(7, 140);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(77, 13);
            this.accountTypeLabel.TabIndex = 3;
            this.accountTypeLabel.Text = "Account Type:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(7, 101);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(7, 65);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(16, 392);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(102, 23);
            this.changePasswordButton.TabIndex = 5;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(481, 392);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 6;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // teacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 427);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.TeacherTabControl);
            this.Controls.Add(this.teacherInstructionLabel);
            this.Name = "teacherForm";
            this.Text = "Teacher Dashboard";
            this.TeacherTabControl.ResumeLayout(false);
            this.createTestTab.ResumeLayout(false);
            this.createTestTab.PerformLayout();
            this.createTestGroupBox.ResumeLayout(false);
            this.createTestGroupBox.PerformLayout();
            this.viewMarksTab.ResumeLayout(false);
            this.viewMarksTab.PerformLayout();
            this.registerUserTab.ResumeLayout(false);
            this.registerUserTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherInstructionLabel;
        private System.Windows.Forms.TabControl TeacherTabControl;
        private System.Windows.Forms.TabPage createTestTab;
        private System.Windows.Forms.TabPage viewMarksTab;
        private System.Windows.Forms.TabPage registerUserTab;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.TextBox viewMarksTextBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.GroupBox createTestGroupBox;
        private System.Windows.Forms.TextBox optionDTextBox;
        private System.Windows.Forms.TextBox optionCTextBox;
        private System.Windows.Forms.TextBox optionBTextBox;
        private System.Windows.Forms.TextBox optionATextBox;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button createTestButton;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button finishCreationButton;
    }
}