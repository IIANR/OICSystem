namespace WindowsFormsApplication1
{
    partial class Login
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ErrMsg = new System.Windows.Forms.Label();
            this.EmpTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PassTextbox = new MetroFramework.Controls.MetroTextBox();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(228, 41);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 17);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "hh:mm";
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Location = new System.Drawing.Point(191, 26);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 17);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "yyyy/mm/dd";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ErrMsg
            // 
            this.ErrMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrMsg.Location = new System.Drawing.Point(26, 277);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(248, 27);
            this.ErrMsg.TabIndex = 9;
            this.ErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrMsg.Click += new System.EventHandler(this.ErrMsg_Click);
            // 
            // EmpTextbox
            // 
            this.EmpTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.EmpTextbox.CustomButton.Image = null;
            this.EmpTextbox.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.EmpTextbox.CustomButton.Name = "";
            this.EmpTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmpTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmpTextbox.CustomButton.TabIndex = 1;
            this.EmpTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmpTextbox.CustomButton.UseSelectable = true;
            this.EmpTextbox.CustomButton.Visible = false;
            this.EmpTextbox.DisplayIcon = true;
            this.EmpTextbox.Icon = ((System.Drawing.Image)(resources.GetObject("EmpTextbox.Icon")));
            this.EmpTextbox.Lines = new string[0];
            this.EmpTextbox.Location = new System.Drawing.Point(26, 157);
            this.EmpTextbox.MaxLength = 22;
            this.EmpTextbox.Multiline = true;
            this.EmpTextbox.Name = "EmpTextbox";
            this.EmpTextbox.PasswordChar = '\0';
            this.EmpTextbox.PromptText = "従業員ID";
            this.EmpTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmpTextbox.SelectedText = "";
            this.EmpTextbox.SelectionLength = 0;
            this.EmpTextbox.SelectionStart = 0;
            this.EmpTextbox.ShortcutsEnabled = true;
            this.EmpTextbox.ShowClearButton = true;
            this.EmpTextbox.Size = new System.Drawing.Size(251, 31);
            this.EmpTextbox.TabIndex = 10;
            this.EmpTextbox.UseSelectable = true;
            this.EmpTextbox.WaterMark = "従業員ID";
            this.EmpTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpTextbox.WaterMarkFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PassTextbox
            // 
            this.PassTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.PassTextbox.CustomButton.Image = null;
            this.PassTextbox.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.PassTextbox.CustomButton.Name = "";
            this.PassTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextbox.CustomButton.TabIndex = 1;
            this.PassTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextbox.CustomButton.UseSelectable = true;
            this.PassTextbox.CustomButton.Visible = false;
            this.PassTextbox.Lines = new string[0];
            this.PassTextbox.Location = new System.Drawing.Point(26, 239);
            this.PassTextbox.MaxLength = 32767;
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.PasswordChar = '*';
            this.PassTextbox.PromptText = "パスワード";
            this.PassTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextbox.SelectedText = "";
            this.PassTextbox.SelectionLength = 0;
            this.PassTextbox.SelectionStart = 0;
            this.PassTextbox.ShortcutsEnabled = true;
            this.PassTextbox.Size = new System.Drawing.Size(251, 23);
            this.PassTextbox.TabIndex = 11;
            this.PassTextbox.UseSelectable = true;
            this.PassTextbox.WaterMark = "パスワード";
            this.PassTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTextbox.WaterMarkFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(26, 307);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(251, 42);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "ログイン";
            this.LoginBtn.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.EmpTextbox);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(23, 85, 23, 28);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ErrMsg;
        private MetroFramework.Controls.MetroTextBox EmpTextbox;
        private MetroFramework.Controls.MetroTextBox PassTextbox;
        private MetroFramework.Controls.MetroButton LoginBtn;
    }
}

