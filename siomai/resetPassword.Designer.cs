namespace siomai
{
    partial class resetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetPassword));
            groupBox1 = new GroupBox();
            resetPasswordButton = new Button();
            label3 = new Label();
            label2 = new Label();
            confirmPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resetPasswordButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(confirmPasswordTextBox);
            groupBox1.Controls.Add(newPasswordTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(114, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.Location = new Point(130, 203);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(75, 23);
            resetPasswordButton.TabIndex = 5;
            resetPasswordButton.Text = "Reset";
            resetPasswordButton.UseVisualStyleBackColor = true;
            resetPasswordButton.Click += resetPasswordButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 174);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "confirm new password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 111);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 3;
            label2.Text = "enter new password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(93, 148);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(149, 23);
            confirmPasswordTextBox.TabIndex = 2;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(93, 85);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(149, 23);
            newPasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 31);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Reset Password";
            // 
            // resetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 352);
            Controls.Add(groupBox1);
            Name = "resetPassword";
            Text = "resetPassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox confirmPasswordTextBox;
        private TextBox newPasswordTextBox;
        private Button resetPasswordButton;
    }
}