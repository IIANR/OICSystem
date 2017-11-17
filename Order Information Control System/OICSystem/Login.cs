using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public SystmTop frm2 = new SystmTop();

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();

        int id;
        int inid;
        public string name;
        string pass;
        string inpass;



        public Login()
        {
            InitializeComponent();

            DateTime dtNow = DateTime.Now;

            DateLabel.Text = (dtNow.ToLongDateString());
            TimeLabel.Text = (dtNow.ToLongTimeString());

            timer1.Interval = 1000;
            timer1.Enabled = true;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            EmpErrMsg.Text = "";
            PassErrMsg.Text = "";
            

            if (EmpTextbox.Text == null||EmpTextbox.Text=="")
            {
                EmpTextbox.Text = "";
                EmpErrMsg.Text = "従業員IDを入力してください。";
               
            }
            else
            {
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                cn.Open();

                cmd.CommandText = "SELECT * FROM 従業員マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();

                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();
    
                inid = int.Parse(EmpTextbox.Text);

                while (rd.Read())
                {
                    id = (int)rd.GetValue(0);
                    name = (string)rd.GetValue(1);
                    pass = (string)rd.GetValue(12);
                        if (id == inid)
                        {
                            inpass = PassTextbox.Text;
                            if (PassTextbox.Text == null || PassTextbox.Text == "")
                            {
                                PassTextbox.Text = "";
                                PassErrMsg.Text = "パスワードを入力してください。";
                            }
                            else if (pass == inpass)
                            {
                                this.Hide();
                                frm2.frm1 = this;
                                frm2.Show();
                            }
                            else
                            {
                                EmpTextbox.Text = "";
                                PassTextbox.Text = "";
                                EmpErrMsg.Text = "従業員IDかパスワードが間違っています。";
                            }
                            break;
                        }      

                }
                EmpTextbox.Text = "";
                PassTextbox.Text = "";
                EmpErrMsg.Text = "従業員IDかパスワードが間違っています。";

                cn.Close();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void EmpTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;

            // 取得した日付と時刻を表示する
            DateLabel.Text = (dtNow.ToLongDateString());
            TimeLabel.Text = (dtNow.ToLongTimeString());
        }
      
    }
}
