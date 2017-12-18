namespace WindowsFormsApplication1
{
    partial class IOOrdering
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
            this.label3 = new System.Windows.Forms.Label();
            this.InputNameCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderingGoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TelTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodsidTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderingPayTextbox = new System.Windows.Forms.TextBox();
            this.OrderingCompBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InputNumTextbox = new System.Windows.Forms.TextBox();
            this.OrderingPrintBtn = new System.Windows.Forms.Button();
            this.PosTextbox = new System.Windows.Forms.TextBox();
            this.Addres1Textbox = new System.Windows.Forms.TextBox();
            this.Addres2Textbox = new System.Windows.Forms.TextBox();
            this.PosLabel = new System.Windows.Forms.Label();
            this.Addres1Label = new System.Windows.Forms.Label();
            this.Addres2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderingGoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "電話番号：";
            // 
            // InputNameCombo
            // 
            this.InputNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputNameCombo.FormattingEnabled = true;
            this.InputNameCombo.Location = new System.Drawing.Point(547, 68);
            this.InputNameCombo.Name = "InputNameCombo";
            this.InputNameCombo.Size = new System.Drawing.Size(175, 20);
            this.InputNameCombo.TabIndex = 8;
            this.InputNameCombo.TextChanged += new System.EventHandler(this.InputNameCombo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(558, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "入庫先";
            // 
            // OrderingGoodsDataGrid
            // 
            this.OrderingGoodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderingGoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderingGoodsDataGrid.Location = new System.Drawing.Point(12, 53);
            this.OrderingGoodsDataGrid.Name = "OrderingGoodsDataGrid";
            this.OrderingGoodsDataGrid.ReadOnly = true;
            this.OrderingGoodsDataGrid.RowTemplate.Height = 21;
            this.OrderingGoodsDataGrid.Size = new System.Drawing.Size(403, 361);
            this.OrderingGoodsDataGrid.TabIndex = 6;
            this.OrderingGoodsDataGrid.Click += new System.EventHandler(this.OrderingGoodsDataGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(129, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "要発注商品";
            // 
            // TelTextBox
            // 
            this.TelTextBox.Location = new System.Drawing.Point(547, 97);
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.ReadOnly = true;
            this.TelTextBox.Size = new System.Drawing.Size(175, 19);
            this.TelTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(478, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(59, 12);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.Text = "仕入先名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "商品ID：";
            // 
            // GoodsidTextBox
            // 
            this.GoodsidTextBox.Location = new System.Drawing.Point(547, 265);
            this.GoodsidTextBox.Name = "GoodsidTextBox";
            this.GoodsidTextBox.ReadOnly = true;
            this.GoodsidTextBox.Size = new System.Drawing.Size(100, 19);
            this.GoodsidTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "発注数：";
            // 
            // OrderingPayTextbox
            // 
            this.OrderingPayTextbox.Location = new System.Drawing.Point(547, 290);
            this.OrderingPayTextbox.Name = "OrderingPayTextbox";
            this.OrderingPayTextbox.ReadOnly = true;
            this.OrderingPayTextbox.Size = new System.Drawing.Size(100, 19);
            this.OrderingPayTextbox.TabIndex = 15;
            // 
            // OrderingCompBtn
            // 
            this.OrderingCompBtn.Location = new System.Drawing.Point(547, 366);
            this.OrderingCompBtn.Name = "OrderingCompBtn";
            this.OrderingCompBtn.Size = new System.Drawing.Size(89, 33);
            this.OrderingCompBtn.TabIndex = 16;
            this.OrderingCompBtn.Text = "発注";
            this.OrderingCompBtn.UseVisualStyleBackColor = true;
            this.OrderingCompBtn.Click += new System.EventHandler(this.OrderingCompBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "仕入れ値：";
            // 
            // InputNumTextbox
            // 
            this.InputNumTextbox.Location = new System.Drawing.Point(547, 318);
            this.InputNumTextbox.Name = "InputNumTextbox";
            this.InputNumTextbox.Size = new System.Drawing.Size(100, 19);
            this.InputNumTextbox.TabIndex = 18;
            // 
            // OrderingPrintBtn
            // 
            this.OrderingPrintBtn.Location = new System.Drawing.Point(644, 366);
            this.OrderingPrintBtn.Name = "OrderingPrintBtn";
            this.OrderingPrintBtn.Size = new System.Drawing.Size(89, 33);
            this.OrderingPrintBtn.TabIndex = 19;
            this.OrderingPrintBtn.Text = "発注書印刷";
            this.OrderingPrintBtn.UseVisualStyleBackColor = true;
            this.OrderingPrintBtn.Click += new System.EventHandler(this.OrderingPrintBtn_Click);
            // 
            // PosTextbox
            // 
            this.PosTextbox.Location = new System.Drawing.Point(547, 126);
            this.PosTextbox.Name = "PosTextbox";
            this.PosTextbox.ReadOnly = true;
            this.PosTextbox.Size = new System.Drawing.Size(175, 19);
            this.PosTextbox.TabIndex = 20;
            // 
            // Addres1Textbox
            // 
            this.Addres1Textbox.Location = new System.Drawing.Point(547, 155);
            this.Addres1Textbox.Name = "Addres1Textbox";
            this.Addres1Textbox.ReadOnly = true;
            this.Addres1Textbox.Size = new System.Drawing.Size(175, 19);
            this.Addres1Textbox.TabIndex = 21;
            // 
            // Addres2Textbox
            // 
            this.Addres2Textbox.Location = new System.Drawing.Point(547, 184);
            this.Addres2Textbox.Name = "Addres2Textbox";
            this.Addres2Textbox.ReadOnly = true;
            this.Addres2Textbox.Size = new System.Drawing.Size(175, 19);
            this.Addres2Textbox.TabIndex = 22;
            // 
            // PosLabel
            // 
            this.PosLabel.AutoSize = true;
            this.PosLabel.Location = new System.Drawing.Point(478, 129);
            this.PosLabel.Name = "PosLabel";
            this.PosLabel.Size = new System.Drawing.Size(59, 12);
            this.PosLabel.TabIndex = 23;
            this.PosLabel.Text = "郵便番号：";
            // 
            // Addres1Label
            // 
            this.Addres1Label.AutoSize = true;
            this.Addres1Label.Location = new System.Drawing.Point(496, 158);
            this.Addres1Label.Name = "Addres1Label";
            this.Addres1Label.Size = new System.Drawing.Size(41, 12);
            this.Addres1Label.TabIndex = 24;
            this.Addres1Label.Text = "住所1：";
            // 
            // Addres2Label
            // 
            this.Addres2Label.AutoSize = true;
            this.Addres2Label.Location = new System.Drawing.Point(496, 187);
            this.Addres2Label.Name = "Addres2Label";
            this.Addres2Label.Size = new System.Drawing.Size(41, 12);
            this.Addres2Label.TabIndex = 25;
            this.Addres2Label.Text = "住所2：";
            // 
            // IOOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Addres2Label);
            this.Controls.Add(this.Addres1Label);
            this.Controls.Add(this.PosLabel);
            this.Controls.Add(this.Addres2Textbox);
            this.Controls.Add(this.Addres1Textbox);
            this.Controls.Add(this.PosTextbox);
            this.Controls.Add(this.OrderingPrintBtn);
            this.Controls.Add(this.InputNumTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderingCompBtn);
            this.Controls.Add(this.OrderingPayTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoodsidTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputNameCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderingGoodsDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "IOOrdering";
            this.Size = new System.Drawing.Size(760, 430);
            this.Load += new System.EventHandler(this.IOOrdering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderingGoodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InputNameCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OrderingGoodsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TelTextBox;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GoodsidTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderingPayTextbox;
        private System.Windows.Forms.Button OrderingCompBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputNumTextbox;
        private System.Windows.Forms.Button OrderingPrintBtn;
        private System.Windows.Forms.TextBox PosTextbox;
        private System.Windows.Forms.TextBox Addres1Textbox;
        private System.Windows.Forms.TextBox Addres2Textbox;
        private System.Windows.Forms.Label PosLabel;
        private System.Windows.Forms.Label Addres1Label;
        private System.Windows.Forms.Label Addres2Label;
    }
}
