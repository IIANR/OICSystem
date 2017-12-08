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

        int id;
        int tid;
        string pass;
        string tpass;
        string name;
        string tname;
        string sabname;
        string tsabname;
        string post;
        string tpost;
        string add;
        string tadd;
        string tel;
        string ttel;
        string bone;
        string tbone;
        string sex;
        string tsex;
        bool Authority;
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

        }

        private void RegistrationB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(EmpNameTextB.Text + "のデータを登録してもよろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 従業員マスタ (従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限)" +
                " VALUES (@empid,@pass,@name,@assistname,@sex,@post,@addres,@address2,@tel,@birthday,@day,@authority)";
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
            OleDbParameter praddres2 = new OleDbParameter("@addres2", EmpAddress2TextB.Text);
            cmd.Parameters.Add(praddres2);
            OleDbParameter prtel = new OleDbParameter("@tel", EmpTelTextB.Text);
            cmd.Parameters.Add(prtel);
            OleDbParameter prbirthday = new OleDbParameter("@birthday", BirthdayTextB.Text);
            cmd.Parameters.Add(prbirthday);
            OleDbParameter prday = new OleDbParameter("@day", DateTime.Today);
            cmd.Parameters.Add(prday);
            OleDbParameter pryauthority = new OleDbParameter("@authority", YesAuthorityRB.Checked);
            cmd.Parameters.Add(pryauthority);
            OleDbParameter prnauthority = new OleDbParameter("@authority", NoAuthorityRB.Checked);
            cmd.Parameters.Add(prnauthority);

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
            dataload(0);
            
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 従業員マスタ";
            cmd.Connection = cn;

            
            OleDbDataReader rd = cmd.ExecuteReader();

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            //name = MemberNameTBox.Text;
            //tell = MemberTelTBox.Text;

            //ID
            if(EmpIDTextB.Text!="")
            {
                tid = int.Parse(EmpIDTextB.Text);
            }
            //PASS
            if ( EmpPassTextB.Text != "")
            {
                tpass = EmpPassTextB.Text;
            }
            //NAME
            if (EmpNameTextB.Text != "")
            {
                tname = EmpNameTextB.Text;
            }
            //SABNAME
            if (HuriganaTextB.Text != "")
            {
                tsabname = HuriganaTextB.Text;
            }
            //POST
            if (EmpPostTextB.Text != "")
            {
                tpost = EmpPostTextB.Text;
            }
            //ADD
            if (EmpAddressTextB.Text != "")
            {
                tadd = EmpAddressTextB.Text;
            }
            //TEL
            if (EmpTelTextB.Text != "")
            {
                ttel = EmpTelTextB.Text;
            }
            //BONE
            if (BirthdayTextB.Text != "")
            {
                tbone = BirthdayTextB.Text;
            }
           
            

            while (rd.Read())
            {

                id = (int)rd.GetValue(0);    //従業員ID
                pass = (string)rd.GetValue(12);  //パスワード
                name = (string)rd.GetValue(1);  //名前
                sabname = (string)rd.GetValue(2);//ﾌﾘｶﾞﾅ
                post = (string)rd.GetValue(4);  //郵便番号
                add = (string)rd.GetValue(5);   //住所1
                tel = (string)rd.GetValue(7);  //電話番号
                bone = (string)rd.GetValue(8).ToString();  //生年月日
                sex = (string)rd.GetValue(3).ToString();  //性別
                Authority = (bool)rd.GetValue(10);    //責任者権限

                if (id == tid)
                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 従業員ID LIKE '%" + EmpIDTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (pass == tpass)
                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE パスワード LIKE '%" + EmpPassTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (name == tname)
                {
                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 名前 LIKE '%" + EmpNameTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (sabname == tsabname)
                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE ﾌﾘｶﾞﾅ LIKE '%" + HuriganaTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (post == tpost)
                {
                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 郵便番号 LIKE '%" + EmpPostTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (add == tadd)
                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 住所1 LIKE '%" + EmpAddressTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (tel == ttel)
                {
                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 電話番号 LIKE '%" + EmpTelTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (bone == tbone + " 0:00:00")  

                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 生年月日 LIKE '%" + BirthdayTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (tsex != WomanRB.Text)
                { 
                    if (sex == tsex)
                    {

                        selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 性別 LIKE '%" + ManRB.Text + "%'");
                        label1.Text = "";
                        break;
                    }
                }
                else if(tsex!=ManRB.Text)
                {
                    if (sex == tsex)
                    {

                        selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 性別 LIKE '%" + WomanRB.Text + "%'");
                        label1.Text = "";
                        break;
                    }
                }
                if (tAuthority == false)
                {
                    if (Authority == tAuthority)
                    {

                        selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 責任者権限 = false ");
                        label1.Text = "";
                        break;
                    }
                }
                else if (tAuthority == true)
                {
                    if (Authority == tAuthority)
                    {

                        selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 責任者権限 = true");
                        label1.Text = "";
                        break;
                    }
                }



                label1.Text = "その情報は登録されていません";     
            }
            cn.Close();

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
            tsex = "";
            YesAuthorityRB.Checked = false;
            NoAuthorityRB.Checked = false;

            

        }
        private void clickdata()
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
