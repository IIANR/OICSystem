namespace WindowsFormsApplication1
{
    partial class IOMgt
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
            this.OrderingBtn = new System.Windows.Forms.Button();
            this.OrderingEditBtn = new System.Windows.Forms.Button();
            this.ctrPanel = new System.Windows.Forms.Panel();
            this.InOutPanelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderingBtn
            // 
            this.OrderingBtn.Location = new System.Drawing.Point(696, 11);
            this.OrderingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderingBtn.Name = "OrderingBtn";
            this.OrderingBtn.Size = new System.Drawing.Size(149, 50);
            this.OrderingBtn.TabIndex = 60;
            this.OrderingBtn.TabStop = false;
            this.OrderingBtn.Text = "発注";
            this.OrderingBtn.UseVisualStyleBackColor = true;
            this.OrderingBtn.Click += new System.EventHandler(this.OrderingBtn_Click);
            // 
            // OrderingEditBtn
            // 
            this.OrderingEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderingEditBtn.Location = new System.Drawing.Point(861, 11);
            this.OrderingEditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderingEditBtn.Name = "OrderingEditBtn";
            this.OrderingEditBtn.Size = new System.Drawing.Size(137, 50);
            this.OrderingEditBtn.TabIndex = 57;
            this.OrderingEditBtn.TabStop = false;
            this.OrderingEditBtn.Text = "入庫先情報";
            this.OrderingEditBtn.UseVisualStyleBackColor = true;
            this.OrderingEditBtn.Click += new System.EventHandler(this.OrderingEditBtn_Click);
            // 
            // ctrPanel
            // 
            this.ctrPanel.Location = new System.Drawing.Point(0, 95);
            this.ctrPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrPanel.Name = "ctrPanel";
            this.ctrPanel.Size = new System.Drawing.Size(1013, 538);
            this.ctrPanel.TabIndex = 59;
            // 
            // InOutPanelBtn
            // 
            this.InOutPanelBtn.Location = new System.Drawing.Point(539, 11);
            this.InOutPanelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InOutPanelBtn.Name = "InOutPanelBtn";
            this.InOutPanelBtn.Size = new System.Drawing.Size(149, 50);
            this.InOutPanelBtn.TabIndex = 58;
            this.InOutPanelBtn.TabStop = false;
            this.InOutPanelBtn.Text = "入出庫処理";
            this.InOutPanelBtn.UseVisualStyleBackColor = true;
            this.InOutPanelBtn.Click += new System.EventHandler(this.InOutPanelBtn_Click);
            // 
            // IOMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderingBtn);
            this.Controls.Add(this.OrderingEditBtn);
            this.Controls.Add(this.ctrPanel);
            this.Controls.Add(this.InOutPanelBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IOMgt";
            this.Size = new System.Drawing.Size(1017, 648);
            this.Load += new System.EventHandler(this.IOMgt_Load);
            this.VisibleChanged += new System.EventHandler(this.IOMgt_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderingBtn;
        private System.Windows.Forms.Button OrderingEditBtn;
        private System.Windows.Forms.Panel ctrPanel;
        private System.Windows.Forms.Button InOutPanelBtn;

    }
}
