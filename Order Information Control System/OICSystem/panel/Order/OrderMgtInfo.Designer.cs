namespace WindowsFormsApplication1
{
    partial class OrderMgtInfo
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderListBtn = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTitleLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.OrderInfoGritview = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.KanaTextbox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.KanaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoGritview)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListBtn
            // 
            this.OrderListBtn.Location = new System.Drawing.Point(865, 470);
            this.OrderListBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderListBtn.Name = "OrderListBtn";
            this.OrderListBtn.Size = new System.Drawing.Size(129, 46);
            this.OrderListBtn.TabIndex = 5;
            this.OrderListBtn.Text = "入金済み一覧";
            this.OrderListBtn.UseVisualStyleBackColor = true;
            this.OrderListBtn.Click += new System.EventHandler(this.OrderListBtn_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(381, 485);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(30, 15);
            this.TotalLabel.TabIndex = 65;
            this.TotalLabel.Text = "0円";
            // 
            // TotalTitleLabel
            // 
            this.TotalTitleLabel.AutoSize = true;
            this.TotalTitleLabel.Location = new System.Drawing.Point(295, 485);
            this.TotalTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalTitleLabel.Name = "TotalTitleLabel";
            this.TotalTitleLabel.Size = new System.Drawing.Size(75, 15);
            this.TotalTitleLabel.TabIndex = 64;
            this.TotalTitleLabel.Text = "合計金額：";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(591, 470);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(129, 46);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "入金確認";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
            // 
            // OrderInfoGritview
            // 
            this.OrderInfoGritview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderInfoGritview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoGritview.Location = new System.Drawing.Point(19, 22);
            this.OrderInfoGritview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderInfoGritview.Name = "OrderInfoGritview";
            this.OrderInfoGritview.RowTemplate.Height = 21;
            this.OrderInfoGritview.Size = new System.Drawing.Size(976, 418);
            this.OrderInfoGritview.TabIndex = 63;
            this.OrderInfoGritview.Click += new System.EventHandler(this.OrderInfoGritview_Click_1);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(453, 470);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(129, 46);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KanaTextbox.Location = new System.Drawing.Point(99, 481);
            this.KanaTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KanaTextbox.MaxLength = 30;
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(155, 22);
            this.KanaTextbox.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(728, 470);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(129, 46);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "注文取消";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // KanaLabel
            // 
            this.KanaLabel.AutoSize = true;
            this.KanaLabel.Location = new System.Drawing.Point(44, 485);
            this.KanaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KanaLabel.Name = "KanaLabel";
            this.KanaLabel.Size = new System.Drawing.Size(53, 15);
            this.KanaLabel.TabIndex = 62;
            this.KanaLabel.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // OrderMgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderListBtn);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTitleLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.OrderInfoGritview);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.KanaTextbox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.KanaLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderMgtInfo";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.OrderMgtInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoGritview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderListBtn;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalTitleLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView OrderInfoGritview;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label KanaLabel;
        public System.Windows.Forms.TextBox KanaTextbox;
    }
}
