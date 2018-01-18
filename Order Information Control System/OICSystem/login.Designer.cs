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
            this.EmpTextbox.Location = new System.Drawing.Point(389, 291);
            this.EmpTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpTextbox.MaxLength = 6;
            this.EmpTextbox.Name = "EmpTextbox";
            this.EmpTextbox.Size = new System.Drawing.Size(496, 24);
            this.EmpTextbox.TabIndex = 1;
            this.EmpTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpTextbox_KeyPress);
            // 
            // PassTextbox
            // 
            this.PassTextbox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassTextbox.Location = new System.Drawing.Point(389, 376);
            this.PassTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassTextbox.MaxLength = 10;
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.PasswordChar = '*';
            this.PassTextbox.Size = new System.Drawing.Size(496, 24);
            this.PassTextbox.TabIndex = 2;
            this.PassTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTextbox_KeyDown);
            // 
            // EmpLabel
            // 
            this.EmpLabel.AutoSize = true;
            this.EmpLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmpLabel.Location = new System.Drawing.Point(384, 264);
            this.EmpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLabel.Name = "EmpLabel";
            this.EmpLabel.Size = new System.Drawing.Size(116, 24);
            this.EmpLabel.TabIndex = 2;
            this.EmpLabel.Text = "従業員ID：";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassLabel.Location = new System.Drawing.Point(383, 349);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(115, 24);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "パスワード：";
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(713, 490);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(173, 45);
            this.LoginBtn.TabIndex = 3;
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
            this.LoginTitle.Location = new System.Drawing.Point(76, 65);
            this.LoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(197, 56);
            this.LoginTitle.TabIndex = 6;
            this.LoginTitle.Text = "ログイン";
            this.LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(1041, 89);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(63, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "hh:mm";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(899, 94);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(87, 15);
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
            this.ErrMsg.Location = new System.Drawing.Point(388, 434);
            this.ErrMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(499, 24);
            this.ErrMsg.TabIndex = 9;
            this.ErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 702);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

