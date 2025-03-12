namespace siomai
{
    partial class verifyOTP
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
            otpTextBox = new TextBox();
            verifyOTPButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // otpTextBox
            // 
            otpTextBox.Location = new Point(133, 137);
            otpTextBox.Name = "otpTextBox";
            otpTextBox.Size = new Size(199, 23);
            otpTextBox.TabIndex = 0;
            // 
            // verifyOTPButton
            // 
            verifyOTPButton.Location = new Point(203, 176);
            verifyOTPButton.Name = "verifyOTPButton";
            verifyOTPButton.Size = new Size(58, 29);
            verifyOTPButton.TabIndex = 1;
            verifyOTPButton.Text = "Enter";
            verifyOTPButton.UseVisualStyleBackColor = true;
            verifyOTPButton.Click += verifyOTPButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 98);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter OTP";
            // 
            // verifyOTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(459, 296);
            Controls.Add(label1);
            Controls.Add(verifyOTPButton);
            Controls.Add(otpTextBox);
            Name = "verifyOTP";
            Text = "verifyOTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox otpTextBox;
        private Button verifyOTPButton;
        private Label label1;
    }
}