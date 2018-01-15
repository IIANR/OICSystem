using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderingList : Form
    {
        public IOOrdering frm3;

        OleDbConnection cn = new OleDbConnection();

        public OrderingList()
        {
            InitializeComponent();
        }

        private void OrderingList_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = !this.MaximizeBox;

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            DsOrderingList ds1 = new DsOrderingList();

            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string sql = "SELECT 発注テーブル.発注ID, 発注テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.仕入れ値, 発注テーブル.発注数量 FROM 商品マスタ INNER JOIN 発注テーブル ON 商品マスタ.商品ID = 発注テーブル.商品ID WHERE 商品マスタ.フラグ='発注済み' AND 発注テーブル.フラグ='発注書未作成' ORDER BY 発注テーブル.発注ID;";

            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            da.Fill(ds1.Dt1);

            OrderingReport.Reset();
            OrderingReport.ProcessingMode = ProcessingMode.Local;
            OrderingReport.LocalReport.ReportPath = Environment.CurrentDirectory + @"Data Source=.\..\..\OrderingReport.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds1.Dt1;

            var reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("ReportParameter1", frm3.InputNameCombo.Text));
            this.OrderingReport.LocalReport.SetParameters(reportParams);

            //ReportViewerに表示
            this.OrderingReport.LocalReport.DataSources.Add(rds);

            this.OrderingReport.RefreshReport();

            string mineType;
            string encoding;
            string extension;
            String[] stringminds;
            Warning[] warnings;

            byte[] bytes = this.OrderingReport.LocalReport.Render("EXCELOPENXML",
            null, out mineType, out encoding, out extension, out stringminds, out warnings);
            FileStream fs = new FileStream(@"..\..\assets\EXCEL\"+dtNow.ToString("yyyyMMddhhmmss")+".xlsx", FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();           
        }

        private void OrderingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("注文書の印刷、保存は終わっていますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 発注テーブル SET フラグ = '発注書作成済み'";

                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Parameters.Clear();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
