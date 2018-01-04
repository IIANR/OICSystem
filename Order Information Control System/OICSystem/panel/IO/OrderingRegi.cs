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

        private void OrderingRegi_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            ErrMsg2.Visible = false;
            UpdateBtn.Visible = false;
            RegiBtn.Visible = false;

            dt.Clear();
            OrderingGridview.Columns.Clear();
            OrderingGridview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            //データグリッドビューに注文状況を表示
            da = new OleDbDataAdapter("SELECT * FROM 入庫先マスタ", cn);
            da.Fill(dt);
            OrderingGridview.DataSource = dt;

            OrderingGridview.AllowUserToAddRows = false;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (OrderingGridview.ReadOnly == true)
            {
                OrderingGridview.ReadOnly = false;
                UpdateBtn.Visible = true;
                RegiBtn.Visible = true;
                MessageBox.Show("編集可能になりました。", "編集可能");
            }
            else if (OrderingGridview.ReadOnly == false)
            {
                OrderingGridview.ReadOnly = true;
                UpdateBtn.Visible = false;
                RegiBtn.Visible = false;
                MessageBox.Show("編集不可になりました。", "編集不可");
            }
        }

        private void PoscodeTextbox_Leave(object sender, EventArgs e)
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

        private void TelTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void PoscodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OrderingGridview.Rows.Count; i++)
            {
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 入庫先マスタ SET 入庫先名 ='" + (string)OrderingGridview.Rows[i].Cells[1].Value.ToString()
                    + "' ,郵便番号 ='" + (string)OrderingGridview.Rows[i].Cells[2].Value.ToString()
                    + "' ,住所1 ='" + (string)OrderingGridview.Rows[i].Cells[3].Value.ToString()
                    + "' ,住所2 ='" + (string)OrderingGridview.Rows[i].Cells[4].Value.ToString()
                    + "' ,電話番号 ='" + (string)OrderingGridview.Rows[i].Cells[5].Value.ToString()
                    + "' WHERE 入庫先ID=" + (int)OrderingGridview.Rows[i].Cells[0].Value + "";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("更新しました", "OICSystem");

            NameTextbox.Text = "";
            TelTextbox.Text = "";
            PoscodeTextbox.Text = "";
            AddressTextbox1.Text = "";
            AddressTextbox2.Text = "";
        }

        private void RegiBtn_Click(object sender, EventArgs e)
        {
            //現在の日付
            DateTime dtNow = DateTime.Now;

            if (NameTextbox.Text == null || NameTextbox.Text == "" || TelTextbox.Text == null || TelTextbox.Text == "" || PoscodeTextbox.Text == null || PoscodeTextbox.Text == "" || AddressTextbox1.Text == null || AddressTextbox1.Text == "")
            {
                ErrMsg2.Visible = true;
                ErrMsg2.Text = "";
                ErrMsg2.Text = "※住所2以外で未入力の項目があります";
            }

            else
            {
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

                MessageBox.Show("更新しました", "OICSystem");

                NameTextbox.Text = "";
                TelTextbox.Text = "";
                PoscodeTextbox.Text = "";
                AddressTextbox1.Text = "";
                AddressTextbox2.Text = "";

                ErrMsg2.Visible = false;
            }
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            OrderingGridview.Columns.Clear();
            OrderingGridview.DataSource = null;

            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            //データグリッドビューに注文状況を表示
            da = new OleDbDataAdapter("SELECT * FROM 入庫先マスタ", cn);
            da.Fill(dt);
            OrderingGridview.DataSource = dt;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ErrMsg2.Visible = false;

            NameTextbox.Text = "";
            TelTextbox.Text = "";
            PoscodeTextbox.Text = "";
            AddressTextbox1.Text = "";
            AddressTextbox2.Text = "";

            dt.Clear();
            OrderingGridview.DataSource = null;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT 入庫先ID,入庫先名,郵便番号,住所1,住所2,電話番号,登録日 FROM 入庫先マスタ" +
                " WHERE 入庫先名 LIKE '%" + NameTextbox.Text + "%'" +
                " AND 郵便番号 LIKE '%" + PoscodeTextbox.Text + "%'" +
                " AND 住所1 LIKE '%" + AddressTextbox1.Text + "%'" +
                " AND 住所2 LIKE '%" + AddressTextbox2.Text + "%'" +
                " AND 電話番号 LIKE '%" + TelTextbox.Text + "%'", cn);

            dt = new DataTable();
            da.Fill(dt);

            OrderingGridview.DataSource = dt;
        }
    }
}
