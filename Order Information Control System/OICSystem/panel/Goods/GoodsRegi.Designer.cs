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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsRegi));
            this.goodsRegiId = new System.Windows.Forms.Label();
            this.goodsRegiName = new System.Windows.Forms.Label();
            this.goodsRegiPrice = new System.Windows.Forms.Label();
            this.textBname = new System.Windows.Forms.TextBox();
            this.textBprice = new System.Windows.Forms.TextBox();
            this.goodsRegicateID = new System.Windows.Forms.Label();
            this.goodsRegiBikou = new System.Windows.Forms.Label();
            this.goodsReginumber = new System.Windows.Forms.Label();
            this.textBbikou = new System.Windows.Forms.TextBox();
            this.textBnumber = new System.Windows.Forms.TextBox();
            this.comboBcate = new System.Windows.Forms.ComboBox();
            this.カテゴリマスタ商品マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.カテゴリマスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.textBimage = new System.Windows.Forms.TextBox();
            this.textBID = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カテゴリマスタTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.カテゴリマスタTableAdapter();
            this.商品マスタTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.商品マスタTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリマスタ商品マスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリマスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(58, 45);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(42, 12);
            this.goodsRegiId.TabIndex = 0;
            this.goodsRegiId.Text = "商品ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(57, 83);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(43, 12);
            this.goodsRegiName.TabIndex = 0;
            this.goodsRegiName.Text = "商品名:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(69, 121);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 0;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(106, 76);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(125, 19);
            this.textBname.TabIndex = 1;
            // 
            // textBprice
            // 
            this.textBprice.Location = new System.Drawing.Point(106, 114);
            this.textBprice.Name = "textBprice";
            this.textBprice.Size = new System.Drawing.Size(66, 19);
            this.textBprice.TabIndex = 2;
            // 
            // goodsRegicateID
            // 
            this.goodsRegicateID.AutoSize = true;
            this.goodsRegicateID.Location = new System.Drawing.Point(37, 160);
            this.goodsRegicateID.Name = "goodsRegicateID";
            this.goodsRegicateID.Size = new System.Drawing.Size(63, 12);
            this.goodsRegicateID.TabIndex = 0;
            this.goodsRegicateID.Text = "カテゴリー名:";
            // 
            // goodsRegiBikou
            // 
            this.goodsRegiBikou.AutoSize = true;
            this.goodsRegiBikou.Location = new System.Drawing.Point(69, 198);
            this.goodsRegiBikou.Name = "goodsRegiBikou";
            this.goodsRegiBikou.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiBikou.TabIndex = 0;
            this.goodsRegiBikou.Text = "備考:";
            // 
            // goodsReginumber
            // 
            this.goodsReginumber.AutoSize = true;
            this.goodsReginumber.Location = new System.Drawing.Point(33, 236);
            this.goodsReginumber.Name = "goodsReginumber";
            this.goodsReginumber.Size = new System.Drawing.Size(67, 12);
            this.goodsReginumber.TabIndex = 0;
            this.goodsReginumber.Text = "定量発注数:";
            // 
            // textBbikou
            // 
            this.textBbikou.Location = new System.Drawing.Point(106, 191);
            this.textBbikou.Name = "textBbikou";
            this.textBbikou.Size = new System.Drawing.Size(186, 19);
            this.textBbikou.TabIndex = 3;
            // 
            // textBnumber
            // 
            this.textBnumber.Location = new System.Drawing.Point(106, 229);
            this.textBnumber.Name = "textBnumber";
            this.textBnumber.Size = new System.Drawing.Size(86, 19);
            this.textBnumber.TabIndex = 4;
            // 
            // comboBcate
            // 
            this.comboBcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBcate.FormattingEnabled = true;
            this.comboBcate.Location = new System.Drawing.Point(106, 152);
            this.comboBcate.Name = "comboBcate";
            this.comboBcate.Size = new System.Drawing.Size(103, 20);
            this.comboBcate.TabIndex = 0;
            this.comboBcate.ValueMember = "カテゴリID";
            // 
            // カテゴリマスタ商品マスタBindingSource
            // 
            this.カテゴリマスタ商品マスタBindingSource.DataMember = "カテゴリマスタ商品マスタ";
            this.カテゴリマスタ商品マスタBindingSource.DataSource = this.カテゴリマスタBindingSource;
            // 
            // カテゴリマスタBindingSource
            // 
            this.カテゴリマスタBindingSource.DataMember = "カテゴリマスタ";
            this.カテゴリマスタBindingSource.DataSource = this.iM2DataSet;
            // 
            // iM2DataSet
            // 
            this.iM2DataSet.DataSetName = "IM2DataSet";
            this.iM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(452, 291);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(114, 43);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
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
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(452, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(262, 247);
            this.panel.TabIndex = 18;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // textBimage
            // 
            this.textBimage.Location = new System.Drawing.Point(530, 13);
            this.textBimage.Name = "textBimage";
            this.textBimage.ReadOnly = true;
            this.textBimage.Size = new System.Drawing.Size(83, 19);
            this.textBimage.TabIndex = 0;
            this.textBimage.TextChanged += new System.EventHandler(this.textBimage_TextChanged);
            // 
            // textBID
            // 
            this.textBID.Location = new System.Drawing.Point(109, 38);
            this.textBID.Name = "textBID";
            this.textBID.ReadOnly = true;
            this.textBID.Size = new System.Drawing.Size(100, 19);
            this.textBID.TabIndex = 0;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(261, 381);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(188, 25);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VersionToolStripMenuItem.Image")));
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.VersionToolStripMenuItem.Text = "バージョン情報";
            // 
            // カテゴリマスタTableAdapter
            // 
            this.カテゴリマスタTableAdapter.ClearBeforeFill = true;
            // 
            // 商品マスタTableAdapter
            // 
            this.商品マスタTableAdapter.ClearBeforeFill = true;
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.textBID);
            this.Controls.Add(this.textBimage);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.comboBcate);
            this.Controls.Add(this.textBnumber);
            this.Controls.Add(this.textBbikou);
            this.Controls.Add(this.goodsReginumber);
            this.Controls.Add(this.goodsRegiBikou);
            this.Controls.Add(this.goodsRegicateID);
            this.Controls.Add(this.textBprice);
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.goodsRegiPrice);
            this.Controls.Add(this.goodsRegiName);
            this.Controls.Add(this.goodsRegiId);
            this.Name = "GoodsRegi";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.GoodsRegi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリマスタ商品マスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリマスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.TextBox textBprice;
        private System.Windows.Forms.Label goodsRegicateID;
        private System.Windows.Forms.Label goodsRegiBikou;
        private System.Windows.Forms.Label goodsReginumber;
        private System.Windows.Forms.TextBox textBbikou;
        private System.Windows.Forms.TextBox textBnumber;
        private System.Windows.Forms.ComboBox comboBcate;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBimage;
        private System.Windows.Forms.TextBox textBID;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
        private System.Windows.Forms.BindingSource カテゴリマスタBindingSource;
        private IM2DataSet iM2DataSet;
        private IM2DataSetTableAdapters.カテゴリマスタTableAdapter カテゴリマスタTableAdapter;
        private System.Windows.Forms.BindingSource カテゴリマスタ商品マスタBindingSource;
        private IM2DataSetTableAdapters.商品マスタTableAdapter 商品マスタTableAdapter;
    }
}
