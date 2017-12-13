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
            this.OutputDataGrid = new System.Windows.Forms.DataGridView();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.OutputBtn = new System.Windows.Forms.Button();
            this.OrderidLabel = new System.Windows.Forms.Label();
            this.OrderidTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputDataGrid
            // 
            this.OutputDataGrid.AllowUserToAddRows = false;
            this.OutputDataGrid.AllowUserToDeleteRows = false;
            this.OutputDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDataGrid.Location = new System.Drawing.Point(3, 3);
            this.OutputDataGrid.Name = "OutputDataGrid";
            this.OutputDataGrid.ReadOnly = true;
            this.OutputDataGrid.RowTemplate.Height = 21;
            this.OutputDataGrid.Size = new System.Drawing.Size(754, 308);
            this.OutputDataGrid.TabIndex = 0;
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
            // OutputBtn
            // 
            this.OutputBtn.Location = new System.Drawing.Point(594, 341);
            this.OutputBtn.Name = "OutputBtn";
            this.OutputBtn.Size = new System.Drawing.Size(119, 40);
            this.OutputBtn.TabIndex = 7;
            this.OutputBtn.Text = "出庫完了";
            this.OutputBtn.UseVisualStyleBackColor = true;
            this.OutputBtn.Click += new System.EventHandler(this.OutputBtn_Click_1);
            // 
            // OrderidLabel
            // 
            this.OrderidLabel.AutoSize = true;
            this.OrderidLabel.Location = new System.Drawing.Point(41, 341);
            this.OrderidLabel.Name = "OrderidLabel";
            this.OrderidLabel.Size = new System.Drawing.Size(46, 12);
            this.OrderidLabel.TabIndex = 6;
            this.OrderidLabel.Text = "注文ID：";
            // 
            // OrderidTextbox
            // 
            this.OrderidTextbox.Location = new System.Drawing.Point(93, 338);
            this.OrderidTextbox.Name = "OrderidTextbox";
            this.OrderidTextbox.Size = new System.Drawing.Size(100, 19);
            this.OrderidTextbox.TabIndex = 5;
            // 
            // IOOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.OutputBtn);
            this.Controls.Add(this.OrderidLabel);
            this.Controls.Add(this.OrderidTextbox);
            this.Controls.Add(this.OutputDataGrid);
            this.Name = "IOOutput";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OutputDataGrid;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Button OutputBtn;
        private System.Windows.Forms.Label OrderidLabel;
        private System.Windows.Forms.TextBox OrderidTextbox;
    }
}
