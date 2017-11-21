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

        private void regiBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID=" + RemText.Text + "のデータを追加してもよろしいですか", "CS-27", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (ImageText.Text == "")
            {
                MessageBox.Show("新規画像がありません。登録済みの画像が設定されます。", "CS-27", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImageText.Text = textBox6.Text;
            }

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Goods (商品ID, 商品名, 単価, カテゴリID,備考, 定期発注数, 画像ファイル)" +
                " VALUES (@id,@name,@number,@teamid,@borndate,@height,@weight,@imagefile)";
            OleDbParameter gdid = new OleDbParameter("@gdid", IDText.Text);
            cmd.Parameters.Add(gdid);
            OleDbParameter gdname = new OleDbParameter("@gdname", NameText.Text);
            cmd.Parameters.Add(gdname);
            OleDbParameter gdCategoryid = new OleDbParameter("@gdCategoryid", CategoryText.Text);
            cmd.Parameters.Add(gdCategoryid);
            OleDbParameter grrem = new OleDbParameter("@teamid", RemText.Text);
            cmd.Parameters.Add(grrem);
            OleDbParameter prborndate = new OleDbParameter("@borndate", textBox3.Text);
            cmd.Parameters.Add(prborndate);
            OleDbParameter prheight = new OleDbParameter("@height", int.Parse(textBox4.Text));
            cmd.Parameters.Add(prheight);
            OleDbParameter prweight = new OleDbParameter("@weight", int.Parse(textBox5.Text));
            cmd.Parameters.Add(prweight);
            OleDbParameter primagefile = new OleDbParameter("@imagefile ", ImageText.Text);
            cmd.Parameters.Add(primagefile);
        }

        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            string dropfile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string imagefile = Path.GetFileName(dropfile);
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @".\IM2image\" + imagefile;
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
