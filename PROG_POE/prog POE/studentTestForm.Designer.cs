namespace prog_POE
{
    partial class studentTestForm
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
            this.takeTestInstructionLabel = new System.Windows.Forms.Label();
            this.tesHubGroupBox = new System.Windows.Forms.GroupBox();
            this.exitTestButton = new System.Windows.Forms.Button();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.testRadioButtonD = new System.Windows.Forms.RadioButton();
            this.testRadioButtonC = new System.Windows.Forms.RadioButton();
            this.testRadioButtonB = new System.Windows.Forms.RadioButton();
            this.testRadioButtonA = new System.Windows.Forms.RadioButton();
            this.testQuestionTextBox = new System.Windows.Forms.TextBox();
            this.testOptionATextBox = new System.Windows.Forms.TextBox();
            this.testOptionDTextBox = new System.Windows.Forms.TextBox();
            this.testOptionCTextBox = new System.Windows.Forms.TextBox();
            this.testOptionBTextBox = new System.Windows.Forms.TextBox();
            this.tesHubGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // takeTestInstructionLabel
            // 
            this.takeTestInstructionLabel.AutoSize = true;
            this.takeTestInstructionLabel.Location = new System.Drawing.Point(47, 20);
            this.takeTestInstructionLabel.Name = "takeTestInstructionLabel";
            this.takeTestInstructionLabel.Size = new System.Drawing.Size(392, 26);
            this.takeTestInstructionLabel.TabIndex = 6;
            this.takeTestInstructionLabel.Text = "Please select the Correct answer and click next question. please be aware that if" +
    "\r\nyou exit the test before completion your unfinished questions will not be regi" +
    "stered.";
            // 
            // tesHubGroupBox
            // 
            this.tesHubGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tesHubGroupBox.Controls.Add(this.testOptionBTextBox);
            this.tesHubGroupBox.Controls.Add(this.testOptionCTextBox);
            this.tesHubGroupBox.Controls.Add(this.testOptionDTextBox);
            this.tesHubGroupBox.Controls.Add(this.testOptionATextBox);
            this.tesHubGroupBox.Controls.Add(this.testQuestionTextBox);
            this.tesHubGroupBox.Controls.Add(this.exitTestButton);
            this.tesHubGroupBox.Controls.Add(this.nextQuestionButton);
            this.tesHubGroupBox.Controls.Add(this.testRadioButtonD);
            this.tesHubGroupBox.Controls.Add(this.testRadioButtonC);
            this.tesHubGroupBox.Controls.Add(this.testRadioButtonB);
            this.tesHubGroupBox.Controls.Add(this.testRadioButtonA);
            this.tesHubGroupBox.Location = new System.Drawing.Point(13, 74);
            this.tesHubGroupBox.Name = "tesHubGroupBox";
            this.tesHubGroupBox.Size = new System.Drawing.Size(473, 328);
            this.tesHubGroupBox.TabIndex = 7;
            this.tesHubGroupBox.TabStop = false;
            this.tesHubGroupBox.Text = "Test Hub";
            // 
            // exitTestButton
            // 
            this.exitTestButton.Location = new System.Drawing.Point(18, 282);
            this.exitTestButton.Name = "exitTestButton";
            this.exitTestButton.Size = new System.Drawing.Size(75, 23);
            this.exitTestButton.TabIndex = 17;
            this.exitTestButton.Text = "Exit Test";
            this.exitTestButton.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(357, 282);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(89, 23);
            this.nextQuestionButton.TabIndex = 16;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // testRadioButtonD
            // 
            this.testRadioButtonD.AutoSize = true;
            this.testRadioButtonD.Location = new System.Drawing.Point(19, 248);
            this.testRadioButtonD.Name = "testRadioButtonD";
            this.testRadioButtonD.Size = new System.Drawing.Size(33, 17);
            this.testRadioButtonD.TabIndex = 15;
            this.testRadioButtonD.TabStop = true;
            this.testRadioButtonD.Text = "D";
            this.testRadioButtonD.UseVisualStyleBackColor = true;
            // 
            // testRadioButtonC
            // 
            this.testRadioButtonC.AutoSize = true;
            this.testRadioButtonC.Location = new System.Drawing.Point(20, 200);
            this.testRadioButtonC.Name = "testRadioButtonC";
            this.testRadioButtonC.Size = new System.Drawing.Size(32, 17);
            this.testRadioButtonC.TabIndex = 14;
            this.testRadioButtonC.TabStop = true;
            this.testRadioButtonC.Text = "C";
            this.testRadioButtonC.UseVisualStyleBackColor = true;
            // 
            // testRadioButtonB
            // 
            this.testRadioButtonB.AutoSize = true;
            this.testRadioButtonB.Location = new System.Drawing.Point(20, 150);
            this.testRadioButtonB.Name = "testRadioButtonB";
            this.testRadioButtonB.Size = new System.Drawing.Size(32, 17);
            this.testRadioButtonB.TabIndex = 13;
            this.testRadioButtonB.TabStop = true;
            this.testRadioButtonB.Text = "B";
            this.testRadioButtonB.UseVisualStyleBackColor = true;
            // 
            // testRadioButtonA
            // 
            this.testRadioButtonA.AutoSize = true;
            this.testRadioButtonA.Location = new System.Drawing.Point(20, 98);
            this.testRadioButtonA.Name = "testRadioButtonA";
            this.testRadioButtonA.Size = new System.Drawing.Size(32, 17);
            this.testRadioButtonA.TabIndex = 12;
            this.testRadioButtonA.TabStop = true;
            this.testRadioButtonA.Text = "A";
            this.testRadioButtonA.UseVisualStyleBackColor = true;
            // 
            // testQuestionTextBox
            // 
            this.testQuestionTextBox.Location = new System.Drawing.Point(79, 19);
            this.testQuestionTextBox.Multiline = true;
            this.testQuestionTextBox.Name = "testQuestionTextBox";
            this.testQuestionTextBox.ReadOnly = true;
            this.testQuestionTextBox.Size = new System.Drawing.Size(347, 48);
            this.testQuestionTextBox.TabIndex = 18;
            // 
            // testOptionATextBox
            // 
            this.testOptionATextBox.Location = new System.Drawing.Point(79, 89);
            this.testOptionATextBox.Multiline = true;
            this.testOptionATextBox.Name = "testOptionATextBox";
            this.testOptionATextBox.ReadOnly = true;
            this.testOptionATextBox.Size = new System.Drawing.Size(347, 26);
            this.testOptionATextBox.TabIndex = 19;
            // 
            // testOptionDTextBox
            // 
            this.testOptionDTextBox.Location = new System.Drawing.Point(79, 239);
            this.testOptionDTextBox.Multiline = true;
            this.testOptionDTextBox.Name = "testOptionDTextBox";
            this.testOptionDTextBox.ReadOnly = true;
            this.testOptionDTextBox.Size = new System.Drawing.Size(347, 26);
            this.testOptionDTextBox.TabIndex = 20;
            // 
            // testOptionCTextBox
            // 
            this.testOptionCTextBox.Location = new System.Drawing.Point(79, 191);
            this.testOptionCTextBox.Multiline = true;
            this.testOptionCTextBox.Name = "testOptionCTextBox";
            this.testOptionCTextBox.ReadOnly = true;
            this.testOptionCTextBox.Size = new System.Drawing.Size(347, 26);
            this.testOptionCTextBox.TabIndex = 21;
            // 
            // testOptionBTextBox
            // 
            this.testOptionBTextBox.Location = new System.Drawing.Point(79, 141);
            this.testOptionBTextBox.Multiline = true;
            this.testOptionBTextBox.Name = "testOptionBTextBox";
            this.testOptionBTextBox.ReadOnly = true;
            this.testOptionBTextBox.Size = new System.Drawing.Size(347, 26);
            this.testOptionBTextBox.TabIndex = 22;
            // 
            // studentTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 415);
            this.Controls.Add(this.tesHubGroupBox);
            this.Controls.Add(this.takeTestInstructionLabel);
            this.Name = "studentTestForm";
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentTestForm_FormClosing);
            this.tesHubGroupBox.ResumeLayout(false);
            this.tesHubGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label takeTestInstructionLabel;
        private System.Windows.Forms.GroupBox tesHubGroupBox;
        private System.Windows.Forms.Button exitTestButton;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.RadioButton testRadioButtonD;
        private System.Windows.Forms.RadioButton testRadioButtonC;
        private System.Windows.Forms.RadioButton testRadioButtonB;
        private System.Windows.Forms.RadioButton testRadioButtonA;
        private System.Windows.Forms.TextBox testQuestionTextBox;
        private System.Windows.Forms.TextBox testOptionBTextBox;
        private System.Windows.Forms.TextBox testOptionCTextBox;
        private System.Windows.Forms.TextBox testOptionDTextBox;
        private System.Windows.Forms.TextBox testOptionATextBox;
    }
}