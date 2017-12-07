namespace WindowsFormsApplication1.panel.Goods
{
    partial class GoodsList
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
            this.GoodsListDataGridView = new System.Windows.Forms.DataGridView();
            this.GoodsListPictureBox = new System.Windows.Forms.PictureBox();
            this.GoodsListPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsListPictureBox)).BeginInit();
            this.GoodsListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoodsListDataGridView
            // 
            this.GoodsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsListDataGridView.Location = new System.Drawing.Point(21, 22);
            this.GoodsListDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.GoodsListDataGridView.Name = "GoodsListDataGridView";
            this.GoodsListDataGridView.RowTemplate.Height = 21;
            this.GoodsListDataGridView.Size = new System.Drawing.Size(557, 488);
            this.GoodsListDataGridView.TabIndex = 0;
            this.GoodsListDataGridView.Click += new System.EventHandler(this.GoodsListDataGridView_Click);
            // 
            // GoodsListPictureBox
            // 
            this.GoodsListPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodsListPictureBox.Location = new System.Drawing.Point(0, 0);
            this.GoodsListPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.GoodsListPictureBox.Name = "GoodsListPictureBox";
            this.GoodsListPictureBox.Size = new System.Drawing.Size(316, 380);
            this.GoodsListPictureBox.TabIndex = 1;
            this.GoodsListPictureBox.TabStop = false;
            // 
            // GoodsListPanel
            // 
            this.GoodsListPanel.BackColor = System.Drawing.SystemColors.Window;
            this.GoodsListPanel.Controls.Add(this.GoodsListPictureBox);
            this.GoodsListPanel.Location = new System.Drawing.Point(633, 84);
            this.GoodsListPanel.Name = "GoodsListPanel";
            this.GoodsListPanel.Size = new System.Drawing.Size(316, 380);
            this.GoodsListPanel.TabIndex = 2;
            // 
            // GoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoodsListPanel);
            this.Controls.Add(this.GoodsListDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsList";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.GoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsListPictureBox)).EndInit();
            this.GoodsListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodsListDataGridView;
        private System.Windows.Forms.PictureBox GoodsListPictureBox;
        private System.Windows.Forms.Panel GoodsListPanel;
    }
}
