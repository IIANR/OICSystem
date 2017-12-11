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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.KanaTextbox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.KanaLabel = new System.Windows.Forms.Label();
            this.OrderInfoGritview = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.TotalTitleLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoGritview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(340, 370);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(97, 37);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.Location = new System.Drawing.Point(74, 379);
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(117, 19);
            this.KanaTextbox.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(546, 370);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(97, 37);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "注文取消";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // KanaLabel
            // 
            this.KanaLabel.AutoSize = true;
            this.KanaLabel.Location = new System.Drawing.Point(33, 382);
            this.KanaLabel.Name = "KanaLabel";
            this.KanaLabel.Size = new System.Drawing.Size(42, 12);
            this.KanaLabel.TabIndex = 37;
            this.KanaLabel.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // OrderInfoGritview
            // 
            this.OrderInfoGritview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderInfoGritview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoGritview.Location = new System.Drawing.Point(14, 12);
            this.OrderInfoGritview.Name = "OrderInfoGritview";
            this.OrderInfoGritview.RowTemplate.Height = 21;
            this.OrderInfoGritview.Size = new System.Drawing.Size(732, 334);
            this.OrderInfoGritview.TabIndex = 47;
            this.OrderInfoGritview.Click += new System.EventHandler(this.OrderInfoGritview_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(443, 370);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(97, 37);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "入金済み列更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TotalTitleLabel
            // 
            this.TotalTitleLabel.AutoSize = true;
            this.TotalTitleLabel.Location = new System.Drawing.Point(221, 382);
            this.TotalTitleLabel.Name = "TotalTitleLabel";
            this.TotalTitleLabel.Size = new System.Drawing.Size(59, 12);
            this.TotalTitleLabel.TabIndex = 55;
            this.TotalTitleLabel.Text = "合計金額：";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(286, 382);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(23, 12);
            this.TotalLabel.TabIndex = 56;
            this.TotalLabel.Text = "0円";
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(649, 370);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(97, 37);
            this.List.TabIndex = 57;
            this.List.Text = "入金済み一覧";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.OrderList_Click);
            // 
            // OrderMgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.List);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTitleLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.OrderInfoGritview);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.KanaTextbox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.KanaLabel);
            this.Name = "OrderMgtInfo";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.OrderMgtInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoGritview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox KanaTextbox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label KanaLabel;
        private System.Windows.Forms.DataGridView OrderInfoGritview;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label TotalTitleLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button List;
    }
}
