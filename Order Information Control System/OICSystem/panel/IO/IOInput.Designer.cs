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
            this.InputDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputDataGrid
            // 
            this.InputDataGrid.AllowUserToAddRows = false;
            this.InputDataGrid.AllowUserToDeleteRows = false;
            this.InputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataGrid.Location = new System.Drawing.Point(3, 3);
            this.InputDataGrid.Name = "InputDataGrid";
            this.InputDataGrid.ReadOnly = true;
            this.InputDataGrid.RowTemplate.Height = 21;
            this.InputDataGrid.Size = new System.Drawing.Size(754, 424);
            this.InputDataGrid.TabIndex = 0;
            // 
            // IOInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputDataGrid);
            this.Name = "IOInput";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫先IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView InputDataGrid;

    }
}
