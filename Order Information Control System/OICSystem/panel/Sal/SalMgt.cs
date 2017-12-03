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
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();

        DataSet dsorder = new DataSet();
        DataSet dsgoods = new DataSet();

		DateTime time;
		string name;

		public SalMgt()
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


        public void button5_Click(object sender, EventArgs e)
        {
            //日付
            string DS1;
            string DS2;

			//
			//
			// Valueプロパティの値をそのまま表示します
			//
			DS1 = DateSet1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(DS1);
            DS2 = DateSet2.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(DS2);

			cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";

			cn.Open();
			
			cmd.CommandText = "SELECT 注文テーブル.注文日,商品マスタ.商品名 FROM 注文テーブル,商品マスタ where 注文テーブル.商品ID=商品マスタ.商品ID  BETWEEN 'DS1' AND 'DS2'";
			cmd.Connection = cn;

			OleDbDataReader rd = cmd.ExecuteReader();

			dt = CreateSchemaDataTable(rd);
			DataRow row = dt.NewRow();

			while (rd.Read())
			{
				time = (DateTime)rd.GetValue(0);
				name = (String)rd.GetValue(1);
			}

			label3.Text = time.ToString();
			label4.Text = name;

			cn.Close();

			//cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";

			//cn.Open();

			//cmd.CommandText = "SELECT * FROM 注文テーブル";
			//cmd.Connection = cn;

			//OleDbDataReader rd = cmd.ExecuteReader();

			//dt = CreateSchemaDataTable(rd);
			//DataRow row = dt.NewRow();

			//// 注文テーブルの定義
			//dsorder.Tables.Add("Order");
			//dsorder.Tables["Order"].Columns.Add("date", typeof(DateTime));
			//dsorder.Tables["Order"].Columns.Add("id", typeof(String));
			//dsorder.Tables["Order"].Columns.Add("authority", typeof(bool));

			//while (rd.Read())
			//{
			//    row["date"] = (DateTime)rd.GetValue(1);
			//    row["id"] = (string)rd.GetValue(2);
			//    row["authority"] = (bool)rd.GetBoolean(6);
			//}

			//cn.Close();

			//cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";

			//cn.Open();

			//cmd.CommandText = "SELECT * FROM 商品マスタ";
			//cmd.Connection = cn;



			//dt = CreateSchemaDataTable(rd);


			////商品テーブルの定義
			//dsgoods.Tables.Add("Goods");
			//dsgoods.Tables["Goods"].Columns.Add("id", typeof(String));
			//dsgoods.Tables["Goods"].Columns.Add("name", typeof(String));
			//dsgoods.Tables["Goods"].Columns.Add("price", typeof(int));

			//while (rd.Read())
			//{
			//    row["id"] = (string)rd.GetValue(0);
			//    row["name"] = (string)rd.GetValue(1);
			//    row["price"] = (int)rd.GetValue(2);
			//}

			//cn.Close();

			//dsgoods.Relations.Add("GoodsOrder",
			//dsorder.Tables["Order"].Columns["goodsID"],
			//dsgoods.Tables["Goods"].Columns["goodsID"]);

			//foreach (DataRow Goods in dsgoods.Tables["Goods"].Rows)
			//{
			//    Console.WriteLine("Order who work for {0}:", Goods["name"]);
			//    foreach (DataRow emps in Goods.GetChildRows("GoodsOrder"))
			//    {
			//        Console.WriteLine("\t{0}", emps["name"]);
			//    }
			//}
			//foreach (DataRow Order in dsorder.Tables["Orders"].Rows)
			//{
			//    DataRow Goods = Order.GetParentRow("GoodsOrder");
			//    Console.WriteLine("{0} belongs to {1}.", Order["name"], Goods["name"]);
			//}

		}




	}
}
