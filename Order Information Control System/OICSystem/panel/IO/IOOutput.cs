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
            DataGrid.Columns.Clear();
            DataGrid.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 発注テーブル.発注ID, 発注テーブル.発注日, 発注テーブル.商品ID, 商品マスタ.商品名, 発注テーブル.発注数量 FROM 商品マスタ INNER JOIN 発注テーブル ON 商品マスタ.商品ID = 発注テーブル.商品ID", cn);
            da.Fill(dt);
            DataGrid.DataSource = dt;

            //dt = new DataTable();
            //cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            //da = new OleDbDataAdapter("SELECT 出庫テーブル.出庫ID, 出庫テーブル.注文ID, 出庫テーブル.出庫日, 顧客テーブル.名前 AS 顧客名, 注文テーブル.[フラグ] FROM 顧客テーブル INNER JOIN(注文テーブル INNER JOIN 出庫テーブル ON 注文テーブル.注文ID = 出庫テーブル.注文ID) ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID ORDER BY 出庫テーブル.出庫ID", cn);
            //da.Fill(dt);
            //OutputDataGrid.DataSource = dt;
            DataGrid.AllowUserToAddRows = false;
        }

        private void CompBtn_Click(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            int flag = 0;
            if (OutputRadioBtn.Checked == true)
            {
                ErrMsg.Visible = false;
                if (IdTextbox.Text == null || IdTextbox.Text == "")
                {
                    ErrMsg.Text = "※注文IDを入力してください";
                    ErrMsg.Visible = true;
                }
                else
                {

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
                        if (db_Orderid == int.Parse(IdTextbox.Text))
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
                        if (db_Orderid == int.Parse(IdTextbox.Text))
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
                        OleDbParameter prorderid = new OleDbParameter("@orderid", IdTextbox.Text);
                        cmd2.Parameters.Add(prorderid);
                        OleDbParameter proutputdate = new OleDbParameter("@outputdate", dtNow.ToString("MM/dd"));
                        cmd2.Parameters.Add(proutputdate);


                        OleDbCommand cmd3 = new OleDbCommand();
                        cmd3.Connection = cn;
                        cmd3.CommandText = "UPDATE 注文テーブル SET フラグ='出庫済み' WHERE 注文ID=" + IdTextbox.Text + " AND 入金済み=True";
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
                        DataGrid.Columns.Clear();
                        DataGrid.DataSource = null;

                        dt = new DataTable();
                        cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
                        da = new OleDbDataAdapter("SELECT 出庫テーブル.出庫ID, 出庫テーブル.注文ID, 出庫テーブル.出庫日, 顧客テーブル.名前 AS 顧客名, 注文テーブル.[フラグ] FROM 顧客テーブル INNER JOIN(注文テーブル INNER JOIN 出庫テーブル ON 注文テーブル.注文ID = 出庫テーブル.注文ID) ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID ORDER BY 出庫テーブル.出庫ID", cn);
                        da.Fill(dt);
                        DataGrid.DataSource = dt;
                        DataGrid.AllowUserToAddRows = false;

                        cmd.Parameters.Clear();
                        cmd2.Parameters.Clear();
                        cmd3.Parameters.Clear();
                        IdTextbox.Text = "";
                    }
                    else if (flag == 0)
                    {
                        ErrMsg.Text = "※存在しない注文IDです";
                        ErrMsg.Visible = true;
                        IdTextbox.Text = "";
                    }
                    else if (flag == 2)
                    {
                        ErrMsg.Text = "※すでに登録されています";
                        ErrMsg.Visible = true;
                        IdTextbox.Text = "";
                    }
                    else if (flag == 3)
                    {
                        ErrMsg.Text = "※まだ入金が完了していません";
                        ErrMsg.Visible = true;
                        IdTextbox.Text = "";
                    }

                }
            }
            if (InputRadioBtn.Checked == true)
            {
                ErrMsg.Visible = false;
                if (IdTextbox.Text == null || IdTextbox.Text == "")
                {
                    ErrMsg.Text = "※行を選択してください";
                    ErrMsg.Visible = true;
                }
                else
                {
                    dt = new DataTable();
                    cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

                    OleDbCommand cmd = new OleDbCommand();
                    cn.Open();
                    cmd.CommandText = "SELECT 発注ID FROM 入庫テーブル";
                    cmd.Connection = cn;
                    OleDbDataReader rd = cmd.ExecuteReader();

                    dt = CreateSchemaDataTable(rd);
                    DataRow row = dt.NewRow();

                    int db_Orderingid = 0;

                    while (rd.Read())
                    {
                        db_Orderingid = (int)rd.GetValue(0);
                        if (db_Orderingid == int.Parse(IdTextbox.Text))
                        {
                            flag = 1;
                        }
                    }
                    cn.Close();

                    if (flag == 0)
                    {
                        OleDbCommand cmd2 = new OleDbCommand();
                        cmd2.Connection = cn;
                        cmd2.CommandText = "INSERT INTO 入庫テーブル (発注ID,入庫日)" + "VALUES (@inputid,@inputdate) ";
                        OleDbParameter prinputid = new OleDbParameter("@inputid", int.Parse((string)DataGrid.CurrentRow.Cells[0].Value.ToString()));
                        cmd2.Parameters.Add(prinputid);
                        OleDbParameter prinputdate = new OleDbParameter("@inputdate", dtNow.ToString("MM/dd"));
                        cmd2.Parameters.Add(prinputdate);

                        OleDbCommand cmd3 = new OleDbCommand();
                        cmd3.Connection = cn;
                        cmd3.CommandText = "UPDATE 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID SET 在庫テーブル.在庫数 = 在庫テーブル.在庫数 + "+int.Parse(InputNumTextbox.Text)+" WHERE 商品マスタ.商品名 = '" + (string)DataGrid.CurrentRow.Cells[3].Value.ToString() + "'";

                        cn.Open();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cn.Close();

                        
                    }

                    else if (flag == 1)
                    {
                        ErrMsg.Text = "※すでに登録されています";
                        ErrMsg.Visible = true;
                        IdTextbox.Text = "";
                        InputNumTextbox.Text = "";
                    }

                }
            }
        }

        private void InputRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            idLabel.Text = "発注ID：";
            CompBtn.Text = "入庫完了";
            InputNumLabel.Visible = true;
            InputNumTextbox.Visible = true;
            ErrMsg.Visible = false;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 発注テーブル.発注ID, 発注テーブル.発注日, 発注テーブル.商品ID, 商品マスタ.商品名, 発注テーブル.発注数量 FROM 商品マスタ INNER JOIN 発注テーブル ON 商品マスタ.商品ID = 発注テーブル.商品ID", cn);
            da.Fill(dt);
            DataGrid.DataSource = dt;
        }

        private void OutputRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            idLabel.Text = "注文ID：";
            CompBtn.Text = "出庫完了";
            InputNumLabel.Visible = false;
            InputNumTextbox.Visible = false;
            ErrMsg.Visible = false;

            dt.Clear();
            DataGrid.Columns.Clear();
            DataGrid.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 出庫テーブル.出庫ID, 出庫テーブル.注文ID, 出庫テーブル.出庫日, 顧客テーブル.名前 AS 顧客名, 注文テーブル.[フラグ] FROM 顧客テーブル INNER JOIN(注文テーブル INNER JOIN 出庫テーブル ON 注文テーブル.注文ID = 出庫テーブル.注文ID) ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID ORDER BY 出庫テーブル.出庫ID", cn);
            da.Fill(dt);
            DataGrid.DataSource = dt;
        }

        private void DataGrid_Click(object sender, EventArgs e)
        {
            if (InputRadioBtn.Checked == true)
            {
                InputNumTextbox.Text = (string)DataGrid.CurrentRow.Cells[4].Value.ToString();
                IdTextbox.Text = (string)DataGrid.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
