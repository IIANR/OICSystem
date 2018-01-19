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
            this.textBsupp = new System.Windows.Forms.TextBox();
            this.textBodr = new System.Windows.Forms.TextBox();
            this.Lblodr = new System.Windows.Forms.Label();
            this.textBprice = new System.Windows.Forms.TextBox();
            this.Lblsupp = new System.Windows.Forms.Label();
            this.textBID = new System.Windows.Forms.TextBox();
            this.textBimage = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.comboBcate = new System.Windows.Forms.ComboBox();
            this.textBnumber = new System.Windows.Forms.TextBox();
            this.goodsReginumber = new System.Windows.Forms.Label();
            this.goodsRegicateID = new System.Windows.Forms.Label();
            this.textBname = new System.Windows.Forms.TextBox();
            this.goodsRegiPrice = new System.Windows.Forms.Label();
            this.goodsRegiName = new System.Windows.Forms.Label();
            this.goodsRegiId = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBsupp
            // 
            this.textBsupp.Location = new System.Drawing.Point(192, 192);
            this.textBsupp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBsupp.MaxLength = 5;
            this.textBsupp.Name = "textBsupp";
            this.textBsupp.Size = new System.Drawing.Size(113, 22);
            this.textBsupp.TabIndex = 2;
            this.textBsupp.TextChanged += new System.EventHandler(this.textBsupp_TextChanged);
            this.textBsupp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBsupp_KeyPress);
            // 
            // textBodr
            // 
            this.textBodr.Location = new System.Drawing.Point(188, 364);
            this.textBodr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBodr.MaxLength = 3;
            this.textBodr.Name = "textBodr";
            this.textBodr.Size = new System.Drawing.Size(65, 22);
            this.textBodr.TabIndex = 5;
            this.textBodr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBodr_KeyPress);
            // 
            // Lblodr
            // 
            this.Lblodr.AutoSize = true;
            this.Lblodr.Location = new System.Drawing.Point(123, 372);
            this.Lblodr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblodr.Name = "Lblodr";
            this.Lblodr.Size = new System.Drawing.Size(55, 15);
            this.Lblodr.TabIndex = 103;
            this.Lblodr.Text = "発注数:";
            // 
            // textBprice
            // 
            this.textBprice.Enabled = false;
            this.textBprice.Location = new System.Drawing.Point(192, 231);
            this.textBprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBprice.Name = "textBprice";
            this.textBprice.ReadOnly = true;
            this.textBprice.Size = new System.Drawing.Size(109, 22);
            this.textBprice.TabIndex = 113;
            this.textBprice.TabStop = false;
            // 
            // Lblsupp
            // 
            this.Lblsupp.AutoSize = true;
            this.Lblsupp.Location = new System.Drawing.Point(108, 196);
            this.Lblsupp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblsupp.Name = "Lblsupp";
            this.Lblsupp.Size = new System.Drawing.Size(68, 15);
            this.Lblsupp.TabIndex = 105;
            this.Lblsupp.Text = "仕入れ値:";
            // 
            // textBID
            // 
            this.textBID.Location = new System.Drawing.Point(188, 100);
            this.textBID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBID.Name = "textBID";
            this.textBID.ReadOnly = true;
            this.textBID.Size = new System.Drawing.Size(113, 22);
            this.textBID.TabIndex = 0;
            this.textBID.TabStop = false;
            // 
            // textBimage
            // 
            this.textBimage.Location = new System.Drawing.Point(675, 69);
            this.textBimage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBimage.Name = "textBimage";
            this.textBimage.ReadOnly = true;
            this.textBimage.Size = new System.Drawing.Size(109, 22);
            this.textBimage.TabIndex = 107;
            this.textBimage.TabStop = false;
            this.textBimage.TextChanged += new System.EventHandler(this.textBimage_TextChanged);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(571, 100);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(349, 309);
            this.panel.TabIndex = 108;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(349, 309);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // InsertBtn
            // 
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Location = new System.Drawing.Point(768, 416);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(152, 54);
            this.InsertBtn.TabIndex = 6;
            this.InsertBtn.Text = "追加";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // comboBcate
            // 
            this.comboBcate.DisplayMember = "カテゴリID";
            this.comboBcate.FormattingEnabled = true;
            this.comboBcate.Location = new System.Drawing.Point(188, 275);
            this.comboBcate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBcate.Name = "comboBcate";
            this.comboBcate.Size = new System.Drawing.Size(136, 23);
            this.comboBcate.TabIndex = 3;
            this.comboBcate.ValueMember = "カテゴリID";
            // 
            // textBnumber
            // 
            this.textBnumber.Location = new System.Drawing.Point(188, 320);
            this.textBnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBnumber.MaxLength = 2;
            this.textBnumber.Name = "textBnumber";
            this.textBnumber.Size = new System.Drawing.Size(113, 22);
            this.textBnumber.TabIndex = 4;
            this.textBnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBnumber_KeyPress);
            // 
            // goodsReginumber
            // 
            this.goodsReginumber.AutoSize = true;
            this.goodsReginumber.Location = new System.Drawing.Point(92, 329);
            this.goodsReginumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsReginumber.Name = "goodsReginumber";
            this.goodsReginumber.Size = new System.Drawing.Size(85, 15);
            this.goodsReginumber.TabIndex = 111;
            this.goodsReginumber.Text = "安全在庫数:";
            // 
            // goodsRegicateID
            // 
            this.goodsRegicateID.AutoSize = true;
            this.goodsRegicateID.Location = new System.Drawing.Point(99, 285);
            this.goodsRegicateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsRegicateID.Name = "goodsRegicateID";
            this.goodsRegicateID.Size = new System.Drawing.Size(80, 15);
            this.goodsRegicateID.TabIndex = 110;
            this.goodsRegicateID.Text = "カテゴリー名:";
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(188, 144);
            this.textBname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBname.MaxLength = 30;
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(165, 22);
            this.textBname.TabIndex = 1;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(139, 240);
            this.goodsRegiPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(40, 15);
            this.goodsRegiPrice.TabIndex = 102;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(124, 152);
            this.goodsRegiName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(55, 15);
            this.goodsRegiName.TabIndex = 109;
            this.goodsRegiName.Text = "商品名:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(124, 109);
            this.goodsRegiId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(54, 15);
            this.goodsRegiId.TabIndex = 101;
            this.goodsRegiId.Text = "商品ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBsupp);
            this.Controls.Add(this.textBodr);
            this.Controls.Add(this.Lblodr);
            this.Controls.Add(this.textBprice);
            this.Controls.Add(this.Lblsupp);
            this.Controls.Add(this.textBID);
            this.Controls.Add(this.textBimage);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.comboBcate);
            this.Controls.Add(this.textBnumber);
            this.Controls.Add(this.goodsReginumber);
            this.Controls.Add(this.goodsRegicateID);
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.GoodsRegi_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBsupp;
        private System.Windows.Forms.TextBox textBodr;
        private System.Windows.Forms.Label Lblodr;
        private System.Windows.Forms.TextBox textBprice;
        private System.Windows.Forms.Label Lblsupp;
        private System.Windows.Forms.TextBox textBID;
        private System.Windows.Forms.TextBox textBimage;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.ComboBox comboBcate;
        private System.Windows.Forms.TextBox textBnumber;
        private System.Windows.Forms.Label goodsReginumber;
        private System.Windows.Forms.Label goodsRegicateID;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiId;
    }
}
