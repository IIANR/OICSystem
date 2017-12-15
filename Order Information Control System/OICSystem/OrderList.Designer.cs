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
            this.lblid3 = new System.Windows.Forms.Label();
            this.lblid2 = new System.Windows.Forms.Label();
            this.lblid1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.OrderListDataGridView4 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView3 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView2 = new System.Windows.Forms.DataGridView();
            this.OrderTitleLabel = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.OrderListDataGridView = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid3
            // 
            this.lblid3.AutoSize = true;
            this.lblid3.Location = new System.Drawing.Point(712, 533);
            this.lblid3.Name = "lblid3";
            this.lblid3.Size = new System.Drawing.Size(0, 12);
            this.lblid3.TabIndex = 25;
            // 
            // lblid2
            // 
            this.lblid2.AutoSize = true;
            this.lblid2.Location = new System.Drawing.Point(422, 533);
            this.lblid2.Name = "lblid2";
            this.lblid2.Size = new System.Drawing.Size(0, 12);
            this.lblid2.TabIndex = 24;
            // 
            // lblid1
            // 
            this.lblid1.AutoSize = true;
            this.lblid1.Location = new System.Drawing.Point(118, 533);
            this.lblid1.Name = "lblid1";
            this.lblid1.Size = new System.Drawing.Size(0, 12);
            this.lblid1.TabIndex = 23;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(258, 522);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "前へ";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(543, 522);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 21;
            this.NextBtn.Text = "次へ";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click_1);
            // 
            // OrderListDataGridView4
            // 
            this.OrderListDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView4.Location = new System.Drawing.Point(587, 316);
            this.OrderListDataGridView4.Name = "OrderListDataGridView4";
            this.OrderListDataGridView4.RowTemplate.Height = 21;
            this.OrderListDataGridView4.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView4.TabIndex = 20;
            // 
            // OrderListDataGridView3
            // 
            this.OrderListDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView3.Location = new System.Drawing.Point(299, 316);
            this.OrderListDataGridView3.Name = "OrderListDataGridView3";
            this.OrderListDataGridView3.RowTemplate.Height = 21;
            this.OrderListDataGridView3.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView3.TabIndex = 19;
            // 
            // OrderListDataGridView2
            // 
            this.OrderListDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView2.Location = new System.Drawing.Point(11, 316);
            this.OrderListDataGridView2.Name = "OrderListDataGridView2";
            this.OrderListDataGridView2.RowTemplate.Height = 21;
            this.OrderListDataGridView2.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView2.TabIndex = 18;
            // 
            // OrderTitleLabel
            // 
            this.OrderTitleLabel.AutoSize = true;
            this.OrderTitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.OrderTitleLabel.Location = new System.Drawing.Point(369, 12);
            this.OrderTitleLabel.Name = "OrderTitleLabel";
            this.OrderTitleLabel.Size = new System.Drawing.Size(120, 27);
            this.OrderTitleLabel.TabIndex = 17;
            this.OrderTitleLabel.Text = "注文一覧";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(781, 12);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(86, 38);
            this.PrintBtn.TabIndex = 16;
            this.PrintBtn.Text = "印刷";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // OrderListDataGridView
            // 
            this.OrderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView.Location = new System.Drawing.Point(11, 65);
            this.OrderListDataGridView.Name = "OrderListDataGridView";
            this.OrderListDataGridView.RowTemplate.Height = 21;
            this.OrderListDataGridView.Size = new System.Drawing.Size(856, 245);
            this.OrderListDataGridView.TabIndex = 15;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.lblid3);
            this.Controls.Add(this.lblid2);
            this.Controls.Add(this.lblid1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.OrderListDataGridView4);
            this.Controls.Add(this.OrderListDataGridView3);
            this.Controls.Add(this.OrderListDataGridView2);
            this.Controls.Add(this.OrderTitleLabel);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.OrderListDataGridView);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid3;
        private System.Windows.Forms.Label lblid2;
        private System.Windows.Forms.Label lblid1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.DataGridView OrderListDataGridView4;
        private System.Windows.Forms.DataGridView OrderListDataGridView3;
        private System.Windows.Forms.DataGridView OrderListDataGridView2;
        private System.Windows.Forms.Label OrderTitleLabel;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.DataGridView OrderListDataGridView;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}