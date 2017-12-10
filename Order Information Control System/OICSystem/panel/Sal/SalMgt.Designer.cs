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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.DateSelect = new System.Windows.Forms.Button();
			this.注文テーブルBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
			this.注文テーブルTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.注文テーブルTableAdapter();
			this.Msg = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.DateStart = new System.Windows.Forms.MaskedTextBox();
			this.DateEnd = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// DateSelect
			// 
			this.DateSelect.Location = new System.Drawing.Point(509, 425);
			this.DateSelect.Name = "DateSelect";
			this.DateSelect.Size = new System.Drawing.Size(75, 37);
			this.DateSelect.TabIndex = 50;
			this.DateSelect.Text = "期間指定";
			this.DateSelect.UseVisualStyleBackColor = true;
			this.DateSelect.Click += new System.EventHandler(this.DateSelect_Click);
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
			// 注文テーブルTableAdapter
			// 
			this.注文テーブルTableAdapter.ClearBeforeFill = true;
			// 
			// Msg
			// 
			this.Msg.AutoSize = true;
			this.Msg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Msg.Location = new System.Drawing.Point(188, 122);
			this.Msg.Name = "Msg";
			this.Msg.Size = new System.Drawing.Size(0, 24);
			this.Msg.TabIndex = 59;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(121, 161);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(88, 16);
			this.radioButton1.TabIndex = 63;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(44, 203);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(381, 189);
			this.chart1.TabIndex = 64;
			this.chart1.Text = "chart1";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(467, 171);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(88, 16);
			this.radioButton2.TabIndex = 65;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(438, 226);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 66;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(648, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 69;
			this.label7.Text = "～";
			// 
			// DateStart
			// 
			this.DateStart.Location = new System.Drawing.Point(568, 34);
			this.DateStart.Mask = "0000/00/00";
			this.DateStart.Name = "DateStart";
			this.DateStart.Size = new System.Drawing.Size(74, 19);
			this.DateStart.TabIndex = 86;
			this.DateStart.ValidatingType = typeof(System.DateTime);
			// 
			// DateEnd
			// 
			this.DateEnd.Location = new System.Drawing.Point(671, 34);
			this.DateEnd.Mask = "0000/00/00";
			this.DateEnd.Name = "DateEnd";
			this.DateEnd.Size = new System.Drawing.Size(65, 19);
			this.DateEnd.TabIndex = 87;
			this.DateEnd.ValidatingType = typeof(System.DateTime);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(285, 425);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 88;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SalMgt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DateEnd);
			this.Controls.Add(this.DateStart);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.Msg);
			this.Controls.Add(this.DateSelect);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Name = "SalMgt";
			this.Size = new System.Drawing.Size(760, 515);
			((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DateSelect;
        private System.Windows.Forms.BindingSource 注文テーブルBindingSource;
        private IM2DataSet iM2DataSet;
        private IM2DataSetTableAdapters.注文テーブルTableAdapter 注文テーブルTableAdapter;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox DateStart;
		private System.Windows.Forms.MaskedTextBox DateEnd;
		private System.Windows.Forms.Button button1;
	}
}
