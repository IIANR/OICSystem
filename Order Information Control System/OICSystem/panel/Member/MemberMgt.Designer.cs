namespace WindowsFormsApplication1
{
    partial class MemberMgt
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
            this.MemberNameTBox = new System.Windows.Forms.TextBox();
            this.MemberDisBtn = new System.Windows.Forms.Button();
            this.MemberNameLbl = new System.Windows.Forms.Label();
            this.MemberMgrLbl = new System.Windows.Forms.Label();
            this.MemberDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberDisLbl = new System.Windows.Forms.Label();
            this.MemberClearBtn = new System.Windows.Forms.Button();
            this.MemberUpdateBtn = new System.Windows.Forms.Button();
            this.MemberEditBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberNameTBox
            // 
            this.MemberNameTBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.MemberNameTBox.Location = new System.Drawing.Point(127, 424);
            this.MemberNameTBox.Name = "MemberNameTBox";
            this.MemberNameTBox.Size = new System.Drawing.Size(149, 19);
            this.MemberNameTBox.TabIndex = 1;
            // 
            // MemberDisBtn
            // 
            this.MemberDisBtn.Location = new System.Drawing.Point(436, 372);
            this.MemberDisBtn.Name = "MemberDisBtn";
            this.MemberDisBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberDisBtn.TabIndex = 2;
            this.MemberDisBtn.Text = "検索";
            this.MemberDisBtn.UseVisualStyleBackColor = true;
            this.MemberDisBtn.Click += new System.EventHandler(this.MemberDisBtn_Click);
            // 
            // MemberNameLbl
            // 
            this.MemberNameLbl.AutoSize = true;
            this.MemberNameLbl.Location = new System.Drawing.Point(81, 426);
            this.MemberNameLbl.Name = "MemberNameLbl";
            this.MemberNameLbl.Size = new System.Drawing.Size(42, 12);
            this.MemberNameLbl.TabIndex = 51;
            this.MemberNameLbl.Text = "ﾌﾘｶﾞﾅ：";
            // 
            // MemberMgrLbl
            // 
            this.MemberMgrLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberMgrLbl.Location = new System.Drawing.Point(19, 17);
            this.MemberMgrLbl.Name = "MemberMgrLbl";
            this.MemberMgrLbl.Size = new System.Drawing.Size(96, 36);
            this.MemberMgrLbl.TabIndex = 50;
            this.MemberMgrLbl.Text = "顧客管理";
            this.MemberMgrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberDataGridView
            // 
            this.MemberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDataGridView.Location = new System.Drawing.Point(21, 65);
            this.MemberDataGridView.Name = "MemberDataGridView";
            this.MemberDataGridView.ReadOnly = true;
            this.MemberDataGridView.RowTemplate.Height = 21;
            this.MemberDataGridView.Size = new System.Drawing.Size(723, 286);
            this.MemberDataGridView.TabIndex = 6;
            // 
            // MemberDisLbl
            // 
            this.MemberDisLbl.AutoSize = true;
            this.MemberDisLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberDisLbl.ForeColor = System.Drawing.Color.Red;
            this.MemberDisLbl.Location = new System.Drawing.Point(42, 380);
            this.MemberDisLbl.Name = "MemberDisLbl";
            this.MemberDisLbl.Size = new System.Drawing.Size(0, 16);
            this.MemberDisLbl.TabIndex = 63;
            // 
            // MemberClearBtn
            // 
            this.MemberClearBtn.Location = new System.Drawing.Point(436, 415);
            this.MemberClearBtn.Name = "MemberClearBtn";
            this.MemberClearBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberClearBtn.TabIndex = 3;
            this.MemberClearBtn.Text = "クリア";
            this.MemberClearBtn.UseVisualStyleBackColor = true;
            this.MemberClearBtn.Click += new System.EventHandler(this.MemberClearBtn_Click);
            // 
            // MemberUpdateBtn
            // 
            this.MemberUpdateBtn.Location = new System.Drawing.Point(593, 415);
            this.MemberUpdateBtn.Name = "MemberUpdateBtn";
            this.MemberUpdateBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberUpdateBtn.TabIndex = 5;
            this.MemberUpdateBtn.Text = "更新";
            this.MemberUpdateBtn.UseVisualStyleBackColor = true;
            this.MemberUpdateBtn.Click += new System.EventHandler(this.MemberUpdateBtn_Click);
            // 
            // MemberEditBtn
            // 
            this.MemberEditBtn.Location = new System.Drawing.Point(593, 372);
            this.MemberEditBtn.Name = "MemberEditBtn";
            this.MemberEditBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberEditBtn.TabIndex = 4;
            this.MemberEditBtn.Text = "編集";
            this.MemberEditBtn.UseVisualStyleBackColor = true;
            this.MemberEditBtn.Click += new System.EventHandler(this.MemberEditBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(622, 17);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(122, 36);
            this.PrintBtn.TabIndex = 64;
            this.PrintBtn.Text = "印刷";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // MemberMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.MemberEditBtn);
            this.Controls.Add(this.MemberUpdateBtn);
            this.Controls.Add(this.MemberClearBtn);
            this.Controls.Add(this.MemberDisLbl);
            this.Controls.Add(this.MemberDataGridView);
            this.Controls.Add(this.MemberNameTBox);
            this.Controls.Add(this.MemberDisBtn);
            this.Controls.Add(this.MemberNameLbl);
            this.Controls.Add(this.MemberMgrLbl);
            this.Name = "MemberMgt";
            this.Size = new System.Drawing.Size(760, 489);
            this.Load += new System.EventHandler(this.MemberMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemberNameTBox;
        private System.Windows.Forms.Button MemberDisBtn;
        private System.Windows.Forms.Label MemberNameLbl;
        private System.Windows.Forms.Label MemberMgrLbl;
        private System.Windows.Forms.DataGridView MemberDataGridView;
        private System.Windows.Forms.Label MemberDisLbl;
        private System.Windows.Forms.Button MemberClearBtn;
        private System.Windows.Forms.Button MemberUpdateBtn;
        private System.Windows.Forms.Button MemberEditBtn;
        private System.Windows.Forms.Button PrintBtn;
    }
}
