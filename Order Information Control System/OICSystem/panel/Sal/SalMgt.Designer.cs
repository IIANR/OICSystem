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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.DateSelectMoney = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            this.TotalMsg = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MaskedTextBox();
            this.DateStart = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateSelectCount = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analysis = new System.Windows.Forms.Button();
            this.printing = new System.Windows.Forms.Button();
            this.AddMsg = new System.Windows.Forms.Label();
            this.Btnclean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateSelectMoney
            // 
            this.DateSelectMoney.Location = new System.Drawing.Point(844, 585);
            this.DateSelectMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateSelectMoney.Name = "DateSelectMoney";
            this.DateSelectMoney.Size = new System.Drawing.Size(133, 50);
            this.DateSelectMoney.TabIndex = 4;
            this.DateSelectMoney.TabStop = false;
            this.DateSelectMoney.Text = "販売「金額」表示";
            this.DateSelectMoney.UseVisualStyleBackColor = true;
            this.DateSelectMoney.Click += new System.EventHandler(this.DateSelectMoney_Click);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Msg.Location = new System.Drawing.Point(124, 89);
            this.Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(61, 30);
            this.Msg.TabIndex = 114;
            this.Msg.Text = "Msg";
            // 
            // TotalMsg
            // 
            this.TotalMsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalMsg.AutoSize = true;
            this.TotalMsg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalMsg.Location = new System.Drawing.Point(193, 136);
            this.TotalMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalMsg.Name = "TotalMsg";
            this.TotalMsg.Size = new System.Drawing.Size(141, 30);
            this.TotalMsg.TabIndex = 113;
            this.TotalMsg.Text = "TotalMsg";
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(537, 599);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateEnd.Mask = "0000/00/00";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(91, 22);
            this.DateEnd.TabIndex = 2;
            this.DateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(400, 599);
            this.DateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateStart.Mask = "0000/00/00";
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(97, 22);
            this.DateStart.TabIndex = 1;
            this.DateStart.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 602);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "～";
            // 
            // DateSelectCount
            // 
            this.DateSelectCount.Location = new System.Drawing.Point(703, 586);
            this.DateSelectCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateSelectCount.Name = "DateSelectCount";
            this.DateSelectCount.Size = new System.Drawing.Size(133, 50);
            this.DateSelectCount.TabIndex = 0;
            this.DateSelectCount.TabStop = false;
            this.DateSelectCount.Text = "販売「数」表示";
            this.DateSelectCount.UseVisualStyleBackColor = true;
            this.DateSelectCount.Click += new System.EventHandler(this.DateSelectCount_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 79);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(963, 499);
            this.listBox1.TabIndex = 108;
            this.listBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(44, 170);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(933, 394);
            this.chart1.TabIndex = 116;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart2";
            // 
            // analysis
            // 
            this.analysis.Location = new System.Drawing.Point(80, 590);
            this.analysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(145, 41);
            this.analysis.TabIndex = 117;
            this.analysis.TabStop = false;
            this.analysis.Text = "販売済み表示";
            this.analysis.UseVisualStyleBackColor = true;
            this.analysis.Click += new System.EventHandler(this.analysis_Click);
            // 
            // printing
            // 
            this.printing.Location = new System.Drawing.Point(888, 35);
            this.printing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(89, 40);
            this.printing.TabIndex = 3;
            this.printing.Text = "印刷";
            this.printing.UseVisualStyleBackColor = true;
            this.printing.Click += new System.EventHandler(this.printing_Click);
            // 
            // AddMsg
            // 
            this.AddMsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddMsg.AutoSize = true;
            this.AddMsg.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddMsg.Location = new System.Drawing.Point(124, 170);
            this.AddMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddMsg.Name = "AddMsg";
            this.AddMsg.Size = new System.Drawing.Size(109, 30);
            this.AddMsg.TabIndex = 119;
            this.AddMsg.Text = "AddMsg";
            // 
            // Btnclean
            // 
            this.Btnclean.Location = new System.Drawing.Point(269, 594);
            this.Btnclean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btnclean.Name = "Btnclean";
            this.Btnclean.Size = new System.Drawing.Size(76, 29);
            this.Btnclean.TabIndex = 143;
            this.Btnclean.TabStop = false;
            this.Btnclean.Text = "クリア";
            this.Btnclean.UseVisualStyleBackColor = true;
            this.Btnclean.Click += new System.EventHandler(this.Btnclean_Click);
            // 
            // SalMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btnclean);
            this.Controls.Add(this.AddMsg);
            this.Controls.Add(this.printing);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DateSelectMoney);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.TotalMsg);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateSelectCount);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalMgt";
            this.Size = new System.Drawing.Size(1013, 644);
            this.Load += new System.EventHandler(this.SalMgt_Load);
            this.VisibleChanged += new System.EventHandler(this.SalMgt_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DateSelectMoney;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Label TotalMsg;
        private System.Windows.Forms.MaskedTextBox DateEnd;
        private System.Windows.Forms.MaskedTextBox DateStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DateSelectCount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button analysis;
        private System.Windows.Forms.Button printing;
        private System.Windows.Forms.Label AddMsg;
        private System.Windows.Forms.Button Btnclean;
    }
}
