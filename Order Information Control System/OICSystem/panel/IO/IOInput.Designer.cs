namespace WindowsFormsApplication1.panel.IO
{
    partial class IOInput
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
            this.InputDataGrid1 = new System.Windows.Forms.DataGridView();
            this.InputRBtn = new System.Windows.Forms.RadioButton();
            this.OrderingRBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputDataGrid1
            // 
            this.InputDataGrid1.AllowUserToAddRows = false;
            this.InputDataGrid1.AllowUserToDeleteRows = false;
            this.InputDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataGrid1.Location = new System.Drawing.Point(3, 0);
            this.InputDataGrid1.Name = "InputDataGrid1";
            this.InputDataGrid1.ReadOnly = true;
            this.InputDataGrid1.RowTemplate.Height = 21;
            this.InputDataGrid1.Size = new System.Drawing.Size(754, 309);
            this.InputDataGrid1.TabIndex = 0;
            // 
            // InputRBtn
            // 
            this.InputRBtn.AutoSize = true;
            this.InputRBtn.Checked = true;
            this.InputRBtn.Location = new System.Drawing.Point(9, 336);
            this.InputRBtn.Name = "InputRBtn";
            this.InputRBtn.Size = new System.Drawing.Size(109, 16);
            this.InputRBtn.TabIndex = 1;
            this.InputRBtn.TabStop = true;
            this.InputRBtn.Text = "入庫テーブル一覧";
            this.InputRBtn.UseVisualStyleBackColor = true;
            // 
            // OrderingRBtn
            // 
            this.OrderingRBtn.AutoSize = true;
            this.OrderingRBtn.Location = new System.Drawing.Point(9, 367);
            this.OrderingRBtn.Name = "OrderingRBtn";
            this.OrderingRBtn.Size = new System.Drawing.Size(109, 16);
            this.OrderingRBtn.TabIndex = 2;
            this.OrderingRBtn.Text = "発注テーブル一覧";
            this.OrderingRBtn.UseVisualStyleBackColor = true;
            // 
            // IOInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderingRBtn);
            this.Controls.Add(this.InputRBtn);
            this.Controls.Add(this.InputDataGrid1);
            this.Name = "IOInput";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫先IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView InputDataGrid1;
        private System.Windows.Forms.RadioButton InputRBtn;
        private System.Windows.Forms.RadioButton OrderingRBtn;
    }
}
