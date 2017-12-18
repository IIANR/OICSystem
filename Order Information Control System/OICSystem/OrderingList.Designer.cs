namespace WindowsFormsApplication1
{
    partial class OrderingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderingReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // OrderingReport
            // 
            this.OrderingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderingReport.Location = new System.Drawing.Point(0, 0);
            this.OrderingReport.Name = "OrderingReport";
            this.OrderingReport.Size = new System.Drawing.Size(625, 637);
            this.OrderingReport.TabIndex = 0;
            // 
            // OrderingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 637);
            this.Controls.Add(this.OrderingReport);
            this.Name = "OrderingList";
            this.Text = "OrderingList";
            this.Load += new System.EventHandler(this.OrderingList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer OrderingReport;
    }
}