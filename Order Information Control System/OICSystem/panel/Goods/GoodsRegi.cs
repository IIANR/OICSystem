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

            //if (ImageText.Text == "")//画像がないときのエラーメッセージ
            //{
            //    MessageBox.Show("画像がありません。", "IM2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 商品マスタ (商品ID, 商品名, カテゴリID,単価, 備考, 定期発注数)" +
                " VALUES (@id,@name,@categoryid,@price,@rem,@umber)";
            OleDbParameter gdid = new OleDbParameter("@id",IDText.Text);//商品ID
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
            pictureBox.Image = null;
            DropLbl.Visible = true;
            //clickdata();
        }

        private void clickdata()
        {
            //int max = int.Parse(dataGridView[0, dataGridView.Rows.Count - 2].Value.ToString());
            //IDText.Text = (max + 1).ToString("D3");
            //NameText.Text = dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString();
            //PriceText.Text = dataGridView[2, dataGridView.CurrentCell.RowIndex].Value.ToString();
            //CategoryText.Text = dataGridView[3, dataGridView.CurrentCell.RowIndex].Value.ToString();
            //RemText.Text = dataGridView[4, dataGridView.CurrentCell.RowIndex].Value.ToString();
            //UmberText.Text = dataGridView[5, dataGridView.CurrentCell.RowIndex].Value.ToString();
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string dropfile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string imagefile = Path.GetFileName(dropfile);
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @".\img\" + imagefile;

            pictureBox.Image = Image.FromFile(dropfile);
            try
            {
                System.IO.File.Copy(dropfile, path, true);
            }

            catch
            {
                MessageBox.Show("コピーできませんでした。", "IM2");
            }
            ImageText.Text = imagefile;
            DropLbl.Visible = false;
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
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

        private void dataGridView_Click(object sender, EventArgs e)
        {
            //clickdata();
        }
    }
}
