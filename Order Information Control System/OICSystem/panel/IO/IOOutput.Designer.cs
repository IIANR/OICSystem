namespace WindowsFormsApplication1.panel.IO
{
    partial class IOOutput
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
            this.InputNumTextbox = new System.Windows.Forms.TextBox();
            this.InputNumLabel = new System.Windows.Forms.Label();
            this.OutputRadioBtn = new System.Windows.Forms.RadioButton();
            this.InputRadioBtn = new System.Windows.Forms.RadioButton();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.CompBtn = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputNumTextbox
            // 
            this.InputNumTextbox.Location = new System.Drawing.Point(393, 464);
            this.InputNumTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputNumTextbox.MaxLength = 3;
            this.InputNumTextbox.Name = "InputNumTextbox";
            this.InputNumTextbox.Size = new System.Drawing.Size(132, 22);
            this.InputNumTextbox.TabIndex = 2;
            this.InputNumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumTextbox_KeyPress);
            // 
            // InputNumLabel
            // 
            this.InputNumLabel.AutoSize = true;
            this.InputNumLabel.Location = new System.Drawing.Point(307, 469);
            this.InputNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputNumLabel.Name = "InputNumLabel";
            this.InputNumLabel.Size = new System.Drawing.Size(75, 15);
            this.InputNumLabel.TabIndex = 20;
            this.InputNumLabel.Text = "入庫数量：";
            // 
            // OutputRadioBtn
            // 
            this.OutputRadioBtn.AutoSize = true;
            this.OutputRadioBtn.Location = new System.Drawing.Point(152, 421);
            this.OutputRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputRadioBtn.Name = "OutputRadioBtn";
            this.OutputRadioBtn.Size = new System.Drawing.Size(58, 19);
            this.OutputRadioBtn.TabIndex = 19;
            this.OutputRadioBtn.Text = "出庫";
            this.OutputRadioBtn.UseVisualStyleBackColor = true;
            this.OutputRadioBtn.CheckedChanged += new System.EventHandler(this.OutputRadioBtn_CheckedChanged);
            // 
            // InputRadioBtn
            // 
            this.InputRadioBtn.AutoSize = true;
            this.InputRadioBtn.Checked = true;
            this.InputRadioBtn.Location = new System.Drawing.Point(57, 421);
            this.InputRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputRadioBtn.Name = "InputRadioBtn";
            this.InputRadioBtn.Size = new System.Drawing.Size(58, 19);
            this.InputRadioBtn.TabIndex = 18;
            this.InputRadioBtn.TabStop = true;
            this.InputRadioBtn.Text = "入庫";
            this.InputRadioBtn.UseVisualStyleBackColor = true;
            this.InputRadioBtn.CheckedChanged += new System.EventHandler(this.InputRadioBtn_CheckedChanged);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(121, 496);
            this.ErrMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(43, 15);
            this.ErrMsg.TabIndex = 17;
            this.ErrMsg.Text = "label2";
            // 
            // CompBtn
            // 
            this.CompBtn.Location = new System.Drawing.Point(792, 450);
            this.CompBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompBtn.Name = "CompBtn";
            this.CompBtn.Size = new System.Drawing.Size(159, 50);
            this.CompBtn.TabIndex = 3;
            this.CompBtn.Text = "入庫完了";
            this.CompBtn.UseVisualStyleBackColor = true;
            this.CompBtn.Click += new System.EventHandler(this.CompBtn_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(55, 468);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(59, 15);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "発注ID：";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(124, 464);
            this.IdTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdTextbox.MaxLength = 5;
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(132, 22);
            this.IdTextbox.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(4, 28);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 21;
            this.DataGrid.Size = new System.Drawing.Size(1005, 385);
            this.DataGrid.TabIndex = 13;
            this.DataGrid.TabStop = false;
            // 
            // IOOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputNumTextbox);
            this.Controls.Add(this.InputNumLabel);
            this.Controls.Add(this.OutputRadioBtn);
            this.Controls.Add(this.InputRadioBtn);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.CompBtn);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.DataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IOOutput";
            this.Size = new System.Drawing.Size(1013, 538);
            this.Load += new System.EventHandler(this.IOOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumTextbox;
        private System.Windows.Forms.Label InputNumLabel;
        private System.Windows.Forms.RadioButton OutputRadioBtn;
        private System.Windows.Forms.RadioButton InputRadioBtn;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Button CompBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        public System.Windows.Forms.TextBox IdTextbox;
    }
}
