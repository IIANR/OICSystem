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
            this.goodsRegiId = new System.Windows.Forms.Label();
            this.goodsRegiName = new System.Windows.Forms.Label();
            this.goodsRegiPrice = new System.Windows.Forms.Label();
            this.商品マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM2Data = new WindowsFormsApplication1.IM2Data();
            this.textBname = new System.Windows.Forms.TextBox();
            this.textBprice = new System.Windows.Forms.TextBox();
            this.商品マスタTableAdapter = new WindowsFormsApplication1.IM2DataTableAdapters.商品マスタTableAdapter();
            this.goodsRegicateID = new System.Windows.Forms.Label();
            this.goodsRegiBikou = new System.Windows.Forms.Label();
            this.goodsReginumber = new System.Windows.Forms.Label();
            this.textBbikou = new System.Windows.Forms.TextBox();
            this.textBnumber = new System.Windows.Forms.TextBox();
            this.comboBcate = new System.Windows.Forms.ComboBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.updateMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBimage = new System.Windows.Forms.TextBox();
            this.textBID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsRegiId
            // 
            this.goodsRegiId.AutoSize = true;
            this.goodsRegiId.Location = new System.Drawing.Point(86, 45);
            this.goodsRegiId.Name = "goodsRegiId";
            this.goodsRegiId.Size = new System.Drawing.Size(18, 12);
            this.goodsRegiId.TabIndex = 0;
            this.goodsRegiId.Text = "ID:";
            this.goodsRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiName
            // 
            this.goodsRegiName.AutoSize = true;
            this.goodsRegiName.Location = new System.Drawing.Point(79, 83);
            this.goodsRegiName.Name = "goodsRegiName";
            this.goodsRegiName.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiName.TabIndex = 1;
            this.goodsRegiName.Text = "名前:";
            this.goodsRegiName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // goodsRegiPrice
            // 
            this.goodsRegiPrice.AutoSize = true;
            this.goodsRegiPrice.Location = new System.Drawing.Point(73, 121);
            this.goodsRegiPrice.Name = "goodsRegiPrice";
            this.goodsRegiPrice.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiPrice.TabIndex = 2;
            this.goodsRegiPrice.Text = "単価:";
            this.goodsRegiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 商品マスタBindingSource
            // 
            this.商品マスタBindingSource.DataMember = "商品マスタ";
            this.商品マスタBindingSource.DataSource = this.iM2Data;
            this.商品マスタBindingSource.CurrentChanged += new System.EventHandler(this.商品マスタBindingSource_CurrentChanged);
            // 
            // iM2Data
            // 
            this.iM2Data.DataSetName = "IM2Data";
            this.iM2Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBname
            // 
            this.textBname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "商品名", true));
            this.textBname.Location = new System.Drawing.Point(116, 76);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(125, 19);
            this.textBname.TabIndex = 4;
            // 
            // textBprice
            // 
            this.textBprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "単価", true));
            this.textBprice.Location = new System.Drawing.Point(116, 114);
            this.textBprice.Name = "textBprice";
            this.textBprice.Size = new System.Drawing.Size(66, 19);
            this.textBprice.TabIndex = 5;
            // 
            // 商品マスタTableAdapter
            // 
            this.商品マスタTableAdapter.ClearBeforeFill = true;
            // 
            // goodsRegicateID
            // 
            this.goodsRegicateID.AutoSize = true;
            this.goodsRegicateID.Location = new System.Drawing.Point(37, 160);
            this.goodsRegicateID.Name = "goodsRegicateID";
            this.goodsRegicateID.Size = new System.Drawing.Size(62, 12);
            this.goodsRegicateID.TabIndex = 6;
            this.goodsRegicateID.Text = "カテゴリーID:";
            // 
            // goodsRegiBikou
            // 
            this.goodsRegiBikou.AutoSize = true;
            this.goodsRegiBikou.Location = new System.Drawing.Point(68, 198);
            this.goodsRegiBikou.Name = "goodsRegiBikou";
            this.goodsRegiBikou.Size = new System.Drawing.Size(31, 12);
            this.goodsRegiBikou.TabIndex = 8;
            this.goodsRegiBikou.Text = "備考:";
            // 
            // goodsReginumber
            // 
            this.goodsReginumber.AutoSize = true;
            this.goodsReginumber.Location = new System.Drawing.Point(37, 236);
            this.goodsReginumber.Name = "goodsReginumber";
            this.goodsReginumber.Size = new System.Drawing.Size(67, 12);
            this.goodsReginumber.TabIndex = 9;
            this.goodsReginumber.Text = "定量発注数:";
            // 
            // textBbikou
            // 
            this.textBbikou.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "備考", true));
            this.textBbikou.Location = new System.Drawing.Point(116, 191);
            this.textBbikou.Name = "textBbikou";
            this.textBbikou.Size = new System.Drawing.Size(186, 19);
            this.textBbikou.TabIndex = 11;
            // 
            // textBnumber
            // 
            this.textBnumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "定期発注数", true));
            this.textBnumber.Location = new System.Drawing.Point(116, 229);
            this.textBnumber.Name = "textBnumber";
            this.textBnumber.Size = new System.Drawing.Size(86, 19);
            this.textBnumber.TabIndex = 12;
            // 
            // comboBcate
            // 
            this.comboBcate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "カテゴリID", true));
            this.comboBcate.FormattingEnabled = true;
            this.comboBcate.Location = new System.Drawing.Point(116, 152);
            this.comboBcate.Name = "comboBcate";
            this.comboBcate.Size = new System.Drawing.Size(103, 20);
            this.comboBcate.TabIndex = 13;
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(197, 366);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 23);
            this.btnBefore.TabIndex = 14;
            this.btnBefore.Text = "前へ";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(452, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "次へ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(452, 291);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(114, 43);
            this.UpdateBtn.TabIndex = 16;
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
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(116, 366);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "最初へ";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(533, 366);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "最後へ";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // updateMessage
            // 
            this.updateMessage.AutoSize = true;
            this.updateMessage.Location = new System.Drawing.Point(590, 322);
            this.updateMessage.Name = "updateMessage";
            this.updateMessage.Size = new System.Drawing.Size(84, 12);
            this.updateMessage.TabIndex = 21;
            this.updateMessage.Text = "updateMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // textBimage
            // 
            this.textBimage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "商品画像", true));
            this.textBimage.Location = new System.Drawing.Point(533, 13);
            this.textBimage.Name = "textBimage";
            this.textBimage.ReadOnly = true;
            this.textBimage.Size = new System.Drawing.Size(100, 19);
            this.textBimage.TabIndex = 24;
            // 
            // textBID
            // 
            this.textBID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.商品マスタBindingSource, "商品画像", true));
            this.textBID.Location = new System.Drawing.Point(119, 38);
            this.textBID.Name = "textBID";
            this.textBID.ReadOnly = true;
            this.textBID.Size = new System.Drawing.Size(100, 19);
            this.textBID.TabIndex = 25;
            // 
            // GoodsRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBID);
            this.Controls.Add(this.textBimage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateMessage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBefore);
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
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodsRegiId;
        private System.Windows.Forms.Label goodsRegiName;
        private System.Windows.Forms.Label goodsRegiPrice;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.TextBox textBprice;
        private System.Windows.Forms.BindingSource 商品マスタBindingSource;
        private IM2Data iM2Data;
        private IM2DataTableAdapters.商品マスタTableAdapter 商品マスタTableAdapter;
        private System.Windows.Forms.Label goodsRegicateID;
        private System.Windows.Forms.Label goodsRegiBikou;
        private System.Windows.Forms.Label goodsReginumber;
        private System.Windows.Forms.TextBox textBbikou;
        private System.Windows.Forms.TextBox textBnumber;
        private System.Windows.Forms.ComboBox comboBcate;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label updateMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBimage;
        private System.Windows.Forms.TextBox textBID;
    }
}
