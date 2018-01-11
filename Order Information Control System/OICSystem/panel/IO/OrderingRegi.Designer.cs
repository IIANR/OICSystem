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
            this.AllBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RegiBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.OrderingGridview = new System.Windows.Forms.DataGridView();
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
            this.EditMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderingGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBtn
            // 
            this.AllBtn.Location = new System.Drawing.Point(22, 303);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(87, 22);
            this.AllBtn.TabIndex = 113;
            this.AllBtn.Text = "全てのデータ";
            this.AllBtn.UseVisualStyleBackColor = true;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(554, 379);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(92, 37);
            this.ClearBtn.TabIndex = 112;
            this.ClearBtn.Text = "クリア";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RegiBtn
            // 
            this.RegiBtn.Location = new System.Drawing.Point(554, 320);
            this.RegiBtn.Name = "RegiBtn";
            this.RegiBtn.Size = new System.Drawing.Size(92, 39);
            this.RegiBtn.TabIndex = 111;
            this.RegiBtn.Text = "新規登録";
            this.RegiBtn.UseVisualStyleBackColor = true;
            this.RegiBtn.Click += new System.EventHandler(this.RegiBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(456, 379);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(92, 37);
            this.SearchBtn.TabIndex = 110;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(652, 320);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(92, 39);
            this.UpdateBtn.TabIndex = 109;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(652, 379);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(92, 37);
            this.EditBtn.TabIndex = 108;
            this.EditBtn.Text = "編集";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // OrderingGridview
            // 
            this.OrderingGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderingGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderingGridview.Location = new System.Drawing.Point(22, 47);
            this.OrderingGridview.Name = "OrderingGridview";
            this.OrderingGridview.ReadOnly = true;
            this.OrderingGridview.RowTemplate.Height = 21;
            this.OrderingGridview.Size = new System.Drawing.Size(722, 246);
            this.OrderingGridview.TabIndex = 107;
            // 
            // ErrMsg2
            // 
            this.ErrMsg2.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg2.Location = new System.Drawing.Point(159, 308);
            this.ErrMsg2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ErrMsg2.Name = "ErrMsg2";
            this.ErrMsg2.Size = new System.Drawing.Size(210, 18);
            this.ErrMsg2.TabIndex = 106;
            this.ErrMsg2.Text = "エラーメッセージ";
            // 
            // AddressTextbox2
            // 
            this.AddressTextbox2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddressTextbox2.Location = new System.Drawing.Point(291, 395);
            this.AddressTextbox2.Name = "AddressTextbox2";
            this.AddressTextbox2.Size = new System.Drawing.Size(152, 19);
            this.AddressTextbox2.TabIndex = 98;
            // 
            // AddressLabel2
            // 
            this.AddressLabel2.AutoSize = true;
            this.AddressLabel2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddressLabel2.Location = new System.Drawing.Point(236, 398);
            this.AddressLabel2.Name = "AddressLabel2";
            this.AddressLabel2.Size = new System.Drawing.Size(41, 12);
            this.AddressLabel2.TabIndex = 105;
            this.AddressLabel2.Text = "住所2：";
            // 
            // PoscodeTextbox
            // 
            this.PoscodeTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PoscodeTextbox.Location = new System.Drawing.Point(95, 370);
            this.PoscodeTextbox.Name = "PoscodeTextbox";
            this.PoscodeTextbox.Size = new System.Drawing.Size(135, 19);
            this.PoscodeTextbox.TabIndex = 96;
            this.PoscodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoscodeTextbox_KeyPress);
            this.PoscodeTextbox.Leave += new System.EventHandler(this.PoscodeTextbox_Leave);
            // 
            // PoscodeLabel
            // 
            this.PoscodeLabel.AutoSize = true;
            this.PoscodeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PoscodeLabel.Location = new System.Drawing.Point(19, 373);
            this.PoscodeLabel.Name = "PoscodeLabel";
            this.PoscodeLabel.Size = new System.Drawing.Size(59, 12);
            this.PoscodeLabel.TabIndex = 104;
            this.PoscodeLabel.Text = "郵便番号：";
            // 
            // TelTextbox
            // 
            this.TelTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TelTextbox.Location = new System.Drawing.Point(308, 344);
            this.TelTextbox.Name = "TelTextbox";
            this.TelTextbox.Size = new System.Drawing.Size(135, 19);
            this.TelTextbox.TabIndex = 99;
            this.TelTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelTextbox_KeyPress);
            // 
            // AddressTextbox1
            // 
            this.AddressTextbox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddressTextbox1.Location = new System.Drawing.Point(74, 395);
            this.AddressTextbox1.Name = "AddressTextbox1";
            this.AddressTextbox1.Size = new System.Drawing.Size(156, 19);
            this.AddressTextbox1.TabIndex = 97;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameTextbox.Location = new System.Drawing.Point(95, 344);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(135, 19);
            this.NameTextbox.TabIndex = 95;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TelLabel.Location = new System.Drawing.Point(236, 347);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(59, 12);
            this.TelLabel.TabIndex = 103;
            this.TelLabel.Text = "電話番号：";
            // 
            // AddressLabel1
            // 
            this.AddressLabel1.AutoSize = true;
            this.AddressLabel1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddressLabel1.Location = new System.Drawing.Point(19, 398);
            this.AddressLabel1.Name = "AddressLabel1";
            this.AddressLabel1.Size = new System.Drawing.Size(41, 12);
            this.AddressLabel1.TabIndex = 102;
            this.AddressLabel1.Text = "住所1：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameLabel.Location = new System.Drawing.Point(19, 347);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 12);
            this.NameLabel.TabIndex = 101;
            this.NameLabel.Text = "入庫先名：";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.MemberLabel.Location = new System.Drawing.Point(17, 15);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(128, 29);
            this.MemberLabel.TabIndex = 100;
            this.MemberLabel.Text = "入庫先管理";
            // 
            // EditMsg
            // 
            this.EditMsg.AutoSize = true;
            this.EditMsg.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditMsg.ForeColor = System.Drawing.Color.Red;
            this.EditMsg.Location = new System.Drawing.Point(477, 329);
            this.EditMsg.Name = "EditMsg";
            this.EditMsg.Size = new System.Drawing.Size(46, 16);
            this.EditMsg.TabIndex = 114;
            this.EditMsg.Text = "label1";
            // 
            // OrderingRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditMsg);
            this.Controls.Add(this.AllBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegiBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.OrderingGridview);
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
            ((System.ComponentModel.ISupportInitialize)(this.OrderingGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RegiBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView OrderingGridview;
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
        private System.Windows.Forms.Label EditMsg;
    }
}
