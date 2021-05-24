namespace prog_POE
{
    partial class studentMemoForm
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.yourAnswerLabel = new System.Windows.Forms.Label();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.yourAnswerTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerTextbox = new System.Windows.Forms.TextBox();
            this.yourChar = new System.Windows.Forms.Label();
            this.correctChar = new System.Windows.Forms.Label();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(111, 26);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(0, 13);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(470, 324);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.nextQuestionButton.TabIndex = 1;
            this.nextQuestionButton.Text = "Next";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(13, 103);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(94, 13);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "The question was:";
            // 
            // yourAnswerLabel
            // 
            this.yourAnswerLabel.AutoSize = true;
            this.yourAnswerLabel.Location = new System.Drawing.Point(13, 171);
            this.yourAnswerLabel.Name = "yourAnswerLabel";
            this.yourAnswerLabel.Size = new System.Drawing.Size(78, 13);
            this.yourAnswerLabel.TabIndex = 4;
            this.yourAnswerLabel.Text = "You answered:";
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Location = new System.Drawing.Point(19, 232);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(78, 13);
            this.correctAnswerLabel.TabIndex = 5;
            this.correctAnswerLabel.Text = "Correct answer";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(179, 90);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(347, 26);
            this.questionTextBox.TabIndex = 20;
            // 
            // yourAnswerTextBox
            // 
            this.yourAnswerTextBox.Location = new System.Drawing.Point(179, 158);
            this.yourAnswerTextBox.Multiline = true;
            this.yourAnswerTextBox.Name = "yourAnswerTextBox";
            this.yourAnswerTextBox.ReadOnly = true;
            this.yourAnswerTextBox.Size = new System.Drawing.Size(347, 26);
            this.yourAnswerTextBox.TabIndex = 21;
            // 
            // correctAnswerTextbox
            // 
            this.correctAnswerTextbox.Location = new System.Drawing.Point(179, 219);
            this.correctAnswerTextbox.Multiline = true;
            this.correctAnswerTextbox.Name = "correctAnswerTextbox";
            this.correctAnswerTextbox.ReadOnly = true;
            this.correctAnswerTextbox.Size = new System.Drawing.Size(347, 26);
            this.correctAnswerTextbox.TabIndex = 22;
            // 
            // yourChar
            // 
            this.yourChar.AutoSize = true;
            this.yourChar.Location = new System.Drawing.Point(111, 171);
            this.yourChar.Name = "yourChar";
            this.yourChar.Size = new System.Drawing.Size(35, 13);
            this.yourChar.TabIndex = 23;
            this.yourChar.Text = "label1";
            // 
            // correctChar
            // 
            this.correctChar.AutoSize = true;
            this.correctChar.Location = new System.Drawing.Point(111, 232);
            this.correctChar.Name = "correctChar";
            this.correctChar.Size = new System.Drawing.Size(35, 13);
            this.correctChar.TabIndex = 24;
            this.correctChar.Text = "label2";
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.Location = new System.Drawing.Point(16, 13);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(35, 13);
            this.questionCountLabel.TabIndex = 25;
            this.questionCountLabel.Text = "label1";
            // 
            // studentMemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.correctChar);
            this.Controls.Add(this.yourChar);
            this.Controls.Add(this.correctAnswerTextbox);
            this.Controls.Add(this.yourAnswerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.correctAnswerLabel);
            this.Controls.Add(this.yourAnswerLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.greetingLabel);
            this.Name = "studentMemoForm";
            this.Text = "Memo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label yourAnswerLabel;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox yourAnswerTextBox;
        private System.Windows.Forms.TextBox correctAnswerTextbox;
        private System.Windows.Forms.Label yourChar;
        private System.Windows.Forms.Label correctChar;
        private System.Windows.Forms.Label questionCountLabel;
    }
}