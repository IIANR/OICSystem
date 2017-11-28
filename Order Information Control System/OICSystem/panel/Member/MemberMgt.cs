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
        string pnum;
        string tpnum;
        string add1;
        string tadd1;
        string add2;
        string tadd2;


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

            while (rd.Read())
            {

                name = (string)rd.GetValue(1);  //名前
                tname = MemberNameTBox.Text;
                /*
                tell = (string)rd.GetValue(3);  //電話番号
                ttell = MemberTelTBox.Text;
                pnum = (string)rd.GetValue(4);  //郵便番号
                tpnum = MemberPostNumTBox.Text;
                add1 = (string)rd.GetValue(5);   //住所1
                tadd1 = MemberAddlessTBox.Text;
                //add2 = (string)rd.GetValue(6);   //住所2
                //tadd2 = MemberAddlessTBox.Text;
                */

                if (name == tname)
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE 名前 LIKE '%" + MemberNameTBox.Text + "%'");
                    MemberDisLbl.Text = "";
                    break;
                }
                /*
                if (tell == ttell)
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE 電話番号 LIKE '%" + MemberTelTBox.Text + "%'");
                    MemberDisLbl.Text = "";
                    break;
                }
                if (pnum == tpnum)
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE 郵便番号 LIKE '%" + MemberPostNumTBox.Text + "%'");
                    MemberDisLbl.Text = "";
                    break;
                }

                if(add2 == null)
                {
                     add2 = "Null";
                }
                if (add1 == tadd1 || add2 == tadd2)
                {
                    
                    selectfunc("SELECT * FROM 顧客テーブル WHERE 住所1 LIKE '%" + MemberAddlessTBox.Text + "%'");
                    MemberDisLbl.Text = "";
                    break;
                }
                */

                
                MemberDisLbl.Text = "その情報は登録されていません";     
            }

            MemberNameTBox.Text = "";

            cn.Close();

         }




        //クリア
        private void MemberClearBtn_Click(object sender, EventArgs e)
        {
            dataload();
            MemberDisLbl.Text = "";
        }

        private void MemberEditBtn_Click(object sender, EventArgs e)
        {
            MemberDataGridView.ReadOnly = false;
        }

        
    }
}
