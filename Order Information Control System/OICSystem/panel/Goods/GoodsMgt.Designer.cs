namespace WindowsFormsApplication1
{
    partial class GoodsMgt
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
            this.goodsStockBtn = new System.Windows.Forms.Button();
            this.goodsListBtn = new System.Windows.Forms.Button();
            this.goodsRegiBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // goodsStockBtn
            // 
            this.goodsStockBtn.Location = new System.Drawing.Point(590, 20);
            this.goodsStockBtn.Name = "goodsStockBtn";
            this.goodsStockBtn.Size = new System.Drawing.Size(151, 40);
            this.goodsStockBtn.TabIndex = 47;
            this.goodsStockBtn.Text = "商品在庫";
            this.goodsStockBtn.UseVisualStyleBackColor = true;
            // 
            // goodsListBtn
            // 
            this.goodsListBtn.Location = new System.Drawing.Point(433, 20);
            this.goodsListBtn.Name = "goodsListBtn";
            this.goodsListBtn.Size = new System.Drawing.Size(151, 40);
            this.goodsListBtn.TabIndex = 46;
            this.goodsListBtn.Text = "商品情報";
            this.goodsListBtn.UseVisualStyleBackColor = true;
            // 
            // goodsRegiBtn
            // 
            this.goodsRegiBtn.Location = new System.Drawing.Point(276, 20);
            this.goodsRegiBtn.Name = "goodsRegiBtn";
            this.goodsRegiBtn.Size = new System.Drawing.Size(151, 40);
            this.goodsRegiBtn.TabIndex = 52;
            this.goodsRegiBtn.Text = "商品登録";
            this.goodsRegiBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 430);
            this.panel1.TabIndex = 53;
            // 
            // GoodsMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goodsRegiBtn);
            this.Controls.Add(this.goodsStockBtn);
            this.Controls.Add(this.goodsListBtn);
            this.Name = "GoodsMgt";
            this.Size = new System.Drawing.Size(760, 515);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goodsStockBtn;
        private System.Windows.Forms.Button goodsListBtn;
        private System.Windows.Forms.Button goodsRegiBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
