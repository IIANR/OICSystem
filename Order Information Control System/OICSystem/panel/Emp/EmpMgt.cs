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

        }

        private void SearchB_Click(object sender, EventArgs e)
        {

        }
        private void dataload(int n)
        {
            EmpdataGridView.Columns.Clear();
            EmpdataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM Member ORDER BY ID", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            EmpdataGridView.DataSource = dt;
            EmpdataGridView.AutoResizeColumns();
            EmpdataGridView.ClearSelection();
            EmpdataGridView.CurrentCell = EmpdataGridView.Rows[0].Cells["ID"];
            EmpdataGridView.Rows[n].Selected = true;
            EmpdataGridView.FirstDisplayedScrollingRowIndex = n;
            foreach (DataGridViewColumn c in EmpdataGridView.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
