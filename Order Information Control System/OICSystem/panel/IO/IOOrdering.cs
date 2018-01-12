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
    public partial class IOOrdering : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        int db_Inputid = 0;

        public IOOrdering()
        {
            InitializeComponent();
        }

        private void IOOrdering_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.InputNameCombo;
            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

            //データグリッドビューに表示
            da = new OleDbDataAdapter("SELECT 商品マスタ.商品ID, 商品マスタ.商品名,商品マスタ.仕入れ値,商品マスタ.発注数 + 商品マスタ.安全在庫数 AS 発注数,在庫テーブル.在庫数 FROM 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID WHERE 在庫テーブル.在庫数 < 商品マスタ.安全在庫数 AND 商品マスタ.フラグ <> '発注済み'; ", cn);
            da.Fill(dt);
            OrderingGoodsDataGrid.DataSource = dt;

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT 入庫先名 FROM 入庫先マスタ";

            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                InputNameCombo.Items.Add(rd["入庫先名"].ToString());
            }
            cn.Close();

            OrderingGoodsDataGrid.AllowUserToAddRows = false;
            OrderingGoodsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void InputNameCombo_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "SELECT * FROM 入庫先マスタ";
            cmd.Connection = cn;
            OleDbDataReader rd = cmd.ExecuteReader();
            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            while (rd.Read())
            {
                if (InputNameCombo.Text == (string)rd.GetValue(1))
                {
                    db_Inputid = int.Parse((string)rd.GetValue(0).ToString());
                    PosTextbox.Text = (string)rd.GetValue(2).ToString();
                    Addres1Textbox.Text = (string)rd.GetValue(3).ToString();
                    Addres2Textbox.Text = (string)rd.GetValue(4).ToString();
                    TelTextBox.Text = (string)rd.GetValue(5).ToString();
                }
            }
            cn.Close();
        }

        private void OrderingGoodsDataGrid_Click(object sender, EventArgs e)
        {
            if (OrderingGoodsDataGrid.Rows.Count > 0)
            {
                GoodsidTextBox.Text = (string)OrderingGoodsDataGrid.CurrentRow.Cells[0].Value;
                OrderingPayTextbox.Text = (string)OrderingGoodsDataGrid.CurrentRow.Cells[2].Value.ToString();
                InputNumTextbox.Text = (string)OrderingGoodsDataGrid.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void OrderingCompBtn_Click(object sender, EventArgs e)
        {
            if (InputNameCombo.Text == null || InputNameCombo.Text == "")
            {
                MessageBox.Show("入庫先を選択してください");
            }
            else if (GoodsidTextBox.Text == null || GoodsidTextBox.Text == "")
            {
                MessageBox.Show("商品IDを入力してください");
            }
            else if (OrderingPayTextbox.Text == null || OrderingPayTextbox.Text == "")
            {
                MessageBox.Show("仕入れ値を入力してください");
            }
            else if (InputNumTextbox.Text == null || InputNumTextbox.Text == "")
            {
                MessageBox.Show("発注数を入力してください");
            }

            else
            {
                DateTime dtNow = DateTime.Now;

                int total = 0;
                int Pay = 0;
                int num = 0;

                Pay = int.Parse(InputNumTextbox.Text);
                num = int.Parse(OrderingPayTextbox.Text);
                total = Pay * num;

                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO 発注テーブル (発注日,商品ID,発注数量,入庫先ID,合計金額,フラグ)" + "VALUES (@date,@goodsid,@num,@inputid,@total,@flag)";
                OleDbParameter prdate = new OleDbParameter("@date", dtNow.ToString("MM/dd"));
                cmd.Parameters.Add(prdate);
                OleDbParameter prgoodsid = new OleDbParameter("goodsid", GoodsidTextBox.Text);
                cmd.Parameters.Add(prgoodsid);
                OleDbParameter prnum = new OleDbParameter("@num", InputNumTextbox.Text);
                cmd.Parameters.Add(prnum);
                OleDbParameter prinputid = new OleDbParameter("@inputid", db_Inputid);
                cmd.Parameters.Add(prinputid);
                OleDbParameter prtotal = new OleDbParameter("@total", total);
                cmd.Parameters.Add(prtotal);
                OleDbParameter prflag = new OleDbParameter("@flag", "発注書未作成");
                cmd.Parameters.Add(prflag);

                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = cn;
                cmd2.CommandText = "UPDATE 商品マスタ SET フラグ = '発注済み' WHERE 商品ID='" + GoodsidTextBox.Text + "'";

                cn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cn.Close();

                dt = new DataTable();
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

                //データグリッドビューに表示
                da = new OleDbDataAdapter("SELECT 商品マスタ.商品ID, 商品マスタ.商品名,商品マスタ.仕入れ値,商品マスタ.発注数 + 商品マスタ.安全在庫数 AS 発注数,在庫テーブル.在庫数 FROM 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID WHERE 在庫テーブル.在庫数 < 商品マスタ.安全在庫数 AND 商品マスタ.フラグ <> '発注済み'; ", cn);
                da.Fill(dt);
                OrderingGoodsDataGrid.DataSource = dt;

                OrderingGoodsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                cmd.Parameters.Clear();
                cmd2.Parameters.Clear();

                GoodsidTextBox.Text = "";
                OrderingPayTextbox.Text = "";
                InputNumTextbox.Text = "";
            }
        }

        private void OrderingPrintBtn_Click(object sender, EventArgs e)
        {
            
            OrderingList f = new OrderingList();
            f.ShowDialog(this);
            f.Dispose();
            
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

            ////データグリッドビューに表示
            //da = new OleDbDataAdapter("SELECT 商品マスタ.商品ID, 商品マスタ.商品名,商品マスタ.仕入れ値,商品マスタ.発注数 + 商品マスタ.安全在庫数 AS 発注数,在庫テーブル.在庫数 FROM 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID WHERE 在庫テーブル.在庫数 < 商品マスタ.安全在庫数 AND 商品マスタ.フラグ <> '発注済み'; ", cn);
            //da.Fill(dt);
            //OrderingGoodsDataGrid.DataSource = dt;

            InputNameCombo.Items.Clear();
            IOOrdering_Load(null, EventArgs.Empty);

            TelTextBox.Text = "";
            PosTextbox.Text = "";
            Addres1Textbox.Text = "";
            Addres2Textbox.Text = "";
            Addres2Textbox.Text = "";
            GoodsidTextBox.Text = "";
            OrderingPayTextbox.Text = "";
            InputNumTextbox.Text = "";
        }

        private void InputNumTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }
    }
}
