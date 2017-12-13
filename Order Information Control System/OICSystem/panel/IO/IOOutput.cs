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

namespace WindowsFormsApplication1.panel.IO
{
    public partial class IOOutput : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public IOOutput()
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

        private void IOOutput_Load(object sender, EventArgs e)
        {
            ErrMsg.Visible = false;

            //クリア
            dt.Clear();
            OutputDataGrid.Columns.Clear();
            OutputDataGrid.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 出庫テーブル.出庫ID, 出庫テーブル.注文ID, 出庫テーブル.出庫日, 顧客テーブル.名前 AS 顧客名, 注文テーブル.[フラグ] FROM 顧客テーブル INNER JOIN(注文テーブル INNER JOIN 出庫テーブル ON 注文テーブル.注文ID = 出庫テーブル.注文ID) ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID ORDER BY 出庫テーブル.出庫ID", cn);
            da.Fill(dt);
            OutputDataGrid.DataSource = dt;
            OutputDataGrid.AllowUserToAddRows = false;
        }

        private void OutputBtn_Click_1(object sender, EventArgs e)
        {
            ErrMsg.Visible = false;
            if (OrderidTextbox.Text == null || OrderidTextbox.Text == "")
            {
                ErrMsg.Text = "※注文IDを入力してください";
                ErrMsg.Visible = true;
            }
            else
            {
                DateTime dtNow = DateTime.Now;
                int flag = 0;

                dt = new DataTable();
                cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

                cn.Open();
                cmd.CommandText = "SELECT 注文ID,入金済み FROM 注文テーブル";
                cmd.Connection = cn;
                OleDbDataReader rd = cmd.ExecuteReader();

                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();

                int db_Orderid = 0;
                bool db_Pay;

                while (rd.Read())
                {
                    db_Orderid = (int)rd.GetValue(0);
                    db_Pay = (bool)rd.GetValue(1);
                    if (db_Orderid == int.Parse(OrderidTextbox.Text))
                    {
                        flag = 1;
                        if (db_Pay != true)
                        {
                            flag = 3;
                        }
                    }
                }
                cn.Close();

                cn.Open();
                cmd.CommandText = "SELECT 注文ID FROM 出庫テーブル";
                cmd.Connection = cn;
                OleDbDataReader rd2 = cmd.ExecuteReader();

                dt = CreateSchemaDataTable(rd2);
                DataRow row2 = dt.NewRow();

                while (rd2.Read())
                {
                    db_Orderid = (int)rd2.GetValue(0);
                    if (db_Orderid == int.Parse(OrderidTextbox.Text))
                    {
                        flag = 2;
                    }
                }
                cn.Close();

                if (flag == 1)
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = cn;
                    cmd2.CommandText = "INSERT INTO 出庫テーブル (注文ID,出庫日)" + "VALUES (@orderid,@outputdate) ";
                    OleDbParameter prorderid = new OleDbParameter("@orderid", OrderidTextbox.Text);
                    cmd2.Parameters.Add(prorderid);
                    OleDbParameter proutputdate = new OleDbParameter("@outputdate", dtNow.ToString("MM/dd"));
                    cmd2.Parameters.Add(proutputdate);


                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = cn;
                    cmd3.CommandText = "UPDATE 注文テーブル SET フラグ='出庫済み' WHERE 注文ID=" + OrderidTextbox.Text + " AND 入金済み=True";
                    try
                    {
                        cn.Open();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "OICSystem");
                    }
                    cn.Close();

                    //クリア
                    dt.Clear();
                    OutputDataGrid.Columns.Clear();
                    OutputDataGrid.DataSource = null;

                    dt = new DataTable();
                    cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
                    da = new OleDbDataAdapter("SELECT 出庫テーブル.出庫ID, 出庫テーブル.注文ID, 出庫テーブル.出庫日, 顧客テーブル.名前 AS 顧客名, 注文テーブル.[フラグ] FROM 顧客テーブル INNER JOIN(注文テーブル INNER JOIN 出庫テーブル ON 注文テーブル.注文ID = 出庫テーブル.注文ID) ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID ORDER BY 出庫テーブル.出庫ID", cn);
                    da.Fill(dt);
                    OutputDataGrid.DataSource = dt;
                    OutputDataGrid.AllowUserToAddRows = false;

                    cmd.Parameters.Clear();
                    cmd2.Parameters.Clear();
                    cmd3.Parameters.Clear();
                    OrderidTextbox.Text = "";
                }
                else if (flag == 0)
                {
                    ErrMsg.Text = "※存在しない注文IDです";
                    ErrMsg.Visible = true;
                    OrderidTextbox.Text = "";
                }
                else if (flag == 2)
                {
                    ErrMsg.Text = "※すでに登録されています";
                    ErrMsg.Visible = true;
                    OrderidTextbox.Text = "";
                }
                else if (flag == 3)
                {
                    ErrMsg.Text = "※まだ入金が完了していません";
                    ErrMsg.Visible = true;
                    OrderidTextbox.Text = "";
                }

            }
        }
    }
}
