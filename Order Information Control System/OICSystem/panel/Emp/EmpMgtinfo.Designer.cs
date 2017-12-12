namespace WindowsFormsApplication1
{
    partial class EmpMgtInfo
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
            this.EmpMgtLbl = new System.Windows.Forms.Label();
            this.EmpdataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.EmpIDTextB = new System.Windows.Forms.TextBox();
            this.EmpNameTextB = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.EmpIDLbl = new System.Windows.Forms.Label();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpMgtLbl
            // 
            this.EmpMgtLbl.Location = new System.Drawing.Point(8, 0);
            this.EmpMgtLbl.Name = "EmpMgtLbl";
            this.EmpMgtLbl.Size = new System.Drawing.Size(151, 40);
            this.EmpMgtLbl.TabIndex = 87;
            this.EmpMgtLbl.Text = "従業員管理";
            this.EmpMgtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpdataGridView
            // 
            this.EmpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpdataGridView.Location = new System.Drawing.Point(3, 57);
            this.EmpdataGridView.Name = "EmpdataGridView";
            this.EmpdataGridView.ReadOnly = true;
            this.EmpdataGridView.RowTemplate.Height = 21;
            this.EmpdataGridView.Size = new System.Drawing.Size(754, 294);
            this.EmpdataGridView.TabIndex = 94;
            // 
            // UpdateB
            // 
            this.UpdateB.Location = new System.Drawing.Point(590, 374);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(150, 37);
            this.UpdateB.TabIndex = 114;
            this.UpdateB.Text = "更新";
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // EditB
            // 
            this.EditB.Location = new System.Drawing.Point(433, 374);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(151, 37);
            this.EditB.TabIndex = 113;
            this.EditB.Text = "編集";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // EmpIDTextB
            // 
            this.EmpIDTextB.Location = new System.Drawing.Point(86, 357);
            this.EmpIDTextB.Name = "EmpIDTextB";
            this.EmpIDTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpIDTextB.TabIndex = 112;
            // 
            // EmpNameTextB
            // 
            this.EmpNameTextB.Location = new System.Drawing.Point(86, 392);
            this.EmpNameTextB.Name = "EmpNameTextB";
            this.EmpNameTextB.Size = new System.Drawing.Size(117, 19);
            this.EmpNameTextB.TabIndex = 111;
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(276, 374);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(151, 37);
            this.SearchB.TabIndex = 110;
            this.SearchB.Text = "検索";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // EmpIDLbl
            // 
            this.EmpIDLbl.AutoSize = true;
            this.EmpIDLbl.Location = new System.Drawing.Point(22, 360);
            this.EmpIDLbl.Name = "EmpIDLbl";
            this.EmpIDLbl.Size = new System.Drawing.Size(58, 12);
            this.EmpIDLbl.TabIndex = 109;
            this.EmpIDLbl.Text = "従業員ID：";
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Location = new System.Drawing.Point(45, 395);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(35, 12);
            this.EmpNameLbl.TabIndex = 108;
            this.EmpNameLbl.Text = "名前：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 115;
            // 
            // EmpMgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.EmpIDTextB);
            this.Controls.Add(this.EmpNameTextB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.EmpIDLbl);
            this.Controls.Add(this.EmpNameLbl);
            this.Controls.Add(this.EmpdataGridView);
            this.Controls.Add(this.EmpMgtLbl);
            this.Name = "EmpMgtInfo";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.EmpMgtInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpMgtLbl;
        private System.Windows.Forms.DataGridView EmpdataGridView;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.TextBox EmpIDTextB;
        private System.Windows.Forms.TextBox EmpNameTextB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label EmpIDLbl;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Label label1;
    }
}
