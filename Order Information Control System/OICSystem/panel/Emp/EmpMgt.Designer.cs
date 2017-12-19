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
            this.EmpNameTextB = new System.Windows.Forms.TextBox();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.EmpMgtLbl = new System.Windows.Forms.Label();
            this.EmpdataGridView = new System.Windows.Forms.DataGridView();
            this.BirthdayLbl = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddressLbl2 = new System.Windows.Forms.Label();
            this.EmpAddress2TextB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoAuthorityRB = new System.Windows.Forms.RadioButton();
            this.YesAuthorityRB = new System.Windows.Forms.RadioButton();
            this.BirthdayTextB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorityLbl
            // 
            this.AuthorityLbl.AutoSize = true;
            this.AuthorityLbl.Location = new System.Drawing.Point(6, 13);
            this.AuthorityLbl.Name = "AuthorityLbl";
            this.AuthorityLbl.Size = new System.Drawing.Size(71, 12);
            this.AuthorityLbl.TabIndex = 2;
            this.AuthorityLbl.Text = "責任者権限：";
            // 
            // RegistrationB
            // 
            this.RegistrationB.Location = new System.Drawing.Point(607, 347);
            this.RegistrationB.Name = "RegistrationB";
            this.RegistrationB.Size = new System.Drawing.Size(150, 37);
            this.RegistrationB.TabIndex = 9;
            this.RegistrationB.Text = "登録";
            this.RegistrationB.UseVisualStyleBackColor = true;
            this.RegistrationB.Click += new System.EventHandler(this.RegistrationB_Click);
            // 
            // EmpNameTextB
            // 
            this.EmpNameTextB.Location = new System.Drawing.Point(84, 345);
            this.EmpNameTextB.Name = "EmpNameTextB";
            this.EmpNameTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpNameTextB.TabIndex = 0;
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Location = new System.Drawing.Point(43, 348);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(35, 12);
            this.EmpNameLbl.TabIndex = 11;
            this.EmpNameLbl.Text = "名前：";
            // 
            // EmpMgtLbl
            // 
            this.EmpMgtLbl.Location = new System.Drawing.Point(3, 0);
            this.EmpMgtLbl.Name = "EmpMgtLbl";
            this.EmpMgtLbl.Size = new System.Drawing.Size(151, 40);
            this.EmpMgtLbl.TabIndex = 18;
            this.EmpMgtLbl.Text = "従業員管理";
            this.EmpMgtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpdataGridView
            // 
            this.EmpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpdataGridView.Location = new System.Drawing.Point(3, 43);
            this.EmpdataGridView.Name = "EmpdataGridView";
            this.EmpdataGridView.ReadOnly = true;
            this.EmpdataGridView.RowTemplate.Height = 21;
            this.EmpdataGridView.Size = new System.Drawing.Size(754, 296);
            this.EmpdataGridView.TabIndex = 20;
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.AutoSize = true;
            this.BirthdayLbl.Location = new System.Drawing.Point(19, 398);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(59, 12);
            this.BirthdayLbl.TabIndex = 17;
            this.BirthdayLbl.Text = "生年月日：";
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Location = new System.Drawing.Point(4, 13);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(35, 12);
            this.SexLbl.TabIndex = 2;
            this.SexLbl.Text = "性別：";
            // 
            // ManRB
            // 
            this.ManRB.AutoSize = true;
            this.ManRB.Location = new System.Drawing.Point(39, 11);
            this.ManRB.Name = "ManRB";
            this.ManRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManRB.Size = new System.Drawing.Size(35, 16);
            this.ManRB.TabIndex = 0;
            this.ManRB.Text = "男";
            this.ManRB.UseVisualStyleBackColor = true;
            this.ManRB.CheckedChanged += new System.EventHandler(this.ManRB_CheckedChanged);
            // 
            // WomanRB
            // 
            this.WomanRB.AutoSize = true;
            this.WomanRB.Location = new System.Drawing.Point(80, 11);
            this.WomanRB.Name = "WomanRB";
            this.WomanRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WomanRB.Size = new System.Drawing.Size(35, 16);
            this.WomanRB.TabIndex = 1;
            this.WomanRB.Text = "女";
            this.WomanRB.UseVisualStyleBackColor = true;
            this.WomanRB.CheckedChanged += new System.EventHandler(this.WomanRB_CheckedChanged);
            // 
            // HuriganaLbl
            // 
            this.HuriganaLbl.AutoSize = true;
            this.HuriganaLbl.Location = new System.Drawing.Point(223, 348);
            this.HuriganaLbl.Name = "HuriganaLbl";
            this.HuriganaLbl.Size = new System.Drawing.Size(42, 12);
            this.HuriganaLbl.TabIndex = 12;
            this.HuriganaLbl.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // HuriganaTextB
            // 
            this.HuriganaTextB.Location = new System.Drawing.Point(271, 345);
            this.HuriganaTextB.Name = "HuriganaTextB";
            this.HuriganaTextB.Size = new System.Drawing.Size(117, 19);
            this.HuriganaTextB.TabIndex = 1;
            // 
            // PostalNamLbl
            // 
            this.PostalNamLbl.AutoSize = true;
            this.PostalNamLbl.Location = new System.Drawing.Point(393, 348);
            this.PostalNamLbl.Name = "PostalNamLbl";
            this.PostalNamLbl.Size = new System.Drawing.Size(59, 12);
            this.PostalNamLbl.TabIndex = 13;
            this.PostalNamLbl.Text = "郵便番号：";
            // 
            // EmpPostTextB
            // 
            this.EmpPostTextB.Location = new System.Drawing.Point(458, 345);
            this.EmpPostTextB.Name = "EmpPostTextB";
            this.EmpPostTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpPostTextB.TabIndex = 2;
            this.EmpPostTextB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmpPostTextB_KeyDown);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(37, 373);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(41, 12);
            this.AddressLbl.TabIndex = 14;
            this.AddressLbl.Text = "住所1：";
            // 
            // EmpAddressTextB
            // 
            this.EmpAddressTextB.Location = new System.Drawing.Point(84, 370);
            this.EmpAddressTextB.Name = "EmpAddressTextB";
            this.EmpAddressTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpAddressTextB.TabIndex = 3;
            // 
            // EmpTelLbl
            // 
            this.EmpTelLbl.AutoSize = true;
            this.EmpTelLbl.Location = new System.Drawing.Point(393, 373);
            this.EmpTelLbl.Name = "EmpTelLbl";
            this.EmpTelLbl.Size = new System.Drawing.Size(59, 12);
            this.EmpTelLbl.TabIndex = 16;
            this.EmpTelLbl.Text = "電話番号：";
            // 
            // EmpTelTextB
            // 
            this.EmpTelTextB.Location = new System.Drawing.Point(458, 370);
            this.EmpTelTextB.Name = "EmpTelTextB";
            this.EmpTelTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpTelTextB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SexLbl);
            this.groupBox1.Controls.Add(this.ManRB);
            this.groupBox1.Controls.Add(this.WomanRB);
            this.groupBox1.Location = new System.Drawing.Point(226, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 30);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressLbl2
            // 
            this.AddressLbl2.AutoSize = true;
            this.AddressLbl2.Location = new System.Drawing.Point(224, 373);
            this.AddressLbl2.Name = "AddressLbl2";
            this.AddressLbl2.Size = new System.Drawing.Size(41, 12);
            this.AddressLbl2.TabIndex = 15;
            this.AddressLbl2.Text = "住所2：";
            // 
            // EmpAddress2TextB
            // 
            this.EmpAddress2TextB.Location = new System.Drawing.Point(271, 370);
            this.EmpAddress2TextB.Name = "EmpAddress2TextB";
            this.EmpAddress2TextB.Size = new System.Drawing.Size(117, 19);
            this.EmpAddress2TextB.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoAuthorityRB);
            this.groupBox2.Controls.Add(this.YesAuthorityRB);
            this.groupBox2.Controls.Add(this.AuthorityLbl);
            this.groupBox2.Location = new System.Drawing.Point(375, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 30);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // NoAuthorityRB
            // 
            this.NoAuthorityRB.AutoSize = true;
            this.NoAuthorityRB.Location = new System.Drawing.Point(116, 11);
            this.NoAuthorityRB.Name = "NoAuthorityRB";
            this.NoAuthorityRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoAuthorityRB.Size = new System.Drawing.Size(35, 16);
            this.NoAuthorityRB.TabIndex = 1;
            this.NoAuthorityRB.TabStop = true;
            this.NoAuthorityRB.Text = "無";
            this.NoAuthorityRB.UseVisualStyleBackColor = true;
            this.NoAuthorityRB.CheckedChanged += new System.EventHandler(this.NoAuthorityRB_CheckedChanged);
            // 
            // YesAuthorityRB
            // 
            this.YesAuthorityRB.AutoSize = true;
            this.YesAuthorityRB.Location = new System.Drawing.Point(75, 11);
            this.YesAuthorityRB.Name = "YesAuthorityRB";
            this.YesAuthorityRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.YesAuthorityRB.Size = new System.Drawing.Size(35, 16);
            this.YesAuthorityRB.TabIndex = 0;
            this.YesAuthorityRB.Text = "有";
            this.YesAuthorityRB.UseVisualStyleBackColor = true;
            this.YesAuthorityRB.CheckedChanged += new System.EventHandler(this.YesAuthorityRB_CheckedChanged);
            // 
            // BirthdayTextB
            // 
            this.BirthdayTextB.Location = new System.Drawing.Point(84, 395);
            this.BirthdayTextB.Name = "BirthdayTextB";
            this.BirthdayTextB.Size = new System.Drawing.Size(117, 19);
            this.BirthdayTextB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(214, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 19;
            // 
            // EmpMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthdayTextB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EmpAddress2TextB);
            this.Controls.Add(this.AddressLbl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpTelTextB);
            this.Controls.Add(this.EmpTelLbl);
            this.Controls.Add(this.EmpAddressTextB);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.EmpPostTextB);
            this.Controls.Add(this.PostalNamLbl);
            this.Controls.Add(this.HuriganaTextB);
            this.Controls.Add(this.HuriganaLbl);
            this.Controls.Add(this.BirthdayLbl);
            this.Controls.Add(this.EmpdataGridView);
            this.Controls.Add(this.RegistrationB);
            this.Controls.Add(this.EmpNameTextB);
            this.Controls.Add(this.EmpNameLbl);
            this.Controls.Add(this.EmpMgtLbl);
            this.Name = "EmpMgt";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.EmpMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorityLbl;
        private System.Windows.Forms.Button RegistrationB;
        private System.Windows.Forms.TextBox EmpNameTextB;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Label EmpMgtLbl;
        private System.Windows.Forms.DataGridView EmpdataGridView;
        private System.Windows.Forms.Label BirthdayLbl;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AddressLbl2;
        private System.Windows.Forms.TextBox EmpAddress2TextB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoAuthorityRB;
        private System.Windows.Forms.RadioButton YesAuthorityRB;
        private System.Windows.Forms.MaskedTextBox BirthdayTextB;
        private System.Windows.Forms.Label label1;
    }
}
