using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class OrderMgtInfo : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public OrderMgtInfo()
        {
            InitializeComponent();
        }

        private void OrderMgtInfo_Load(object sender, EventArgs e)
        {
            //クリア
            dt.Clear();
            OrderInfoGritview.Columns.Clear();
            OrderInfoGritview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金確認 FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;
            OrderInfoGritview.AutoResizeColumns();

            OrderInfoGritview.AllowUserToAddRows = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            OrderInfoGritview.Columns.Clear();
            OrderInfoGritview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金確認 FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID AND 顧客テーブル.ﾌﾘｶﾞﾅ LIKE '%"+ KanaTextbox.Text +"%'", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;
            OrderInfoGritview.AutoResizeColumns();

            OrderInfoGritview.AllowUserToAddRows = false;

            KanaTextbox.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OrderInfoGritview.Rows.Count; i++)
            {
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 注文テーブル SET 入金確認=" + (bool)OrderInfoGritview.Rows[i].Cells[7].Value + " WHERE 注文ID=" + (int)OrderInfoGritview.Rows[i].Cells[0].Value + "";   
                cn.Open();
                cmd.ExecuteNonQuery();               
                cn.Close();
            }
            MessageBox.Show("更新しました", "OICSystem");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (OrderInfoGritview.Rows.Count >= 1)
            {
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM 注文テーブル WHERE 注文ID=" + (int)OrderInfoGritview.CurrentRow.Cells[0].Value + "";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                //クリア
                dt.Clear();
                OrderInfoGritview.Columns.Clear();
                OrderInfoGritview.DataSource = null;

                dt = new DataTable();
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
                da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金確認 FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID", cn);
                da.Fill(dt);
                OrderInfoGritview.DataSource = dt;
                OrderInfoGritview.AutoResizeColumns();

                OrderInfoGritview.AllowUserToAddRows = false;
            }
        }
    }
}
