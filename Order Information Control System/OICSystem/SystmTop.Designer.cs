namespace WindowsFormsApplication1
{
    partial class SystmTop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystmTop));
            this.navPanel = new System.Windows.Forms.Panel();
            this.EmpBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.MemberBtn = new System.Windows.Forms.Button();
            this.sanLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.salMgtBtn = new System.Windows.Forms.Button();
            this.goodsMgtBtn = new System.Windows.Forms.Button();
            this.ioMgtBtn = new System.Windows.Forms.Button();
            this.orderMgtBtn = new System.Windows.Forms.Button();
            this.ctrPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.EmpBtn);
            this.navPanel.Controls.Add(this.LogoutBtn);
            this.navPanel.Controls.Add(this.MemberBtn);
            this.navPanel.Controls.Add(this.sanLabel);
            this.navPanel.Controls.Add(this.memberNameLabel);
            this.navPanel.Controls.Add(this.timeLabel);
            this.navPanel.Controls.Add(this.dateLabel);
            this.navPanel.Controls.Add(this.salMgtBtn);
            this.navPanel.Controls.Add(this.goodsMgtBtn);
            this.navPanel.Controls.Add(this.ioMgtBtn);
            this.navPanel.Controls.Add(this.orderMgtBtn);
            this.navPanel.Location = new System.Drawing.Point(-1, -1);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(195, 520);
            this.navPanel.TabIndex = 54;
            // 
            // EmpBtn
            // 
            this.EmpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpBtn.Location = new System.Drawing.Point(-1, 282);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(195, 55);
            this.EmpBtn.TabIndex = 61;
            this.EmpBtn.TabStop = false;
            this.EmpBtn.Text = "従業員管理";
            this.EmpBtn.UseVisualStyleBackColor = false;
            this.EmpBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.BackgroundImage")));
            this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutBtn.Location = new System.Drawing.Point(152, 471);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(40, 40);
            this.LogoutBtn.TabIndex = 59;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MemberBtn
            // 
            this.MemberBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MemberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MemberBtn.Location = new System.Drawing.Point(-1, 228);
            this.MemberBtn.Name = "MemberBtn";
            this.MemberBtn.Size = new System.Drawing.Size(195, 55);
            this.MemberBtn.TabIndex = 60;
            this.MemberBtn.TabStop = false;
            this.MemberBtn.Text = "顧客管理";
            this.MemberBtn.UseVisualStyleBackColor = false;
            this.MemberBtn.Click += new System.EventHandler(this.MemberBtn_Click);
            // 
            // sanLabel
            // 
            this.sanLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sanLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sanLabel.Location = new System.Drawing.Point(106, 487);
            this.sanLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sanLabel.Name = "sanLabel";
            this.sanLabel.Size = new System.Drawing.Size(42, 24);
            this.sanLabel.TabIndex = 58;
            this.sanLabel.Text = "さん";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memberNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberNameLabel.Location = new System.Drawing.Point(3, 480);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(105, 31);
            this.memberNameLabel.TabIndex = 57;
            this.memberNameLabel.Text = "小佐 海斗";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(80, 40);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 24);
            this.timeLabel.TabIndex = 56;
            this.timeLabel.Text = "hh:mm:ss";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(16, 7);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(164, 41);
            this.dateLabel.TabIndex = 55;
            this.dateLabel.Text = "mm月dd日";
            // 
            // salMgtBtn
            // 
            this.salMgtBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salMgtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salMgtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salMgtBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salMgtBtn.Location = new System.Drawing.Point(-1, 336);
            this.salMgtBtn.Name = "salMgtBtn";
            this.salMgtBtn.Size = new System.Drawing.Size(195, 55);
            this.salMgtBtn.TabIndex = 54;
            this.salMgtBtn.TabStop = false;
            this.salMgtBtn.Text = "売上管理";
            this.salMgtBtn.UseVisualStyleBackColor = false;
            this.salMgtBtn.Click += new System.EventHandler(this.salMgtBtn_Click);
            // 
            // goodsMgtBtn
            // 
            this.goodsMgtBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsMgtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goodsMgtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goodsMgtBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goodsMgtBtn.Location = new System.Drawing.Point(-1, 174);
            this.goodsMgtBtn.Name = "goodsMgtBtn";
            this.goodsMgtBtn.Size = new System.Drawing.Size(195, 55);
            this.goodsMgtBtn.TabIndex = 53;
            this.goodsMgtBtn.TabStop = false;
            this.goodsMgtBtn.Text = "商品管理";
            this.goodsMgtBtn.UseVisualStyleBackColor = false;
            this.goodsMgtBtn.Click += new System.EventHandler(this.goodsMgtBtn_Click);
            // 
            // ioMgtBtn
            // 
            this.ioMgtBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ioMgtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ioMgtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ioMgtBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ioMgtBtn.Location = new System.Drawing.Point(-1, 120);
            this.ioMgtBtn.Name = "ioMgtBtn";
            this.ioMgtBtn.Size = new System.Drawing.Size(195, 55);
            this.ioMgtBtn.TabIndex = 52;
            this.ioMgtBtn.TabStop = false;
            this.ioMgtBtn.Text = "入出庫管理";
            this.ioMgtBtn.UseVisualStyleBackColor = false;
            this.ioMgtBtn.Click += new System.EventHandler(this.ioMgtBtn_Click);
            // 
            // orderMgtBtn
            // 
            this.orderMgtBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderMgtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderMgtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderMgtBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderMgtBtn.Location = new System.Drawing.Point(-1, 66);
            this.orderMgtBtn.Name = "orderMgtBtn";
            this.orderMgtBtn.Size = new System.Drawing.Size(195, 55);
            this.orderMgtBtn.TabIndex = 46;
            this.orderMgtBtn.TabStop = false;
            this.orderMgtBtn.Text = "注文管理";
            this.orderMgtBtn.UseVisualStyleBackColor = false;
            this.orderMgtBtn.Click += new System.EventHandler(this.orderMgtBtn_Click);
            // 
            // ctrPanel
            // 
            this.ctrPanel.Location = new System.Drawing.Point(194, -1);
            this.ctrPanel.Name = "ctrPanel";
            this.ctrPanel.Size = new System.Drawing.Size(760, 515);
            this.ctrPanel.TabIndex = 55;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SystmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 512);
            this.Controls.Add(this.ctrPanel);
            this.Controls.Add(this.navPanel);
            this.Name = "SystmTop";
            this.Text = "注文管理システム";
            this.Load += new System.EventHandler(this.SystmTop_Load);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label sanLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button salMgtBtn;
        private System.Windows.Forms.Button goodsMgtBtn;
        private System.Windows.Forms.Button ioMgtBtn;
        private System.Windows.Forms.Button orderMgtBtn;
        private System.Windows.Forms.Panel ctrPanel;
        private System.Windows.Forms.Button EmpBtn;
        private System.Windows.Forms.Button MemberBtn;
        private System.Windows.Forms.Timer timer1;
    }
}