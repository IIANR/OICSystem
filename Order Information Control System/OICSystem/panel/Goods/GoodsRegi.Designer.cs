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
            this.components = new System.ComponentModel.Container();
            this.textBprice = new System.Windows.Forms.TextBox();
            this.textBsupp = new System.Windows.Forms.TextBox();
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
            this.Lblodr = new System.Windows.Forms.Label();
            this.textBodr = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBprice
            // 
            this.textBprice.Enabled = false;
            this.textBprice.Location = new System.Drawing.Point(145, 153);
            this.textBprice.Name = "textBprice";
            this.textBprice.ReadOnly = true;
            this.textBprice.Size = new System.Drawing.Size(83, 19);
            this.textBprice.TabIndex = 37;
            // 
            // textBsupp
            // 
            this.textBsupp.Location = new System.Drawing.Point(142, 118);
            this.textBsupp.Name = "textBsupp";
            this.textBsupp.Size = new System.Drawing.Size(86, 19);
            this.textBsupp.TabIndex = 36;
            this.textBsupp.TextChanged += new System.EventHandler(this.textBsupp_TextChanged);
            // 
            // Lblsupp
            // 
            this.Lblsupp.AutoSize = true;
            this.Lblsupp.Location = new System.Drawing.Point(82, 125);
            this.Lblsupp.Name = "Lblsupp";
            this.Lblsupp.Size = new System.Drawing.Size(54, 12);
            this.Lblsupp.TabIndex = 35;
            this.Lblsupp.Text = "仕入れ値:";
            // 
            // textBID
            // 
            this.textBID.Location = new System.Drawing.Point(142, 48);
            this.textBID.Name = "textBID";
            this.textBID.ReadOnly = true;
            this.textBID.Size = new System.Drawing.Size(86, 19);
            this.textBID.TabIndex = 34;
            // 
            // textBimage
            // 
            this.textBimage.Location = new System.Drawing.Point(507, 23);
            this.textBimage.Name = "textBimage";
            this.textBimage.ReadOnly = true;
            this.textBimage.Size = new System.Drawing.Size(83, 19);
            this.textBimage.TabIndex = 23;
            this.textBimage.TextChanged += new System.EventHandler(this.textBimage_TextChanged);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(429, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(262, 247);
            this.panel.TabIndex = 33;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(262, 247);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // InsertBtn
            // 
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Location = new System.Drawing.Point(577, 301);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(114, 43);
            this.InsertBtn.TabIndex = 32;
            this.InsertBtn.Text = "追加";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // comboBcate
            // 
            this.comboBcate.DisplayMember = "カテゴリID";
            this.comboBcate.FormattingEnabled = true;
            this.comboBcate.Location = new System.Drawing.Point(142, 188);
            this.comboBcate.Name = "comboBcate";
            this.comboBcate.Size = new System.Drawing.Size(103, 20);
            this.comboBcate.TabIndex = 24;
            this.comboBcate.ValueMember = "カテゴリID";
            // 
            // textBnumber
            // 
            this.textBnumber.Location = new System.Drawing.Point(142, 224);
            this.textBnumber.Name = "textBnumber";
            this.textBnumber.Size = new System.Drawing.Size(86, 19);
            this.textBnumber.TabIndex = 31;
            this.textBnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBnumber_KeyPress);
            // 
            // goodsReginumber
            // 
            this.goodsReginumber.AutoSize = true;
            this.goodsReginumber.Location = new System.Drawing.Point(70, 231);
            this.goodsReginumber.Name = "goodsReginumber";
            this.goodsReginumber.Size = new System.Drawing.Size(67, 12);
            this.goodsReginumber.TabIndex = 25;
            this.goodsReginumber.Text = "安全在庫数:";
            // 
            // goodsRegicateID
            // 
            this.goodsRegicateID.AutoSize = true;
            this.goodsRegicateID.Location = new System.Drawing.Point(74, 196);
            this.goodsRegicateID.Name = "goodsRegicateID";
            this.goodsRegicateID.Size = new System.Drawing.Size(63, 12);
            this.goodsRegicateID.TabIndex = 26;
            this.goodsRegicateID.Text = "カテゴリー名:";
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(142, 83);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(125, 19);
            this.textBname.TabIndex = 30;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(105, 160);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 27;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(94, 90);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(43, 12);
            this.goodsRegiName.TabIndex = 28;
            this.goodsRegiName.Text = "商品名:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(94, 55);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(42, 12);
            this.goodsRegiId.TabIndex = 29;
            this.goodsRegiId.Text = "商品ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lblodr
            // 
            this.Lblodr.AutoSize = true;
            this.Lblodr.Location = new System.Drawing.Point(93, 266);
            this.Lblodr.Name = "Lblodr";
            this.Lblodr.Size = new System.Drawing.Size(43, 12);
            this.Lblodr.TabIndex = 38;
            this.Lblodr.Text = "発注数:";
            // 
            // textBodr
            // 
            this.textBodr.Location = new System.Drawing.Point(142, 259);
            this.textBodr.Name = "textBodr";
            this.textBodr.Size = new System.Drawing.Size(50, 19);
            this.textBodr.TabIndex = 39;
            this.textBodr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBodr_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBodr);
            this.Controls.Add(this.Lblodr);
            this.Controls.Add(this.textBprice);
            this.Controls.Add(this.textBsupp);
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
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.GoodsRegi_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBprice;
        private System.Windows.Forms.TextBox textBsupp;
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
        private System.Windows.Forms.Label Lblodr;
        private System.Windows.Forms.TextBox textBodr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
