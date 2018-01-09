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

            MemberDisLbl.Visible = false;
            MemberEditLbl.Visible = false;
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
       
        private void MemberDisBtn_Click_1(object sender, EventArgs e)
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


                if (name.Contains(tname))
                {
                    selectfunc("SELECT * FROM 顧客テーブル WHERE ﾌﾘｶﾞﾅ LIKE '%" + MemberNameTBox.Text + "%' ORDER BY 顧客ID ASC");
                    MemberDisLbl.Text = "";
                    break;
                }


                MemberDisLbl.Visible = true;
                MemberDisLbl.Text = "その情報は登録されていません";
            }

            MemberNameTBox.Text = "";

            cn.Close();
        }

        //編集ボタン
        private void MemberEditBtn_Click_1(object sender, EventArgs e)
        {
            if (MemberDataGridView.ReadOnly == true)
            {
                MemberDataGridView.ReadOnly = false;
                MemberDataGridView.Columns[0].ReadOnly = true;
                MemberDataGridView.Columns[7].ReadOnly = true;
                MemberUpdateBtn.Visible = false;
                MemberEditLbl.Visible = true;
                PrintBtn.Visible = false;
                MessageBox.Show("編集可能になりました", "OICSystem");
            }
            else if (MemberDataGridView.ReadOnly == false)
            {
                MemberDataGridView.ReadOnly = true;
                MemberUpdateBtn.Visible = true;
                MemberEditLbl.Visible = false;
                PrintBtn.Visible = true;
                MessageBox.Show("編集不可になりました", "OICSystem");
            }
        }

        

        //更新ボタン
        private void MemberUpdateBtn_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MemberDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (MemberDataGridView.Rows[i].Cells[j].Value.ToString() == "")
                    {
                        MessageBox.Show("顧客ID" + MemberDataGridView.Rows[i].Cells[0].Value + "の" + MemberDataGridView.Columns[j].HeaderText + "に空白があります");    //空白の場所を知らせる
                    }
                }
            }


            for (int i = 0; i < MemberDataGridView.Rows.Count; i++)
            {
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 顧客テーブル SET 名前 ='" + (string)MemberDataGridView.Rows[i].Cells[1].Value.ToString()
                    + "' ,ﾌﾘｶﾞﾅ ='" + (string)MemberDataGridView.Rows[i].Cells[2].Value.ToString()
                    + "' ,電話番号 ='" + (string)MemberDataGridView.Rows[i].Cells[3].Value.ToString()
                    + "' ,郵便番号 ='" + (string)MemberDataGridView.Rows[i].Cells[4].Value.ToString()
                    + "' ,住所1 ='" + (string)MemberDataGridView.Rows[i].Cells[5].Value.ToString()
                    + "' ,住所2 ='" + (string)MemberDataGridView.Rows[i].Cells[6].Value.ToString()
                    + "' WHERE 顧客ID=" + (int)MemberDataGridView.Rows[i].Cells[0].Value + "";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("更新しました", "OICSystem");
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            MemberList f = new MemberList();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void MemberMgt_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.ActiveControl = this.MemberNameTBox;
                dataload();
            }
            
        }
    }
}
