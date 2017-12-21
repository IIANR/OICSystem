using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MemberList : Form
    {
        OleDbConnection cn = new OleDbConnection();

        public MemberList()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            DsMemberList ds1 = new DsMemberList();

            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string sql = "SELECT 顧客ID,名前,電話番号,郵便番号,住所1,住所2 FROM 顧客テーブル";

            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            da.Fill(ds1.Dt3);

            MemberReport.Reset();
            MemberReport.ProcessingMode = ProcessingMode.Local;
            MemberReport.LocalReport.ReportPath = Environment.CurrentDirectory + @"Data Source=.\..\..\MemberListReport.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds1.Dt3;

            //ReportViewerに表示
            this.MemberReport.LocalReport.DataSources.Add(rds);

            this.MemberReport.RefreshReport();
        }
    }
}
