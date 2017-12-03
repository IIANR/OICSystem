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

namespace WindowsFormsApplication1.panel.Goods
{
    public partial class GoodsStock : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public GoodsStock()
        {
            InitializeComponent();
        }

        private void GoodsStock_Load(object sender, EventArgs e)
        {
            GoodsDataGridView.Columns.Clear();
            GoodsDataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM 顧客テーブル", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            GoodsDataGridView.DataSource = dt;
            GoodsDataGridView.AutoResizeColumns();
        }
    }
}
