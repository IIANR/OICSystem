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
        OleDbCommand cmd2 = new OleDbCommand();

        double Tax = 0;

        public OrderMgtInfo()
        {
            InitializeComponent();
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

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            TotalLabel.Visible = true;

            dt.Clear();
            OrderInfoGritview.Columns.Clear();
            OrderInfoGritview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.フラグ,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID AND 顧客テーブル.ﾌﾘｶﾞﾅ LIKE '%" + KanaTextbox.Text + "%' ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;

            OrderInfoGritview.AllowUserToAddRows = false;

            KanaTextbox.Text = "";

            if (OrderInfoGritview.Rows.Count >= 1)
            {
                OrderInfoGritview.Rows[0].Selected = true;

                int sum = 0;
                string GoodsId = "";
                string[] GoodsIdArray = new string[] { };

                GoodsId = (string)OrderInfoGritview.CurrentRow.Cells[2].Value;
                GoodsIdArray = GoodsId.Split(',');

                for (int i = 0; i < GoodsIdArray.Length; i++)
                {
                    OleDbDataAdapter daprice = new OleDbDataAdapter("SELECT 単価 FROM 商品マスタ WHERE 商品ID='" + GoodsIdArray[i].PadLeft(4, '0') + "'", cn);
                    DataTable dtprice = new DataTable();
                    daprice.Fill(dtprice);
                    sum += int.Parse(dtprice.Rows[0][0].ToString());
                    dtprice.Clear();
                }

                TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);
            }
            else
            {
                TotalLabel.Visible = false;
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("更新しますか？", "OICSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < OrderInfoGritview.Rows.Count; i++)
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "UPDATE 注文テーブル SET 入金済み=" + (bool)OrderInfoGritview.Rows[i].Cells[7].Value + " WHERE 注文ID=" + (int)OrderInfoGritview.Rows[i].Cells[0].Value + "";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.Connection = cn;
                    cmd2.CommandText = "UPDATE 注文テーブル SET フラグ='入金済み' WHERE 注文ID=" + (int)OrderInfoGritview.Rows[i].Cells[0].Value + " AND 入金済み=True AND フラグ='入金待ち'";
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                }
                dt = new DataTable();
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

                //データグリッドビューに注文状況を表示
                da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.フラグ,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
                da.Fill(dt);
                OrderInfoGritview.DataSource = dt;

                MessageBox.Show("更新しました", "OICSystem");
            }

            else if (result == DialogResult.No)
            {

            }
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("" + "注文ID" + "" + (int)OrderInfoGritview.CurrentRow.Cells[0].Value + "を取り消しますか？", "OICSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if ((string)OrderInfoGritview.CurrentRow.Cells[6].Value == "入金済み")
                {
                    MessageBox.Show("入金済みの注文は取り消しできません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if ((string)OrderInfoGritview.CurrentRow.Cells[6].Value == "出庫済み")
                {
                    MessageBox.Show("出庫済みの注文は取り消しできません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
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
                        da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.フラグ,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
                        da.Fill(dt);
                        OrderInfoGritview.DataSource = dt;

                        OrderInfoGritview.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("注文がありません");
                    }

                }
            }
        }

        protected void ss()
        { 
        
        }

        private void OrderListBtn_Click(object sender, EventArgs e)
        {
            OrderList f = new OrderList();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void OrderMgtInfo_VisibleChanged(object sender, EventArgs e)
        {
            TotalLabel.Visible = true;
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
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.フラグ,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
            da.Fill(dt);
            OrderInfoGritview.DataSource = dt;

            OrderInfoGritview.AllowUserToAddRows = false;
            OrderInfoGritview.Columns[0].ReadOnly = true;
            OrderInfoGritview.Columns[1].ReadOnly = true;
            OrderInfoGritview.Columns[2].ReadOnly = true;
            OrderInfoGritview.Columns[3].ReadOnly = true;
            OrderInfoGritview.Columns[4].ReadOnly = true;
            OrderInfoGritview.Columns[5].ReadOnly = true;
            OrderInfoGritview.Columns[6].ReadOnly = true;
            OrderInfoGritview.CurrentCell = null;
        }

        private void OrderInfoGritview_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //チェックボックスの列番号は11で、かつチェック状態が変わったら
            if (OrderInfoGritview.CurrentCellAddress.X == 7 && OrderInfoGritview.IsCurrentCellDirty == true)
            {
                //dataGridViewをコミットする
                OrderInfoGritview.CommitEdit(DataGridViewDataErrorContexts.Commit);

                //変更後のチェック状態
                bool bl = (bool)OrderInfoGritview[OrderInfoGritview.CurrentCellAddress.X, OrderInfoGritview.CurrentCellAddress.Y].Value;
                // MessageBox.Show(bl.ToString());

                //変更後のチェック状態がfalseなら（trueからfalseに変わったら）
                if (bl == false)
                {
                    if ((string)OrderInfoGritview.CurrentRow.Cells[6].Value != "入金待ち")
                    {
                        //MessageBox.Show("確定した入金は取り消せませんよ？");
                        OrderInfoGritview[OrderInfoGritview.CurrentCellAddress.X, OrderInfoGritview.CurrentCellAddress.Y].Value = true;

                        TotalLabel.Visible = true;
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
                        da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID,注文テーブル.注文日,注文テーブル.商品ID,顧客テーブル.名前 AS 顧客名,顧客テーブル.ﾌﾘｶﾞﾅ AS ﾌﾘｶﾞﾅ,従業員マスタ.名前 AS 従業員名,注文テーブル.フラグ,注文テーブル.入金済み FROM 注文テーブル,顧客テーブル,従業員マスタ WHERE 注文テーブル.顧客ID=顧客テーブル.顧客ID AND 注文テーブル.従業員ID=従業員マスタ.従業員ID ORDER BY 注文テーブル.入金済み=True,注文テーブル.注文ID", cn);
                        da.Fill(dt);
                        OrderInfoGritview.DataSource = dt;

                        OrderInfoGritview.AllowUserToAddRows = false;
                        OrderInfoGritview.Columns[0].ReadOnly = true;
                        OrderInfoGritview.Columns[1].ReadOnly = true;
                        OrderInfoGritview.Columns[2].ReadOnly = true;
                        OrderInfoGritview.Columns[3].ReadOnly = true;
                        OrderInfoGritview.Columns[4].ReadOnly = true;
                        OrderInfoGritview.Columns[5].ReadOnly = true;
                        OrderInfoGritview.Columns[6].ReadOnly = true;

                        OrderInfoGritview.CurrentCell = null;
                    }
                }
            }
        }

        private void OrderInfoGritview_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string GoodsId = "";
            string[] GoodsIdArray = new string[] { };

            GoodsId = (string)OrderInfoGritview.CurrentRow.Cells[2].Value;
            GoodsIdArray = GoodsId.Split(',');

            for (int i = 0; i < GoodsIdArray.Length; i++)
            {
                OleDbDataAdapter daprice = new OleDbDataAdapter("SELECT 単価 FROM 商品マスタ WHERE 商品ID='" + GoodsIdArray[i].PadLeft(4, '0') + "'", cn);
                DataTable dtprice = new DataTable();
                daprice.Fill(dtprice);
                sum += int.Parse(dtprice.Rows[0][0].ToString());
                dtprice.Clear();
            }
            TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);
        }
    }
}
