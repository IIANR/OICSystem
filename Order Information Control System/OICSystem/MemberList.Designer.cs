namespace WindowsFormsApplication1
{
    partial class MemberList
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MemberReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsMemberList = new WindowsFormsApplication1.DsMemberList();
            this.Dt3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DsMemberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberReport
            // 
            this.MemberReport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Dt3BindingSource;
            this.MemberReport.LocalReport.DataSources.Add(reportDataSource1);
            this.MemberReport.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.MemberListReport.rdlc";
            this.MemberReport.Location = new System.Drawing.Point(0, 0);
            this.MemberReport.Name = "MemberReport";
            this.MemberReport.Size = new System.Drawing.Size(617, 662);
            this.MemberReport.TabIndex = 0;
            // 
            // DsMemberList
            // 
            this.DsMemberList.DataSetName = "DsMemberList";
            this.DsMemberList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dt3BindingSource
            // 
            this.Dt3BindingSource.DataMember = "Dt3";
            this.Dt3BindingSource.DataSource = this.DsMemberList;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 662);
            this.Controls.Add(this.MemberReport);
            this.Name = "MemberList";
            this.Text = "MemberList";
            this.Load += new System.EventHandler(this.MemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMemberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer MemberReport;
        private System.Windows.Forms.BindingSource Dt3BindingSource;
        private DsMemberList DsMemberList;
    }
}