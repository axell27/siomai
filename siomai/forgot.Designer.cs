namespace siomai
{
    partial class forgot
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
            groupBox1 = new GroupBox();
            checkUsernameButton = new Button();
            label1 = new Label();
            usernameTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(checkUsernameButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // checkUsernameButton
            // 
            checkUsernameButton.Location = new Point(258, 125);
            checkUsernameButton.Name = "checkUsernameButton";
            checkUsernameButton.Size = new Size(105, 33);
            checkUsernameButton.TabIndex = 2;
            checkUsernameButton.Text = "Enter";
            checkUsernameButton.UseVisualStyleBackColor = true;
            checkUsernameButton.Click += checkUsernameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 84);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(202, 82);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(234, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // forgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 217);
            Controls.Add(groupBox1);
            Name = "forgot";
            Text = "forgot";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox usernameTextBox;
        private Button checkUsernameButton;
    }
}