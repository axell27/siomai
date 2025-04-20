namespace siomai
{
    partial class AdminMenuForm
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            lstMenuItems = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(292, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 23);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(292, 207);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 23);
            txtPrice.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(346, 255);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(65, 24);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(602, 367);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(75, 26);
            btnDeleteItem.TabIndex = 4;
            btnDeleteItem.Text = "delete item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // lstMenuItems
            // 
            lstMenuItems.Location = new Point(493, 12);
            lstMenuItems.Name = "lstMenuItems";
            lstMenuItems.Size = new Size(295, 349);
            lstMenuItems.TabIndex = 5;
            lstMenuItems.UseCompatibleStateImageBehavior = false;
            lstMenuItems.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 143);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "SiomaiKing Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 210);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(434, 40);
            label3.TabIndex = 8;
            label3.Text = "SIOMAI KING BACKROOMS";
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstMenuItems);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Name = "AdminMenuForm";
            Text = "AdminMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private ListView lstMenuItems;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}