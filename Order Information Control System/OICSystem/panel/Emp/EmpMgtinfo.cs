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
    public partial class EmpMgtInfo : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        int id;
        int tid;
        string name;
        string tname;

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

        public EmpMgtInfo()
        {
            InitializeComponent();
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
            if (EmpIDTextB.Text != "")
            {
                tid = int.Parse(EmpIDTextB.Text);
            }
            //NAME
            if (EmpNameTextB.Text != "")
            {
                tname = EmpNameTextB.Text;
            }



            while (rd.Read())
            {

                id = (int)rd.GetValue(0);    //従業員ID
                name = (string)rd.GetValue(1);  //名前

                if (id == tid)
                {

                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 従業員ID LIKE '%" + EmpIDTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }
                if (name == tname)
                {
                    selectfunc("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限 FROM 従業員マスタ WHERE 名前 LIKE '%" + EmpNameTextB.Text + "%'");
                    label1.Text = "";
                    break;
                }



                label1.Text = "その情報は登録されていません";
            }
            cn.Close();

            EmpIDTextB.Text = "";
            EmpNameTextB.Text = "";


        }
        private void Clickdata()
        {
            int max = int.Parse(EmpdataGridView[0, EmpdataGridView.Rows.Count - 2].Value.ToString());
            EmpIDTextB.Text = EmpdataGridView[1, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpNameTextB.Text = EmpdataGridView[2, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();


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

        private void UpdateB_Click(object sender, EventArgs e)
        {
            dataload(0);
            label1.Text = "";
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            if(EmpdataGridView.ReadOnly == true)
            {
                EmpdataGridView.ReadOnly = false;
                MessageBox.Show("編集可能になりました。", "編集可能");
            }
            else if(EmpdataGridView.ReadOnly==false)
            {
                EmpdataGridView.ReadOnly = true;
                MessageBox.Show("編集不可になりました。", "編集不可");
            }
        }
    }
}
