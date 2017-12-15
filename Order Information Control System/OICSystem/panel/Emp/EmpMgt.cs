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
    public partial class EmpMgt : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        string tsex;
        bool tAuthority;

         

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            EmpdataGridView.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            EmpdataGridView.DataSource = dt;
            EmpdataGridView.AutoResizeColumns();
        }



        public EmpMgt()
        {
            InitializeComponent();
        }

        private void EmpMgt_Load(object sender, EventArgs e)
        {
            dataload(0);
            BirthdayTextB.Mask = "0000年90月90日";
        }

        private void RegistrationB_Click(object sender, EventArgs e)
        {
            //現在の日付
            DateTime dtNow = DateTime.Now;

            if (MessageBox.Show(EmpNameTextB.Text + "のデータを登録してもよろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 従業員マスタ (従業員ID,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限,パスワード)" +
                " VALUES (@empid,@name,@assistname,@sex,@post,@addres,@address2,@tel,@birthday,@day,@authority,@pass)";
            OleDbParameter prempid = new OleDbParameter("@empid", int.Parse(EmpIDTextB.Text));
            cmd.Parameters.Add(prempid);          
            OleDbParameter prname = new OleDbParameter("@name", EmpNameTextB.Text);
            cmd.Parameters.Add(prname);
            OleDbParameter prassistname = new OleDbParameter("@assistname", HuriganaTextB.Text);
            cmd.Parameters.Add(prassistname);
            OleDbParameter prsex = new OleDbParameter("@sex", tsex.ToString());
            cmd.Parameters.Add(prsex);
            OleDbParameter prpost = new OleDbParameter("@post", EmpPostTextB.Text);
            cmd.Parameters.Add(prpost);
            OleDbParameter praddres = new OleDbParameter("@addres", EmpAddressTextB.Text);
            cmd.Parameters.Add(praddres);
            OleDbParameter praddres2 = new OleDbParameter("@addres2", EmpAddress2TextB.Text);
            cmd.Parameters.Add(praddres2);
            OleDbParameter prtel = new OleDbParameter("@tel", EmpTelTextB.Text);
            cmd.Parameters.Add(prtel);
            OleDbParameter prbirthday = new OleDbParameter("@birthday", BirthdayTextB.Text);
            cmd.Parameters.Add(prbirthday);
            OleDbParameter prday = new OleDbParameter("@day", dtNow.ToString("MM/dd"));
            cmd.Parameters.Add(prday);
            OleDbParameter prauthority = new OleDbParameter("@authority", tAuthority);
            cmd.Parameters.Add(prauthority);
            OleDbParameter prpass = new OleDbParameter("@pass", EmpPassTextB.Text);
            cmd.Parameters.Add(prpass);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました", "成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ok");
            }
            finally   //●
            {
                cmd.Parameters.Clear();   //●
                cn.Close();
            }
            dataload(dcnt);   // ●データを再ロード
            dt.Clear();
            EmpdataGridView.DataSource = null;

            EmpIDTextB.Text = "";
            EmpPassTextB.Text = "";
            EmpNameTextB.Text = "";
            HuriganaTextB.Text = "";
            EmpPostTextB.Text = "";
            EmpAddressTextB.Text = "";
            EmpTelTextB.Text = "";
            BirthdayTextB.Text = "";

            ManRB.Checked = false;
            WomanRB.Checked = false;
            YesAuthorityRB.Checked = false;
            NoAuthorityRB.Checked = false;

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



        private void Clickdata()
        {
            int max = int.Parse(EmpdataGridView[0, EmpdataGridView.Rows.Count - 2].Value.ToString());
            EmpIDTextB.Text = EmpdataGridView[1, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpPassTextB.Text = EmpdataGridView[2, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpNameTextB.Text = EmpdataGridView[3, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            BirthdayTextB.Text = DateTime.Parse(EmpdataGridView[4, EmpdataGridView.CurrentCell.RowIndex].Value.ToString()).ToString();
            HuriganaTextB.Text = EmpdataGridView[5, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpPostTextB.Text = EmpdataGridView[6, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpAddressTextB.Text = EmpdataGridView[7, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpTelTextB.Text = EmpdataGridView[8, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();


        }
        static int dcnt = 0;   //●　データの行数を入れる変数

        private void dataload(int n)
        {
            EmpdataGridView.Columns.Clear();
            EmpdataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限,備考 FROM 従業員マスタ", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            dcnt = dt.Rows.Count;      //データの行数

            EmpdataGridView.DataSource = dt;
            EmpdataGridView.AutoResizeColumns();
            EmpdataGridView.ClearSelection();
            EmpdataGridView.Rows[n].Selected = true;
            EmpdataGridView.FirstDisplayedScrollingRowIndex = n;
            foreach (DataGridViewColumn c in EmpdataGridView.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataload(0);
        }

        private void WomanRB_CheckedChanged(object sender, EventArgs e)
        {
            tsex = WomanRB.Text;
        }

        private void ManRB_CheckedChanged(object sender, EventArgs e)
        {
            tsex = ManRB.Text;
        }

        private void YesAuthorityRB_CheckedChanged(object sender, EventArgs e)
        {
            tAuthority = true;
        }

        private void NoAuthorityRB_CheckedChanged(object sender, EventArgs e)
        {
            tAuthority = false;

        }
    }
}
