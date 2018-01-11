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

        public int db_id;
        int inid;
        public string db_name;
        string db_pass;
        string inpass;
        public bool db_admin;

        private static Login _loginInstance;
        //private static Login _authorutyInstance;

        public static Login LoginInstance
        {
            get
            {
                return _loginInstance;
            }
            set
            {
                _loginInstance = value;
            }
        }

        public int Empid
        {
            get
            {
                return db_id;
            }
            set
            {
                db_id = value;
            }
        }

        //public static Login AuthorityInstance
        //{
        //    get
        //    {
        //        return _authorutyInstance;
        //    }
        //    set
        //    {
        //        _authorutyInstance = value;
        //    }
        //}

        public bool Authority
        {
            get
            {
                return db_admin;
            }
            set
            {
                db_admin = value;
            }
        }

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
            ErrMsg.Text = "";


            if (EmpTextbox.Text == null || EmpTextbox.Text == "")   // IDの入力チェック
            {
                ErrMsg.Text = "従業員IDを入力してください。";
            }
            else if (PassTextbox.Text == null || PassTextbox.Text == "") // パスワードの入力チェック
            {
                ErrMsg.Text = "パスワードを入力してください。";
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
                    db_id = (int)rd.GetValue(0);
                    db_name = (string)rd.GetValue(1);
                    db_admin = (bool)rd.GetValue(10);
                    db_pass = (string)rd.GetValue(11);
                    if (db_id == inid)
                    {
                        inpass = PassTextbox.Text;

                        if (db_pass == inpass)
                        {
                            this.Hide();
                            frm2.frm1 = this;
                            frm2.Show();
                        }
                        else
                        {
                            ErrMsg.Text = "従業員IDかパスワードが間違っています。";
                        }
                        break;
                    }
                    else
                    {
                        ErrMsg.Text = "従業員IDかパスワードが間違っています。";
                    }

                }

                cn.Close();

            }

            //入力情報のクリア
            EmpTextbox.Text = "";
            PassTextbox.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

            Login.LoginInstance = this;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = !this.MaximizeBox;
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

        private void PassTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoginBtn_Click(null, EventArgs.Empty);
            }
        }
    }
}
