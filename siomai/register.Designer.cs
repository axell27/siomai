namespace siomai
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label1 = new Label();
            passwordTextBox = new TextBox();
            label3 = new Label();
            confirmPasswordTextBox = new TextBox();
            label4 = new Label();
            registerButton = new Button();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(357, 50);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 16;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.MenuBar;
            usernameTextBox.Location = new Point(304, 75);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(205, 23);
            usernameTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(360, 113);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 18;
            label1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.MenuBar;
            passwordTextBox.Location = new Point(304, 138);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(205, 23);
            passwordTextBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(316, 183);
            label3.Name = "label3";
            label3.Size = new Size(183, 22);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = SystemColors.MenuBar;
            confirmPasswordTextBox.Location = new Point(304, 208);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(205, 23);
            confirmPasswordTextBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(316, 311);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 22;
            label4.Text = "Already have an account?";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Transparent;
            registerButton.BackgroundImage = (Image)resources.GetObject("registerButton.BackgroundImage");
            registerButton.BackgroundImageLayout = ImageLayout.None;
            registerButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.Transparent;
            registerButton.ImageKey = "(none)";
            registerButton.Location = new Point(346, 247);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 37);
            registerButton.TabIndex = 23;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(453, 311);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(37, 15);
            linkLabel2.TabIndex = 24;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(537, 358);
            Controls.Add(linkLabel2);
            Controls.Add(registerButton);
            Controls.Add(label4);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "register";
            Text = "register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label1;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox confirmPasswordTextBox;
        private Label label4;
        private Button registerButton;
        private LinkLabel linkLabel2;
    }
}