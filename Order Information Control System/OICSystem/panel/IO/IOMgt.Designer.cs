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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderingBtn
            // 
            this.OrderingBtn.Location = new System.Drawing.Point(522, 9);
            this.OrderingBtn.Name = "OrderingBtn";
            this.OrderingBtn.Size = new System.Drawing.Size(112, 40);
            this.OrderingBtn.TabIndex = 60;
            this.OrderingBtn.Text = "発注";
            this.OrderingBtn.UseVisualStyleBackColor = true;
            this.OrderingBtn.Click += new System.EventHandler(this.OrderingBtn_Click);
            // 
            // OrderingEditBtn
            // 
            this.OrderingEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderingEditBtn.Location = new System.Drawing.Point(646, 9);
            this.OrderingEditBtn.Name = "OrderingEditBtn";
            this.OrderingEditBtn.Size = new System.Drawing.Size(103, 40);
            this.OrderingEditBtn.TabIndex = 57;
            this.OrderingEditBtn.Text = "入庫先管理";
            this.OrderingEditBtn.UseVisualStyleBackColor = true;
            this.OrderingEditBtn.Click += new System.EventHandler(this.OrderingEditBtn_Click);
            // 
            // ctrPanel
            // 
            this.ctrPanel.Location = new System.Drawing.Point(0, 76);
            this.ctrPanel.Name = "ctrPanel";
            this.ctrPanel.Size = new System.Drawing.Size(760, 430);
            this.ctrPanel.TabIndex = 59;
            // 
            // InOutPanelBtn
            // 
            this.InOutPanelBtn.Location = new System.Drawing.Point(404, 9);
            this.InOutPanelBtn.Name = "InOutPanelBtn";
            this.InOutPanelBtn.Size = new System.Drawing.Size(112, 40);
            this.InOutPanelBtn.TabIndex = 58;
            this.InOutPanelBtn.Text = "入出庫処理";
            this.InOutPanelBtn.UseVisualStyleBackColor = true;
            this.InOutPanelBtn.Click += new System.EventHandler(this.InOutPanelBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 56;
            this.label1.Text = "入出庫管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IOMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderingBtn);
            this.Controls.Add(this.OrderingEditBtn);
            this.Controls.Add(this.ctrPanel);
            this.Controls.Add(this.InOutPanelBtn);
            this.Controls.Add(this.label1);
            this.Name = "IOMgt";
            this.Size = new System.Drawing.Size(763, 518);
            this.Load += new System.EventHandler(this.IOMgt_Load);
            this.VisibleChanged += new System.EventHandler(this.IOMgt_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderingBtn;
        private System.Windows.Forms.Button OrderingEditBtn;
        private System.Windows.Forms.Panel ctrPanel;
        private System.Windows.Forms.Button InOutPanelBtn;
        private System.Windows.Forms.Label label1;

    }
}
