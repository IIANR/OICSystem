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
    public partial class OrderMgtRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();

        int InOrderid = 0;
        int db_Orderid = 0;
        string db_Goodsname = "";
        int db_GoodsPrice = 0;


        public OrderMgtRegister()
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

        public void OrderMgtRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //データテーブルクリア
            dt.Clear();
            OrderRegiDataGridview.Columns.Clear();
            OrderRegiDataGridview.DataSource = null;

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 商品マスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();
            OrderRegiDataGridview.Columns.Add("GoodsName", "商品名");
            OrderRegiDataGridview.Columns.Add("GoodsPrice", "単価");

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            InOrderid = int.Parse(GoodsidTextBox.Text);

            int cnt = 0;

            while (rd.Read())
            {
                db_Orderid = (int)rd.GetValue(0);
                db_Goodsname = (string)rd.GetValue(1);
                db_GoodsPrice = (int)rd.GetValue(2);
                if (db_Orderid == InOrderid)
                {
                    OrderRegiDataGridview.Rows.Add();
                    OrderRegiDataGridview["GoodsName",cnt].Value = db_Goodsname;
                    OrderRegiDataGridview["GoodsPrice", cnt].Value = db_GoodsPrice;
                }

            }

            cn.Close();
            OrderRegiDataGridview.AutoResizeColumns();
        }
    }
}
