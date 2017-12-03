namespace WindowsFormsApplication1.panel.Goods
{
    partial class GoodsStock
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
            this.GoodsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsDataGridView
            // 
            this.GoodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDataGridView.Location = new System.Drawing.Point(39, 24);
            this.GoodsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoodsDataGridView.Name = "GoodsDataGridView";
            this.GoodsDataGridView.RowTemplate.Height = 21;
            this.GoodsDataGridView.Size = new System.Drawing.Size(927, 416);
            this.GoodsDataGridView.TabIndex = 0;
            // 
            // GoodsStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoodsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsStock";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.GoodsStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodsDataGridView;
    }
}
