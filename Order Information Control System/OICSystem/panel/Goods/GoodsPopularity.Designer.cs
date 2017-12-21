namespace WindowsFormsApplication1
{
    partial class GoodsPopularity
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.printing = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            this.TotalMsg = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MaskedTextBox();
            this.DateStart = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateSelectCount = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // printing
            // 
            this.printing.Location = new System.Drawing.Point(877, 486);
            this.printing.Margin = new System.Windows.Forms.Padding(4);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(64, 35);
            this.printing.TabIndex = 140;
            this.printing.Text = "印刷";
            this.printing.UseVisualStyleBackColor = true;
            this.printing.Click += new System.EventHandler(this.printing_Click);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Msg.Location = new System.Drawing.Point(58, 53);
            this.Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(61, 30);
            this.Msg.TabIndex = 139;
            this.Msg.Text = "Msg";
            this.Msg.Visible = false;
            // 
            // TotalMsg
            // 
            this.TotalMsg.AutoSize = true;
            this.TotalMsg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalMsg.Location = new System.Drawing.Point(109, 95);
            this.TotalMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalMsg.Name = "TotalMsg";
            this.TotalMsg.Size = new System.Drawing.Size(141, 30);
            this.TotalMsg.TabIndex = 138;
            this.TotalMsg.Text = "TotalMsg";
            this.TotalMsg.Visible = false;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(612, 493);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateEnd.Mask = "0000/00/00";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(91, 22);
            this.DateEnd.TabIndex = 137;
            this.DateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(474, 493);
            this.DateStart.Margin = new System.Windows.Forms.Padding(4);
            this.DateStart.Mask = "0000/00/00";
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(97, 22);
            this.DateStart.TabIndex = 136;
            this.DateStart.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 496);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 135;
            this.label7.Text = "～";
            // 
            // DateSelectCount
            // 
            this.DateSelectCount.Location = new System.Drawing.Point(268, 482);
            this.DateSelectCount.Margin = new System.Windows.Forms.Padding(4);
            this.DateSelectCount.Name = "DateSelectCount";
            this.DateSelectCount.Size = new System.Drawing.Size(173, 46);
            this.DateSelectCount.TabIndex = 134;
            this.DateSelectCount.Text = "期間指定(販売数表示)";
            this.DateSelectCount.UseVisualStyleBackColor = true;
            this.DateSelectCount.Click += new System.EventHandler(this.DateSelectCount_Click);
            // 
            // chart1
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(44, 86);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(933, 372);
            this.chart1.TabIndex = 141;
            this.chart1.Text = "chart2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(964, 454);
            this.listBox1.TabIndex = 133;
            // 
            // GoodsPopularity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printing);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.TotalMsg);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateSelectCount);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Name = "GoodsPopularity";
            this.Size = new System.Drawing.Size(1013, 538);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printing;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Label TotalMsg;
        private System.Windows.Forms.MaskedTextBox DateEnd;
        private System.Windows.Forms.MaskedTextBox DateStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DateSelectCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
