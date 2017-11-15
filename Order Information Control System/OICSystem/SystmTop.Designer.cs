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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystmTop));
            this.navPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sanLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.salMgtBtn = new System.Windows.Forms.Button();
            this.goodsMgtBtn = new System.Windows.Forms.Button();
            this.ioMgtBtn = new System.Windows.Forms.Button();
            this.orderMgtBtn = new System.Windows.Forms.Button();
            this.ctrPanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.button2);
            this.navPanel.Controls.Add(this.logoutBtn);
            this.navPanel.Controls.Add(this.button1);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(-1, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 55);
            this.button2.TabIndex = 61;
            this.button2.Text = "従業員管理";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.BackgroundImage")));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutBtn.Location = new System.Drawing.Point(152, 471);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(40, 40);
            this.logoutBtn.TabIndex = 59;
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(-1, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 55);
            this.button1.TabIndex = 60;
            this.button1.Text = "顧客管理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // SystmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 512);
            this.Controls.Add(this.ctrPanel);
            this.Controls.Add(this.navPanel);
            this.Name = "SystmTop";
            this.Text = "注文管理システム";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label sanLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button salMgtBtn;
        private System.Windows.Forms.Button goodsMgtBtn;
        private System.Windows.Forms.Button ioMgtBtn;
        private System.Windows.Forms.Button orderMgtBtn;
        private System.Windows.Forms.Panel ctrPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}