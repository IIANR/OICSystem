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

        //private void Monthlybtn_Click(object sender, EventArgs e)
        //{
        //    cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2777.accdb;";
        //    cn.Open();

        //    cmd.CommandText = "SELECT * FROM 注文テーブル WHERE create_datetime>='2017-10-01'AND create_datetime<='2017-11-01'";
        //    cmd.Connection = cn;

        //    OleDbDataReader rd = cmd.ExecuteReader();

        //    dt = CreateSchemaDataTable(rd);
        //    DataRow row = dt.NewRow();

        //    date2.Text = DateTime.Parse(dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString()).ToString("yyyy/MM/dd");

        //    cn.Close();
        //}

        //private void Monthlybtn_Click(object sender, EventArgs e)
        //{
        //    cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
        //    cn.Open();

        //    cmd.CommandText = "SELECT * FROM 従業員マスタ";
        //    cmd.Connection = cn;

        //    OleDbDataReader rd = cmd.ExecuteReader();

        //    dt = CreateSchemaDataTable(rd);
        //    DataRow row = dt.NewRow();

        //    inid = int.Parse(EmpTextbox.Text);

        //    while (rd.Read())
        //    {
        //        db_id = (int)rd.GetValue(0);
        //        db_name = (string)rd.GetValue(1);
        //        db_pass = (string)rd.GetValue(12);
        //        if (db_id == inid)
        //        {
        //            inpass = PassTextbox.Text;

        //            if (db_pass == inpass)
        //            {
        //                this.Hide();
        //                frm2.frm1 = this;
        //                frm2.Show();
        //            }
        //            else
        //            {
        //                ErrMsg.Text = "従業員IDかパスワードが間違っています。";
        //            }
        //            break;
        //        }

        //    }

        //    cn.Close();
        //}

        private void dataload(int n)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2777.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM Member ORDER BY ID", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["ID"];
            dataGridView1.Rows[n].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = n;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string DS1;
            string DS2;
            //
            // Valueプロパティの値をそのまま表示します
            //
            DS1 = DateSet1.Value.ToString("yyyy/MM/dd");
            Console.WriteLine(DS1);
            DS2 = DateSet2.Value.ToString("yyyy/MM/dd");
            Console.WriteLine(DS2);

            
         
        }

        private void Weeklybtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.注文テーブルBindingSource.EndEdit();
            this.注文テーブルTableAdapter.UpdateAll(this.iM2DataSet);
        }

        private void SalMgt_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dBJapanDataSet.Member' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.注文テーブルTableAdapter.Fill(this.iM2DataSet.注文テーブル);
            dataGridView1.AutoResizeColumns();
        }

    }
}
