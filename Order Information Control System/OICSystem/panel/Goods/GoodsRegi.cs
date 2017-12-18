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

        string priceBtext;
        string cateID;
        //string goodsID;
        int price;
        int goodsid;
        double priceText;


        public GoodsRegi()
        {
            InitializeComponent();
        }



        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            dataLoad();
            GoodsLoad();
            

        }

        private void GoodsLoad()//カテゴリの中身
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

        private Boolean SerchCategory(string category)//カテゴリDBの繰り返しフラグ処理
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
        private void Goodsid()//商品IDをすべてカウントして、1足す
        {
            dt.Clear();

            goodsid = 0;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT 商品ID FROM 商品マスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();

            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            while (rd.Read())
            {
                if (goodsid < int.Parse((string)rd.GetValue(0)))
                {
                    goodsid = int.Parse((string)rd.GetValue(0));
                }
            }

            goodsid = goodsid + 1;

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

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;


            if (SerchCategory(comboBcate.Text) == true) // カテゴリ名追加
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



            //カテゴリIDを入れる↓
            da = new OleDbDataAdapter("SELECT カテゴリID FROM カテゴリマスタ WHERE カテゴリ名='" + comboBcate.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cateID = dt.Rows[0][0].ToString();
            dt.Clear();




            if (MessageBox.Show("ID=" + textBID.Text + "のデータを追加してもよろしいですか", "IM2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (textBimage.Text == "")//無かった場合image
            {
                textBimage.Text = textBimage.Text;
            }



            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 商品マスタ (商品ID,商品名,単価,カテゴリID,安全在庫数,画像ファイル,仕入れ値,発注数,フラグ)" +
                " VALUES (@id,@name,@price,@cateID,@number,@imagefile,@supp,@odr,@flag)";

            OleDbParameter gdID = new OleDbParameter("@id", int.Parse(textBID.Text));
            cmd.Parameters.Add(gdID);
            OleDbParameter gdname = new OleDbParameter("@name", textBname.Text);
            cmd.Parameters.Add(gdname);
            OleDbParameter gdprice = new OleDbParameter("@price", textBprice.Text);
            cmd.Parameters.Add(gdprice);
            OleDbParameter gdcateid = new OleDbParameter("@cateID", cateID);
            cmd.Parameters.Add(gdcateid);
            OleDbParameter gdnumber = new OleDbParameter("@number", int.Parse(textBnumber.Text));
            cmd.Parameters.Add(gdnumber);
            OleDbParameter primagefile = new OleDbParameter("@imagefile", textBimage.Text);
            cmd.Parameters.Add(primagefile);
            OleDbParameter gdsupp = new OleDbParameter("@supp", int.Parse(textBsupp.Text));
            cmd.Parameters.Add(gdsupp);
            OleDbParameter gdodr = new OleDbParameter("@odr", int.Parse(textBodr.Text));
            cmd.Parameters.Add(gdodr);
            OleDbParameter gdflag = new OleDbParameter("@flag","販売中");
            cmd.Parameters.Add(gdflag);

            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = cn;
            cmd2.CommandText = "INSERT INTO 在庫テーブル (商品ID,在庫数)" +
                          " VALUES (@Id,@stock)";
            OleDbParameter stID = new OleDbParameter("@Id", textBID.Text);
            cmd2.Parameters.Add(stID);
            OleDbParameter stock = new OleDbParameter("@stock", "0");
            cmd2.Parameters.Add(stock);
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("追加しました", "IM2");
                cmd.Parameters.Clear();
                cmd2.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IM2");
            }


            cn.Close();
            CategoryLoad();

            dataLoad();
            Goodsid();

        }

        private void CategoryLoad()
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

        private void dataLoad() //初期値
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM 商品マスタ ", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);

            Goodsid();
            textBID.Text = goodsid.ToString();
            textBname.Text = "";
            textBprice.Text = "";
            comboBcate.Text = "";
            textBnumber.Text = "";
            textBimage.Text = "Noimage.png";
            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            textBsupp.Text = "";
            textBodr.Text = "";

        }

        //下変更なし

        private void textBimage_TextChanged(object sender, EventArgs e)
        {
            imageChange();
        }


        private void imageChange()
        {
            if (textBimage.Text.Length > 1)
            {
                pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
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

        private void textBsupp_TextChanged(object sender, EventArgs e)
        {
            textBprice.Clear();

            if (textBsupp.Text == "0")
            {
                textBprice.Text = "0";
            }
            else if (textBsupp.Text == "")
            {
                textBprice.Text = "";
            }
            else
            {
                //仕入れ値の１.6倍の単価を計算↓
                priceText = double.Parse(textBsupp.Text) * 1.6;
                price = (int)priceText;
            }

            textBprice.Text = price.ToString();
        }

        private void textBsupp_KeyPress(object sender, KeyPressEventArgs e)//数値以外キャンセル　仕入れ値
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBnumber_KeyPress(object sender, KeyPressEventArgs e)//数値以外キャンセル　安全在庫数
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void textBodr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }
    }


}