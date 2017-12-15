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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class EmpMgt : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        string tsex;
        bool tAuthority;



        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            EmpdataGridView.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            EmpdataGridView.DataSource = dt;
            EmpdataGridView.AutoResizeColumns();
        }

        private const string PASSWORD_num = "0123456789";
        private const string PASSWORD_CHARS = "abcdefghijklmnopqrstuvwxyz";

        public static string GenerateId(int length)
        {
            var sb = new System.Text.StringBuilder(length);
            var r = new System.Random();
            int pos;
            char c;
            for (int i = 0; i < length; i++)
            {
                pos = r.Next(PASSWORD_num.Length);
                c = PASSWORD_num[pos];
                sb.Append(c);
            }

            return sb.ToString();
        }

        public static string GeneratePassword(int length)
        {
            var sb = new System.Text.StringBuilder(length);
            var r = new System.Random();
            int pos;
            char c;
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    pos = r.Next(PASSWORD_num.Length);
                    c = PASSWORD_num[pos];
                    sb.Append(c);
                }
                else
                {
                    pos = r.Next(PASSWORD_CHARS.Length);
                    c = PASSWORD_CHARS[pos];
                    sb.Append(c);
                }

            }

            return sb.ToString();
        }

        public EmpMgt()
        {
            InitializeComponent();
        }

        private void EmpMgt_Load(object sender, EventArgs e)
        {
            dataload(0);
            BirthdayTextB.Mask = "0000年90月90日";
            EmpdataGridView.AllowUserToAddRows = false;
        }

        private void RegistrationB_Click(object sender, EventArgs e)
        {
            //現在の日付
            DateTime dtNow = DateTime.Now;
            if (EmpNameTextB == null || HuriganaTextB == null || tsex == null || EmpPostTextB == null || EmpAddressTextB == null || EmpAddress2TextB == null || EmpTelTextB == null || BirthdayTextB == null)
            {
                MessageBox.Show("空白の部分があります", "失敗");

                //    try
                //    {
                //        cn.Open();
                //        //cmd.ExecuteNonQuery();
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message, "miss");
                //    }
                //finally   //●
                //    {
                //        cmd.Parameters.Clear();   //●
                //        cn.Close();
                //    }
                //    dataload(dcnt);   // ●データを再ロード
                //    dt.Clear();
                //    //EmpdataGridView.DataSource = null;
            }
            else
            {
                if (MessageBox.Show(EmpNameTextB.Text + "のデータを登録してもよろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                string id;
                string pass;
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                cn.Open();

                cmd.CommandText = "SELECT * FROM 従業員マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();

                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();
                int db_id;
                id = GenerateId(6);

                while (rd.Read())
                {
                    db_id = (int)rd.GetValue(0);

                    while (db_id == int.Parse(id))
                    {
                        id = GenerateId(6);
                    }

                }
                int db_pass;
                pass = GeneratePassword(6);

                while (rd.Read())
                {
                    db_pass = (int)rd.GetValue(0);

                    while (db_pass == int.Parse(pass))
                    {
                        pass = GeneratePassword(6);
                    }

                }

                cn.Close();
                EmpdataGridView.AllowUserToAddRows = true;
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO 従業員マスタ (従業員ID,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限,パスワード)" +
                    " VALUES (@empid,@name,@assistname,@sex,@post,@addres,@address2,@tel,@birthday,@day,@authority,@pass)";
                OleDbParameter prempid = new OleDbParameter("@empid", int.Parse(id));
                cmd.Parameters.Add(prempid);
                OleDbParameter prname = new OleDbParameter("@name", EmpNameTextB.Text);
                cmd.Parameters.Add(prname);
                OleDbParameter prassistname = new OleDbParameter("@assistname", HuriganaTextB.Text);
                cmd.Parameters.Add(prassistname);
                OleDbParameter prsex = new OleDbParameter("@sex", tsex.ToString());
                cmd.Parameters.Add(prsex);
                OleDbParameter prpost = new OleDbParameter("@post", EmpPostTextB.Text);
                cmd.Parameters.Add(prpost);
                OleDbParameter praddres = new OleDbParameter("@addres", EmpAddressTextB.Text);
                cmd.Parameters.Add(praddres);
                OleDbParameter praddres2 = new OleDbParameter("@addres2", EmpAddress2TextB.Text);
                cmd.Parameters.Add(praddres2);
                OleDbParameter prtel = new OleDbParameter("@tel", EmpTelTextB.Text);
                cmd.Parameters.Add(prtel);
                OleDbParameter prbirthday = new OleDbParameter("@birthday", BirthdayTextB.Text);
                cmd.Parameters.Add(prbirthday);
                OleDbParameter prday = new OleDbParameter("@day", dtNow.ToString("MM/dd"));
                cmd.Parameters.Add(prday);
                OleDbParameter prauthority = new OleDbParameter("@authority", tAuthority);
                cmd.Parameters.Add(prauthority);
                OleDbParameter prpass = new OleDbParameter("@pass", pass);
                cmd.Parameters.Add(prpass);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("追加しました", "成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ok");
                }
                finally   //●
                {
                    cmd.Parameters.Clear();   //●
                    cn.Close();
                }
                dataload(dcnt);   // ●データを再ロード
                dt.Clear();
                EmpdataGridView.DataSource = null;
                EmpdataGridView.AllowUserToAddRows = false;
                EmpNameTextB.Text = "";
                HuriganaTextB.Text = "";
                EmpPostTextB.Text = "";
                EmpAddressTextB.Text = "";
                EmpAddress2TextB.Text = "";
                EmpTelTextB.Text = "";
                BirthdayTextB.Text = "";

                ManRB.Checked = false;
                WomanRB.Checked = false;
                YesAuthorityRB.Checked = false;
                NoAuthorityRB.Checked = false;

                dataload(0);
            }
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



        private void Clickdata()
        {
            int max = int.Parse(EmpdataGridView[0, EmpdataGridView.Rows.Count - 2].Value.ToString());
            //EmpIDTextB.Text = EmpdataGridView[1, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            //EmpPassTextB.Text = EmpdataGridView[2, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpNameTextB.Text = EmpdataGridView[3, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            BirthdayTextB.Text = DateTime.Parse(EmpdataGridView[4, EmpdataGridView.CurrentCell.RowIndex].Value.ToString()).ToString();
            HuriganaTextB.Text = EmpdataGridView[5, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpPostTextB.Text = EmpdataGridView[6, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpAddressTextB.Text = EmpdataGridView[7, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();
            EmpTelTextB.Text = EmpdataGridView[8, EmpdataGridView.CurrentCell.RowIndex].Value.ToString();


        }
        static int dcnt = 0;   //●　データの行数を入れる変数

        private void dataload(int n)
        {
            EmpdataGridView.Columns.Clear();
            EmpdataGridView.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            da = new OleDbDataAdapter("SELECT 従業員ID,パスワード,名前,ﾌﾘｶﾞﾅ,性別,郵便番号,住所1,住所2,電話番号,生年月日,入社日,責任者権限,備考 FROM 従業員マスタ", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            dcnt = dt.Rows.Count;      //データの行数

            EmpdataGridView.DataSource = dt;
            EmpdataGridView.AutoResizeColumns();
            EmpdataGridView.ClearSelection();
            EmpdataGridView.Rows[n].Selected = true;
            EmpdataGridView.FirstDisplayedScrollingRowIndex = n;
            foreach (DataGridViewColumn c in EmpdataGridView.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataload(0);
        }

        private void EmpPostTextB_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string Address;         //住所
                Boolean blnFlag = false;  //見つかったかどうかのフラグ

                //郵便番号が入力されていないとき
                if (EmpPostTextB.Text == "")
                {
                    MessageBox.Show("郵便番号が入力されていません。");
                    this.EmpPostTextB.Focus();
                    return; //処理を抜ける
                }
                //マウスカーソルを砂時計にする
                Cursor.Current = Cursors.WaitCursor;
                string sKey = EmpPostTextB.Text;
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
                            EmpAddressTextB.Text = Address;
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

        private void ManRB_CheckedChanged_1(object sender, EventArgs e)
        {
            tsex = WomanRB.Text;
        }

        private void WomanRB_CheckedChanged_1(object sender, EventArgs e)
        {
            tsex = ManRB.Text;
        }

        private void YesAuthorityRB_CheckedChanged_1(object sender, EventArgs e)
        {
            tAuthority = true;
        }

        private void NoAuthorityRB_CheckedChanged_1(object sender, EventArgs e)
        {
            tAuthority = false;
        }
    }
}

