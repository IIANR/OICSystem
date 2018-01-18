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
            this.label1 = new System.Windows.Forms.Label();
            this.BirthdayTextB = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoAuthorityRB = new System.Windows.Forms.RadioButton();
            this.YesAuthorityRB = new System.Windows.Forms.RadioButton();
            this.AuthorityLbl = new System.Windows.Forms.Label();
            this.EmpAddress2TextB = new System.Windows.Forms.TextBox();
            this.AddressLbl2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SexLbl = new System.Windows.Forms.Label();
            this.ManRB = new System.Windows.Forms.RadioButton();
            this.WomanRB = new System.Windows.Forms.RadioButton();
            this.EmpTelTextB = new System.Windows.Forms.TextBox();
            this.EmpTelLbl = new System.Windows.Forms.Label();
            this.EmpAddressTextB = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.EmpPostTextB = new System.Windows.Forms.TextBox();
            this.PostalNamLbl = new System.Windows.Forms.Label();
            this.HuriganaTextB = new System.Windows.Forms.TextBox();
            this.HuriganaLbl = new System.Windows.Forms.Label();
            this.BirthdayLbl = new System.Windows.Forms.Label();
            this.EmpdataGridView = new System.Windows.Forms.DataGridView();
            this.RegistrationB = new System.Windows.Forms.Button();
            this.EmpNameTextB = new System.Windows.Forms.TextBox();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 13;
            // 
            // BirthdayTextB
            // 
            this.BirthdayTextB.Location = new System.Drawing.Point(112, 495);
            this.BirthdayTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthdayTextB.Mask = "0000/00/00";
            this.BirthdayTextB.Name = "BirthdayTextB";
            this.BirthdayTextB.Size = new System.Drawing.Size(155, 22);
            this.BirthdayTextB.TabIndex = 7;
            this.BirthdayTextB.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoAuthorityRB);
            this.groupBox2.Controls.Add(this.YesAuthorityRB);
            this.groupBox2.Controls.Add(this.AuthorityLbl);
            this.groupBox2.Location = new System.Drawing.Point(500, 491);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(211, 38);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // NoAuthorityRB
            // 
            this.NoAuthorityRB.AutoSize = true;
            this.NoAuthorityRB.Location = new System.Drawing.Point(155, 14);
            this.NoAuthorityRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoAuthorityRB.Name = "NoAuthorityRB";
            this.NoAuthorityRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoAuthorityRB.Size = new System.Drawing.Size(43, 19);
            this.NoAuthorityRB.TabIndex = 1;
            this.NoAuthorityRB.TabStop = true;
            this.NoAuthorityRB.Text = "無";
            this.NoAuthorityRB.UseVisualStyleBackColor = true;
            this.NoAuthorityRB.CheckedChanged += new System.EventHandler(this.NoAuthorityRB_CheckedChanged_1);
            // 
            // YesAuthorityRB
            // 
            this.YesAuthorityRB.AutoSize = true;
            this.YesAuthorityRB.Location = new System.Drawing.Point(100, 14);
            this.YesAuthorityRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YesAuthorityRB.Name = "YesAuthorityRB";
            this.YesAuthorityRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.YesAuthorityRB.Size = new System.Drawing.Size(43, 19);
            this.YesAuthorityRB.TabIndex = 0;
            this.YesAuthorityRB.Text = "有";
            this.YesAuthorityRB.UseVisualStyleBackColor = true;
            this.YesAuthorityRB.CheckedChanged += new System.EventHandler(this.YesAuthorityRB_CheckedChanged_1);
            // 
            // AuthorityLbl
            // 
            this.AuthorityLbl.AutoSize = true;
            this.AuthorityLbl.Location = new System.Drawing.Point(8, 16);
            this.AuthorityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorityLbl.Name = "AuthorityLbl";
            this.AuthorityLbl.Size = new System.Drawing.Size(90, 15);
            this.AuthorityLbl.TabIndex = 100;
            this.AuthorityLbl.Text = "責任者権限：";
            // 
            // EmpAddress2TextB
            // 
            this.EmpAddress2TextB.Location = new System.Drawing.Point(361, 464);
            this.EmpAddress2TextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpAddress2TextB.MaxLength = 40;
            this.EmpAddress2TextB.Name = "EmpAddress2TextB";
            this.EmpAddress2TextB.Size = new System.Drawing.Size(155, 22);
            this.EmpAddress2TextB.TabIndex = 5;
            // 
            // AddressLbl2
            // 
            this.AddressLbl2.AutoSize = true;
            this.AddressLbl2.Location = new System.Drawing.Point(299, 468);
            this.AddressLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLbl2.Name = "AddressLbl2";
            this.AddressLbl2.Size = new System.Drawing.Size(53, 15);
            this.AddressLbl2.TabIndex = 18;
            this.AddressLbl2.Text = "住所2：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SexLbl);
            this.groupBox1.Controls.Add(this.ManRB);
            this.groupBox1.Controls.Add(this.WomanRB);
            this.groupBox1.Location = new System.Drawing.Point(301, 495);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(161, 38);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Location = new System.Drawing.Point(5, 16);
            this.SexLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(45, 15);
            this.SexLbl.TabIndex = 96;
            this.SexLbl.Text = "性別：";
            // 
            // ManRB
            // 
            this.ManRB.AutoSize = true;
            this.ManRB.Location = new System.Drawing.Point(52, 14);
            this.ManRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManRB.Name = "ManRB";
            this.ManRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManRB.Size = new System.Drawing.Size(43, 19);
            this.ManRB.TabIndex = 0;
            this.ManRB.Text = "男";
            this.ManRB.UseVisualStyleBackColor = true;
            this.ManRB.CheckedChanged += new System.EventHandler(this.ManRB_CheckedChanged_1);
            // 
            // WomanRB
            // 
            this.WomanRB.AutoSize = true;
            this.WomanRB.Location = new System.Drawing.Point(107, 14);
            this.WomanRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WomanRB.Name = "WomanRB";
            this.WomanRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WomanRB.Size = new System.Drawing.Size(43, 19);
            this.WomanRB.TabIndex = 1;
            this.WomanRB.Text = "女";
            this.WomanRB.UseVisualStyleBackColor = true;
            this.WomanRB.CheckedChanged += new System.EventHandler(this.WomanRB_CheckedChanged_1);
            // 
            // EmpTelTextB
            // 
            this.EmpTelTextB.Location = new System.Drawing.Point(611, 464);
            this.EmpTelTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpTelTextB.MaxLength = 11;
            this.EmpTelTextB.Name = "EmpTelTextB";
            this.EmpTelTextB.Size = new System.Drawing.Size(155, 22);
            this.EmpTelTextB.TabIndex = 6;
            // 
            // EmpTelLbl
            // 
            this.EmpTelLbl.AutoSize = true;
            this.EmpTelLbl.Location = new System.Drawing.Point(524, 468);
            this.EmpTelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpTelLbl.Name = "EmpTelLbl";
            this.EmpTelLbl.Size = new System.Drawing.Size(75, 15);
            this.EmpTelLbl.TabIndex = 19;
            this.EmpTelLbl.Text = "電話番号：";
            // 
            // EmpAddressTextB
            // 
            this.EmpAddressTextB.Location = new System.Drawing.Point(112, 464);
            this.EmpAddressTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpAddressTextB.MaxLength = 40;
            this.EmpAddressTextB.Name = "EmpAddressTextB";
            this.EmpAddressTextB.Size = new System.Drawing.Size(155, 22);
            this.EmpAddressTextB.TabIndex = 4;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(49, 468);
            this.AddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(53, 15);
            this.AddressLbl.TabIndex = 17;
            this.AddressLbl.Text = "住所1：";
            // 
            // EmpPostTextB
            // 
            this.EmpPostTextB.Location = new System.Drawing.Point(611, 432);
            this.EmpPostTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpPostTextB.MaxLength = 7;
            this.EmpPostTextB.Name = "EmpPostTextB";
            this.EmpPostTextB.Size = new System.Drawing.Size(155, 22);
            this.EmpPostTextB.TabIndex = 3;
            this.EmpPostTextB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpPostTextB_KeyPress);
            this.EmpPostTextB.Leave += new System.EventHandler(this.EmpPostTextB_Leave);
            // 
            // PostalNamLbl
            // 
            this.PostalNamLbl.AutoSize = true;
            this.PostalNamLbl.Location = new System.Drawing.Point(524, 436);
            this.PostalNamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostalNamLbl.Name = "PostalNamLbl";
            this.PostalNamLbl.Size = new System.Drawing.Size(75, 15);
            this.PostalNamLbl.TabIndex = 16;
            this.PostalNamLbl.Text = "郵便番号：";
            // 
            // HuriganaTextB
            // 
            this.HuriganaTextB.Location = new System.Drawing.Point(361, 432);
            this.HuriganaTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HuriganaTextB.MaxLength = 30;
            this.HuriganaTextB.Name = "HuriganaTextB";
            this.HuriganaTextB.Size = new System.Drawing.Size(155, 22);
            this.HuriganaTextB.TabIndex = 2;
            // 
            // HuriganaLbl
            // 
            this.HuriganaLbl.AutoSize = true;
            this.HuriganaLbl.Location = new System.Drawing.Point(297, 436);
            this.HuriganaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HuriganaLbl.Name = "HuriganaLbl";
            this.HuriganaLbl.Size = new System.Drawing.Size(53, 15);
            this.HuriganaLbl.TabIndex = 15;
            this.HuriganaLbl.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.AutoSize = true;
            this.BirthdayLbl.Location = new System.Drawing.Point(25, 499);
            this.BirthdayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(75, 15);
            this.BirthdayLbl.TabIndex = 20;
            this.BirthdayLbl.Text = "生年月日：";
            // 
            // EmpdataGridView
            // 
            this.EmpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpdataGridView.Location = new System.Drawing.Point(4, 55);
            this.EmpdataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpdataGridView.Name = "EmpdataGridView";
            this.EmpdataGridView.ReadOnly = true;
            this.EmpdataGridView.RowTemplate.Height = 21;
            this.EmpdataGridView.Size = new System.Drawing.Size(1005, 370);
            this.EmpdataGridView.TabIndex = 20;
            this.EmpdataGridView.TabStop = false;
            // 
            // RegistrationB
            // 
            this.RegistrationB.Location = new System.Drawing.Point(809, 435);
            this.RegistrationB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrationB.Name = "RegistrationB";
            this.RegistrationB.Size = new System.Drawing.Size(200, 46);
            this.RegistrationB.TabIndex = 8;
            this.RegistrationB.Text = "登録";
            this.RegistrationB.UseVisualStyleBackColor = true;
            this.RegistrationB.Click += new System.EventHandler(this.RegistrationB_Click);
            // 
            // EmpNameTextB
            // 
            this.EmpNameTextB.Location = new System.Drawing.Point(112, 432);
            this.EmpNameTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpNameTextB.MaxLength = 20;
            this.EmpNameTextB.Name = "EmpNameTextB";
            this.EmpNameTextB.Size = new System.Drawing.Size(155, 22);
            this.EmpNameTextB.TabIndex = 1;
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Location = new System.Drawing.Point(57, 436);
            this.EmpNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(45, 15);
            this.EmpNameLbl.TabIndex = 14;
            this.EmpNameLbl.Text = "名前：";
            // 
            // EmpMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmpMgt";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.EmpMgt_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox BirthdayTextB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoAuthorityRB;
        private System.Windows.Forms.RadioButton YesAuthorityRB;
        private System.Windows.Forms.Label AuthorityLbl;
        private System.Windows.Forms.TextBox EmpAddress2TextB;
        private System.Windows.Forms.Label AddressLbl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SexLbl;
        private System.Windows.Forms.RadioButton ManRB;
        private System.Windows.Forms.RadioButton WomanRB;
        private System.Windows.Forms.TextBox EmpTelTextB;
        private System.Windows.Forms.Label EmpTelLbl;
        private System.Windows.Forms.TextBox EmpAddressTextB;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox EmpPostTextB;
        private System.Windows.Forms.Label PostalNamLbl;
        private System.Windows.Forms.TextBox HuriganaTextB;
        private System.Windows.Forms.Label HuriganaLbl;
        private System.Windows.Forms.Label BirthdayLbl;
        private System.Windows.Forms.DataGridView EmpdataGridView;
        private System.Windows.Forms.Button RegistrationB;
        private System.Windows.Forms.TextBox EmpNameTextB;
        private System.Windows.Forms.Label EmpNameLbl;
    }
}
