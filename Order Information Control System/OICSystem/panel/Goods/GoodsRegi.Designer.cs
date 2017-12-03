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
            this.panel = new System.Windows.Forms.Panel();
            this.DropLbl = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(80, 49);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(18, 12);
            this.goodsRegiId.TabIndex = 0;
            this.goodsRegiId.Text = "ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(78, 74);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiName.TabIndex = 1;
            this.goodsRegiName.Text = "名前:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(78, 99);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 2;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(115, 67);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(228, 19);
            this.NameText.TabIndex = 4;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(115, 92);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(228, 19);
            this.PriceText.TabIndex = 5;
            // 
            // regiBtn
            // 
            this.regiBtn.Location = new System.Drawing.Point(664, 257);
            this.regiBtn.Name = "regiBtn";
            this.regiBtn.Size = new System.Drawing.Size(96, 29);
            this.regiBtn.TabIndex = 6;
            this.regiBtn.Text = "登録";
            this.regiBtn.UseVisualStyleBackColor = true;
            this.regiBtn.Click += new System.EventHandler(this.regiBtn_Click);
            // 
            // RemText
            // 
            this.RemText.Location = new System.Drawing.Point(115, 143);
            this.RemText.Name = "RemText";
            this.RemText.Size = new System.Drawing.Size(228, 19);
            this.RemText.TabIndex = 25;
            // 
            // UmberText
            // 
            this.UmberText.Location = new System.Drawing.Point(115, 168);
            this.UmberText.Name = "UmberText";
            this.UmberText.Size = new System.Drawing.Size(67, 19);
            this.UmberText.TabIndex = 26;
            // 
            // RemLbl
            // 
            this.RemLbl.AutoSize = true;
            this.RemLbl.Location = new System.Drawing.Point(78, 150);
            this.RemLbl.Name = "RemLbl";
            this.RemLbl.Size = new System.Drawing.Size(31, 12);
            this.RemLbl.TabIndex = 27;
            this.RemLbl.Text = "備考:";
            // 
            // UmberLbl
            // 
            this.UmberLbl.AutoSize = true;
            this.UmberLbl.Location = new System.Drawing.Point(42, 175);
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
            this.CategoryText.Location = new System.Drawing.Point(115, 117);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(121, 20);
            this.CategoryText.TabIndex = 29;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(68, 125);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(41, 12);
            this.CategoryLbl.TabIndex = 30;
            this.CategoryLbl.Text = "カテゴリ:";
            // 
            // ImageText
            // 
            this.ImageText.Location = new System.Drawing.Point(429, 42);
            this.ImageText.Name = "ImageText";
            this.ImageText.ReadOnly = true;
            this.ImageText.Size = new System.Drawing.Size(84, 19);
            this.ImageText.TabIndex = 31;
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.DropLbl);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(349, 67);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(245, 219);
            this.panel.TabIndex = 34;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // DropLbl
            // 
            this.DropLbl.AutoSize = true;
            this.DropLbl.Location = new System.Drawing.Point(90, 109);
            this.DropLbl.Name = "DropLbl";
            this.DropLbl.Size = new System.Drawing.Size(64, 12);
            this.DropLbl.TabIndex = 36;
            this.DropLbl.Text = "ここにドロップ";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(245, 219);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(115, 42);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(84, 19);
            this.IDText.TabIndex = 35;
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.panel);
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
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.GoodsRegi_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiPrice;
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
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label DropLbl;
        private System.Windows.Forms.TextBox IDText;
    }
}
