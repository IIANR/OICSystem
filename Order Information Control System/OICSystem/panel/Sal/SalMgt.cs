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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class SalMgt : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet sal = new DataSet();

		string ordercode="";

		public SalMgt()
        {
            InitializeComponent();
        }

        protected DataTable GetDataOrder()
        {
            //注文テーブルから注文日,商品ID,入金済みを注文日順に取り出す
            OleDbConnection cn = new OleDbConnection("Provider=microsoft.ace.oledb.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT 注文日,商品ID FROM 注文テーブル WHERE 入金済み in (true) ORDER BY 注文日", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable order = new DataTable();   //データテーブルオブジェクトを作成
            DataRow dtRow;

			

            order.Columns.Add("注文日", Type.GetType("System.DateTime"));
            order.Columns.Add("商品ID", Type.GetType("System.String"));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtRow = order.NewRow();
                dtRow["注文日"] = dt.Rows[i][0]; 　　　　 //DBから取得したdtの注文日を示す行の行番号と列番号
                //dtRow["商品ID"] = dt.Rows[i][1];          //DBから取得したdtの商品IDを示す行の行番号と列番号
				ordercode+=dt.Rows[i][1];
				order.Rows.Add(dtRow);
            }
			
			//Msg.Text = ordercode;
			return dt;    //データテーブルを返す
        }

        protected  DataTable GetDataGoods()
        {
            //Goodsテーブルから商品ID,商品名,単価を商品ID順に取り出す
            OleDbConnection cn = new OleDbConnection("Provider=microsoft.ace.oledb.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT 商品ID,商品名,単価 FROM 商品マスタ ORDER BY 商品ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataTable goods = new DataTable();   //データテーブルオブジェクトを作成
            DataRow dtRow;

            goods.Columns.Add("商品ID", Type.GetType("System.String"));
            goods.Columns.Add("商品名", Type.GetType("System.String"));
            goods.Columns.Add("単価", Type.GetType("System.Double"));

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				dtRow = goods.NewRow();
				dtRow["商品ID"] = dt.Rows[i][0];      //DBから取得したdtの商品IDを示す行の行番号と列番号
				dtRow["商品名"] = dt.Rows[i][1];  //DBから取得したdtの商品名を示す行の行番号と列番号
				dtRow["単価"] = dt.Rows[i][2];        //DBから取得したdtの単価を示す行の行番号と列番号
				goods.Rows.Add(dtRow);
			}
			return dt;    //データテーブルを返す
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable goods = GetDataGoods();     //DBから取り出したデータを取得して設定
            chart1.Series.Clear();
            chart1.Titles.Add("商品別の単価");
            chart1.Series.Add("商品名");
            chart1.Series.Add("単価");


            chart1.Series["商品名"].ChartType = SeriesChartType.Column; //Column
            chart1.Series["単価"].ChartType = SeriesChartType.Column;       //Column
            chart1.Series["単価"].IsValueShownAsLabel = true;

            chart1.DataSource = goods;         //チャートに表示するデータテーブルを設定
            chart1.Series["単価"].XValueMember = goods.Columns["商品名"].ColumnName;
            chart1.Series["単価"].YValueMembers = goods.Columns["単価"].ColumnName;
            //chart1.Legends.Add("legend");   //凡例の設定
            chart1.DataBind();　　　//データバインド
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
			// DataTable order = GetDataOrder();
			// DataTable goods = GetDataGoods();

			string DSCheck=DateStart.Text;
			string DECheck = DateEnd.Text;
			
			OleDbConnection ocn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
			ocn.Open();

			OleDbCommand ocmd = new OleDbCommand();                 //日付指定　＃-'

			if (DateStart.Text == "    /  /" && DateEnd.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 入金済み in (true) ORDER BY 注文日";
				Msg.Text = "全データ";
			}
			else if (DateEnd.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateStart.Text + "#  AND 入金済み in (true) ORDER BY 注文日";
				Msg.Text = "";
			}
			else if (DateStart.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateEnd.Text + "# AND 入金済み in (true) ORDER BY 注文日";
			}
			else
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateStart.Text + "# and #" + DateEnd.Text + "# AND 入金済み in (true) ORDER BY 注文日";
			}
			ocmd.Connection = ocn;

			OleDbDataAdapter oda = new OleDbDataAdapter();
			oda.SelectCommand = ocmd;

			DataSet ds = new DataSet();
			oda.Fill(ds);
		
			dataGridView1.DataSource = ds.Tables[0];
			
		}

		private void DateSelect_Click(object sender, EventArgs e)
		{
			OleDbConnection ocn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
			ocn.Open();

			string DSCheck = DateStart.Text;
			string DECheck = DateEnd.Text;

			OleDbCommand ocmd = new OleDbCommand();                 //日付指定　＃-'

			if (DateStart.Text == "    /  /" && DateEnd.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 入金済み in (true) ORDER BY 注文日";
				Msg.Text = "全てのデータ";
			}
			else if (DateEnd.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateStart.Text + "#  AND 入金済み in (true) ORDER BY 注文日";
				Msg.Text = DSCheck+"のデータ";
			}
			else if (DateStart.Text == "    /  /")
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateEnd.Text + "# AND 入金済み in (true) ORDER BY 注文日";
				Msg.Text = DECheck + "のデータ";
			}
			else
			{
				ocmd.CommandText = "SELECT 注文日,商品ID FROM 注文テーブル WHERE 注文日 Between #" + DateStart.Text + "# and #" + DateEnd.Text + "# AND 入金済み in (true) ORDER BY 注文日";
				Msg.Text = DSCheck + "～"+DECheck+"のデータ";
			}
			ocmd.Connection = ocn;

			OleDbDataAdapter oda = new OleDbDataAdapter();
			oda.SelectCommand = ocmd;

			DataSet ds = new DataSet();
			oda.Fill(ds);

			dataGridView1.DataSource = ds.Tables[0];
		}

		private void radioButton2_Click(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			DataTable dt = ds.Tables.Add("Computer");
			DataRow dr;

			dt.Columns.Add("メーカー");
			dt.Columns.Add("パソコン名");

			dr = dt.NewRow();
			dr["メーカー"] = "NEC";
			dr["パソコン名"] = "ValueStar";
			dt.Rows.Add(dr);

			dr = dt.NewRow();
			dr["メーカー"] = "SONY";
			dr["パソコン名"] = "VAIO";
			dt.Rows.Add(dr);

			dr = dt.NewRow();
			dr["メーカー"] = "DELL";
			dr["パソコン名"] = "Precision";
			dt.Rows.Add(dr);

			dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "Computer";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable order = GetDataOrder();
			//DataTable goods = GetDataGoods();
			DataSet sal = new DataSet();

			//Goodsテーブルから商品ID,商品名,単価を商品ID順に取り出す
			OleDbConnection cn = new OleDbConnection("Provider=microsoft.ace.oledb.12.0;" + @"Data Source=.\DB\IM2.accdb;");
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT 商品ID,商品名,単価 FROM 商品マスタ ORDER BY 商品ID", cn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			DataTable goods = sal.Tables.Add("goods");
			DataRow dtRow;

			var count = new int[dt.Rows.Count];
			string price;
			int sum;
			int total=0;

			goods.Columns.Add("商品ID", Type.GetType("System.String"));
			goods.Columns.Add("商品名", Type.GetType("System.String"));
			goods.Columns.Add("単価", Type.GetType("System.Double"));
			goods.Columns.Add("数量", Type.GetType("System.Double"));
			goods.Columns.Add("売上", Type.GetType("System.Double"));


			//配列の初期化
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				count[i] = 0;
			}
			//数量計算
			for (int i = 0; i < ordercode.Length; i++)
			{
				if (ordercode.Substring(i, 1) != ",")
				{
					count[int.Parse(ordercode.Substring(i, 1)) - 1] += 1;
				}
			}

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				dtRow = goods.NewRow();
				dtRow["商品ID"] = dt.Rows[i][0];      //DBから取得したdtの商品IDを示す行の行番号と列番号
				dtRow["商品名"] = dt.Rows[i][1];  //DBから取得したdtの商品名を示す行の行番号と列番号
				dtRow["単価"] = dt.Rows[i][2];        //DBから取得したdtの単価を示す行の行番号と列番号   
				price = dt.Rows[i][2].ToString();
				sum = int.Parse(price);
				dtRow["数量"] = count[i];
				total += sum * count[i];
				dtRow["売上"] = sum * count[i];
				goods.Rows.Add(dtRow);
			}

			Console.WriteLine(count[0]);

			dataGridView1.DataSource = sal;
			dataGridView1.DataMember = "goods";

			chart1.Series.Clear();
			chart1.Titles.Add("商品別の売上");
			chart1.Series.Add("商品名");
			chart1.Series.Add("売上");


			chart1.Series["商品名"].ChartType = SeriesChartType.Column; //Column
			chart1.Series["売上"].ChartType = SeriesChartType.Column;       //Column
			chart1.Series["売上"].IsValueShownAsLabel = true;

			chart1.DataSource = goods;         //チャートに表示するデータテーブルを設定
			chart1.Series["売上"].XValueMember = goods.Columns["商品名"].ColumnName;
			chart1.Series["売上"].YValueMembers = goods.Columns["売上"].ColumnName;
			//chart1.Legends.Add("legend");   //凡例の設定
			chart1.DataBind();   //データバインド
			Msg.Text = total.ToString();

		}
	}
}
