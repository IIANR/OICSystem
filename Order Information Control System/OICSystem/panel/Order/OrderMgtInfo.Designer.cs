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
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderInfoGritview = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoGritview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(595, 322);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(151, 37);
            this.SearchBtn.TabIndex = 46;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.Location = new System.Drawing.Point(53, 344);
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(117, 19);
            this.KanaTextbox.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(595, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 37);
            this.button3.TabIndex = 40;
            this.button3.Text = "注文取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // OrderInfoGritview
            // 
            this.OrderInfoGritview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoGritview.Location = new System.Drawing.Point(14, 12);
            this.OrderInfoGritview.Name = "OrderInfoGritview";
            this.OrderInfoGritview.RowTemplate.Height = 21;
            this.OrderInfoGritview.Size = new System.Drawing.Size(732, 272);
            this.OrderInfoGritview.TabIndex = 47;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(418, 322);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(151, 37);
            this.UpdateBtn.TabIndex = 48;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // OrderMgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.OrderInfoGritview);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.KanaTextbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView OrderInfoGritview;
        private System.Windows.Forms.Button UpdateBtn;
    }
}
