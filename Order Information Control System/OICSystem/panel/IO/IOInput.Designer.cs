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
            this.components = new System.ComponentModel.Container();
            this.入庫先名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDataGrid = new System.Windows.Forms.DataGridView();
            this.入庫IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入庫日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入庫テーブルBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
            this.入庫テーブルTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.入庫テーブルTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.入庫テーブルBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // 入庫先名
            // 
            this.入庫先名.DataPropertyName = "入庫先名";
            this.入庫先名.HeaderText = "入庫先名";
            this.入庫先名.Name = "入庫先名";
            this.入庫先名.ReadOnly = true;
            // 
            // InputDataGrid
            // 
            this.InputDataGrid.AllowUserToAddRows = false;
            this.InputDataGrid.AllowUserToDeleteRows = false;
            this.InputDataGrid.AutoGenerateColumns = false;
            this.InputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.入庫IDDataGridViewTextBoxColumn,
            this.入庫日DataGridViewTextBoxColumn,
            this.商品IDDataGridViewTextBoxColumn,
            this.数量DataGridViewTextBoxColumn,
            this.入庫先名,
            this.備考DataGridViewTextBoxColumn});
            this.InputDataGrid.DataSource = this.入庫テーブルBindingSource;
            this.InputDataGrid.Location = new System.Drawing.Point(3, 3);
            this.InputDataGrid.Name = "InputDataGrid";
            this.InputDataGrid.ReadOnly = true;
            this.InputDataGrid.RowTemplate.Height = 21;
            this.InputDataGrid.Size = new System.Drawing.Size(754, 330);
            this.InputDataGrid.TabIndex = 0;
            // 
            // 入庫IDDataGridViewTextBoxColumn
            // 
            this.入庫IDDataGridViewTextBoxColumn.DataPropertyName = "入庫ID";
            this.入庫IDDataGridViewTextBoxColumn.HeaderText = "入庫ID";
            this.入庫IDDataGridViewTextBoxColumn.Name = "入庫IDDataGridViewTextBoxColumn";
            this.入庫IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入庫日DataGridViewTextBoxColumn
            // 
            this.入庫日DataGridViewTextBoxColumn.DataPropertyName = "入庫日";
            this.入庫日DataGridViewTextBoxColumn.HeaderText = "入庫日";
            this.入庫日DataGridViewTextBoxColumn.Name = "入庫日DataGridViewTextBoxColumn";
            this.入庫日DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 商品IDDataGridViewTextBoxColumn
            // 
            this.商品IDDataGridViewTextBoxColumn.DataPropertyName = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.Name = "商品IDDataGridViewTextBoxColumn";
            this.商品IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 数量DataGridViewTextBoxColumn
            // 
            this.数量DataGridViewTextBoxColumn.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn";
            this.数量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入庫テーブルBindingSource
            // 
            this.入庫テーブルBindingSource.DataMember = "入庫テーブル";
            this.入庫テーブルBindingSource.DataSource = this.iM2DataSet;
            // 
            // iM2DataSet
            // 
            this.iM2DataSet.DataSetName = "IM2DataSet";
            this.iM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 入庫テーブルTableAdapter
            // 
            this.入庫テーブルTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.入庫テーブルBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫先IDDataGridViewTextBoxColumn;
        private IM2DataSet iM2DataSet;
        private System.Windows.Forms.BindingSource 入庫テーブルBindingSource;
        private IM2DataSetTableAdapters.入庫テーブルTableAdapter 入庫テーブルTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫先名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView InputDataGrid;

    }
}
