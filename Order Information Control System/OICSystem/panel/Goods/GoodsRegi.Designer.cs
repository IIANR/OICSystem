namespace WindowsFormsApplication1.panel
{
    partial class GoodsRegi
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
            this.goodsRegiId = new System.Windows.Forms.Label();
            this.goodsRegiName = new System.Windows.Forms.Label();
            this.goodsRegiPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.登録 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(76, 77);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(18, 12);
            this.goodsRegiId.TabIndex = 0;
            this.goodsRegiId.Text = "ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(63, 132);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiName.TabIndex = 1;
            this.goodsRegiName.Text = "名前:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(63, 187);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 2;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 19);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 19);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 19);
            this.textBox3.TabIndex = 5;
            // 
            // 登録
            // 
            this.登録.Location = new System.Drawing.Point(593, 353);
            this.登録.Name = "登録";
            this.登録.Size = new System.Drawing.Size(138, 47);
            this.登録.TabIndex = 6;
            this.登録.Text = "登録";
            this.登録.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(466, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 265);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.登録);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(760, 430);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button 登録;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
