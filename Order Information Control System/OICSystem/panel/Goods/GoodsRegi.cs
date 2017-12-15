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
        string GoodsID;
        string Goodsnumber;
        int price;
        int count;
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
        // ↓　ここから再開
        private Boolean SerchGoodsID(string goodsID　)//商品マスタの繰り返しフラグ処理
        {
            Boolean flag = false;
            da = new OleDbDataAdapter("SELECT * FROM 商品マスタ WHERE 商品ID='" + goodsID + "'", cn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)//商品IDがないとき
            {

                da = new OleDbDataAdapter("SELECT 商品ID FROM 商品マスタ WHERE 商品ID='" + comboBcate.Text + "'", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Goodsnumber = dt.Rows[0][0].ToString();
                dt.Clear();
                flag = true;

            }
            else //商品IDが割り当てられているとき
            {
                count = count + 1;//商品マスタの数を数える

                flag = false;
            }
            return flag;
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

            if (SerchGoodsID(textBID.Text) == true) // 商品IDの位置を指定
            {
                


                //cmd.CommandText = "INSERT INTO カテゴリマスタ (カテゴリ名)" + " VALUES (@catename)";
                //OleDbParameter prcatename = new OleDbParameter("@catename", comboBcate.Text);
                //cmd.Parameters.Add(prcatename);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("新規のカテゴリ名を追加");
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


            //仕入れ値の１.6倍の単価を計算↓
            priceText = double.Parse(textBsupp.Text) * 1.6;
            price = (int)priceText;

            if (MessageBox.Show("ID=" + textBID.Text + "のデータを追加してもよろしいですか", "IM2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (textBimage.Text == "")//無かった場合image
            {
                textBimage.Text = textBimage.Text;
            }



            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 商品マスタ (商品ID,商品名,単価,カテゴリID,定期発注数,画像ファイル,仕入れ値)" +
                " VALUES (@id,@name,@price,@cateID,@number,@imagefile,@supp)";

            OleDbParameter gdID = new OleDbParameter("@id", textBID.Text);
            cmd.Parameters.Add(gdID);
            OleDbParameter gdname = new OleDbParameter("@name", textBname.Text);
            cmd.Parameters.Add(gdname);
            OleDbParameter gdprice = new OleDbParameter("@price", price);
            cmd.Parameters.Add(gdprice);
            OleDbParameter gdcateid = new OleDbParameter("@cateID", cateID);
            cmd.Parameters.Add(gdcateid);
            OleDbParameter gdnumber = new OleDbParameter("@number", int.Parse(textBnumber.Text));
            cmd.Parameters.Add(gdnumber);
            OleDbParameter primagefile = new OleDbParameter("@imagefile", textBimage.Text);
            cmd.Parameters.Add(primagefile);
            OleDbParameter gdsupp = new OleDbParameter("@supp", int.Parse(textBsupp.Text));
            cmd.Parameters.Add(gdsupp);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました", "IM2");
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IM2");
            }
            cn.Close();
            CategoryLoad();
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

            textBID.Text = "";
            textBname.Text = "";
            textBprice.Text = "";
            comboBcate.Text = "";
            textBnumber.Text = "";
            textBimage.Text = "Noimage.png";
            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            textBsupp.Text = "";

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
      
    }

   
}