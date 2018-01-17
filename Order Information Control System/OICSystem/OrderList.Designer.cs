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
            this.OrderListDataGridView4 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView3 = new System.Windows.Forms.DataGridView();
            this.OrderListDataGridView2 = new System.Windows.Forms.DataGridView();
            this.OrderTitleLabel = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.OrderListDataGridView = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Next3Btn = new System.Windows.Forms.Button();
            this.lblid3 = new System.Windows.Forms.Label();
            this.lblid2 = new System.Windows.Forms.Label();
            this.lblid1 = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Back3Btn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListDataGridView4
            // 
            this.OrderListDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView4.Location = new System.Drawing.Point(587, 329);
            this.OrderListDataGridView4.Name = "OrderListDataGridView4";
            this.OrderListDataGridView4.ReadOnly = true;
            this.OrderListDataGridView4.RowTemplate.Height = 21;
            this.OrderListDataGridView4.Size = new System.Drawing.Size(282, 174);
            this.OrderListDataGridView4.TabIndex = 20;
            // 
            // OrderListDataGridView3
            // 
            this.OrderListDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView3.Location = new System.Drawing.Point(299, 329);
            this.OrderListDataGridView3.Name = "OrderListDataGridView3";
            this.OrderListDataGridView3.ReadOnly = true;
            this.OrderListDataGridView3.RowTemplate.Height = 21;
            this.OrderListDataGridView3.Size = new System.Drawing.Size(282, 174);
            this.OrderListDataGridView3.TabIndex = 19;
            // 
            // OrderListDataGridView2
            // 
            this.OrderListDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderListDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderListDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDataGridView2.Location = new System.Drawing.Point(11, 329);
            this.OrderListDataGridView2.Name = "OrderListDataGridView2";
            this.OrderListDataGridView2.ReadOnly = true;
            this.OrderListDataGridView2.RowTemplate.Height = 21;
            this.OrderListDataGridView2.Size = new System.Drawing.Size(282, 174);
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
            this.OrderListDataGridView.ReadOnly = true;
            this.OrderListDataGridView.RowTemplate.Height = 21;
            this.OrderListDataGridView.Size = new System.Drawing.Size(856, 196);
            this.OrderListDataGridView.TabIndex = 15;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Next3Btn
            // 
            this.Next3Btn.Location = new System.Drawing.Point(644, 515);
            this.Next3Btn.Name = "Next3Btn";
            this.Next3Btn.Size = new System.Drawing.Size(70, 30);
            this.Next3Btn.TabIndex = 40;
            this.Next3Btn.Text = ">>>";
            this.Next3Btn.UseVisualStyleBackColor = true;
            this.Next3Btn.Click += new System.EventHandler(this.Next3Btn_Click);
            // 
            // lblid3
            // 
            this.lblid3.AutoSize = true;
            this.lblid3.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblid3.Location = new System.Drawing.Point(621, 277);
            this.lblid3.Name = "lblid3";
            this.lblid3.Size = new System.Drawing.Size(37, 40);
            this.lblid3.TabIndex = 39;
            this.lblid3.Text = "3";
            // 
            // lblid2
            // 
            this.lblid2.AutoSize = true;
            this.lblid2.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblid2.Location = new System.Drawing.Point(333, 277);
            this.lblid2.Name = "lblid2";
            this.lblid2.Size = new System.Drawing.Size(37, 40);
            this.lblid2.TabIndex = 38;
            this.lblid2.Text = "2";
            // 
            // lblid1
            // 
            this.lblid1.AutoSize = true;
            this.lblid1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblid1.Location = new System.Drawing.Point(45, 277);
            this.lblid1.Name = "lblid1";
            this.lblid1.Size = new System.Drawing.Size(37, 40);
            this.lblid1.TabIndex = 37;
            this.lblid1.Text = "1";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(510, 515);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(70, 30);
            this.NextBtn.TabIndex = 35;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Back3Btn
            // 
            this.Back3Btn.Location = new System.Drawing.Point(168, 515);
            this.Back3Btn.Name = "Back3Btn";
            this.Back3Btn.Size = new System.Drawing.Size(70, 30);
            this.Back3Btn.TabIndex = 43;
            this.Back3Btn.Text = "<<<";
            this.Back3Btn.UseVisualStyleBackColor = true;
            this.Back3Btn.Click += new System.EventHandler(this.Back3Btn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(300, 515);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(70, 30);
            this.BackBtn.TabIndex = 42;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.Back3Btn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Next3Btn);
            this.Controls.Add(this.lblid3);
            this.Controls.Add(this.lblid2);
            this.Controls.Add(this.lblid1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.OrderListDataGridView4);
            this.Controls.Add(this.OrderListDataGridView3);
            this.Controls.Add(this.OrderListDataGridView2);
            this.Controls.Add(this.OrderTitleLabel);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.OrderListDataGridView);
            this.Name = "OrderList";
            this.Text = "注文一覧";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderListDataGridView4;
        private System.Windows.Forms.DataGridView OrderListDataGridView3;
        private System.Windows.Forms.DataGridView OrderListDataGridView2;
        private System.Windows.Forms.Label OrderTitleLabel;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.DataGridView OrderListDataGridView;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Next3Btn;
        private System.Windows.Forms.Label lblid3;
        private System.Windows.Forms.Label lblid2;
        private System.Windows.Forms.Label lblid1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button Back3Btn;
        private System.Windows.Forms.Button BackBtn;
    }
}