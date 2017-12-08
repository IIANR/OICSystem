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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrMsg2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderRegiDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // TelTextbox
            // 
            this.TelTextbox.Location = new System.Drawing.Point(115, 362);
            this.TelTextbox.Name = "TelTextbox";
            this.TelTextbox.Size = new System.Drawing.Size(186, 19);
            this.TelTextbox.TabIndex = 8;
            this.TelTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelTextbox_KeyPress);
            // 
            // AddressTextbox1
            // 
            this.AddressTextbox1.Location = new System.Drawing.Point(115, 306);
            this.AddressTextbox1.Name = "AddressTextbox1";
            this.AddressTextbox1.Size = new System.Drawing.Size(186, 19);
            this.AddressTextbox1.TabIndex = 6;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(115, 222);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(186, 19);
            this.NameTextbox.TabIndex = 3;
            // 
            // GoodsidTextBox
            // 
            this.GoodsidTextBox.Location = new System.Drawing.Point(115, 86);
            this.GoodsidTextBox.Name = "GoodsidTextBox";
            this.GoodsidTextBox.Size = new System.Drawing.Size(186, 19);
            this.GoodsidTextBox.TabIndex = 1;
            this.GoodsidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GoodsidTextBox_KeyPress);
            // 
            // OrderCompBtn
            // 
            this.OrderCompBtn.Location = new System.Drawing.Point(629, 341);
            this.OrderCompBtn.Name = "OrderCompBtn";
            this.OrderCompBtn.Size = new System.Drawing.Size(102, 40);
            this.OrderCompBtn.TabIndex = 43;
            this.OrderCompBtn.Text = "注文完了";
            this.OrderCompBtn.UseVisualStyleBackColor = true;
            this.OrderCompBtn.Click += new System.EventHandler(this.OrderCompBtn_Click);
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(50, 362);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(59, 12);
            this.TelLabel.TabIndex = 41;
            this.TelLabel.Text = "電話番号：";
            // 
            // AddressLabel1
            // 
            this.AddressLabel1.AutoSize = true;
            this.AddressLabel1.Location = new System.Drawing.Point(67, 306);
            this.AddressLabel1.Name = "AddressLabel1";
            this.AddressLabel1.Size = new System.Drawing.Size(41, 12);
            this.AddressLabel1.TabIndex = 40;
            this.AddressLabel1.Text = "住所1：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(73, 222);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 12);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "名前：";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(36, 193);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(53, 12);
            this.MemberLabel.TabIndex = 38;
            this.MemberLabel.Text = "顧客情報";
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(74, 112);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(35, 12);
            this.NumLabel.TabIndex = 37;
            this.NumLabel.Text = "数量：";
            // 
            // GoodsidLabel
            // 
            this.GoodsidLabel.AutoSize = true;
            this.GoodsidLabel.Location = new System.Drawing.Point(62, 86);
            this.GoodsidLabel.Name = "GoodsidLabel";
            this.GoodsidLabel.Size = new System.Drawing.Size(46, 12);
            this.GoodsidLabel.TabIndex = 36;
            this.GoodsidLabel.Text = "商品ID：";
            // 
            // OrderGoodsLabel
            // 
            this.OrderGoodsLabel.AutoSize = true;
            this.OrderGoodsLabel.Location = new System.Drawing.Point(36, 46);
            this.OrderGoodsLabel.Name = "OrderGoodsLabel";
            this.OrderGoodsLabel.Size = new System.Drawing.Size(53, 12);
            this.OrderGoodsLabel.TabIndex = 35;
            this.OrderGoodsLabel.Text = "注文商品";
            // 
            // PoscodeLabel
            // 
            this.PoscodeLabel.AutoSize = true;
            this.PoscodeLabel.Location = new System.Drawing.Point(50, 278);
            this.PoscodeLabel.Name = "PoscodeLabel";
            this.PoscodeLabel.Size = new System.Drawing.Size(59, 12);
            this.PoscodeLabel.TabIndex = 49;
            this.PoscodeLabel.Text = "郵便番号：";
            // 
            // PoscodeTextbox
            // 
            this.PoscodeTextbox.Location = new System.Drawing.Point(115, 278);
            this.PoscodeTextbox.Name = "PoscodeTextbox";
            this.PoscodeTextbox.Size = new System.Drawing.Size(186, 19);
            this.PoscodeTextbox.TabIndex = 5;
            this.PoscodeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PoscodeTextbox_KeyDown);
            this.PoscodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoscodeTextbox_KeyPress);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(391, 341);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(102, 40);
            this.AddBtn.TabIndex = 52;
            this.AddBtn.Text = "追加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TotalTitleLabel
            // 
            this.TotalTitleLabel.AutoSize = true;
            this.TotalTitleLabel.Location = new System.Drawing.Point(406, 310);
            this.TotalTitleLabel.Name = "TotalTitleLabel";
            this.TotalTitleLabel.Size = new System.Drawing.Size(59, 12);
            this.TotalTitleLabel.TabIndex = 54;
            this.TotalTitleLabel.Text = "合計金額：";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(486, 310);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(11, 12);
            this.TotalLabel.TabIndex = 55;
            this.TotalLabel.Text = "0";
            // 
            // AddressTextbox2
            // 
            this.AddressTextbox2.Location = new System.Drawing.Point(115, 334);
            this.AddressTextbox2.Name = "AddressTextbox2";
            this.AddressTextbox2.Size = new System.Drawing.Size(186, 19);
            this.AddressTextbox2.TabIndex = 7;
            // 
            // AddressLabel2
            // 
            this.AddressLabel2.AutoSize = true;
            this.AddressLabel2.Location = new System.Drawing.Point(67, 334);
            this.AddressLabel2.Name = "AddressLabel2";
            this.AddressLabel2.Size = new System.Drawing.Size(41, 12);
            this.AddressLabel2.TabIndex = 56;
            this.AddressLabel2.Text = "住所2：";
            // 
            // KanaLabel
            // 
            this.KanaLabel.AutoSize = true;
            this.KanaLabel.Location = new System.Drawing.Point(67, 250);
            this.KanaLabel.Name = "KanaLabel";
            this.KanaLabel.Size = new System.Drawing.Size(42, 12);
            this.KanaLabel.TabIndex = 60;
            this.KanaLabel.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // KanaTextbox
            // 
            this.KanaTextbox.Location = new System.Drawing.Point(115, 250);
            this.KanaTextbox.Name = "KanaTextbox";
            this.KanaTextbox.Size = new System.Drawing.Size(186, 19);
            this.KanaTextbox.TabIndex = 4;
            // 
            // OrderRegiDataGridview
            // 
            this.OrderRegiDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderRegiDataGridview.Location = new System.Drawing.Point(391, 46);
            this.OrderRegiDataGridview.Name = "OrderRegiDataGridview";
            this.OrderRegiDataGridview.RowTemplate.Height = 21;
            this.OrderRegiDataGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderRegiDataGridview.Size = new System.Drawing.Size(341, 229);
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
            this.NumCombo.Location = new System.Drawing.Point(116, 110);
            this.NumCombo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.NumCombo.Name = "NumCombo";
            this.NumCombo.Size = new System.Drawing.Size(33, 20);
            this.NumCombo.TabIndex = 2;
            this.NumCombo.Text = "1";
            // 
            // ErrMsg
            // 
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(113, 46);
            this.ErrMsg.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(182, 18);
            this.ErrMsg.TabIndex = 64;
            this.ErrMsg.Text = "エラーメッセージ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(510, 341);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(102, 40);
            this.DeleteBtn.TabIndex = 65;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 66;
            this.label1.Text = "必須";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "必須";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 68;
            this.label3.Text = "必須";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 69;
            this.label4.Text = "必須";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "必須";
            // 
            // ErrMsg2
            // 
            this.ErrMsg2.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg2.Location = new System.Drawing.Point(113, 193);
            this.ErrMsg2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrMsg2.Name = "ErrMsg2";
            this.ErrMsg2.Size = new System.Drawing.Size(223, 18);
            this.ErrMsg2.TabIndex = 71;
            this.ErrMsg2.Text = "エラーメッセージ";
            // 
            // OrderMgtRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrMsg2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "OrderMgtRegister";
            this.Size = new System.Drawing.Size(760, 430);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrMsg2;
    }
}
