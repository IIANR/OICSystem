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

namespace WindowsFormsApplication1.panel.IO
{
    public partial class IOOutput : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public IOOutput()
        {
            InitializeComponent();
        }

        private void IOOutput_Load(object sender, EventArgs e)
        {
            //クリア
            dt.Clear();
            OutputDataGrid.Columns.Clear();
            OutputDataGrid.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");

            //データグリッドビューに注文状況を表示
            da = new OleDbDataAdapter("select * from 発注テーブル left join 商品マスタ on (発注テーブル.商品ID =商品マスタ.商品ID) left join 入庫先マスタ on (発注テーブル.入庫先ID =入庫先マスタ.入庫先ID);", cn);
            da.Fill(dt);
            OutputDataGrid.DataSource = dt;

            OutputDataGrid.AllowUserToAddRows = false;
        }
    }
}
