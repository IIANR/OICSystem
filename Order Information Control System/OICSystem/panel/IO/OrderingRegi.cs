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

namespace WindowsFormsApplication1
{
    public partial class OrderingRegi : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public OrderingRegi()
        {
            InitializeComponent();
        }

        private void PoscodeTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string Address;         //住所
                Boolean blnFlag = false;  //見つかったかどうかのフラグ

                //郵便番号が入力されていないとき
                if (PoscodeTextbox.Text == "")
                {
                    MessageBox.Show("郵便番号が入力されていません。");
                    this.PoscodeTextbox.Focus();
                    return; //処理を抜ける
                }
                //マウスカーソルを砂時計にする
                Cursor.Current = Cursors.WaitCursor;
                string sKey = PoscodeTextbox.Text;
                //文字列の前後のスペースをとる
                sKey = sKey.Trim(' ');
                //Microsoft.VisualBasic名前空間のStrConv関数を使って、
                //全角文字を半角文字に変換
                //sKey = Strings.StrConv(sKey, VbStrConv.Narrow, 0);
                // 文字列の長さを取得する
                int iLength = sKey.Length;
                if (iLength == 8) //"-"が含まれている
                {
                    // 先頭文字目の後から '-' を検索し、見つかった位置を取得する
                    int iFind = sKey.IndexOf('-', 0);
                    //左から3文字+"-"文字以降をtmpZip変数に代入
                    sKey = sKey.Substring(0, 3) + sKey.Substring(iFind + 1);
                }
                try
                {
                    //StreamReaderオブジェクトの作成
                    StreamReader sr = new StreamReader(@"..\..\assets\CSV\KEN_ALL.CSV",
                                                    Encoding.Default);
                    //1行ずつ読み込み
                    string dat;
                    while ((dat = sr.ReadLine()) != null)
                    {
                        string tmpZip;

                        //カンマで区切られた文字列を取得
                        string[] sbuf = dat.Split(',');
                        //配列の3番目が郵便番号
                        tmpZip = sbuf[2].Trim('"');

                        //入力された郵便番号と比較
                        if (sKey == tmpZip)
                        {
                            //住所を作成
                            //都道府県名+市区町村名+町域名
                            Address = sbuf[6].Trim('"') +
                                      sbuf[7].Trim('"') +
                                      sbuf[8].Trim('"');

                            //テキストボックスに住所を表示
                            AddressTextbox1.Text = Address;
                            blnFlag = true; //フラグをTrueにして
                            break;          //ループを抜ける
                        }
                        Application.DoEvents();
                    }
                    //ファイルを閉じる
                    sr.Close();
                }
                catch (Exception ex)
                {
                    //ファイルエラーが発生
                    MessageBox.Show(ex.Message, "ファイルエラー",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return; //処理を抜ける
                }
                finally
                {
                    //マウスカーソルをデフォルトにする
                    Cursor.Current = Cursors.Default;

                }
                if (blnFlag == false)
                {
                    MessageBox.Show("該当の郵便番号は見つかりませんでした。",
                                    "郵便番号検索",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void RegiBtn_Click(object sender, EventArgs e)
        {
            //現在の日付
            DateTime dtNow = DateTime.Now;

            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO 入庫先マスタ (入庫先名,郵便番号,住所1,住所2,電話番号,登録日)" + "VALUES (@name,@pos,@addres1,@addres2,@tel,@date)";
            OleDbParameter prname = new OleDbParameter("@name", NameTextbox.Text);
            cmd.Parameters.Add(prname);
            OleDbParameter prpos = new OleDbParameter("@pos", PoscodeTextbox.Text);
            cmd.Parameters.Add(prpos);
            OleDbParameter praddres1 = new OleDbParameter("@addres1", AddressTextbox1.Text);
            cmd.Parameters.Add(praddres1);
            OleDbParameter praddres2 = new OleDbParameter("@addres2", AddressTextbox2.Text);
            cmd.Parameters.Add(praddres2);
            OleDbParameter prtel = new OleDbParameter("@tel", TelTextbox.Text);
            cmd.Parameters.Add(prtel);
            OleDbParameter prdate = new OleDbParameter("@date", dtNow.ToString("MM/dd"));
            cmd.Parameters.Add(prdate);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void OrderingRegi_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
        }

        private void PoscodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }
    }
}
