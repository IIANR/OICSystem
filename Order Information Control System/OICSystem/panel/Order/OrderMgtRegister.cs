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
        static int cnt = 0;

        static int sum = 0;
        double Tax = 0;

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
            ErrMsg.Visible = false;
            TotalLabel.Visible = false;

            dt.Clear();
            OrderRegiDataGridview.Columns.Clear();
            OrderRegiDataGridview.DataSource = null;

            OrderRegiDataGridview.Columns.Add("GoodsName", "商品名");
            OrderRegiDataGridview.Columns.Add("GoodsPrice", "単価");

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
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
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(NumCombo.Text); i++)
            {
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                cn.Open();

                cmd.CommandText = "SELECT * FROM 商品マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();


                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();

                InOrderid = int.Parse(GoodsidTextBox.Text);



                while (rd.Read())
                {
                    db_Orderid = (int)rd.GetValue(0);
                    db_Goodsname = (string)rd.GetValue(1);
                    db_GoodsPrice = (int)rd.GetValue(2);
                    if (db_Orderid == InOrderid)
                    {
                        OrderRegiDataGridview.Rows.Add();
                        OrderRegiDataGridview["GoodsName", cnt].Value = db_Goodsname;
                        OrderRegiDataGridview["GoodsPrice", cnt].Value = db_GoodsPrice;
                        cnt++;
                        sum += db_GoodsPrice;
                    }

                }

                //合計金額を表示
                TotalLabel.Visible = true;
                TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);

                cn.Close();
                //OrderRegiDataGridview.AutoResizeColumns();
            }
            GoodsidTextBox.Text = "";
            NumCombo.SelectedIndex = 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in OrderRegiDataGridview.SelectedRows)
            {
                string Goodsname = (string)OrderRegiDataGridview.CurrentRow.Cells[0].Value;

                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                cn.Open();

                cmd.CommandText = "SELECT * FROM 商品マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();


                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();

                while (rd.Read())
                {
                    db_Goodsname = (string)rd.GetValue(1);
                    db_GoodsPrice = (int)rd.GetValue(2);
                    if (db_Goodsname == Goodsname)
                    {
                        sum -= db_GoodsPrice;
                    }               
                }
                //合計金額再表示
                TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);



                cn.Close();


                if (!item.IsNewRow)
                {
                    OrderRegiDataGridview.Rows.Remove(item);
                    cnt--;
                }
            }

            // 行データがなくなったら、ラベルを非表示
            if (OrderRegiDataGridview.Rows.Count == 1)
            {
                TotalLabel.Text = "";
                TotalLabel.Visible = false;
            }
        }
    }
}
