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
            this.EmpTextbox = new System.Windows.Forms.TextBox();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.EmpLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmpTextbox
            // 
            this.EmpTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmpTextbox.Location = new System.Drawing.Point(292, 233);
            this.EmpTextbox.Name = "EmpTextbox";
            this.EmpTextbox.Size = new System.Drawing.Size(373, 20);
            this.EmpTextbox.TabIndex = 0;
            this.EmpTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpTextbox_KeyPress);
            // 
            // PassTextbox
            // 
            this.PassTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassTextbox.Location = new System.Drawing.Point(292, 301);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.PasswordChar = '*';
            this.PassTextbox.Size = new System.Drawing.Size(373, 20);
            this.PassTextbox.TabIndex = 1;
            this.PassTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTextbox_KeyDown);
            // 
            // EmpLabel
            // 
            this.EmpLabel.AutoSize = true;
            this.EmpLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmpLabel.Location = new System.Drawing.Point(288, 211);
            this.EmpLabel.Name = "EmpLabel";
            this.EmpLabel.Size = new System.Drawing.Size(93, 19);
            this.EmpLabel.TabIndex = 2;
            this.EmpLabel.Text = "従業員ID：";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassLabel.Location = new System.Drawing.Point(287, 279);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(94, 19);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "パスワード：";
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(535, 392);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(130, 36);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "ログイン";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginTitle
            // 
            this.LoginTitle.BackColor = System.Drawing.SystemColors.Control;
            this.LoginTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginTitle.Location = new System.Drawing.Point(57, 52);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(148, 45);
            this.LoginTitle.TabIndex = 6;
            this.LoginTitle.Text = "ログイン";
            this.LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(781, 71);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(51, 16);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "hh:mm";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(674, 75);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(71, 12);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "yyyy/mm/dd";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ErrMsg
            // 
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrMsg.Location = new System.Drawing.Point(291, 347);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(374, 19);
            this.ErrMsg.TabIndex = 9;
            this.ErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 562);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.EmpLabel);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.EmpTextbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Login";
            this.Text = "注文管理システム";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpTextbox;
        private System.Windows.Forms.TextBox PassTextbox;
        private System.Windows.Forms.Label EmpLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ErrMsg;
    }
}

