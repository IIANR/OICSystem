﻿namespace WindowsFormsApplication1.panel.Goods
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
            this.GoodsStockDisLbl = new System.Windows.Forms.Label();
            this.GoodsStockLbl = new System.Windows.Forms.Label();
            this.GoodsStockTBox = new System.Windows.Forms.TextBox();
            this.GoodsStockDisBtn = new System.Windows.Forms.Button();
            this.GoodsStockDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsStockDisLbl
            // 
            this.GoodsStockDisLbl.AutoSize = true;
            this.GoodsStockDisLbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoodsStockDisLbl.ForeColor = System.Drawing.Color.Red;
            this.GoodsStockDisLbl.Location = new System.Drawing.Point(87, 420);
            this.GoodsStockDisLbl.Name = "GoodsStockDisLbl";
            this.GoodsStockDisLbl.Size = new System.Drawing.Size(0, 17);
            this.GoodsStockDisLbl.TabIndex = 17;
            // 
            // GoodsStockLbl
            // 
            this.GoodsStockLbl.AutoSize = true;
            this.GoodsStockLbl.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoodsStockLbl.Location = new System.Drawing.Point(87, 479);
            this.GoodsStockLbl.Name = "GoodsStockLbl";
            this.GoodsStockLbl.Size = new System.Drawing.Size(60, 15);
            this.GoodsStockLbl.TabIndex = 16;
            this.GoodsStockLbl.Text = "商品名：";
            // 
            // GoodsStockTBox
            // 
            this.GoodsStockTBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GoodsStockTBox.Location = new System.Drawing.Point(153, 475);
            this.GoodsStockTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoodsStockTBox.MaxLength = 30;
            this.GoodsStockTBox.Name = "GoodsStockTBox";
            this.GoodsStockTBox.Size = new System.Drawing.Size(279, 22);
            this.GoodsStockTBox.TabIndex = 1;
            // 
            // GoodsStockDisBtn
            // 
            this.GoodsStockDisBtn.Location = new System.Drawing.Point(781, 458);
            this.GoodsStockDisBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoodsStockDisBtn.Name = "GoodsStockDisBtn";
            this.GoodsStockDisBtn.Size = new System.Drawing.Size(189, 56);
            this.GoodsStockDisBtn.TabIndex = 2;
            this.GoodsStockDisBtn.Text = "検索";
            this.GoodsStockDisBtn.UseVisualStyleBackColor = true;
            this.GoodsStockDisBtn.Click += new System.EventHandler(this.GoodsStockDisBtn_Click);
            // 
            // GoodsStockDataGridView
            // 
            this.GoodsStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GoodsStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsStockDataGridView.Location = new System.Drawing.Point(43, 26);
            this.GoodsStockDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoodsStockDataGridView.Name = "GoodsStockDataGridView";
            this.GoodsStockDataGridView.ReadOnly = true;
            this.GoodsStockDataGridView.RowTemplate.Height = 21;
            this.GoodsStockDataGridView.Size = new System.Drawing.Size(927, 390);
            this.GoodsStockDataGridView.TabIndex = 13;
            this.GoodsStockDataGridView.TabStop = false;
            // 
            // GoodsStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoodsStockDisLbl);
            this.Controls.Add(this.GoodsStockLbl);
            this.Controls.Add(this.GoodsStockTBox);
            this.Controls.Add(this.GoodsStockDisBtn);
            this.Controls.Add(this.GoodsStockDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsStock";
            this.Size = new System.Drawing.Size(1013, 538);
            this.VisibleChanged += new System.EventHandler(this.GoodsStock_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsStockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoodsStockDisLbl;
        private System.Windows.Forms.Label GoodsStockLbl;
        private System.Windows.Forms.TextBox GoodsStockTBox;
        private System.Windows.Forms.Button GoodsStockDisBtn;
        private System.Windows.Forms.DataGridView GoodsStockDataGridView;
    }
}
