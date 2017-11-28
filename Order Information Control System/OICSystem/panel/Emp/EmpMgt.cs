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

        string name;
        string tname;
        string tel;
        string ttel;
        string post;
        string tpost;
        string add;
        string tadd;

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

        }

        private void RegistrationB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID=" + EmpNameTextB.Text + "のデータを登録してもよろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 従業員マスタ (従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,電話番号,生年月日,入社日,責任者権限)" +
                " VALUES (@empid,@pass,@name,@assistname,@sex,@post,@addres,@tel,@birthday,@day,@authority)";
            OleDbParameter prid = new OleDbParameter("@empid", int.Parse(EmpIDTextB.Text));
            cmd.Parameters.Add(prid);
            OleDbParameter prpass = new OleDbParameter("@pass", EmpPassTextB.Text);
            cmd.Parameters.Add(prpass);
            OleDbParameter prname = new OleDbParameter("@name", EmpNameTextB.Text);
            cmd.Parameters.Add(prname);
            OleDbParameter prassistname = new OleDbParameter("@assistname", HuriganaTextB.Text);
            cmd.Parameters.Add(prassistname);
            OleDbParameter prman = new OleDbParameter("@sex", ManRB.Text);
            cmd.Parameters.Add(prman);
            OleDbParameter prwoman = new OleDbParameter("@sex", WomanRB.Text);
            cmd.Parameters.Add(prwoman);
            OleDbParameter prpost = new OleDbParameter("@post", EmpPostTextB.Text);
            cmd.Parameters.Add(prpost);
            OleDbParameter praddres = new OleDbParameter("@addres", EmpAddressTextB.Text);
            cmd.Parameters.Add(praddres);
            OleDbParameter prtel = new OleDbParameter("@tel", EmpTelTextB.Text);
            cmd.Parameters.Add(prtel);
            OleDbParameter prbirthday = new OleDbParameter("@birthday", BirthdayTextB.Text);
            cmd.Parameters.Add(prbirthday);
            OleDbParameter prday = new OleDbParameter("@day", DateTime.Today);
            cmd.Parameters.Add(prday);
            OleDbParameter prauthority = new OleDbParameter("@authority", AuthorityCB.Text);
            cmd.Parameters.Add(prauthority);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました", "成功");
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ok");
            }
            cn.Close();

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



        private void SearchB_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 従業員マスタ";
            cmd.Connection = cn;

            
            OleDbDataReader rd = cmd.ExecuteReader();

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            //name = MemberNameTBox.Text;
            //tell = MemberTelTBox.Text;

            while (rd.Read())
            {

                name = (string)rd.GetValue(1);  //名前
                tname = EmpNameTextB.Text;
                tel = (string)rd.GetValue(3);  //電話番号
                ttel = EmpTelTextB.Text;
                post = (string)rd.GetValue(4);  //郵便番号
                tpost = EmpPostTextB.Text;
                add = (string)rd.GetValue(5);   //住所
                tadd = EmpAddressTextB.Text;


                if (name == tname)
                {
                    selectfunc("SELECT * FROM 従業員マスタ WHERE 名前 LIKE '%" + EmpNameTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (tel == ttel)
                {
                    selectfunc("SELECT * FROM 従業員マスタ WHERE 電話番号 LIKE '%" + EmpTelTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (post == tpost)
                {
                    selectfunc("SELECT * FROM 従業員マスタ WHERE 郵便番号 LIKE '%" + EmpPostTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (add == tadd)
                {
                    
                    selectfunc("SELECT * FROM 従業員マスタ WHERE 住所1 LIKE '%" + EmpAddressTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }



                label1.Text = "その情報は登録されていません";     
            }

            EmpNameTextB.Text = "";

            cn.Close();

            
        }
        private void clickdata()
        {
            int max = int.Parse(EmpdataGridView[0, EmpdataGridView.Rows.Count - 2].Value.ToString());
            EmpIDTextB.Text = EmpdataGridView[1, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpPassTextB.Text = EmpdataGridView[2, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpNameTextB.Text = EmpdataGridView[3, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            BirthdayTextB.Text = DateTime.Parse(EmpdataGridView[4, EmpdataGridView.CurrentCell.RowIndex].Value.ToString()).ToString("yyyy/MM/dd");
            HuriganaTextB.Text = EmpdataGridView[5, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpPostTextB.Text = EmpdataGridView[6, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpAddressTextB.Text = EmpdataGridView[7, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpTelTextB.Text = EmpdataGridView[8, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();

        }
        private void dataload(int n)
        {
            EmpdataGridView.Columns.Clear();
            EmpdataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限,備考 FROM 従業員マスタ", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
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
            label1.Text = "";
        }
    }
}
