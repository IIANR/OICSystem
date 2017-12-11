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
        OleDbCommand cmd = new OleDbCommand();
        BindingSource bds = new BindingSource();


        int flag;
        string CateName;
        string db_cate;
        string cateID;

        public GoodsRegi()
        {
            InitializeComponent();
        }

       

        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT m.商品ID,m.商品名,m.単価,k.カテゴリ名,m.画像ファイル,m.備考,m.定期発注数 FROM 商品マスタ m,カテゴリマスタ k WHERE m.カテゴリID=k.カテゴリID ", cn);
            dt = new DataTable();
            da.Fill(dt);




            bds.DataSource = dt;

            bindingNavigator1.BindingSource = bds;

            textBID.DataBindings.Add("Text", bds, "商品ID");
            textBname.DataBindings.Add("Text", bds, "商品名");
            textBprice.DataBindings.Add("Text", bds, "単価");
            comboBcate.DataBindings.Add("Text", bds, "カテゴリ名");
            textBimage.DataBindings.Add("Text", bds, "画像ファイル");
            textBbikou.DataBindings.Add("Text", bds, "備考");
            textBnumber.DataBindings.Add("Text", bds, "定期発注数");
            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            textBID.SelectionStart = 0;   //選択状態にならないようにする




            cn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            string query = "SELECT カテゴリ名 FROM カテゴリマスタ";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBcate.Items.Add(reader["カテゴリ名"].ToString());
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //ここから変更場所

            
            cn.Open();
            DataTable dt3 = new DataTable();

            cmd.CommandText = "SELECT カテゴリ名 FROM カテゴリマスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();

            dt3 = CreateSchemaDataTable(rd);
            DataRow row = dt3.NewRow();

            CateName = comboBcate.Text;

            while (rd.Read())
            {
                db_cate = (string)rd.GetValue(0);

                if (db_cate != CateName)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
            {
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO カテゴリマスタ (カテゴリ名) VALUES (@catename)";
  
                OleDbParameter prcatename = new OleDbParameter("@catename", comboBcate.Text);
                cmd.Parameters.Add(prcatename);
                cn.Close();
            }
         
            da = new OleDbDataAdapter("SELECT カテゴリID FROM カテゴリマスタ WHERE カテゴリ名='" + comboBcate.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cateID = dt.Rows[0][0].ToString();
            dt.Clear();



            //ここまで






            cmd.Connection = cn;
            cmd.CommandText = "UPDATE 商品マスタ SET 商品名='" + textBname.Text + "', 単価=" + int.Parse(textBprice.Text) + ", カテゴリID=" + cateID + ",備考='" + textBbikou.Text + "',定期発注数=" + int.Parse(textBnumber.Text) + ",画像ファイル='" + textBimage.Text + "' WHERE 商品ID ='" + textBID.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "IM2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IM2");
            }
            finally
            {
                cn.Close();
            }
        }

        private void textBimage_TextChanged(object sender, EventArgs e)
        {
          pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string dropfile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string imagefile = Path.GetFileName(dropfile);
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @".\IM2image\" + imagefile;

            pictureBox.Image = Image.FromFile(dropfile);
            try
            {
                System.IO.File.Copy(dropfile, path, true);
            }

            catch
            {
                MessageBox.Show("更新できませんでした。", "IM2");
            }
            textBimage.Text = imagefile;
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}