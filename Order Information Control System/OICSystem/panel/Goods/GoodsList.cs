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
    public partial class GoodsList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public GoodsList()
        {
            InitializeComponent();
        }

        private void GoodsList_Load(object sender, EventArgs e)
        {
            GoodsListDataGridView.Columns.Clear();
            GoodsListDataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT 商品ID,商品名,単価 FROM 商品マスタ", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            GoodsListDataGridView.DataSource = dt;
            GoodsListDataGridView.AutoResizeColumns();
        }

        private void GoodsListDataGridView_Click(object sender, EventArgs e)
        {
            GoodsListPictureBox.Image = Image.FromFile(@".\img\");
        }
    }
}
