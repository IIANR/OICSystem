namespace WindowsFormsApplication1
{
    partial class OrderingRegi
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ErrMsg2 = new System.Windows.Forms.Label();
            this.AddressTextbox2 = new System.Windows.Forms.TextBox();
            this.AddressLabel2 = new System.Windows.Forms.Label();
            this.PoscodeTextbox = new System.Windows.Forms.TextBox();
            this.PoscodeLabel = new System.Windows.Forms.Label();
            this.TelTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox1 = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.TelLabel = new System.Windows.Forms.Label();
            this.AddressLabel1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.RegiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrMsg2
            // 
            this.ErrMsg2.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg2.Location = new System.Drawing.Point(216, 85);
            this.ErrMsg2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrMsg2.Name = "ErrMsg2";
            this.ErrMsg2.Size = new System.Drawing.Size(223, 18);
            this.ErrMsg2.TabIndex = 85;
            this.ErrMsg2.Text = "エラーメッセージ";
            // 
            // AddressTextbox2
            // 
            this.AddressTextbox2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.AddressTextbox2.Location = new System.Drawing.Point(216, 257);
            this.AddressTextbox2.Name = "AddressTextbox2";
            this.AddressTextbox2.Size = new System.Drawing.Size(223, 27);
            this.AddressTextbox2.TabIndex = 76;
            // 
            // AddressLabel2
            // 
            this.AddressLabel2.AutoSize = true;
            this.AddressLabel2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.AddressLabel2.Location = new System.Drawing.Point(126, 260);
            this.AddressLabel2.Name = "AddressLabel2";
            this.AddressLabel2.Size = new System.Drawing.Size(69, 20);
            this.AddressLabel2.TabIndex = 83;
            this.AddressLabel2.Text = "住所2：";
            // 
            // PoscodeTextbox
            // 
            this.PoscodeTextbox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.PoscodeTextbox.Location = new System.Drawing.Point(216, 166);
            this.PoscodeTextbox.Name = "PoscodeTextbox";
            this.PoscodeTextbox.Size = new System.Drawing.Size(223, 27);
            this.PoscodeTextbox.TabIndex = 74;
            this.PoscodeTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PoscodeTextbox_KeyDown);
            this.PoscodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoscodeTextbox_KeyPress);
            // 
            // PoscodeLabel
            // 
            this.PoscodeLabel.AutoSize = true;
            this.PoscodeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.PoscodeLabel.Location = new System.Drawing.Point(96, 169);
            this.PoscodeLabel.Name = "PoscodeLabel";
            this.PoscodeLabel.Size = new System.Drawing.Size(99, 20);
            this.PoscodeLabel.TabIndex = 82;
            this.PoscodeLabel.Text = "郵便番号：";
            // 
            // TelTextbox
            // 
            this.TelTextbox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TelTextbox.Location = new System.Drawing.Point(216, 311);
            this.TelTextbox.Name = "TelTextbox";
            this.TelTextbox.Size = new System.Drawing.Size(223, 27);
            this.TelTextbox.TabIndex = 77;
            // 
            // AddressTextbox1
            // 
            this.AddressTextbox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.AddressTextbox1.Location = new System.Drawing.Point(216, 208);
            this.AddressTextbox1.Name = "AddressTextbox1";
            this.AddressTextbox1.Size = new System.Drawing.Size(223, 27);
            this.AddressTextbox1.TabIndex = 75;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NameTextbox.Location = new System.Drawing.Point(216, 117);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(223, 27);
            this.NameTextbox.TabIndex = 72;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TelLabel.Location = new System.Drawing.Point(96, 314);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(99, 20);
            this.TelLabel.TabIndex = 81;
            this.TelLabel.Text = "電話番号：";
            // 
            // AddressLabel1
            // 
            this.AddressLabel1.AutoSize = true;
            this.AddressLabel1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.AddressLabel1.Location = new System.Drawing.Point(126, 211);
            this.AddressLabel1.Name = "AddressLabel1";
            this.AddressLabel1.Size = new System.Drawing.Size(69, 20);
            this.AddressLabel1.TabIndex = 80;
            this.AddressLabel1.Text = "住所1：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NameLabel.Location = new System.Drawing.Point(96, 120);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 20);
            this.NameLabel.TabIndex = 79;
            this.NameLabel.Text = "入庫先名：";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.MemberLabel.Location = new System.Drawing.Point(37, 41);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(147, 27);
            this.MemberLabel.TabIndex = 78;
            this.MemberLabel.Text = "入庫先情報";
            // 
            // RegiBtn
            // 
            this.RegiBtn.Location = new System.Drawing.Point(603, 367);
            this.RegiBtn.Name = "RegiBtn";
            this.RegiBtn.Size = new System.Drawing.Size(92, 37);
            this.RegiBtn.TabIndex = 86;
            this.RegiBtn.Text = "登録";
            this.RegiBtn.UseVisualStyleBackColor = true;
            this.RegiBtn.Click += new System.EventHandler(this.RegiBtn_Click);
            // 
            // OrderingRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegiBtn);
            this.Controls.Add(this.ErrMsg2);
            this.Controls.Add(this.AddressTextbox2);
            this.Controls.Add(this.AddressLabel2);
            this.Controls.Add(this.PoscodeTextbox);
            this.Controls.Add(this.PoscodeLabel);
            this.Controls.Add(this.TelTextbox);
            this.Controls.Add(this.AddressTextbox1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.AddressLabel1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MemberLabel);
            this.Name = "OrderingRegi";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.OrderingRegi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrMsg2;
        private System.Windows.Forms.TextBox AddressTextbox2;
        private System.Windows.Forms.Label AddressLabel2;
        private System.Windows.Forms.TextBox PoscodeTextbox;
        private System.Windows.Forms.Label PoscodeLabel;
        private System.Windows.Forms.TextBox TelTextbox;
        private System.Windows.Forms.TextBox AddressTextbox1;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label AddressLabel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.Button RegiBtn;
    }
}
