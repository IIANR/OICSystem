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
    public partial class SalMgt : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        DataTable order = new DataTable();
        DataTable goods = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet sal = new DataSet();

        //DateTime time;
        //string name;

		public SalMgt()
        {
            InitializeComponent();
        }


        //注文テーブルのデータコピー  ACCESS→order(DT)
		private DataTable CreateSchemaDataTableOrder(OleDbDataReader reader)
        {
            if (reader == null) { return null; }
            if (reader.IsClosed) { return null; }

            DataTable schema = reader.GetSchemaTable();
            DataTable order = new DataTable();

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

                order.Columns.Add(col);
            }
            return order;
        }
        //商品マスタのデータコピー  ACCESS→goods(DT)
        private DataTable CreateSchemaDataTableGoods(OleDbDataReader reader)
        {
            if (reader == null) { return null; }
            if (reader.IsClosed) { return null; }

            DataTable schema = reader.GetSchemaTable();
            DataTable Goods = new DataTable();

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

                Goods.Columns.Add(col);
            }
            return Goods;
        }


        public void button5_Click(object sender, EventArgs e)
        {
            //日付
            string DS1;
            string DS2;

			//
			//
			// Valueプロパティの値をそのまま表示します
			//
			DS1 = DateSet1.Value.ToString("yyyy/MM/dd");
            Console.WriteLine(DS1);
            DS2 = DateSet2.Value.ToString("yyyy/MM/dd");
            Console.WriteLine(DS2);


            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();
            //注文テーブルをACCESSから引用
            cmd.CommandText = "SELECT * FROM 注文テーブル ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();

            order = CreateSchemaDataTableOrder(rd);
            DataRow row1 = order.NewRow();

            cn.Close();
            //商品マスタをACCESSから引用
            cn.Open();

            cmd.CommandText = "SELECT * FROM 商品マスタ　";
            cmd.Connection = cn;

            goods = CreateSchemaDataTableGoods(rd);
            DataRow row2 = goods.NewRow();

            cn.Close();

		}




	}
}
