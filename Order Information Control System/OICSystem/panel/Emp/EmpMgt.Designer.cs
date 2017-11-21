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
            this.ManB = new System.Windows.Forms.RadioButton();
            this.WomanB = new System.Windows.Forms.RadioButton();
            this.HuriganaLbl = new System.Windows.Forms.Label();
            this.HuriganaTextB = new System.Windows.Forms.TextBox();
            this.PostalNamLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressTextB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorityLbl
            // 
            this.AuthorityLbl.AutoSize = true;
            this.AuthorityLbl.Location = new System.Drawing.Point(626, 487);
            this.AuthorityLbl.Name = "AuthorityLbl";
            this.AuthorityLbl.Size = new System.Drawing.Size(71, 12);
            this.AuthorityLbl.TabIndex = 61;
            this.AuthorityLbl.Text = "責任者権限：";
            // 
            // RegistrationB
            // 
            this.RegistrationB.Location = new System.Drawing.Point(596, 392);
            this.RegistrationB.Name = "RegistrationB";
            this.RegistrationB.Size = new System.Drawing.Size(151, 37);
            this.RegistrationB.TabIndex = 59;
            this.RegistrationB.Text = "登録";
            this.RegistrationB.UseVisualStyleBackColor = true;
            this.RegistrationB.Click += new System.EventHandler(this.RegistrationB_Click);
            // 
            // EmpIDTextB
            // 
            this.EmpIDTextB.Location = new System.Drawing.Point(86, 414);
            this.EmpIDTextB.Name = "EmpIDTextB";
            this.EmpIDTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpIDTextB.TabIndex = 57;
            // 
            // EmpNameTextB
            // 
            this.EmpNameTextB.Location = new System.Drawing.Point(446, 414);
            this.EmpNameTextB.Name = "EmpNameTextB";
            this.EmpNameTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpNameTextB.TabIndex = 56;
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(596, 440);
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
            this.EmpIDLbl.Location = new System.Drawing.Point(22, 417);
            this.EmpIDLbl.Name = "EmpIDLbl";
            this.EmpIDLbl.Size = new System.Drawing.Size(58, 12);
            this.EmpIDLbl.TabIndex = 54;
            this.EmpIDLbl.Text = "従業員ID：";
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Location = new System.Drawing.Point(405, 417);
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
            this.EmpdataGridView.RowTemplate.Height = 21;
            this.EmpdataGridView.Size = new System.Drawing.Size(723, 317);
            this.EmpdataGridView.TabIndex = 62;
            // 
            // AuthorityCB
            // 
            this.AuthorityCB.AutoSize = true;
            this.AuthorityCB.Location = new System.Drawing.Point(703, 487);
            this.AuthorityCB.Name = "AuthorityCB";
            this.AuthorityCB.Size = new System.Drawing.Size(15, 14);
            this.AuthorityCB.TabIndex = 63;
            this.AuthorityCB.UseVisualStyleBackColor = true;
            // 
            // EmpPassLbl
            // 
            this.EmpPassLbl.AutoSize = true;
            this.EmpPassLbl.Location = new System.Drawing.Point(210, 417);
            this.EmpPassLbl.Name = "EmpPassLbl";
            this.EmpPassLbl.Size = new System.Drawing.Size(58, 12);
            this.EmpPassLbl.TabIndex = 64;
            this.EmpPassLbl.Text = "パスワード：";
            // 
            // EmpPassTextB
            // 
            this.EmpPassTextB.Location = new System.Drawing.Point(271, 414);
            this.EmpPassTextB.Name = "EmpPassTextB";
            this.EmpPassTextB.Size = new System.Drawing.Size(120, 19);
            this.EmpPassTextB.TabIndex = 65;
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.AutoSize = true;
            this.BirthdayLbl.Location = new System.Drawing.Point(206, 487);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(59, 12);
            this.BirthdayLbl.TabIndex = 66;
            this.BirthdayLbl.Text = "生年月日：";
            // 
            // BirthdayTextB
            // 
            this.BirthdayTextB.Location = new System.Drawing.Point(271, 482);
            this.BirthdayTextB.Name = "BirthdayTextB";
            this.BirthdayTextB.Size = new System.Drawing.Size(120, 19);
            this.BirthdayTextB.TabIndex = 67;
            // 
            // SexLbl
            // 
            this.SexLbl.AutoSize = true;
            this.SexLbl.Location = new System.Drawing.Point(455, 483);
            this.SexLbl.Name = "SexLbl";
            this.SexLbl.Size = new System.Drawing.Size(35, 12);
            this.SexLbl.TabIndex = 68;
            this.SexLbl.Text = "性別：";
            // 
            // ManB
            // 
            this.ManB.AutoSize = true;
            this.ManB.Location = new System.Drawing.Point(496, 481);
            this.ManB.Name = "ManB";
            this.ManB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManB.Size = new System.Drawing.Size(35, 16);
            this.ManB.TabIndex = 69;
            this.ManB.TabStop = true;
            this.ManB.Text = "男";
            this.ManB.UseVisualStyleBackColor = true;
            // 
            // WomanB
            // 
            this.WomanB.AutoSize = true;
            this.WomanB.Location = new System.Drawing.Point(537, 481);
            this.WomanB.Name = "WomanB";
            this.WomanB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WomanB.Size = new System.Drawing.Size(35, 16);
            this.WomanB.TabIndex = 70;
            this.WomanB.TabStop = true;
            this.WomanB.Text = "女";
            this.WomanB.UseVisualStyleBackColor = true;
            // 
            // HuriganaLbl
            // 
            this.HuriganaLbl.AutoSize = true;
            this.HuriganaLbl.Location = new System.Drawing.Point(38, 452);
            this.HuriganaLbl.Name = "HuriganaLbl";
            this.HuriganaLbl.Size = new System.Drawing.Size(42, 12);
            this.HuriganaLbl.TabIndex = 71;
            this.HuriganaLbl.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // HuriganaTextB
            // 
            this.HuriganaTextB.Location = new System.Drawing.Point(86, 449);
            this.HuriganaTextB.Name = "HuriganaTextB";
            this.HuriganaTextB.Size = new System.Drawing.Size(117, 19);
            this.HuriganaTextB.TabIndex = 72;
            // 
            // PostalNamLbl
            // 
            this.PostalNamLbl.AutoSize = true;
            this.PostalNamLbl.Location = new System.Drawing.Point(209, 452);
            this.PostalNamLbl.Name = "PostalNamLbl";
            this.PostalNamLbl.Size = new System.Drawing.Size(59, 12);
            this.PostalNamLbl.TabIndex = 73;
            this.PostalNamLbl.Text = "郵便番号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 19);
            this.textBox1.TabIndex = 74;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(405, 452);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(35, 12);
            this.AddressLbl.TabIndex = 75;
            this.AddressLbl.Text = "住所：";
            // 
            // AddressTextB
            // 
            this.AddressTextB.Location = new System.Drawing.Point(446, 449);
            this.AddressTextB.Name = "AddressTextB";
            this.AddressTextB.Size = new System.Drawing.Size(120, 19);
            this.AddressTextB.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 77;
            this.label1.Text = "電話番号：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 19);
            this.textBox2.TabIndex = 78;
            // 
            // EmpMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextB);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PostalNamLbl);
            this.Controls.Add(this.HuriganaTextB);
            this.Controls.Add(this.HuriganaLbl);
            this.Controls.Add(this.WomanB);
            this.Controls.Add(this.ManB);
            this.Controls.Add(this.SexLbl);
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
        private System.Windows.Forms.RadioButton ManB;
        private System.Windows.Forms.RadioButton WomanB;
        private System.Windows.Forms.Label HuriganaLbl;
        private System.Windows.Forms.TextBox HuriganaTextB;
        private System.Windows.Forms.Label PostalNamLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox AddressTextB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
