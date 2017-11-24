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
    public partial class MemberMgt : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        string name;
        string tname;
        string tell;
        string ttell;
        


        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            MemberDataGridView.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);                                                                                        
            MemberDataGridView.DataSource = dt;
            MemberDataGridView.AutoResizeColumns();
        }

        public MemberMgt()
        {
            InitializeComponent();
        }

        private void MemberMgt_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void dataload()
        {
            MemberDataGridView.Columns.Clear();
            MemberDataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM 顧客テーブル", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            MemberDataGridView.DataSource = dt;
            MemberDataGridView.AutoResizeColumns();
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

        private void MemberDisBtn_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 顧客テーブル";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            //name = MemberNameTBox.Text;
            //tell = MemberTelTBox.Text;

            while (rd.Read())
            {

                name = (string)rd.GetValue(1);
                tname = MemberNameTBox.Text;
                tell = (string)rd.GetValue(3);
                ttell = MemberTelTBox.Text;
                if (name == tname || tell == ttell)
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE 名前 LIKE '%" + MemberNameTBox.Text + "%'");
                    MemberDisLbl.Text = "";
                    break;
                }


                
                MemberDisLbl.Text = "その情報は登録されていません";     
            }

            MemberNameTBox.Text = "";

            cn.Close();

         }





        private void MemberClearBtn_Click(object sender, EventArgs e)
        {
            dataload();
            MemberDisLbl.Text = "";
        }

        
    }
}
