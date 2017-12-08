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

            MemberDataGridView.AllowUserToAddRows = false;
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

                name = (string)rd.GetValue(2);  //データベースの「ﾌﾘｶﾞﾅ」
                tname = MemberNameTBox.Text;    //textboxの「ﾌﾘｶﾞﾅ」
                

                if (name == tname)
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE ﾌﾘｶﾞﾅ LIKE '%" + MemberNameTBox.Text + "%'"); //LIKEで囲んでいるが意味は無し。
                    MemberDisLbl.Text = "";
                    break;
                }
                

                
                MemberDisLbl.Text = "その情報は登録されていません";     
            }

            MemberNameTBox.Text = "";

            cn.Close();

         }




        //クリアボタン
        private void MemberClearBtn_Click(object sender, EventArgs e)
        {
            dataload();
            MemberDisLbl.Text = "";
        }

        
        //更新ボタン
        private void MemberUpdateBtn_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < MemberDataGridView.Rows.Count; i++)
            {
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 顧客テーブル SET 名前 ='" + 
                    (string)MemberDataGridView.Rows[i].Cells[1].Value.ToString() + "' ,ﾌﾘｶﾞﾅ ='" +           //セルが空(NULL)の時エラーになるのでTostringを使用
                    (string)MemberDataGridView.Rows[i].Cells[2].Value.ToString() + "' ,電話番号 ='" + 
                    (string)MemberDataGridView.Rows[i].Cells[3].Value.ToString() + "' ,郵便番号 ='" + 
                    (string)MemberDataGridView.Rows[i].Cells[4].Value.ToString() + "' ,住所1 ='" + 
                    (string)MemberDataGridView.Rows[i].Cells[5].Value.ToString() + "' ,住所2 ='" + 
                    (string)MemberDataGridView.Rows[i].Cells[6].Value.ToString() + 
                    "' WHERE 顧客ID=" + (int)MemberDataGridView.Rows[i].Cells[0].Value + "";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("更新しました", "OICSystem");
        }

        //編集ボタン
        private void MemberEditBtn_Click(object sender, EventArgs e)
        {
            if(MemberDataGridView.ReadOnly == true)
            {
                MemberDataGridView.ReadOnly = false;
                MessageBox.Show("編集可能になりました", "OICSystem");
            }
            else if(MemberDataGridView.ReadOnly==false)
            {
                MemberDataGridView.ReadOnly = true;
                MessageBox.Show("編集不可になりました", "OICSystem");
            }
        }

        
    }
}
