using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class OrderMgtRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();

        static int sum = 0;

        private double Tax = 0;
        DataSet sdt = new DataSet();

        public OrderMgtRegister()
        {
            InitializeComponent();
        }

        public void OrderMgtRegister_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            OleDbDataAdapter datax = new OleDbDataAdapter("SELECT 税率 FROM Tax", cn);
            DataTable dttax = new DataTable();
            datax.Fill(dttax);
            Tax = double.Parse(dttax.Rows[0][0].ToString());//データテーブルの0行0列のデータ
            dttax.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("商品名", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("単価", Type.GetType("System.String")));

            sdt.Tables.Add(dt);          
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            OleDbDataAdapter dagoods = new OleDbDataAdapter("SELECT 商品名,単価 FROM 商品マスタ WHERE 商品ID='" + int.Parse(GoodsidTextBox.Text) + "'", cn);
            DataTable dtgoods = new DataTable();
            dagoods.Fill(dtgoods);

            ErrMsg.Text = "";

            if (dtgoods.Rows.Count < 1)
            {
                ErrMsg.Text = "登録されていない商品です";
                return;
            }


            //動的なデータテーブルを戻す
            DataTable dt = sdt.Tables[0];//DataTable型にキャスト

            //反映されるまで待機
            while (dt == null)
            {
                System.Threading.Thread.Sleep(0);
            }

            //データテーブルに追加する行を作成
            DataRow dr;
            dr = dt.NewRow();
            dr["商品名"] = dtgoods.Rows[0][0].ToString();
            dr["価格"] = string.Format("{0:#,###}円", int.Parse(dtgoods.Rows[0][1].ToString()));

            //小計を計算
            sum += int.Parse(dtgoods.Rows[0][1].ToString());

            // データテーブル商品をクリア
            dtgoods.Clear();

            // データテーブルに行を追加
            dt.Rows.Add(dr);

            // GridView1にデータをバインド
            OrderRegiDataGridview.DataSource = dt;
            //OrderRegiDataGridview.DataBind();


            //// 次の入力のために、テキスト入力エリアのクリアとフォーカスの移動
            //TextBGoodsID.Text = "";
            //TextBGoodsID.Focus();          //フォーカス

            //// ラベルの表示
            //LblSumTitle.Visible = true;
            //LblTaxTitle.Visible = true;
            //LblGokeiTitle.Visible = true;
            //LblSum.Visible = true;
            //LblTax.Visible = true;
            //LblGokei.Visible = true;

            // 消費税の計算と金額の表示
            double tax = Tax;
            //LblSum.Text = string.Format("{0:#,###}円", sum);
            //LblTax.Text = string.Format("{0:#,###}円", sum * tax);         //消費税
            TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * tax);  //消費税を加えた合計金額
        }
    }
}
