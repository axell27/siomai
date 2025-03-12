namespace siomai
{
    partial class securityQuestion
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
            securityQuestionLabel = new Label();
            securityAnswerTextBox = new TextBox();
            verifyAnswerButton = new Button();
            SuspendLayout();
            // 
            // securityQuestionLabel
            // 
            securityQuestionLabel.AutoSize = true;
            securityQuestionLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            securityQuestionLabel.Location = new Point(63, 85);
            securityQuestionLabel.Name = "securityQuestionLabel";
            securityQuestionLabel.Size = new Size(209, 28);
            securityQuestionLabel.TabIndex = 0;
            securityQuestionLabel.Text = "SECURITY QUESTION";
            // 
            // securityAnswerTextBox
            // 
            securityAnswerTextBox.Location = new Point(86, 137);
            securityAnswerTextBox.Name = "securityAnswerTextBox";
            securityAnswerTextBox.Size = new Size(209, 23);
            securityAnswerTextBox.TabIndex = 1;
            // 
            // verifyAnswerButton
            // 
            verifyAnswerButton.Location = new Point(156, 178);
            verifyAnswerButton.Name = "verifyAnswerButton";
            verifyAnswerButton.Size = new Size(75, 23);
            verifyAnswerButton.TabIndex = 2;
            verifyAnswerButton.Text = "Verify";
            verifyAnswerButton.UseVisualStyleBackColor = true;
            verifyAnswerButton.Click += verifyAnswerButton_Click;
            // 
            // securityQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(365, 252);
            Controls.Add(verifyAnswerButton);
            Controls.Add(securityAnswerTextBox);
            Controls.Add(securityQuestionLabel);
            Name = "securityQuestion";
            Text = "securityQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label securityQuestionLabel;
        private TextBox securityAnswerTextBox;
        private Button verifyAnswerButton;
    }
}