namespace WindowsFormsApplication1
{
    partial class OrderList
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
            this.OrderListDataGridView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.OrderTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListDataGridView
            // 
            this.OrderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView.Location = new System.Drawing.Point(12, 65);
            this.OrderListDataGridView.Name = "OrderListDataGridView";
            this.OrderListDataGridView.RowTemplate.Height = 21;
            this.OrderListDataGridView.Size = new System.Drawing.Size(856, 480);
            this.OrderListDataGridView.TabIndex = 0;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(782, 12);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(86, 38);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "印刷";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // OrderTitleLabel
            // 
            this.OrderTitleLabel.AutoSize = true;
            this.OrderTitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.OrderTitleLabel.Location = new System.Drawing.Point(370, 12);
            this.OrderTitleLabel.Name = "OrderTitleLabel";
            this.OrderTitleLabel.Size = new System.Drawing.Size(120, 27);
            this.OrderTitleLabel.TabIndex = 2;
            this.OrderTitleLabel.Text = "注文一覧";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.OrderTitleLabel);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.OrderListDataGridView);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderListDataGridView;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label OrderTitleLabel;
    }
}