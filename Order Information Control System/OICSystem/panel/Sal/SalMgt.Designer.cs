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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DateSelectCount = new System.Windows.Forms.Button();
            this.注文テーブルBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
            this.注文テーブルTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.注文テーブルTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.DateStart = new System.Windows.Forms.MaskedTextBox();
            this.DateEnd = new System.Windows.Forms.MaskedTextBox();
            this.Msg = new System.Windows.Forms.Label();
            this.DateSelectMoney = new System.Windows.Forms.Button();
            this.totalMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // DateSelectCount
            // 
            this.DateSelectCount.Location = new System.Drawing.Point(581, 460);
            this.DateSelectCount.Name = "DateSelectCount";
            this.DateSelectCount.Size = new System.Drawing.Size(130, 37);
            this.DateSelectCount.TabIndex = 50;
            this.DateSelectCount.Text = "期間指定(販売数表示)";
            this.DateSelectCount.UseVisualStyleBackColor = true;
            this.DateSelectCount.Click += new System.EventHandler(this.DateSelectCount_Click);
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
            // chart1
            // 
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorGrid.Interval = 1D;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(44, 183);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(692, 209);
            this.chart1.TabIndex = 64;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "～";
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(478, 425);
            this.DateStart.Mask = "0000/00/00";
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(74, 19);
            this.DateStart.TabIndex = 86;
            this.DateStart.ValidatingType = typeof(System.DateTime);
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(581, 425);
            this.DateEnd.Mask = "0000/00/00";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(69, 19);
            this.DateEnd.TabIndex = 87;
            this.DateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Msg.Location = new System.Drawing.Point(83, 108);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 24);
            this.Msg.TabIndex = 95;
            // 
            // DateSelectMoney
            // 
            this.DateSelectMoney.Location = new System.Drawing.Point(406, 460);
            this.DateSelectMoney.Name = "DateSelectMoney";
            this.DateSelectMoney.Size = new System.Drawing.Size(142, 37);
            this.DateSelectMoney.TabIndex = 97;
            this.DateSelectMoney.Text = "期間指定(販売金額表示)";
            this.DateSelectMoney.UseVisualStyleBackColor = true;
            this.DateSelectMoney.Click += new System.EventHandler(this.DateSelectMoney_Click);
            // 
            // totalMsg
            // 
            this.totalMsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalMsg.AutoSize = true;
            this.totalMsg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalMsg.Location = new System.Drawing.Point(135, 146);
            this.totalMsg.Name = "totalMsg";
            this.totalMsg.Size = new System.Drawing.Size(0, 24);
            this.totalMsg.TabIndex = 94;
            // 
            // SalMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateSelectMoney);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.totalMsg);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DateSelectCount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "SalMgt";
            this.Size = new System.Drawing.Size(760, 515);
            ((System.ComponentModel.ISupportInitialize)(this.注文テーブルBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DateSelectCount;
        private System.Windows.Forms.BindingSource 注文テーブルBindingSource;
        private IM2DataSet iM2DataSet;
        private IM2DataSetTableAdapters.注文テーブルTableAdapter 注文テーブルTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox DateStart;
		private System.Windows.Forms.MaskedTextBox DateEnd;
		private System.Windows.Forms.Label Msg;
		private System.Windows.Forms.Button DateSelectMoney;
        private System.Windows.Forms.Label totalMsg;
	}
}
