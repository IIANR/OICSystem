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
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputDataGrid
            // 
            this.OutputDataGrid.AllowUserToAddRows = false;
            this.OutputDataGrid.AllowUserToDeleteRows = false;
            this.OutputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDataGrid.Location = new System.Drawing.Point(3, 3);
            this.OutputDataGrid.Name = "OutputDataGrid";
            this.OutputDataGrid.ReadOnly = true;
            this.OutputDataGrid.RowTemplate.Height = 21;
            this.OutputDataGrid.Size = new System.Drawing.Size(754, 424);
            this.OutputDataGrid.TabIndex = 0;
            // 
            // IOOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.OutputDataGrid);
            this.Name = "IOOutput";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OutputDataGrid;
    }
}
