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

        double Tax = 0;

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

            //税率マスタから税率を取得          
            cn.Open();

            cmd.CommandText = "SELECT * FROM 税率マスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();


            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            while (rd.Read())
            {
                Tax = (double)rd.GetValue(0);
            }

            cn.Close();

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

            //データグリッドビューに注文状況を表示
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;

            OrderInfoGritview.AllowUserToAddRows = false;
        }

        private DataTable CreateSchemaDataTable(OleDbDataReader reader)
        {
            if (reader == null) { return null; }
            if (reader.IsClosed) { return null; }

            DataTable schema = reader.GetSchemaTable();
            DataTable dt = new DataTable();

            foreach (DataRow row in schema.Rows)
            {
                // Column情報を追加してください。
                DataColumn col = new DataColumn();
                col.ColumnName = row["ColumnName"].ToString();
                col.DataType = Type.GetType(row["DataType"].ToString());

                if (col.DataType.Equals(typeof(string)))
                {
                    col.MaxLength = (int)row["ColumnSize"];
                }

                dt.Columns.Add(col);
            }
            return dt;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            OrderInfoGritview.Columns.Clear();
            OrderInfoGritview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID AND 顧客テーブル.ﾌﾘｶﾞﾅ LIKE '%"+ KanaTextbox.Text + "%' ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;

            OrderInfoGritview.AllowUserToAddRows = false;

            KanaTextbox.Text = "";

            OrderInfoGritview.Rows[0].Selected = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OrderInfoGritview.Rows.Count; i++)
            {
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 注文テーブル SET 入金済み=" + (bool)OrderInfoGritview.Rows[i].Cells[7].Value + " WHERE 注文ID=" + (int)OrderInfoGritview.Rows[i].Cells[0].Value + "";   
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
                //削除する注文の商品IDを取得し在庫数を増やす
                string GoodsId = (string)OrderInfoGritview.CurrentRow.Cells[2].Value;
                string[] GoodsIdArray = GoodsId.Split(',');
                for (int i = 0; i < GoodsIdArray.Length; i++)
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "UPDATE 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID SET 在庫テーブル.在庫数 = 在庫テーブル.在庫数 + 1 WHERE 商品マスタ.商品ID = '" + GoodsIdArray[i] + "'";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                //選択されている行を削除
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM 注文テーブル WHERE 注文ID=" + (int)OrderInfoGritview.CurrentRow.Cells[0].Value + "";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                //クリア
                dt.Clear();
                OrderInfoGritview.Columns.Clear();
                OrderInfoGritview.DataSource = null;


                //再表示
                dt = new DataTable();
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
                da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.備考,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
                da.Fill(dt);
                OrderInfoGritview.DataSource = dt;

                OrderInfoGritview.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("注文がありません");
            }
        }

        private void OrderInfoGritview_SelectionChanged(object sender, EventArgs e)
        {
            int sum = 0;
            string db_Goodsid = "";
            int db_GoodsPrice = 0;

            string GoodsId = (string)OrderInfoGritview.CurrentRow.Cells[2].Value;
            string[] GoodsIdArray = GoodsId.Split(',');

            for (int i = 0; i < GoodsIdArray.Length; i++)
            {
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
                cn.Open();

                cmd.CommandText = "SELECT * FROM 商品マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();

                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();

                while (rd.Read())
                {
                    db_Goodsid = (string)rd.GetValue(0);
                    db_GoodsPrice = (int)rd.GetValue(2);
                    if (db_Goodsid == GoodsIdArray[i])
                    {
                        sum += db_GoodsPrice;
                    }

                }
            }
            cn.Close();


            TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);
        }
    }
}
