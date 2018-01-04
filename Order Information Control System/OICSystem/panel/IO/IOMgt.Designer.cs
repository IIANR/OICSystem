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
            this.InOutPanelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPanel = new System.Windows.Forms.Panel();
            this.RegiEditBtn = new System.Windows.Forms.Button();
            this.OrderingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InOutPanelBtn
            // 
            this.InOutPanelBtn.Location = new System.Drawing.Point(404, 18);
            this.InOutPanelBtn.Name = "InOutPanelBtn";
            this.InOutPanelBtn.Size = new System.Drawing.Size(112, 40);
            this.InOutPanelBtn.TabIndex = 41;
            this.InOutPanelBtn.Text = "入出庫処理";
            this.InOutPanelBtn.UseVisualStyleBackColor = true;
            this.InOutPanelBtn.Click += new System.EventHandler(this.outPanelBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 39;
            this.label1.Text = "入出庫管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrPanel
            // 
            this.ctrPanel.Location = new System.Drawing.Point(0, 85);
            this.ctrPanel.Name = "ctrPanel";
            this.ctrPanel.Size = new System.Drawing.Size(760, 430);
            this.ctrPanel.TabIndex = 54;
            // 
            // RegiEditBtn
            // 
            this.RegiEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegiEditBtn.Location = new System.Drawing.Point(643, 18);
            this.RegiEditBtn.Name = "RegiEditBtn";
            this.RegiEditBtn.Size = new System.Drawing.Size(103, 40);
            this.RegiEditBtn.TabIndex = 41;
            this.RegiEditBtn.Text = "入庫先管理";
            this.RegiEditBtn.UseVisualStyleBackColor = true;
            this.RegiEditBtn.Click += new System.EventHandler(this.RegiEditBtn_Click);
            // 
            // OrderingBtn
            // 
            this.OrderingBtn.Location = new System.Drawing.Point(522, 18);
            this.OrderingBtn.Name = "OrderingBtn";
            this.OrderingBtn.Size = new System.Drawing.Size(112, 40);
            this.OrderingBtn.TabIndex = 55;
            this.OrderingBtn.Text = "発注";
            this.OrderingBtn.UseVisualStyleBackColor = true;
            this.OrderingBtn.Click += new System.EventHandler(this.OrderingBtn_Click);
            // 
            // IOMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.OrderingBtn);
            this.Controls.Add(this.RegiEditBtn);
            this.Controls.Add(this.ctrPanel);
            this.Controls.Add(this.InOutPanelBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "IOMgt";
            this.Size = new System.Drawing.Size(763, 518);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InOutPanelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ctrPanel;
        private System.Windows.Forms.Button RegiEditBtn;
        private System.Windows.Forms.Button OrderingBtn;
    }
}
