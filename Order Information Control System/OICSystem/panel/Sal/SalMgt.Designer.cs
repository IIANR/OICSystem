namespace WindowsFormsApplication1
{
    partial class SalMgt
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Weeklybtn = new System.Windows.Forms.Button();
            this.Monthlybtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.注文日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.従業員IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入金済みDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.注文テーブルBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
            this.DateSet1 = new System.Windows.Forms.DateTimePicker();
            this.DateSet2 = new System.Windows.Forms.DateTimePicker();
            this.注文テーブルTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.注文テーブルTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 46;
            this.label1.Text = "売上管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(23, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(723, 328);
            this.listBox1.TabIndex = 49;
            // 
            // Weeklybtn
            // 
            this.Weeklybtn.Location = new System.Drawing.Point(509, 425);
            this.Weeklybtn.Name = "Weeklybtn";
            this.Weeklybtn.Size = new System.Drawing.Size(75, 37);
            this.Weeklybtn.TabIndex = 50;
            this.Weeklybtn.Text = "週別";
            this.Weeklybtn.UseVisualStyleBackColor = true;
            this.Weeklybtn.Click += new System.EventHandler(this.Weeklybtn_Click);
            // 
            // Monthlybtn
            // 
            this.Monthlybtn.Location = new System.Drawing.Point(590, 425);
            this.Monthlybtn.Name = "Monthlybtn";
            this.Monthlybtn.Size = new System.Drawing.Size(75, 37);
            this.Monthlybtn.TabIndex = 51;
            this.Monthlybtn.Text = "月別";
            this.Monthlybtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(671, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 37);
            this.button5.TabIndex = 52;
            this.button5.Text = "仮";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "～";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.注文日DataGridViewTextBoxColumn,
            this.商品IDDataGridViewTextBoxColumn,
            this.数量DataGridViewTextBoxColumn,
            this.顧客IDDataGridViewTextBoxColumn,
            this.従業員IDDataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn,
            this.入金済みDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.注文テーブルBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(714, 291);
            this.dataGridView1.TabIndex = 56;
            // 
            // 注文日DataGridViewTextBoxColumn
            // 
            this.注文日DataGridViewTextBoxColumn.DataPropertyName = "注文日";
            this.注文日DataGridViewTextBoxColumn.HeaderText = "注文日";
            this.注文日DataGridViewTextBoxColumn.Name = "注文日DataGridViewTextBoxColumn";
            // 
            // 商品IDDataGridViewTextBoxColumn
            // 
            this.商品IDDataGridViewTextBoxColumn.DataPropertyName = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.商品IDDataGridViewTextBoxColumn.Name = "商品IDDataGridViewTextBoxColumn";
            // 
            // 数量DataGridViewTextBoxColumn
            // 
            this.数量DataGridViewTextBoxColumn.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn";
            // 
            // 顧客IDDataGridViewTextBoxColumn
            // 
            this.顧客IDDataGridViewTextBoxColumn.DataPropertyName = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.HeaderText = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.Name = "顧客IDDataGridViewTextBoxColumn";
            // 
            // 従業員IDDataGridViewTextBoxColumn
            // 
            this.従業員IDDataGridViewTextBoxColumn.DataPropertyName = "従業員ID";
            this.従業員IDDataGridViewTextBoxColumn.HeaderText = "従業員ID";
            this.従業員IDDataGridViewTextBoxColumn.Name = "従業員IDDataGridViewTextBoxColumn";
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            // 
            // 入金済みDataGridViewCheckBoxColumn
            // 
            this.入金済みDataGridViewCheckBoxColumn.DataPropertyName = "入金済み";
            this.入金済みDataGridViewCheckBoxColumn.HeaderText = "入金済み";
            this.入金済みDataGridViewCheckBoxColumn.Name = "入金済みDataGridViewCheckBoxColumn";
            // 
            // 注文テーブルBindingSource
            // 
            this.注文テーブルBindingSource.DataMember = "注文テーブル";
            this.注文テーブルBindingSource.DataSource = this.iM2DataSet;
            // 
            // iM2DataSet
            // 
            this.iM2DataSet.DataSetName = "IM2DataSet";
            this.iM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateSet1
            // 
            this.DateSet1.Location = new System.Drawing.Point(512, 32);
            this.DateSet1.Name = "DateSet1";
            this.DateSet1.Size = new System.Drawing.Size(103, 19);
            this.DateSet1.TabIndex = 57;
            this.DateSet1.Value = new System.DateTime(2017, 11, 24, 0, 0, 0, 0);
            // 
            // DateSet2
            // 
            this.DateSet2.Location = new System.Drawing.Point(644, 32);
            this.DateSet2.Name = "DateSet2";
            this.DateSet2.Size = new System.Drawing.Size(102, 19);
            this.DateSet2.TabIndex = 58;
            this.DateSet2.Value = new System.DateTime(2017, 11, 24, 23, 59, 59, 0);
            // 
            // 注文テーブルTableAdapter
            // 
            this.注文テーブルTableAdapter.ClearBeforeFill = true;
            // 
            // SalMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateSet2);
            this.Controls.Add(this.DateSet1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Monthlybtn);
            this.Controls.Add(this.Weeklybtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "SalMgt";
            this.Size = new System.Drawing.Size(760, 515);
            this.Load += new System.EventHandler(this.SalMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Weeklybtn;
        private System.Windows.Forms.Button Monthlybtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DateSet1;
        private System.Windows.Forms.DateTimePicker DateSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注文日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 従業員IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 入金済みDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource 注文テーブルBindingSource;
        private IM2DataSet iM2DataSet;
        private IM2DataSetTableAdapters.注文テーブルTableAdapter 注文テーブルTableAdapter;
    }
}
