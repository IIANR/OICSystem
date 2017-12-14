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

        //string cateID;

        public GoodsRegi()
        {
            InitializeComponent();
        }

       

        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        //private void GoodsLoad()
        //{
        //    comboBcate.Items.Clear();
        //    cn.Open();
        //    OleDbCommand command = new OleDbCommand();
        //    command.Connection = cn;
        //    string query = "SELECT * FROM 商品マスタ";
        //    command.CommandText = query;

        //    OleDbDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        comboBcate.Items.Add(reader["カテゴリ名"].ToString());
        //    }

        //    cn.Close();
        //}

        //private Boolean SerchCategory(string category)//フラグ処理
        //{
        //    Boolean flag = false;
        //    da = new OleDbDataAdapter("SELECT * FROM カテゴリマスタ WHERE カテゴリ名='" + category + "'", cn);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count == 0)
        //    {
        //        flag = true;
        //    }
        //    return flag;
        //}

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;

            //if (SerchCategory(comboBcate.Text) == true) // カテゴリ名追加
            //{
            //    cmd.CommandText = "INSERT INTO カテゴリマスタ (カテゴリ名)" + " VALUES (@catename)";
            //    OleDbParameter prcatename = new OleDbParameter("@catename", comboBcate.Text);
            //    cmd.Parameters.Add(prcatename);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("新規のカテゴリ名を追加");
            //}
            //else
            //{

            //}

            //da = new OleDbDataAdapter("SELECT カテゴリID FROM カテゴリマスタ WHERE カテゴリ名='" + comboBcate.Text + "'", cn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cateID = dt.Rows[0][0].ToString();
            //dt.Clear();

            if (MessageBox.Show("ID=" + textBID.Text + "のデータを追加してもよろしいですか", "IM2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (textBimage.Text == "")
            {
                
            }

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 商品マスタ (商品ID,商品名,単価,カテゴリID,備考,定期発注数,画像ファイル)" +
                " VALUES (@id,@name,@price,@cateID,@bikou,@number,@imagefile)";
            OleDbParameter gdID = new OleDbParameter("@id", textBID.Text);
            cmd.Parameters.Add(gdID);
            OleDbParameter gdname = new OleDbParameter("@name", textBname.Text);
            cmd.Parameters.Add(gdname);
            OleDbParameter gdprice = new OleDbParameter("@price", int.Parse(textBprice.Text));
            cmd.Parameters.Add(gdprice);
            OleDbParameter gdcateid = new OleDbParameter("@cateID", comboBcate.Text);
            cmd.Parameters.Add(gdcateid);
            OleDbParameter gdbikou = new OleDbParameter("@bikou", textBbikou.Text);
            cmd.Parameters.Add(gdbikou);
            OleDbParameter gdnumber = new OleDbParameter("@number", int.Parse(textBnumber.Text));
            cmd.Parameters.Add(gdnumber);
            OleDbParameter primagefile = new OleDbParameter("@imagefile", textBimage.Text);
            cmd.Parameters.Add(primagefile);
           

            
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
            textBbikou.Text = "";
            textBnumber.Text = "";
            textBimage.Text = "";
           
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