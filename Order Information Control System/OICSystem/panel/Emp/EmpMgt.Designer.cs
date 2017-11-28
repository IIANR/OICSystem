namespace WindowsFormsApplication1
{
    partial class EmpMgt
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
            this.AuthorityLbl = new System.Windows.Forms.Label();
            this.RegistrationB = new System.Windows.Forms.Button();
            this.EmpIDTextB = new System.Windows.Forms.TextBox();
            this.EmpNameTextB = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.EmpIDLbl = new System.Windows.Forms.Label();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.EmpMgtLbl = new System.Windows.Forms.Label();
            this.EmpdataGridView = new System.Windows.Forms.DataGridView();
            this.AuthorityCB = new System.Windows.Forms.CheckBox();
            this.EmpPassLbl = new System.Windows.Forms.Label();
            this.EmpPassTextB = new System.Windows.Forms.TextBox();
            this.BirthdayLbl = new System.Windows.Forms.Label();
            this.BirthdayTextB = new System.Windows.Forms.TextBox();
            this.SexLbl = new System.Windows.Forms.Label();
            this.ManRB = new System.Windows.Forms.RadioButton();
            this.WomanRB = new System.Windows.Forms.RadioButton();
            this.HuriganaLbl = new System.Windows.Forms.Label();
            this.HuriganaTextB = new System.Windows.Forms.TextBox();
            this.PostalNamLbl = new System.Windows.Forms.Label();
            this.EmpPostTextB = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.EmpAddressTextB = new System.Windows.Forms.TextBox();
            this.EmpTelLbl = new System.Windows.Forms.Label();
            this.EmpTelTextB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorityLbl
            // 
            this.AuthorityLbl.AutoSize = true;
            this.AuthorityLbl.Location = new System.Drawing.Point(595, 495);
            this.AuthorityLbl.Name = "AuthorityLbl";
            this.AuthorityLbl.Size = new System.Drawing.Size(71, 12);
            this.AuthorityLbl.TabIndex = 61;
            this.AuthorityLbl.Text = "責任者権限：";
            // 
            // RegistrationB
            // 
            this.RegistrationB.Location = new System.Drawing.Point(597, 357);
            this.RegistrationB.Name = "RegistrationB";
            this.RegistrationB.Size = new System.Drawing.Size(151, 37);
            this.RegistrationB.TabIndex = 59;
            this.RegistrationB.Text = "登録";
            this.RegistrationB.UseVisualStyleBackColor = true;
            this.RegistrationB.Click += new System.EventHandler(this.RegistrationB_Click);
            // 
            // EmpIDTextB
            // 
            this.EmpIDTextB.Location = new System.Drawing.Point(88, 402);
            this.EmpIDTextB.Name = "EmpIDTextB";
            this.EmpIDTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpIDTextB.TabIndex = 57;
            // 
            // EmpNameTextB
            // 
            this.EmpNameTextB.Location = new System.Drawing.Point(448, 402);
            this.EmpNameTextB.Name = "EmpNameTextB";
            this.EmpNameTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpNameTextB.TabIndex = 56;
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(597, 405);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(151, 37);
            this.SearchB.TabIndex = 55;
            this.SearchB.Text = "検索";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // EmpIDLbl
            // 
            this.EmpIDLbl.AutoSize = true;
            this.EmpIDLbl.Location = new System.Drawing.Point(24, 405);
            this.EmpIDLbl.Name = "EmpIDLbl";
            this.EmpIDLbl.Size = new System.Drawing.Size(58, 12);
            this.EmpIDLbl.TabIndex = 54;
            this.EmpIDLbl.Text = "従業員ID：";
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Location = new System.Drawing.Point(407, 405);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(35, 12);
            this.EmpNameLbl.TabIndex = 53;
            this.EmpNameLbl.Text = "名前：";
            // 
            // EmpMgtLbl
            // 
            this.EmpMgtLbl.Location = new System.Drawing.Point(9, 26);
            this.EmpMgtLbl.Name = "EmpMgtLbl";
            this.EmpMgtLbl.Size = new System.Drawing.Size(151, 40);
            this.EmpMgtLbl.TabIndex = 52;
            this.EmpMgtLbl.Text = "従業員管理";
            this.EmpMgtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpdataGridView
            // 
            this.EmpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpdataGridView.Location = new System.Drawing.Point(24, 69);
            this.EmpdataGridView.Name = "EmpdataGridView";
            this.EmpdataGridView.ReadOnly = true;
            this.EmpdataGridView.RowTemplate.Height = 21;
            this.EmpdataGridView.Size = new System.Drawing.Size(723, 277);
            this.EmpdataGridView.TabIndex = 62;
            // 
            // AuthorityCB
            // 
            this.AuthorityCB.AutoSize = true;
            this.AuthorityCB.Location = new System.Drawing.Point(672, 495);
            this.AuthorityCB.Name = "AuthorityCB";
            this.AuthorityCB.Size = new System.Drawing.Size(15, 14);
            this.AuthorityCB.TabIndex = 63;
            this.AuthorityCB.UseVisualStyleBackColor = true;
            // 
            // EmpPassLbl
            // 
            this.EmpPassLbl.AutoSize = true;
            this.EmpPassLbl.Location = new System.Drawing.Point(212, 405);
            this.EmpPassLbl.Name = "EmpPassLbl";
            this.EmpPassLbl.Size = new System.Drawing.Size(58, 12);
            this.EmpPassLbl.TabIndex = 64;
            this.EmpPassLbl.Text = "パスワード：";
            // 
            // EmpPassTextB
            // 
            this.EmpPassTextB.Location = new System.Drawing.Point(273, 402);
            this.EmpPassTextB.Name = "EmpPassTextB";
            this.EmpPassTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpPassTextB.TabIndex = 65;
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.AutoSize = true;
            this.BirthdayLbl.Location = new System.Drawing.Point(208, 475);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(59, 12);
            this.BirthdayLbl.TabIndex = 66;
            this.BirthdayLbl.Text = "生年月日：";
            // 
            // BirthdayTextB
            // 
            this.BirthdayTextB.Location = new System.Drawing.Point(273, 470);
            this.BirthdayTextB.Name = "BirthdayTextB";
            this.BirthdayTextB.Size = new System.Drawing.Size(120, 19);
            this.BirthdayTextB.TabIndex = 67;
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Location = new System.Drawing.Point(-2, 13);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(35, 12);
            this.SexLbl.TabIndex = 68;
            this.SexLbl.Text = "性別：";
            // 
            // ManRB
            // 
            this.ManRB.AutoSize = true;
            this.ManRB.Location = new System.Drawing.Point(39, 11);
            this.ManRB.Name = "ManRB";
            this.ManRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManRB.Size = new System.Drawing.Size(35, 16);
            this.ManRB.TabIndex = 69;
            this.ManRB.TabStop = true;
            this.ManRB.Text = "男";
            this.ManRB.UseVisualStyleBackColor = true;
            // 
            // WomanRB
            // 
            this.WomanRB.AutoSize = true;
            this.WomanRB.Location = new System.Drawing.Point(80, 11);
            this.WomanRB.Name = "WomanRB";
            this.WomanRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WomanRB.Size = new System.Drawing.Size(35, 16);
            this.WomanRB.TabIndex = 70;
            this.WomanRB.TabStop = true;
            this.WomanRB.Text = "女";
            this.WomanRB.UseVisualStyleBackColor = true;
            // 
            // HuriganaLbl
            // 
            this.HuriganaLbl.AutoSize = true;
            this.HuriganaLbl.Location = new System.Drawing.Point(40, 440);
            this.HuriganaLbl.Name = "HuriganaLbl";
            this.HuriganaLbl.Size = new System.Drawing.Size(42, 12);
            this.HuriganaLbl.TabIndex = 71;
            this.HuriganaLbl.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // HuriganaTextB
            // 
            this.HuriganaTextB.Location = new System.Drawing.Point(88, 437);
            this.HuriganaTextB.Name = "HuriganaTextB";
            this.HuriganaTextB.Size = new System.Drawing.Size(117, 19);
            this.HuriganaTextB.TabIndex = 72;
            // 
            // PostalNamLbl
            // 
            this.PostalNamLbl.AutoSize = true;
            this.PostalNamLbl.Location = new System.Drawing.Point(211, 440);
            this.PostalNamLbl.Name = "PostalNamLbl";
            this.PostalNamLbl.Size = new System.Drawing.Size(59, 12);
            this.PostalNamLbl.TabIndex = 73;
            this.PostalNamLbl.Text = "郵便番号：";
            // 
            // EmpPostTextB
            // 
            this.EmpPostTextB.Location = new System.Drawing.Point(273, 437);
            this.EmpPostTextB.Name = "EmpPostTextB";
            this.EmpPostTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpPostTextB.TabIndex = 74;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(407, 440);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(35, 12);
            this.AddressLbl.TabIndex = 75;
            this.AddressLbl.Text = "住所：";
            // 
            // EmpAddressTextB
            // 
            this.EmpAddressTextB.Location = new System.Drawing.Point(448, 437);
            this.EmpAddressTextB.Name = "EmpAddressTextB";
            this.EmpAddressTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpAddressTextB.TabIndex = 76;
            // 
            // EmpTelLbl
            // 
            this.EmpTelLbl.AutoSize = true;
            this.EmpTelLbl.Location = new System.Drawing.Point(23, 475);
            this.EmpTelLbl.Name = "EmpTelLbl";
            this.EmpTelLbl.Size = new System.Drawing.Size(59, 12);
            this.EmpTelLbl.TabIndex = 77;
            this.EmpTelLbl.Text = "電話番号：";
            // 
            // EmpTelTextB
            // 
            this.EmpTelTextB.Location = new System.Drawing.Point(88, 472);
            this.EmpTelTextB.Name = "EmpTelTextB";
            this.EmpTelTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpTelTextB.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SexLbl);
            this.groupBox1.Controls.Add(this.ManRB);
            this.groupBox1.Controls.Add(this.WomanRB);
            this.groupBox1.Location = new System.Drawing.Point(409, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 30);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 81;
            this.button1.Text = "クリア";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpTelTextB);
            this.Controls.Add(this.EmpTelLbl);
            this.Controls.Add(this.EmpAddressTextB);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.EmpPostTextB);
            this.Controls.Add(this.PostalNamLbl);
            this.Controls.Add(this.HuriganaTextB);
            this.Controls.Add(this.HuriganaLbl);
            this.Controls.Add(this.BirthdayTextB);
            this.Controls.Add(this.BirthdayLbl);
            this.Controls.Add(this.EmpPassTextB);
            this.Controls.Add(this.EmpPassLbl);
            this.Controls.Add(this.AuthorityCB);
            this.Controls.Add(this.EmpdataGridView);
            this.Controls.Add(this.AuthorityLbl);
            this.Controls.Add(this.RegistrationB);
            this.Controls.Add(this.EmpIDTextB);
            this.Controls.Add(this.EmpNameTextB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.EmpIDLbl);
            this.Controls.Add(this.EmpNameLbl);
            this.Controls.Add(this.EmpMgtLbl);
            this.Name = "EmpMgt";
            this.Size = new System.Drawing.Size(760, 515);
            this.Load += new System.EventHandler(this.EmpMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorityLbl;
        private System.Windows.Forms.Button RegistrationB;
        private System.Windows.Forms.TextBox EmpIDTextB;
        private System.Windows.Forms.TextBox EmpNameTextB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label EmpIDLbl;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Label EmpMgtLbl;
        private System.Windows.Forms.DataGridView EmpdataGridView;
        private System.Windows.Forms.CheckBox AuthorityCB;
        private System.Windows.Forms.Label EmpPassLbl;
        private System.Windows.Forms.TextBox EmpPassTextB;
        private System.Windows.Forms.Label BirthdayLbl;
        private System.Windows.Forms.TextBox BirthdayTextB;
        private System.Windows.Forms.Label SexLbl;
        private System.Windows.Forms.RadioButton ManRB;
        private System.Windows.Forms.RadioButton WomanRB;
        private System.Windows.Forms.Label HuriganaLbl;
        private System.Windows.Forms.TextBox HuriganaTextB;
        private System.Windows.Forms.Label PostalNamLbl;
        private System.Windows.Forms.TextBox EmpPostTextB;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox EmpAddressTextB;
        private System.Windows.Forms.Label EmpTelLbl;
        private System.Windows.Forms.TextBox EmpTelTextB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
