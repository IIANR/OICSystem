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
            this.KanaLabel = new System.Windows.Forms.Label();
            this.KanaTextbox = new System.Windows.Forms.TextBox();
            this.OrderRegiDataGridview = new System.Windows.Forms.DataGridView();
            this.NumCombo = new System.Windows.Forms.ComboBox();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderRegiDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // TelTextbox
            // 
            this.TelTextbox.Location = new System.Drawing.Point(249, 724);
            this.TelTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TelTextbox.Name = "TelTextbox";
            this.TelTextbox.Size = new System.Drawing.Size(398, 31);
            this.TelTextbox.TabIndex = 8;
            // 
            // AddressTextbox1
            // 
            this.AddressTextbox1.Location = new System.Drawing.Point(249, 612);
            this.AddressTextbox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddressTextbox1.Name = "AddressTextbox1";
            this.AddressTextbox1.Size = new System.Drawing.Size(398, 31);
            this.AddressTextbox1.TabIndex = 6;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(249, 444);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(398, 31);
            this.NameTextbox.TabIndex = 3;
            // 
            // GoodsidTextBox
            // 
            this.GoodsidTextBox.Location = new System.Drawing.Point(249, 172);
            this.GoodsidTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GoodsidTextBox.Name = "GoodsidTextBox";
            this.GoodsidTextBox.Size = new System.Drawing.Size(398, 31);
            this.GoodsidTextBox.TabIndex = 1;
            this.GoodsidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GoodsidTextBox_KeyPress);
            // 
            // OrderCompBtn
            // 
            this.OrderCompBtn.Location = new System.Drawing.Point(1365, 682);
            this.OrderCompBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OrderCompBtn.Name = "OrderCompBtn";
            this.OrderCompBtn.Size = new System.Drawing.Size(221, 80);
            this.OrderCompBtn.TabIndex = 43;
            this.OrderCompBtn.Text = "注文完了";
            this.OrderCompBtn.UseVisualStyleBackColor = true;
            this.OrderCompBtn.Click += new System.EventHandler(this.OrderCompBtn_Click);
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(108, 724);
            this.TelLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(118, 24);
            this.TelLabel.TabIndex = 41;
            this.TelLabel.Text = "電話番号：";
            // 
            // AddressLabel1
            // 
            this.AddressLabel1.AutoSize = true;
            this.AddressLabel1.Location = new System.Drawing.Point(145, 612);
            this.AddressLabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddressLabel1.Name = "AddressLabel1";
            this.AddressLabel1.Size = new System.Drawing.Size(82, 24);
            this.AddressLabel1.TabIndex = 40;
            this.AddressLabel1.Text = "住所1：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(158, 444);
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
            this.MemberLabel.Size = new System.Drawing.Size(106, 24);
            this.MemberLabel.TabIndex = 38;
            this.MemberLabel.Text = "顧客情報";
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(158, 252);
            this.NumLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(70, 24);
            this.NumLabel.TabIndex = 37;
            this.NumLabel.Text = "個数：";
            // 
            // GoodsidLabel
            // 
            this.GoodsidLabel.AutoSize = true;
            this.GoodsidLabel.Location = new System.Drawing.Point(134, 172);
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
            this.PoscodeLabel.Location = new System.Drawing.Point(108, 556);
            this.PoscodeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PoscodeLabel.Name = "PoscodeLabel";
            this.PoscodeLabel.Size = new System.Drawing.Size(118, 24);
            this.PoscodeLabel.TabIndex = 49;
            this.PoscodeLabel.Text = "郵便番号：";
            // 
            // PoscodeTextbox
            // 
            this.PoscodeTextbox.Location = new System.Drawing.Point(249, 556);
            this.PoscodeTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PoscodeTextbox.Name = "PoscodeTextbox";
            this.PoscodeTextbox.Size = new System.Drawing.Size(398, 31);
            this.PoscodeTextbox.TabIndex = 5;
            this.PoscodeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PoscodeTextbox_KeyDown);
            this.PoscodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoscodeTextbox_KeyPress);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(845, 682);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(221, 80);
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
            this.AddressTextbox2.Location = new System.Drawing.Point(249, 668);
            this.AddressTextbox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddressTextbox2.Name = "AddressTextbox2";
            this.AddressTextbox2.Size = new System.Drawing.Size(398, 31);
            this.AddressTextbox2.TabIndex = 7;
            // 
            // AddressLabel2
            // 
            this.AddressLabel2.AutoSize = true;
            this.AddressLabel2.Location = new System.Drawing.Point(145, 668);
            this.AddressLabel2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddressLabel2.Name = "AddressLabel2";
            this.AddressLabel2.Size = new System.Drawing.Size(82, 24);
            this.AddressLabel2.TabIndex = 56;
            this.AddressLabel2.Text = "住所2：";
            // 
            // KanaLabel
            // 
            this.KanaLabel.AutoSize = true;
            this.KanaLabel.Location = new System.Drawing.Point(145, 500);
            this.KanaLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.KanaLabel.Name = "KanaLabel";
            this.KanaLabel.Size = new System.Drawing.Size(82, 24);
            this.KanaLabel.TabIndex = 60;
            this.KanaLabel.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.Location = new System.Drawing.Point(249, 500);
            this.KanaTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(398, 31);
            this.KanaTextbox.TabIndex = 4;
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
            this.NumCombo.Location = new System.Drawing.Point(249, 249);
            this.NumCombo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.NumCombo.Name = "NumCombo";
            this.NumCombo.Size = new System.Drawing.Size(67, 32);
            this.NumCombo.TabIndex = 2;
            this.NumCombo.Text = "1";
            // 
            // ErrMsg
            // 
            this.ErrMsg.Location = new System.Drawing.Point(258, 208);
            this.ErrMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(394, 36);
            this.ErrMsg.TabIndex = 64;
            this.ErrMsg.Text = "エラーメッセージ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1105, 682);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(221, 80);
            this.DeleteBtn.TabIndex = 65;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // OrderMgtRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.NumCombo);
            this.Controls.Add(this.OrderRegiDataGridview);
            this.Controls.Add(this.KanaTextbox);
            this.Controls.Add(this.KanaLabel);
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
        private System.Windows.Forms.Label KanaLabel;
        private System.Windows.Forms.TextBox KanaTextbox;
        private System.Windows.Forms.DataGridView OrderRegiDataGridview;
        private System.Windows.Forms.ComboBox NumCombo;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
