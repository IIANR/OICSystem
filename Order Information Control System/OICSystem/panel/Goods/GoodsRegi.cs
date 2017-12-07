using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApplication1.panel
{
    public partial class GoodsRegi : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        BindingSource bds = new BindingSource();

        public GoodsRegi()
        {
            InitializeComponent();
        }

        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT m.ID,m.名前,r.カテゴリーID,t.備考,m.定量発注数,m.画像ファイル FROM Goods m,Role r ,Team t WHERE m.ポジションID=r.ID AND m.ID=t.ID ", cn);
            dt = new DataTable();
            da.Fill(dt);

            bds.DataSource = dt;

            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            textBID.SelectionStart = 0;   //選択状態にならないようにする

            this.商品マスタTableAdapter.Fill(this.iM2Data.商品マスタ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveNext();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveLast();
        }




        private void panel_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void 商品マスタBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            string PosID = dt1.Rows[0][0].ToString();
            dt1.Clear();


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Goods SET 名前='" + textBname.Text + "', " +
                "単価='" + textBprice.Text + "', " +
                "備考='" + textBbikou.Text + "'" +
                "定量発注数='" + textBbikou.Text + "'" +
                "WHERE ID ='" + textBID.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "CS-33");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-33");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}