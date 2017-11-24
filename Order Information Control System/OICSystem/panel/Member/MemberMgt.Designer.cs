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
            this.MemberTelTBox = new System.Windows.Forms.TextBox();
            this.MemberAddlessTBox = new System.Windows.Forms.TextBox();
            this.MemberNameTBox = new System.Windows.Forms.TextBox();
            this.MemberDisBtn = new System.Windows.Forms.Button();
            this.MemberTelLbl = new System.Windows.Forms.Label();
            this.MemberAddressLbl = new System.Windows.Forms.Label();
            this.MemberNameLbl = new System.Windows.Forms.Label();
            this.MemberMgrLbl = new System.Windows.Forms.Label();
            this.MemberPostNumTBox = new System.Windows.Forms.TextBox();
            this.MemberPostNumLbl = new System.Windows.Forms.Label();
            this.MemberDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberDisLbl = new System.Windows.Forms.Label();
            this.MemberClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberTelTBox
            // 
            this.MemberTelTBox.Location = new System.Drawing.Point(266, 424);
            this.MemberTelTBox.Name = "MemberTelTBox";
            this.MemberTelTBox.Size = new System.Drawing.Size(116, 19);
            this.MemberTelTBox.TabIndex = 57;
            // 
            // MemberAddlessTBox
            // 
            this.MemberAddlessTBox.Location = new System.Drawing.Point(84, 469);
            this.MemberAddlessTBox.Name = "MemberAddlessTBox";
            this.MemberAddlessTBox.Size = new System.Drawing.Size(293, 19);
            this.MemberAddlessTBox.TabIndex = 56;
            // 
            // MemberNameTBox
            // 
            this.MemberNameTBox.Location = new System.Drawing.Point(84, 424);
            this.MemberNameTBox.Name = "MemberNameTBox";
            this.MemberNameTBox.Size = new System.Drawing.Size(101, 19);
            this.MemberNameTBox.TabIndex = 55;
            // 
            // MemberDisBtn
            // 
            this.MemberDisBtn.Location = new System.Drawing.Point(593, 460);
            this.MemberDisBtn.Name = "MemberDisBtn";
            this.MemberDisBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberDisBtn.TabIndex = 54;
            this.MemberDisBtn.Text = "検索";
            this.MemberDisBtn.UseVisualStyleBackColor = true;
            this.MemberDisBtn.Click += new System.EventHandler(this.MemberDisBtn_Click);
            // 
            // MemberTelLbl
            // 
            this.MemberTelLbl.AutoSize = true;
            this.MemberTelLbl.Location = new System.Drawing.Point(201, 427);
            this.MemberTelLbl.Name = "MemberTelLbl";
            this.MemberTelLbl.Size = new System.Drawing.Size(59, 12);
            this.MemberTelLbl.TabIndex = 53;
            this.MemberTelLbl.Text = "電話番号：";
            // 
            // MemberAddressLbl
            // 
            this.MemberAddressLbl.AutoSize = true;
            this.MemberAddressLbl.Location = new System.Drawing.Point(43, 472);
            this.MemberAddressLbl.Name = "MemberAddressLbl";
            this.MemberAddressLbl.Size = new System.Drawing.Size(35, 12);
            this.MemberAddressLbl.TabIndex = 52;
            this.MemberAddressLbl.Text = "住所：";
            // 
            // MemberNameLbl
            // 
            this.MemberNameLbl.AutoSize = true;
            this.MemberNameLbl.Location = new System.Drawing.Point(43, 427);
            this.MemberNameLbl.Name = "MemberNameLbl";
            this.MemberNameLbl.Size = new System.Drawing.Size(35, 12);
            this.MemberNameLbl.TabIndex = 51;
            this.MemberNameLbl.Text = "名前：";
            // 
            // MemberMgrLbl
            // 
            this.MemberMgrLbl.Location = new System.Drawing.Point(19, 17);
            this.MemberMgrLbl.Name = "MemberMgrLbl";
            this.MemberMgrLbl.Size = new System.Drawing.Size(96, 36);
            this.MemberMgrLbl.TabIndex = 50;
            this.MemberMgrLbl.Text = "顧客管理";
            this.MemberMgrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberPostNumTBox
            // 
            this.MemberPostNumTBox.Location = new System.Drawing.Point(466, 424);
            this.MemberPostNumTBox.Name = "MemberPostNumTBox";
            this.MemberPostNumTBox.Size = new System.Drawing.Size(100, 19);
            this.MemberPostNumTBox.TabIndex = 60;
            // 
            // MemberPostNumLbl
            // 
            this.MemberPostNumLbl.AutoSize = true;
            this.MemberPostNumLbl.Location = new System.Drawing.Point(401, 427);
            this.MemberPostNumLbl.Name = "MemberPostNumLbl";
            this.MemberPostNumLbl.Size = new System.Drawing.Size(59, 12);
            this.MemberPostNumLbl.TabIndex = 61;
            this.MemberPostNumLbl.Text = "郵便番号：";
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
            this.MemberDataGridView.TabIndex = 62;
            // 
            // MemberDisLbl
            // 
            this.MemberDisLbl.AutoSize = true;
            this.MemberDisLbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberDisLbl.ForeColor = System.Drawing.Color.Red;
            this.MemberDisLbl.Location = new System.Drawing.Point(78, 372);
            this.MemberDisLbl.Name = "MemberDisLbl";
            this.MemberDisLbl.Size = new System.Drawing.Size(0, 14);
            this.MemberDisLbl.TabIndex = 63;
            // 
            // MemberClearBtn
            // 
            this.MemberClearBtn.Location = new System.Drawing.Point(593, 402);
            this.MemberClearBtn.Name = "MemberClearBtn";
            this.MemberClearBtn.Size = new System.Drawing.Size(151, 37);
            this.MemberClearBtn.TabIndex = 64;
            this.MemberClearBtn.Text = "クリア";
            this.MemberClearBtn.UseVisualStyleBackColor = true;
            this.MemberClearBtn.Click += new System.EventHandler(this.MemberClearBtn_Click);
            // 
            // MemberMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberClearBtn);
            this.Controls.Add(this.MemberDisLbl);
            this.Controls.Add(this.MemberDataGridView);
            this.Controls.Add(this.MemberPostNumLbl);
            this.Controls.Add(this.MemberPostNumTBox);
            this.Controls.Add(this.MemberTelTBox);
            this.Controls.Add(this.MemberAddlessTBox);
            this.Controls.Add(this.MemberNameTBox);
            this.Controls.Add(this.MemberDisBtn);
            this.Controls.Add(this.MemberTelLbl);
            this.Controls.Add(this.MemberAddressLbl);
            this.Controls.Add(this.MemberNameLbl);
            this.Controls.Add(this.MemberMgrLbl);
            this.Name = "MemberMgt";
            this.Size = new System.Drawing.Size(760, 515);
            this.Load += new System.EventHandler(this.MemberMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemberTelTBox;
        private System.Windows.Forms.TextBox MemberAddlessTBox;
        private System.Windows.Forms.TextBox MemberNameTBox;
        private System.Windows.Forms.Button MemberDisBtn;
        private System.Windows.Forms.Label MemberTelLbl;
        private System.Windows.Forms.Label MemberAddressLbl;
        private System.Windows.Forms.Label MemberNameLbl;
        private System.Windows.Forms.Label MemberMgrLbl;
        private System.Windows.Forms.TextBox MemberPostNumTBox;
        private System.Windows.Forms.Label MemberPostNumLbl;
        private System.Windows.Forms.DataGridView MemberDataGridView;
        private System.Windows.Forms.Label MemberDisLbl;
        private System.Windows.Forms.Button MemberClearBtn;
    }
}
