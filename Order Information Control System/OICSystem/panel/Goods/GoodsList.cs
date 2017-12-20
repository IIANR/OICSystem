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

namespace WindowsFormsApplication1.panel.Goods
{
    public partial class GoodsList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        OleDbCommand cmd = new OleDbCommand();

        string priceBtext;
        string cateID;
        int price;
        double priceText;
        public GoodsList()
        {
            InitializeComponent();
        }


        private void CategoryLoad()// comboBtextの中身を更新する
        {

            comboBcate.Items.Clear();

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
        private void GDLoad()
        {
            textBprice.Clear();

            cn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            string goodque = "SELECT 単価 FROM 商品マスタ";
            command.CommandText = goodque;
            OleDbDataReader reader = command.ExecuteReader();

            da = new OleDbDataAdapter("SELECT 単価 FROM 商品マスタ ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            priceBtext = dt.Rows[0][0].ToString();

            textBprice.Text = priceBtext;

            cn.Close();
        }


        private void GoodsLoad()
        {
            CategoryLoad();
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


        private Boolean SerchCategory(string category)
        {
            Boolean flag = false;
            da = new OleDbDataAdapter("SELECT * FROM カテゴリマスタ WHERE カテゴリ名='" + category + "'", cn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                flag = true;
            }
            return flag;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            if (SerchCategory(comboBcate.Text) == true)
            {
                cmd.CommandText = "INSERT INTO カテゴリマスタ (カテゴリ名)" + " VALUES (@catename)";
                OleDbParameter prcatename = new OleDbParameter("@catename", comboBcate.Text);
                cmd.Parameters.Add(prcatename);
                cmd.ExecuteNonQuery();
                MessageBox.Show("新規のカテゴリ名を追加");
            }
            else
            {

            }

            cn.Close();


            priceText = double.Parse(textBsupp.Text) * 1.6;
            price = (int)priceText;

            da = new OleDbDataAdapter("SELECT カテゴリID FROM カテゴリマスタ WHERE カテゴリ名='" + comboBcate.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cateID = dt.Rows[0][0].ToString();
            dt.Clear();
            cn.Close();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE 商品マスタ SET 商品名='" + textBname.Text + "', 単価=" + price + ", カテゴリID=" + cateID + ",安全在庫数=" + int.Parse(textBnumber.Text) + ",画像ファイル='" + textBimage.Text + "',仕入れ値=" + int.Parse(textBsupp.Text) + ",発注数=" + int.Parse(textBodr.Text) + " WHERE 商品ID ='" + textBID.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "OICSystem");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OICSystem");
            }
            finally
            {
                cn.Close();
            }

            CategoryLoad();
            GDLoad();
        }


        private void imageChange()
        {
            if (textBimage.Text.Length > 1)
            {
                pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE 商品マスタ SET フラグ = '販売中止' WHERE 商品ID='" + textBID.Text + "'";
            cmd.ExecuteNonQuery();
            try
            {

                MessageBox.Show("削除しました", "OICSystem");

                BindData(1);

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "IM2");
            }
            cn.Close();

        }
        private void BindData(int cnt)  //テキストボックスをバインド
        {


            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT m.商品ID,m.商品名,m.仕入れ値,m.単価,k.カテゴリ名,m.画像ファイル,m.安全在庫数,m.発注数,m.フラグ FROM 商品マスタ m,カテゴリマスタ k WHERE m.カテゴリID=k.カテゴリID  AND m.フラグ <> '販売中止'", cn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            if (cnt == 1)
            {

            }
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;

            bindingNavigator1.BindingSource = bds;

            textBID.DataBindings.Add("Text", bds, "商品ID");
            textBname.DataBindings.Add("Text", bds, "商品名");
            textBsupp.DataBindings.Add("Text", bds, "仕入れ値");
            textBprice.DataBindings.Add("Text", bds, "単価");
            comboBcate.DataBindings.Add("Text", bds, "カテゴリ名");
            textBimage.DataBindings.Add("Text", bds, "画像ファイル");
            textBnumber.DataBindings.Add("Text", bds, "安全在庫数");
            textBodr.DataBindings.Add("Text", bds, "発注数");
            imageChange();
            textBID.SelectionStart = 0;   //選択状態にならないようにする

            GoodsLoad();

        }

        //private void Delete()
        //{

        //    cn.Open();

        //    cmd.Connection = cn;
        //    cmd.CommandText = "DELETE FROM 在庫テーブル WHERE 商品ID='" + textBID.Text + "'";
        //    cmd.ExecuteNonQuery();
        //    try
        //    {

        //        MessageBox.Show("削除しました", "IM2");

        //        BindData(1);

        //    }
        //    catch (Exception )
        //    {

        //    }
        //}

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
                MessageBox.Show("更新できませんでした。", "OICSystem");
            }
            textBimage.Text = imagefile;
        }

        private void textBimage_TextChanged(object sender, EventArgs e)
        {
            imageChange();
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {


            textBID.DataBindings.Clear();
            textBname.DataBindings.Clear();
            textBsupp.DataBindings.Clear();
            textBprice.DataBindings.Clear();
            comboBcate.DataBindings.Clear();
            textBimage.DataBindings.Clear();
            textBnumber.DataBindings.Clear();
            textBodr.DataBindings.Clear();

            BindData(0);
        }

        private void GoodsList_Load(object sender, EventArgs e)
        {
            BindData(0);
        }
    }


}