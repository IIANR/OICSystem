﻿using Microsoft.Reporting.WinForms;
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
    public partial class OrderingList : Form
    {
        OleDbConnection cn = new OleDbConnection();
        public OrderingList()
        {
            InitializeComponent();
        }

        private void OrderingList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            DsOrderingList ds1 = new DsOrderingList();

            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string sql = "SELECT 発注テーブル.発注ID, 発注テーブル.商品ID, 商品マスタ.商品名, 発注テーブル.発注数量 FROM 商品マスタ INNER JOIN 発注テーブル ON 商品マスタ.商品ID = 発注テーブル.商品ID;";

            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            da.Fill(ds1.Dt1);

            OrderingReport.Reset();
            OrderingReport.ProcessingMode = ProcessingMode.Local;
            OrderingReport.LocalReport.ReportPath = Environment.CurrentDirectory + @"Data Source=.\..\..\OrderingReport.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds1.Dt1;

            //ReportViewerに表示
            this.OrderingReport.LocalReport.DataSources.Add(rds);

            this.OrderingReport.RefreshReport();
        }
    }
}