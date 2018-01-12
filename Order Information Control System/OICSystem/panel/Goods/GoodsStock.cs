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

namespace WindowsFormsApplication1.panel.Goods
{
    public partial class GoodsStock : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        string GSname;
        string GStname;

        public GoodsStock()
        {
            InitializeComponent();
        }

        private void GoodsStock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.GoodsStockTBox;
            dataload();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            GoodsStockDataGridView.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            GoodsStockDataGridView.DataSource = dt;
            GoodsStockDataGridView.AutoResizeColumns();
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

        private void GoodsStockDisBtn_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 商品マスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();




            while (rd.Read())
            {

                GSname = (string)rd.GetValue(1);  //データベースの「商品名」
                GStname = GoodsStockTBox.Text;    //textboxの「商品名」


                if (GSname.Contains(GStname))     //Containsは部分検索
                {
                    selectfunc("SELECT Z.商品ID,S.商品名,Z.在庫数,S.安全在庫数 FROM 在庫テーブル Z,商品マスタ S WHERE Z.商品ID=S.商品ID AND 商品名 LIKE '%" + GoodsStockTBox.Text + "%' AND S.フラグ <> '販売中止'");
                    GoodsStockDisLbl.Text = "";
                    break;
                }



                GoodsStockDisLbl.Text = "その情報は登録されていません";
            }

            GoodsStockTBox.Text = "";

            cn.Close();

        }


        private void dataload()
        {
            GoodsStockDataGridView.Columns.Clear();
            GoodsStockDataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT Z.商品ID,S.商品名,Z.在庫数,S.安全在庫数 FROM 在庫テーブル Z,商品マスタ S WHERE Z.商品ID=S.商品ID AND S.フラグ <> '販売中止' ORDER BY Z.商品ID ASC", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            GoodsStockDataGridView.DataSource = dt;
            GoodsStockDataGridView.AutoResizeColumns();

            GoodsStockDataGridView.AllowUserToAddRows = false;      //datagridviewの最下行を消す
        }
    }
}
