namespace siomai
{
    partial class orderForm
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
            dgvOrders = new DataGridView();
            btnAddItem = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbMenuItems = new ComboBox();
            lblTotalPrice = new Label();
            numQuantity = new NumericUpDown();
            lstOrderItems = new ListBox();
            btnPlaceOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(272, 272);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(493, 145);
            dgvOrders.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(197, 222);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "ADD";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(364, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(532, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbMenuItems
            // 
            cmbMenuItems.FormattingEnabled = true;
            cmbMenuItems.Location = new Point(53, 117);
            cmbMenuItems.Name = "cmbMenuItems";
            cmbMenuItems.Size = new Size(171, 23);
            cmbMenuItems.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(252, 120);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 15);
            lblTotalPrice.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(87, 161);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 8;
            // 
            // lstOrderItems
            // 
            lstOrderItems.FormattingEnabled = true;
            lstOrderItems.ItemHeight = 15;
            lstOrderItems.Location = new Point(430, 27);
            lstOrderItems.Name = "lstOrderItems";
            lstOrderItems.Size = new Size(311, 169);
            lstOrderItems.TabIndex = 9;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(114, 325);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(93, 23);
            btnPlaceOrder.TabIndex = 10;
            btnPlaceOrder.Text = "PLACE ORDER";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // orderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lstOrderItems);
            Controls.Add(numQuantity);
            Controls.Add(lblTotalPrice);
            Controls.Add(cmbMenuItems);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddItem);
            Controls.Add(dgvOrders);
            Name = "orderForm";
            Text = "orderForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnAddItem;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmbMenuItems;
        private Label lblTotalPrice;
        private NumericUpDown numQuantity;
        private ListBox lstOrderItems;
        private Button btnPlaceOrder;
    }
}