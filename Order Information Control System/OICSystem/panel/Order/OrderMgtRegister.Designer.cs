namespace WindowsFormsApplication1
{
    partial class OrderMgtRegister
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
            this.TelTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox1 = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.GoodsidTextBox = new System.Windows.Forms.TextBox();
            this.OrderCompBtn = new System.Windows.Forms.Button();
            this.TelLabel = new System.Windows.Forms.Label();
            this.AddressLabel1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.NumLabel = new System.Windows.Forms.Label();
            this.GoodsidLabel = new System.Windows.Forms.Label();
            this.OrderGoodsLabel = new System.Windows.Forms.Label();
            this.PoscodeLabel = new System.Windows.Forms.Label();
            this.PoscodeTextbox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TotalTitleLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AddressTextbox2 = new System.Windows.Forms.TextBox();
            this.AddressLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KanaLabel = new System.Windows.Forms.Label();
            this.KanaTextbox = new System.Windows.Forms.TextBox();
            this.OrderRegiDataGridview = new System.Windows.Forms.DataGridView();
            this.NumCombo = new System.Windows.Forms.ComboBox();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
            this.商品マスタBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品マスタTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.商品マスタTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderRegiDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TelTextbox
            // 
            this.TelTextbox.Location = new System.Drawing.Point(325, 724);
            this.TelTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TelTextbox.Name = "TelTextbox";
            this.TelTextbox.Size = new System.Drawing.Size(249, 31);
            this.TelTextbox.TabIndex = 48;
            // 
            // AddressTextbox1
            // 
            this.AddressTextbox1.Location = new System.Drawing.Point(325, 612);
            this.AddressTextbox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddressTextbox1.Name = "AddressTextbox1";
            this.AddressTextbox1.Size = new System.Drawing.Size(249, 31);
            this.AddressTextbox1.TabIndex = 47;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(325, 444);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(249, 31);
            this.NameTextbox.TabIndex = 46;
            // 
            // GoodsidTextBox
            // 
            this.GoodsidTextBox.Location = new System.Drawing.Point(299, 172);
            this.GoodsidTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GoodsidTextBox.Name = "GoodsidTextBox";
            this.GoodsidTextBox.Size = new System.Drawing.Size(394, 31);
            this.GoodsidTextBox.TabIndex = 44;
            // 
            // OrderCompBtn
            // 
            this.OrderCompBtn.Location = new System.Drawing.Point(1259, 682);
            this.OrderCompBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OrderCompBtn.Name = "OrderCompBtn";
            this.OrderCompBtn.Size = new System.Drawing.Size(327, 80);
            this.OrderCompBtn.TabIndex = 43;
            this.OrderCompBtn.Text = "注文完了";
            this.OrderCompBtn.UseVisualStyleBackColor = true;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(163, 730);
            this.TelLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(118, 24);
            this.TelLabel.TabIndex = 41;
            this.TelLabel.Text = "電話番号：";
            // 
            // AddressLabel1
            // 
            this.AddressLabel1.AutoSize = true;
            this.AddressLabel1.Location = new System.Drawing.Point(199, 618);
            this.AddressLabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddressLabel1.Name = "AddressLabel1";
            this.AddressLabel1.Size = new System.Drawing.Size(82, 24);
            this.AddressLabel1.TabIndex = 40;
            this.AddressLabel1.Text = "住所1：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(212, 450);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 24);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "名前：";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(98, 386);
            this.MemberLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(126, 24);
            this.MemberLabel.TabIndex = 38;
            this.MemberLabel.Text = "お客様情報";
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(210, 256);
            this.NumLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(70, 24);
            this.NumLabel.TabIndex = 37;
            this.NumLabel.Text = "個数：";
            // 
            // GoodsidLabel
            // 
            this.GoodsidLabel.AutoSize = true;
            this.GoodsidLabel.Location = new System.Drawing.Point(186, 175);
            this.GoodsidLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.GoodsidLabel.Name = "GoodsidLabel";
            this.GoodsidLabel.Size = new System.Drawing.Size(92, 24);
            this.GoodsidLabel.TabIndex = 36;
            this.GoodsidLabel.Text = "商品ID：";
            // 
            // OrderGoodsLabel
            // 
            this.OrderGoodsLabel.AutoSize = true;
            this.OrderGoodsLabel.Location = new System.Drawing.Point(89, 106);
            this.OrderGoodsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.OrderGoodsLabel.Name = "OrderGoodsLabel";
            this.OrderGoodsLabel.Size = new System.Drawing.Size(106, 24);
            this.OrderGoodsLabel.TabIndex = 35;
            this.OrderGoodsLabel.Text = "注文商品";
            // 
            // PoscodeLabel
            // 
            this.PoscodeLabel.AutoSize = true;
            this.PoscodeLabel.Location = new System.Drawing.Point(163, 562);
            this.PoscodeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PoscodeLabel.Name = "PoscodeLabel";
            this.PoscodeLabel.Size = new System.Drawing.Size(118, 24);
            this.PoscodeLabel.TabIndex = 49;
            this.PoscodeLabel.Text = "郵便番号：";
            // 
            // PoscodeTextbox
            // 
            this.PoscodeTextbox.Location = new System.Drawing.Point(325, 556);
            this.PoscodeTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PoscodeTextbox.Name = "PoscodeTextbox";
            this.PoscodeTextbox.Size = new System.Drawing.Size(249, 31);
            this.PoscodeTextbox.TabIndex = 50;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(845, 682);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(327, 80);
            this.AddBtn.TabIndex = 52;
            this.AddBtn.Text = "追加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TotalTitleLabel
            // 
            this.TotalTitleLabel.AutoSize = true;
            this.TotalTitleLabel.Location = new System.Drawing.Point(880, 620);
            this.TotalTitleLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TotalTitleLabel.Name = "TotalTitleLabel";
            this.TotalTitleLabel.Size = new System.Drawing.Size(118, 24);
            this.TotalTitleLabel.TabIndex = 54;
            this.TotalTitleLabel.Text = "合計金額：";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(1053, 620);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(22, 24);
            this.TotalLabel.TabIndex = 55;
            this.TotalLabel.Text = "0";
            // 
            // AddressTextbox2
            // 
            this.AddressTextbox2.Location = new System.Drawing.Point(325, 668);
            this.AddressTextbox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddressTextbox2.Name = "AddressTextbox2";
            this.AddressTextbox2.Size = new System.Drawing.Size(249, 31);
            this.AddressTextbox2.TabIndex = 57;
            // 
            // AddressLabel2
            // 
            this.AddressLabel2.AutoSize = true;
            this.AddressLabel2.Location = new System.Drawing.Point(199, 674);
            this.AddressLabel2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddressLabel2.Name = "AddressLabel2";
            this.AddressLabel2.Size = new System.Drawing.Size(82, 24);
            this.AddressLabel2.TabIndex = 56;
            this.AddressLabel2.Text = "住所2：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "注文ID：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(160, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 46);
            this.label2.TabIndex = 59;
            this.label2.Text = "0000";
            // 
            // KanaLabel
            // 
            this.KanaLabel.AutoSize = true;
            this.KanaLabel.Location = new System.Drawing.Point(199, 506);
            this.KanaLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.KanaLabel.Name = "KanaLabel";
            this.KanaLabel.Size = new System.Drawing.Size(82, 24);
            this.KanaLabel.TabIndex = 60;
            this.KanaLabel.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.Location = new System.Drawing.Point(325, 500);
            this.KanaTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(249, 31);
            this.KanaTextbox.TabIndex = 61;
            // 
            // OrderRegiDataGridview
            // 
            this.OrderRegiDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderRegiDataGridview.Location = new System.Drawing.Point(845, 106);
            this.OrderRegiDataGridview.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OrderRegiDataGridview.Name = "OrderRegiDataGridview";
            this.OrderRegiDataGridview.RowTemplate.Height = 21;
            this.OrderRegiDataGridview.Size = new System.Drawing.Size(741, 444);
            this.OrderRegiDataGridview.TabIndex = 62;
            // 
            // NumCombo
            // 
            this.NumCombo.FormattingEnabled = true;
            this.NumCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumCombo.Location = new System.Drawing.Point(299, 248);
            this.NumCombo.Name = "NumCombo";
            this.NumCombo.Size = new System.Drawing.Size(67, 32);
            this.NumCombo.TabIndex = 63;
            this.NumCombo.Text = "1";
            // 
            // ErrMsg
            // 
            this.ErrMsg.Location = new System.Drawing.Point(299, 209);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(394, 36);
            this.ErrMsg.TabIndex = 64;
            this.ErrMsg.Text = "エラーメッセージ";
            // 
            // iM2DataSet
            // 
            this.iM2DataSet.DataSetName = "IM2DataSet";
            this.iM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品マスタBindingSource
            // 
            this.商品マスタBindingSource.DataMember = "商品マスタ";
            this.商品マスタBindingSource.DataSource = this.iM2DataSet;
            // 
            // 商品マスタTableAdapter
            // 
            this.商品マスタTableAdapter.ClearBeforeFill = true;
            // 
            // OrderMgtRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.NumCombo);
            this.Controls.Add(this.OrderRegiDataGridview);
            this.Controls.Add(this.KanaTextbox);
            this.Controls.Add(this.KanaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextbox2);
            this.Controls.Add(this.AddressLabel2);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTitleLabel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PoscodeTextbox);
            this.Controls.Add(this.PoscodeLabel);
            this.Controls.Add(this.TelTextbox);
            this.Controls.Add(this.AddressTextbox1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.GoodsidTextBox);
            this.Controls.Add(this.OrderCompBtn);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.AddressLabel1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MemberLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.GoodsidLabel);
            this.Controls.Add(this.OrderGoodsLabel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "OrderMgtRegister";
            this.Size = new System.Drawing.Size(1647, 860);
            this.Load += new System.EventHandler(this.OrderMgtRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderRegiDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品マスタBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TelTextbox;
        private System.Windows.Forms.TextBox AddressTextbox1;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox GoodsidTextBox;
        private System.Windows.Forms.Button OrderCompBtn;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label AddressLabel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label GoodsidLabel;
        private System.Windows.Forms.Label OrderGoodsLabel;
        private System.Windows.Forms.Label PoscodeLabel;
        private System.Windows.Forms.TextBox PoscodeTextbox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label TotalTitleLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox AddressTextbox2;
        private System.Windows.Forms.Label AddressLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KanaLabel;
        private System.Windows.Forms.TextBox KanaTextbox;
        private System.Windows.Forms.DataGridView OrderRegiDataGridview;
        private System.Windows.Forms.ComboBox NumCombo;
        private System.Windows.Forms.Label ErrMsg;
        private IM2DataSet iM2DataSet;
        private System.Windows.Forms.BindingSource 商品マスタBindingSource;
        private IM2DataSetTableAdapters.商品マスタTableAdapter 商品マスタTableAdapter;
    }
}
