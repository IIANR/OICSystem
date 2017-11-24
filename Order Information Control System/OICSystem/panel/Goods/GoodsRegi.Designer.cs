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
            this.IDText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.regiBtn = new System.Windows.Forms.Button();
            this.RemText = new System.Windows.Forms.TextBox();
            this.UmberText = new System.Windows.Forms.TextBox();
            this.RemLbl = new System.Windows.Forms.Label();
            this.UmberLbl = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.ImageText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dropLbl = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.picture.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(76, 81);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(18, 12);
            this.goodsRegiId.TabIndex = 0;
            this.goodsRegiId.Text = "ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(63, 130);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiName.TabIndex = 1;
            this.goodsRegiName.Text = "名前:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(63, 179);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 2;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(100, 74);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(228, 19);
            this.IDText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(100, 123);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(228, 19);
            this.NameText.TabIndex = 4;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(100, 172);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(228, 19);
            this.PriceText.TabIndex = 5;
            // 
            // regiBtn
            // 
            this.regiBtn.Location = new System.Drawing.Point(593, 353);
            this.regiBtn.Name = "regiBtn";
            this.regiBtn.Size = new System.Drawing.Size(138, 47);
            this.regiBtn.TabIndex = 6;
            this.regiBtn.Text = "登録";
            this.regiBtn.UseVisualStyleBackColor = true;
            this.regiBtn.Click += new System.EventHandler(this.regiBtn_Click);
            // 
            // RemText
            // 
            this.RemText.Location = new System.Drawing.Point(100, 271);
            this.RemText.Name = "RemText";
            this.RemText.Size = new System.Drawing.Size(228, 19);
            this.RemText.TabIndex = 25;
            // 
            // UmberText
            // 
            this.UmberText.Location = new System.Drawing.Point(100, 320);
            this.UmberText.Name = "UmberText";
            this.UmberText.Size = new System.Drawing.Size(67, 19);
            this.UmberText.TabIndex = 26;
            // 
            // RemLbl
            // 
            this.RemLbl.AutoSize = true;
            this.RemLbl.Location = new System.Drawing.Point(63, 278);
            this.RemLbl.Name = "RemLbl";
            this.RemLbl.Size = new System.Drawing.Size(31, 12);
            this.RemLbl.TabIndex = 27;
            this.RemLbl.Text = "備考:";
            // 
            // UmberLbl
            // 
            this.UmberLbl.AutoSize = true;
            this.UmberLbl.Location = new System.Drawing.Point(27, 327);
            this.UmberLbl.Name = "UmberLbl";
            this.UmberLbl.Size = new System.Drawing.Size(67, 12);
            this.UmberLbl.TabIndex = 28;
            this.UmberLbl.Text = "定期発注数:";
            // 
            // CategoryText
            // 
            this.CategoryText.AutoCompleteCustomSource.AddRange(new string[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Items.AddRange(new object[] {
            "GK",
            "DF",
            "FW",
            "MF"});
            this.CategoryText.Location = new System.Drawing.Point(100, 221);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(121, 20);
            this.CategoryText.TabIndex = 29;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(53, 229);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(41, 12);
            this.CategoryLbl.TabIndex = 30;
            this.CategoryLbl.Text = "カテゴリ:";
            // 
            // ImageText
            // 
            this.ImageText.Location = new System.Drawing.Point(563, 13);
            this.ImageText.Name = "ImageText";
            this.ImageText.ReadOnly = true;
            this.ImageText.Size = new System.Drawing.Size(100, 19);
            this.ImageText.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dropLbl
            // 
            this.dropLbl.AutoSize = true;
            this.dropLbl.Location = new System.Drawing.Point(95, 134);
            this.dropLbl.Name = "dropLbl";
            this.dropLbl.Size = new System.Drawing.Size(64, 12);
            this.dropLbl.TabIndex = 20;
            this.dropLbl.Text = "ここにドロップ";
            // 
            // picture
            // 
            this.picture.AllowDrop = true;
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Controls.Add(this.dropLbl);
            this.picture.Controls.Add(this.pictureBox1);
            this.picture.Location = new System.Drawing.Point(466, 38);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(265, 265);
            this.picture.TabIndex = 24;
            this.picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImageText);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.UmberLbl);
            this.Controls.Add(this.RemLbl);
            this.Controls.Add(this.UmberText);
            this.Controls.Add(this.RemText);
            this.Controls.Add(this.regiBtn);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Controls.Add(this.picture);
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(760, 430);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.picture.ResumeLayout(false);
            this.picture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Button regiBtn;
        private System.Windows.Forms.TextBox RemText;
        private System.Windows.Forms.TextBox UmberText;
        private System.Windows.Forms.Label RemLbl;
        private System.Windows.Forms.Label UmberLbl;
        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.TextBox ImageText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dropLbl;
        private System.Windows.Forms.Panel picture;
    }
}
