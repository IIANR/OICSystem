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
            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

            //データグリッドビューに表示
            da = new OleDbDataAdapter("SELECT 商品マスタ.商品ID, 商品マスタ.商品名,商品マスタ.発注数 FROM 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID WHERE 在庫テーブル.在庫数 < 商品マスタ.安全在庫数; ", cn);
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
            cmd.CommandText = "SELECT 入庫先ID,入庫先名,電話番号 FROM 入庫先マスタ";
            cmd.Connection = cn;
            OleDbDataReader rd = cmd.ExecuteReader();
            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            while (rd.Read())
            {
                if (InputNameCombo.Text == (string)rd.GetValue(1))
                {
                    db_Inputid = int.Parse((string)rd.GetValue(0).ToString());
                    TelTextBox.Text = (string)rd.GetValue(2).ToString();
                }
            }
            cn.Close();
        }

        private void OrderingGoodsDataGrid_Click(object sender, EventArgs e)
        {
            GoodsidTextBox.Text = (string)OrderingGoodsDataGrid.CurrentRow.Cells[0].Value;
            OrderingNumTextbox.Text = (string)OrderingGoodsDataGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void OrderingCompBtn_Click(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;

            int total = 0;

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 発注テーブル (発注日,商品ID,発注数量,入庫先ID,合計金額)" + "VALUES (@date,@goodsid,@num,@inputid,@total)";
            OleDbParameter prdate = new OleDbParameter("@date", dtNow.ToString("MM/dd"));
            cmd.Parameters.Add(prdate);
            OleDbParameter prgoodsid = new OleDbParameter("goodsid", GoodsidTextBox.Text);
            cmd.Parameters.Add(prgoodsid);
            OleDbParameter prnum = new OleDbParameter("@num", OrderingNumTextbox.Text);
            cmd.Parameters.Add(prnum);
            OleDbParameter prinputid = new OleDbParameter("@inputid", db_Inputid);
            cmd.Parameters.Add(prinputid);
            OleDbParameter prtotal = new OleDbParameter("@total",);
            cmd.Parameters.Add(prtotal);


            //OleDbParameter prname = new OleDbParameter("@name", NameTextbox.Text);
            //cmd.Parameters.Add(prname);
            

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
