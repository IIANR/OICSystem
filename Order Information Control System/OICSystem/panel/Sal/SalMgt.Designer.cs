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
			this.注文テーブルBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.iM2DataSet = new WindowsFormsApplication1.IM2DataSet();
			this.DateSet1 = new System.Windows.Forms.DateTimePicker();
			this.DateSet2 = new System.Windows.Forms.DateTimePicker();
			this.注文テーブルTableAdapter = new WindowsFormsApplication1.IM2DataSetTableAdapters.注文テーブルTableAdapter();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(111, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 59;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(493, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 60;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(111, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 62;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(493, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 61;
			this.label6.Text = "label6";
			// 
			// SalMgt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DateSet2);
			this.Controls.Add(this.DateSet1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Monthlybtn);
			this.Controls.Add(this.Weeklybtn);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Name = "SalMgt";
			this.Size = new System.Drawing.Size(760, 515);
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
        private System.Windows.Forms.DateTimePicker DateSet1;
        private System.Windows.Forms.DateTimePicker DateSet2;
        private System.Windows.Forms.BindingSource 注文テーブルBindingSource;
        private IM2DataSet iM2DataSet;
        private IM2DataSetTableAdapters.注文テーブルTableAdapter 注文テーブルTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
	}
}
