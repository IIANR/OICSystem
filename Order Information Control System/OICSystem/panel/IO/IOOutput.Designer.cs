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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.CompBtn = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.InputRadioBtn = new System.Windows.Forms.RadioButton();
            this.OutputRadioBtn = new System.Windows.Forms.RadioButton();
            this.InputNumLabel = new System.Windows.Forms.Label();
            this.InputNumTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(3, 3);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 21;
            this.DataGrid.Size = new System.Drawing.Size(754, 308);
            this.DataGrid.TabIndex = 0;
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(91, 378);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(35, 12);
            this.ErrMsg.TabIndex = 8;
            this.ErrMsg.Text = "label2";
            // 
            // CompBtn
            // 
            this.CompBtn.Location = new System.Drawing.Point(594, 341);
            this.CompBtn.Name = "CompBtn";
            this.CompBtn.Size = new System.Drawing.Size(119, 40);
            this.CompBtn.TabIndex = 7;
            this.CompBtn.Text = "入庫完了";
            this.CompBtn.UseVisualStyleBackColor = true;
            this.CompBtn.Click += new System.EventHandler(this.CompBtn_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(41, 355);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(46, 12);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "発注ID：";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(93, 352);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(100, 19);
            this.IdTextbox.TabIndex = 5;
            // 
            // InputRadioBtn
            // 
            this.InputRadioBtn.AutoSize = true;
            this.InputRadioBtn.Checked = true;
            this.InputRadioBtn.Location = new System.Drawing.Point(43, 318);
            this.InputRadioBtn.Name = "InputRadioBtn";
            this.InputRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.InputRadioBtn.TabIndex = 9;
            this.InputRadioBtn.TabStop = true;
            this.InputRadioBtn.Text = "入庫";
            this.InputRadioBtn.UseVisualStyleBackColor = true;
            this.InputRadioBtn.CheckedChanged += new System.EventHandler(this.InputRadioBtn_CheckedChanged);
            // 
            // OutputRadioBtn
            // 
            this.OutputRadioBtn.AutoSize = true;
            this.OutputRadioBtn.Location = new System.Drawing.Point(114, 318);
            this.OutputRadioBtn.Name = "OutputRadioBtn";
            this.OutputRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.OutputRadioBtn.TabIndex = 10;
            this.OutputRadioBtn.Text = "出庫";
            this.OutputRadioBtn.UseVisualStyleBackColor = true;
            this.OutputRadioBtn.CheckedChanged += new System.EventHandler(this.OutputRadioBtn_CheckedChanged);
            // 
            // InputNumLabel
            // 
            this.InputNumLabel.AutoSize = true;
            this.InputNumLabel.Location = new System.Drawing.Point(230, 356);
            this.InputNumLabel.Name = "InputNumLabel";
            this.InputNumLabel.Size = new System.Drawing.Size(59, 12);
            this.InputNumLabel.TabIndex = 11;
            this.InputNumLabel.Text = "入庫数量：";
            // 
            // InputNumTextbox
            // 
            this.InputNumTextbox.Location = new System.Drawing.Point(295, 352);
            this.InputNumTextbox.Name = "InputNumTextbox";
            this.InputNumTextbox.Size = new System.Drawing.Size(100, 19);
            this.InputNumTextbox.TabIndex = 12;
            // 
            // IOOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.InputNumTextbox);
            this.Controls.Add(this.InputNumLabel);
            this.Controls.Add(this.OutputRadioBtn);
            this.Controls.Add(this.InputRadioBtn);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.CompBtn);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.DataGrid);
            this.Name = "IOOutput";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Button CompBtn;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.RadioButton InputRadioBtn;
        private System.Windows.Forms.RadioButton OutputRadioBtn;
        private System.Windows.Forms.Label InputNumLabel;
        private System.Windows.Forms.TextBox InputNumTextbox;
    }
}
