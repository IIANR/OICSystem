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
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public GoodsRegi()
        {
            InitializeComponent();
        }

        private void regiBtn_Click(object sender, EventArgs e)//登録ボタンをクリック
        {
            if (MessageBox.Show("ID=" + IDText.Text + "のデータを追加しますか？", "IM2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (ImageText.Text == "")//画像がないときのエラーメッセージ
            {
                MessageBox.Show("画像がありません。", "IM2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Goods (商品ID, 商品名, カテゴリID,単価, 備考, 定期発注数, 画像ファイル)" +
                " VALUES (@id,@name,@categoryid,@price,@rem,@umber,@imagefile)";
            OleDbParameter gdid = new OleDbParameter("@id", int.Parse(IDText.Text));//商品ID
            cmd.Parameters.Add(gdid);
            OleDbParameter gdname = new OleDbParameter("@name", NameText.Text);//商品名
            cmd.Parameters.Add(gdname);
            OleDbParameter gdcategoryid = new OleDbParameter("@categoryid", CategoryText.Text);//カテゴリID
            cmd.Parameters.Add(gdcategoryid);
            OleDbParameter gdprice = new OleDbParameter("@price", int.Parse(PriceText.Text));//単価
            cmd.Parameters.Add(gdprice);
            OleDbParameter gdrem = new OleDbParameter("@rem", RemText.Text);//備考
            cmd.Parameters.Add(gdrem);
            OleDbParameter gdumber = new OleDbParameter("@umber", int.Parse(UmberText.Text));//定量発注数
            cmd.Parameters.Add(gdumber);
            OleDbParameter primagefile = new OleDbParameter("@imagefile ", ImageText.Text);//画像
            cmd.Parameters.Add(primagefile);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました", "IM2");
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IM2");
            }
            cn.Close();
            ImageText.Text = "";
            pictureBox1.Image = null;
            dropLbl.Visible = true;
        }

        

        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            string dropfile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string imagefile = Path.GetFileName(dropfile);
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @".\IM2image\" + imagefile;

            try
            {
                System.IO.File.Copy(dropfile, path, true);
            }

            catch
            {
                MessageBox.Show("コピーできませんでした。", "CS-27");
            }
            ImageText.Text = imagefile;
            dropLbl.Visible = false;
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
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
