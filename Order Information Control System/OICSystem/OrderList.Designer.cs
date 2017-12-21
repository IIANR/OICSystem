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
            this.OrderListDataGridView2 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView3 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView4 = new System.Windows.Forms.DataGridView();
            this.NextBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.lblid1 = new System.Windows.Forms.Label();
            this.lblid2 = new System.Windows.Forms.Label();
            this.lblid3 = new System.Windows.Forms.Label();
            this.Next3Btn = new System.Windows.Forms.Button();
            this.Back3Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListDataGridView
            // 
            this.OrderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView.Location = new System.Drawing.Point(12, 65);
            this.OrderListDataGridView.Name = "OrderListDataGridView";
            this.OrderListDataGridView.RowTemplate.Height = 21;
            this.OrderListDataGridView.Size = new System.Drawing.Size(856, 245);
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
            // OrderListDataGridView2
            // 
            this.OrderListDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView2.Location = new System.Drawing.Point(12, 316);
            this.OrderListDataGridView2.Name = "OrderListDataGridView2";
            this.OrderListDataGridView2.RowTemplate.Height = 21;
            this.OrderListDataGridView2.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView2.TabIndex = 4;
            // 
            // OrderListDataGridView3
            // 
            this.OrderListDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView3.Location = new System.Drawing.Point(300, 316);
            this.OrderListDataGridView3.Name = "OrderListDataGridView3";
            this.OrderListDataGridView3.RowTemplate.Height = 21;
            this.OrderListDataGridView3.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView3.TabIndex = 8;
            // 
            // OrderListDataGridView4
            // 
            this.OrderListDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView4.Location = new System.Drawing.Point(588, 316);
            this.OrderListDataGridView4.Name = "OrderListDataGridView4";
            this.OrderListDataGridView4.RowTemplate.Height = 21;
            this.OrderListDataGridView4.Size = new System.Drawing.Size(282, 200);
            this.OrderListDataGridView4.TabIndex = 9;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(557, 522);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(25, 23);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = ">>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(300, 522);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(27, 23);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "<<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // lblid1
            // 
            this.lblid1.AutoSize = true;
            this.lblid1.Location = new System.Drawing.Point(119, 533);
            this.lblid1.Name = "lblid1";
            this.lblid1.Size = new System.Drawing.Size(0, 12);
            this.lblid1.TabIndex = 12;
            // 
            // lblid2
            // 
            this.lblid2.AutoSize = true;
            this.lblid2.Location = new System.Drawing.Point(423, 533);
            this.lblid2.Name = "lblid2";
            this.lblid2.Size = new System.Drawing.Size(0, 12);
            this.lblid2.TabIndex = 13;
            // 
            // lblid3
            // 
            this.lblid3.AutoSize = true;
            this.lblid3.Location = new System.Drawing.Point(713, 533);
            this.lblid3.Name = "lblid3";
            this.lblid3.Size = new System.Drawing.Size(0, 12);
            this.lblid3.TabIndex = 14;
            // 
            // Next3Btn
            // 
            this.Next3Btn.Location = new System.Drawing.Point(588, 522);
            this.Next3Btn.Name = "Next3Btn";
            this.Next3Btn.Size = new System.Drawing.Size(69, 23);
            this.Next3Btn.TabIndex = 15;
            this.Next3Btn.Text = ">> >> >>";
            this.Next3Btn.UseVisualStyleBackColor = true;
            this.Next3Btn.Click += new System.EventHandler(this.Next3Btn_Click);
            // 
            // Back3Btn
            // 
            this.Back3Btn.Location = new System.Drawing.Point(225, 522);
            this.Back3Btn.Name = "Back3Btn";
            this.Back3Btn.Size = new System.Drawing.Size(69, 23);
            this.Back3Btn.TabIndex = 16;
            this.Back3Btn.Text = "<< << <<";
            this.Back3Btn.UseVisualStyleBackColor = true;
            this.Back3Btn.Click += new System.EventHandler(this.Back3Btn_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.Back3Btn);
            this.Controls.Add(this.Next3Btn);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderList_FormClosing);
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderListDataGridView;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label OrderTitleLabel;
        private System.Windows.Forms.DataGridView OrderListDataGridView2;
        private System.Windows.Forms.DataGridView OrderListDataGridView3;
        private System.Windows.Forms.DataGridView OrderListDataGridView4;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label lblid1;
        private System.Windows.Forms.Label lblid2;
        private System.Windows.Forms.Label lblid3;
        private System.Windows.Forms.Button Next3Btn;
        private System.Windows.Forms.Button Back3Btn;
    }
}