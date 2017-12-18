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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsList));
            this.Lblsupp = new System.Windows.Forms.Label();
            this.textBsupp = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.textBID = new System.Windows.Forms.TextBox();
            this.textBimage = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.comboBcate = new System.Windows.Forms.ComboBox();
            this.textBnumber = new System.Windows.Forms.TextBox();
            this.goodsReginumber = new System.Windows.Forms.Label();
            this.goodsRegicateID = new System.Windows.Forms.Label();
            this.textBprice = new System.Windows.Forms.TextBox();
            this.textBname = new System.Windows.Forms.TextBox();
            this.goodsRegiPrice = new System.Windows.Forms.Label();
            this.goodsRegiName = new System.Windows.Forms.Label();
            this.goodsRegiId = new System.Windows.Forms.Label();
            this.textBodr = new System.Windows.Forms.TextBox();
            this.Lblodr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblsupp
            // 
            this.Lblsupp.AutoSize = true;
            this.Lblsupp.Location = new System.Drawing.Point(87, 125);
            this.Lblsupp.Name = "Lblsupp";
            this.Lblsupp.Size = new System.Drawing.Size(54, 12);
            this.Lblsupp.TabIndex = 63;
            this.Lblsupp.Text = "仕入れ値:";
            // 
            // textBsupp
            // 
            this.textBsupp.Location = new System.Drawing.Point(150, 118);
            this.textBsupp.Name = "textBsupp";
            this.textBsupp.Size = new System.Drawing.Size(83, 19);
            this.textBsupp.TabIndex = 62;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(572, 345);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(114, 43);
            this.DeleteBtn.TabIndex = 61;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(272, 387);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(188, 25);
            this.bindingNavigator1.TabIndex = 60;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // textBID
            // 
            this.textBID.Location = new System.Drawing.Point(150, 44);
            this.textBID.Name = "textBID";
            this.textBID.ReadOnly = true;
            this.textBID.Size = new System.Drawing.Size(83, 19);
            this.textBID.TabIndex = 49;
            // 
            // textBimage
            // 
            this.textBimage.Location = new System.Drawing.Point(506, 19);
            this.textBimage.Name = "textBimage";
            this.textBimage.ReadOnly = true;
            this.textBimage.Size = new System.Drawing.Size(83, 19);
            this.textBimage.TabIndex = 50;
            this.textBimage.TextChanged += new System.EventHandler(this.textBimage_TextChanged);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(424, 44);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(262, 247);
            this.panel.TabIndex = 59;
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
            // UpdateBtn
            // 
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(572, 296);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(114, 43);
            this.UpdateBtn.TabIndex = 58;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // comboBcate
            // 
            this.comboBcate.DisplayMember = "カテゴリID";
            this.comboBcate.FormattingEnabled = true;
            this.comboBcate.Location = new System.Drawing.Point(150, 192);
            this.comboBcate.Name = "comboBcate";
            this.comboBcate.Size = new System.Drawing.Size(103, 20);
            this.comboBcate.TabIndex = 51;
            this.comboBcate.ValueMember = "カテゴリID";
            // 
            // textBnumber
            // 
            this.textBnumber.Location = new System.Drawing.Point(150, 230);
            this.textBnumber.Name = "textBnumber";
            this.textBnumber.Size = new System.Drawing.Size(86, 19);
            this.textBnumber.TabIndex = 57;
            // 
            // goodsReginumber
            // 
            this.goodsReginumber.AutoSize = true;
            this.goodsReginumber.Location = new System.Drawing.Point(74, 237);
            this.goodsReginumber.Name = "goodsReginumber";
            this.goodsReginumber.Size = new System.Drawing.Size(67, 12);
            this.goodsReginumber.TabIndex = 54;
            this.goodsReginumber.Text = "定量発注数:";
            // 
            // goodsRegicateID
            // 
            this.goodsRegicateID.AutoSize = true;
            this.goodsRegicateID.Location = new System.Drawing.Point(78, 200);
            this.goodsRegicateID.Name = "goodsRegicateID";
            this.goodsRegicateID.Size = new System.Drawing.Size(63, 12);
            this.goodsRegicateID.TabIndex = 52;
            this.goodsRegicateID.Text = "カテゴリー名:";
            // 
            // textBprice
            // 
            this.textBprice.Location = new System.Drawing.Point(150, 155);
            this.textBprice.Name = "textBprice";
            this.textBprice.ReadOnly = true;
            this.textBprice.Size = new System.Drawing.Size(83, 19);
            this.textBprice.TabIndex = 56;
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(150, 81);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(125, 19);
            this.textBname.TabIndex = 55;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(110, 162);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 48;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(98, 88);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(43, 12);
            this.goodsRegiName.TabIndex = 53;
            this.goodsRegiName.Text = "商品名:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(99, 51);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(42, 12);
            this.goodsRegiId.TabIndex = 47;
            this.goodsRegiId.Text = "商品ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBodr
            // 
            this.textBodr.Location = new System.Drawing.Point(150, 267);
            this.textBodr.Name = "textBodr";
            this.textBodr.Size = new System.Drawing.Size(50, 19);
            this.textBodr.TabIndex = 65;
            // 
            // Lblodr
            // 
            this.Lblodr.AutoSize = true;
            this.Lblodr.Location = new System.Drawing.Point(98, 274);
            this.Lblodr.Name = "Lblodr";
            this.Lblodr.Size = new System.Drawing.Size(43, 12);
            this.Lblodr.TabIndex = 64;
            this.Lblodr.Text = "発注数:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBodr);
            this.Controls.Add(this.Lblodr);
            this.Controls.Add(this.Lblsupp);
            this.Controls.Add(this.textBsupp);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.textBID);
            this.Controls.Add(this.textBimage);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.comboBcate);
            this.Controls.Add(this.textBnumber);
            this.Controls.Add(this.goodsReginumber);
            this.Controls.Add(this.goodsRegicateID);
            this.Controls.Add(this.textBprice);
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Name = "GoodsList";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.GoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblsupp;
        private System.Windows.Forms.TextBox textBsupp;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox textBID;
        private System.Windows.Forms.TextBox textBimage;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox comboBcate;
        private System.Windows.Forms.TextBox textBnumber;
        private System.Windows.Forms.Label goodsReginumber;
        private System.Windows.Forms.Label goodsRegicateID;
        private System.Windows.Forms.TextBox textBprice;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.TextBox textBodr;
        private System.Windows.Forms.Label Lblodr;
        private System.Windows.Forms.Button button1;
    }
}
