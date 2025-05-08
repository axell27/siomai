namespace siomai
{
    partial class TransactionsForm
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
            transactionsDataGridView = new DataGridView();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDataGridView.Location = new Point(245, 113);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.Size = new Size(543, 325);
            transactionsDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 45);
            label3.Name = "label3";
            label3.Size = new Size(261, 40);
            label3.TabIndex = 9;
            label3.Text = "Transactions";
            // 
            // button1
            // 
            button1.Location = new Point(55, 321);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 10;
            button1.Text = "Generate Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 397);
            button2.Name = "button2";
            button2.Size = new Size(107, 41);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(transactionsDataGridView);
            Name = "TransactionsForm";
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionsDataGridView;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}