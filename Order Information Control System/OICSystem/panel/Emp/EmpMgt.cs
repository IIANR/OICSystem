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
            OleDbParameter prid = new OleDbParameter("@empid", EmpIDTextB.Text);
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
            OleDbParameter praddres = new OleDbParameter("@addres", AddressTextB.Text);
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

        private void SearchB_Click(object sender, EventArgs e)
        {

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
    }
}
