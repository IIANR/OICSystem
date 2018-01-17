using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderList : Form
    {
        TextBox aa = new TextBox();
        int cnt = 0;
        int poi;
        string GoodsId = "";
        string[] GoodsIdArray = new string[] { };
        string[,] count2 = new string[20, 12] { { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "", "" } };
        string[] count3 = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", };

        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public OrderList()
        {
            InitializeComponent();
        }

        //フォームのイメージを保存する変数
        private Bitmap memoryImage;

        /// <summary>
        /// フォームのイメージを印刷する
        /// </summary>
        /// <param name="frm">イメージを印刷するフォーム</param>
        public void PrintForm(Form frm)
        {
            //フォームのイメージを取得する
            memoryImage = CaptureControl(frm);
            //フォームのイメージを印刷する
            System.Drawing.Printing.PrintDocument PrintDocument1 =
                 new System.Drawing.Printing.PrintDocument();
            PrintDocument1.PrintPage +=
                 new System.Drawing.Printing.PrintPageEventHandler(
                 PrintDocument1_PrintPage);
            PrintDocument1.Print();

            memoryImage.Dispose();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest,
             int nXDest, int nYDest, int nWidth, int nHeight,
             IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        private const int SRCCOPY = 0xCC0020;

        /// <summary>
        /// コントロールのイメージを取得する
        /// </summary>
        /// <param name="ctrl">キャプチャするコントロール</param>
        /// <returns>取得できたイメージ</returns>
        public Bitmap CaptureControl(Control ctrl)
        {
            Graphics g = ctrl.CreateGraphics();
            Bitmap img = new Bitmap(ctrl.ClientRectangle.Width,
                ctrl.ClientRectangle.Height, g);
            Graphics memg = Graphics.FromImage(img);
            IntPtr dc1 = g.GetHdc();
            IntPtr dc2 = memg.GetHdc();
            BitBlt(dc2, 0, 0, img.Width, img.Height, dc1, 0, 0, SRCCOPY);
            g.ReleaseHdc(dc1);
            memg.ReleaseHdc(dc2);
            memg.Dispose();
            g.Dispose();
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);//数字変えれば回転する
            return img;
        }

        //PrintDocument1のPrintPageイベントハンドラ
        private void PrintDocument1_PrintPage(object sender,
             System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        protected void DataGrids2(string orderid, int p)
        {
            DataSet sal = new DataSet();

            //Goodsテーブルから商品ID,商品名,単価を商品ID順に取り出す
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT 商品ID,商品名 FROM 商品マスタ ORDER BY 商品ID", cn);
            DataTable su = new DataTable();
            da.Fill(su);

            DataTable goods = sal.Tables.Add("goods");
            DataRow dtRow;

            var count = new int[su.Rows.Count];


            goods.Columns.Add("商品ID", Type.GetType("System.String"));
            goods.Columns.Add("商品名", Type.GetType("System.String"));
            goods.Columns.Add("数量", Type.GetType("System.Double"));


            //配列の初期化
            for (int i = 0; i < su.Rows.Count; i++)
            {
                count[i] = 0;
            }
            //数量計算
            for (int i = 0; i < count2.GetLongLength(1); i++)
            {
                if (count2[p, i] != "")
                {
                    count[int.Parse(count2[p, i]) - 1] += 1;
                }
            }

            for (int i = 0; i < su.Rows.Count; i++)
            {
                dtRow = goods.NewRow();
                dtRow["商品ID"] = su.Rows[i][0];      //DBから取得したdtの商品IDを示す行の行番号と列番号
                dtRow["商品名"] = su.Rows[i][1];  //DBから取得したdtの商品名を示す行の行番号と列番号
                dtRow["数量"] = count[i];
                if (count[i] != 0)
                {
                    goods.Rows.Add(dtRow);
                }
            }
            OrderListDataGridView2.DataSource = sal;
            OrderListDataGridView2.DataMember = "goods";

            lblid1.Text = "注文ID：" + orderid;
            OrderListDataGridView.Focus();
            OrderListDataGridView.Rows[p].Selected = true;
            OrderListDataGridView2.RowHeadersVisible = false;
            OrderListDataGridView2.CurrentCell = null;
        }

        protected void DataGrids3(string orderid, int p)
        {
            DataSet sal = new DataSet();

            //Goodsテーブルから商品ID,商品名,単価を商品ID順に取り出す
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT 商品ID,商品名 FROM 商品マスタ ORDER BY 商品ID", cn);
            DataTable su = new DataTable();
            da.Fill(su);

            DataTable goods = sal.Tables.Add("goods");
            DataRow dtRow;

            var count = new int[su.Rows.Count];


            goods.Columns.Add("商品ID", Type.GetType("System.String"));
            goods.Columns.Add("商品名", Type.GetType("System.String"));
            goods.Columns.Add("数量", Type.GetType("System.Double"));


            //配列の初期化
            for (int i = 0; i < su.Rows.Count; i++)
            {
                count[i] = 0;
            }
            //数量計算
            for (int i = 0; i < count2.GetLongLength(1); i++)
            {
                if (count2[p, i] != "")
                {
                    count[int.Parse(count2[p, i]) - 1] += 1;
                }
            }

            for (int i = 0; i < su.Rows.Count; i++)
            {
                dtRow = goods.NewRow();
                dtRow["商品ID"] = su.Rows[i][0];      //DBから取得したdtの商品IDを示す行の行番号と列番号
                dtRow["商品名"] = su.Rows[i][1];  //DBから取得したdtの商品名を示す行の行番号と列番号
                dtRow["数量"] = count[i];
                if (count[i] != 0)
                {
                    goods.Rows.Add(dtRow);
                }
            }
            OrderListDataGridView3.DataSource = sal;
            OrderListDataGridView3.DataMember = "goods";

            lblid2.Text = "注文ID：" + orderid;
            OrderListDataGridView.Focus();
            OrderListDataGridView.Rows[p].Selected = true;
            OrderListDataGridView3.RowHeadersVisible = false;
            OrderListDataGridView3.CurrentCell = null;
        }

        protected void DataGrids4(string orderid, int p)
        {
            DataSet sal = new DataSet();

            //Goodsテーブルから商品ID,商品名,単価を商品ID順に取り出す
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT 商品ID,商品名 FROM 商品マスタ ORDER BY 商品ID", cn);
            DataTable su = new DataTable();
            da.Fill(su);

            DataTable goods = sal.Tables.Add("goods");
            DataRow dtRow;

            var count = new int[su.Rows.Count];


            goods.Columns.Add("商品ID", Type.GetType("System.String"));
            goods.Columns.Add("商品名", Type.GetType("System.String"));
            goods.Columns.Add("数量", Type.GetType("System.Double"));


            //配列の初期化
            for (int i = 0; i < su.Rows.Count; i++)
            {
                count[i] = 0;
            }
            //数量計算
            for (int i = 0; i < count2.GetLongLength(1); i++)
            {
                if (count2[p, i] != "")
                {
                    count[int.Parse(count2[p, i]) - 1] += 1;
                }
            }

            for (int i = 0; i < su.Rows.Count; i++)
            {
                dtRow = goods.NewRow();
                dtRow["商品ID"] = su.Rows[i][0];      //DBから取得したdtの商品IDを示す行の行番号と列番号
                dtRow["商品名"] = su.Rows[i][1];  //DBから取得したdtの商品名を示す行の行番号と列番号
                dtRow["数量"] = count[i];
                if (count[i] != 0)
                {
                    goods.Rows.Add(dtRow);
                }
            }
            OrderListDataGridView4.DataSource = sal;
            OrderListDataGridView4.DataMember = "goods";

            lblid3.Text = "注文ID：" + orderid;
            OrderListDataGridView.Focus();
            OrderListDataGridView.Rows[p].Selected = true;
            OrderListDataGridView4.RowHeadersVisible = false;
            OrderListDataGridView4.CurrentCell = null;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = !this.MaximizeBox;

            dt.Clear();
            OrderListDataGridView.Columns.Clear();
            OrderListDataGridView.DataSource = null;

            GoodsId = "";

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT 注文テーブル.注文ID, 注文テーブル.注文日, 注文テーブル.商品ID, 顧客テーブル.名前, 顧客テーブル.郵便番号, 顧客テーブル.住所1, 顧客テーブル.住所2, 顧客テーブル.電話番号 FROM 従業員マスタ INNER JOIN(顧客テーブル INNER JOIN 注文テーブル ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID) ON 従業員マスタ.従業員ID = 注文テーブル.従業員ID WHERE 注文テーブル.フラグ = '入金済み' AND 注文テーブル.入金済み = True order by 注文テーブル.注文ID; ";
            cn.Open();
            OleDbDataReader dreader = cmd.ExecuteReader();
            OrderListDataGridView.Columns.Add("orderid", "注文ID");
            OrderListDataGridView.Columns.Add("date", "注文日");
            OrderListDataGridView.Columns.Add("membername", "名前");
            OrderListDataGridView.Columns.Add("poscode", "郵便番号");
            OrderListDataGridView.Columns.Add("addres1", "住所1");
            OrderListDataGridView.Columns.Add("addres2", "住所2");
            OrderListDataGridView.Columns.Add("tel", "電話番号");

            cnt = 0;
            //cnt2 = 0;
            int id;
            while (dreader.Read())
            {
                OrderListDataGridView.Rows.Add();
                id = dreader.GetInt32(0);
                OrderListDataGridView["orderid", cnt].Value = id.ToString();
                count3[cnt] = id.ToString();
                OrderListDataGridView["date", cnt].Value = dreader.GetDateTime(1).ToString("yyyy/MM/dd");
                GoodsId = dreader.GetString(2);
                GoodsIdArray = GoodsId.Split(',');

                for (int i = 0; i < GoodsIdArray.Length; i++)
                {
                    count2[cnt, i] = GoodsIdArray[i].ToString();
                }

                // count2[cnt2,0]=GoodsIdArray;
                OrderListDataGridView["membername", cnt].Value = dreader.GetString(3);
                OrderListDataGridView["poscode", cnt].Value = dreader.GetString(4);
                OrderListDataGridView["addres1", cnt].Value = dreader.GetString(5);
                OrderListDataGridView["addres2", cnt].Value = dreader.GetString(6);
                OrderListDataGridView["tel", cnt].Value = dreader.GetString(7);
                cnt++;
                //cnt2++;
            }
            cn.Close();
            poi = 0;
            if (count3[poi] != "")
            {
                DataGrids2(count3[poi], poi);

                if (count3[poi + 1] != "")
                {
                    DataGrids3(count3[poi + 1], poi + 1);

                    if (count3[poi + 2] != "")
                    {
                        DataGrids4(count3[poi + 2], poi + 2);


                    }
                    else
                    {

                        OrderListDataGridView4.Visible = false;
                    }
                }
                else
                {

                    OrderListDataGridView3.Visible = false;
                    OrderListDataGridView4.Visible = false;
                }
            }
            else
            {
                OrderListDataGridView2.Visible = false;
                OrderListDataGridView3.Visible = false;
                OrderListDataGridView4.Visible = false;
            }


            OrderListDataGridView.RowHeadersVisible = false;
            OrderListDataGridView.AllowUserToAddRows = false;
            OrderListDataGridView2.AllowUserToAddRows = false;
            OrderListDataGridView3.AllowUserToAddRows = false;
            OrderListDataGridView4.AllowUserToAddRows = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (0 <= poi - 1)
            {
                poi -= 1;
                OrderListDataGridView.Rows[poi + 3].Selected = false;
                DataGrids2(count3[poi], poi);
                DataGrids3(count3[poi + 1], poi + 1);
                DataGrids4(count3[poi + 2], poi + 2);
            }
            else
            {
                MessageBox.Show("これより前のデータは存在しません", "範囲外");
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (poi + 3 < cnt)
            {
                poi += 1;
                OrderListDataGridView.Rows[poi - 1].Selected = false;
                DataGrids2(count3[poi], poi);
                DataGrids3(count3[poi + 1], poi + 1);
                DataGrids4(count3[poi + 2], poi + 2);
            }
            else
            {
                MessageBox.Show("これより後のデータは存在しません", "範囲外");
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (OrderListDataGridView.RowCount < 1)
            {
                MessageBox.Show("データがありません", "OICSystem");
                return;
            }



            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument pd = new PrintDocument();

                PrintForm(this);

            }
        }

        private void Next3Btn_Click(object sender, EventArgs e)
        {
            if (poi + 5 < cnt)
            {
                poi += 3;
                OrderListDataGridView.Rows[poi - 1].Selected = false;
                OrderListDataGridView.Rows[poi - 2].Selected = false;
                OrderListDataGridView.Rows[poi - 3].Selected = false;
                DataGrids2(count3[poi], poi);
                DataGrids3(count3[poi + 1], poi + 1);
                DataGrids4(count3[poi + 2], poi + 2);
            }
            else
            {
                MessageBox.Show("これより後に3件以上のデータが存在しません", "範囲外");
            }
        }

        private void Back3Btn_Click(object sender, EventArgs e)
        {
            if (0 <= poi - 3)
            {
                poi -= 3;
                OrderListDataGridView.Rows[poi + 3].Selected = false;
                OrderListDataGridView.Rows[poi + 4].Selected = false;
                OrderListDataGridView.Rows[poi + 5].Selected = false;
                DataGrids2(count3[poi], poi);
                DataGrids3(count3[poi + 1], poi + 1);
                DataGrids4(count3[poi + 2], poi + 2);
            }
            else
            {
                MessageBox.Show("これより前に3件以上のデータが存在しません", "範囲外");
            }
        }

        
    }
}
