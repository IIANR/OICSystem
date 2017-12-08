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
    public partial class OrderMgtRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataTable dttemp = new DataTable();

        string InGoodsid = "";
        string db_Goodsid = "";
        string db_Goodsname = "";
        int db_GoodsPrice = 0;
        int db_memberid = 0;
        static int cnt = 0;

        static int sum = 0;
        double Tax = 0;

        public OrderMgtRegister()
        {
            InitializeComponent();

            this.Disposed += (sender, args) =>
            {
                if (dttemp.Rows.Count > 0)
                {
                    for (int i = 0; i < dttemp.Rows.Count; i++)
                    {
                        string Goodsname = dttemp.Rows[i][1].ToString();

                        //在庫数を増やす
                        cmd.Connection = cn;
                        cmd.CommandText = "UPDATE 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID SET 在庫テーブル.在庫数 = 在庫テーブル.在庫数 + 1 WHERE 商品マスタ.商品名 = '" + Goodsname + "'";
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            };
        }

        private DataTable GetDataTable()
        {
            var cols = OrderRegiDataGridview.Columns;
            foreach (DataGridViewColumn c in cols)
            {
                if (c.ValueType != null)
                {
                    dttemp.Columns.Add(c.Name, c.ValueType);
                }
                else
                {
                    dttemp.Columns.Add(c.Name);
                }
            }

            var rows = OrderRegiDataGridview.Rows;
            foreach (DataGridViewRow r in rows)
            {
                List<object> array = new List<object>();
                foreach (DataGridViewCell cell in r.Cells)
                {
                    array.Add(cell.Value);
                }
                dttemp.Rows.Add(array.ToArray());
            }
            return dttemp;
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

        public void OrderMgtRegister_Load(object sender, EventArgs e)
        {
            ErrMsg.Visible = false;
            ErrMsg2.Visible = false;
            TotalLabel.Visible = false;

            dtclear();

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
            cn.Open();

            cmd.CommandText = "SELECT * FROM 税率マスタ";
            cmd.Connection = cn;

            OleDbDataReader rd = cmd.ExecuteReader();


            dt = CreateSchemaDataTable(rd);
            DataRow row = dt.NewRow();

            while (rd.Read())
            {
                Tax = (double)rd.GetValue(0);
            }

            cn.Close();

            OrderRegiDataGridview.AllowUserToAddRows = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            dttemp.Clear();
            dttemp.Columns.Clear();

            if (GoodsidTextBox.Text == null || GoodsidTextBox.Text == "")
            {
                ErrMsg.Visible = true;
                ErrMsg.Text = "";
                ErrMsg.Text = "※商品IDを入力してください";
            }
            else if (NumCombo.Text==null|| NumCombo.Text == "")
            {
                ErrMsg.Visible = true;
                ErrMsg.Text = "";
                ErrMsg.Text = "※商品数量を入力してください";
            }

            else
            {
                int GoodsNum = 0;
                OleDbDataAdapter dastock = new OleDbDataAdapter("SELECT 在庫数 FROM 在庫テーブル WHERE 商品ID='" + GoodsidTextBox.Text + "'", cn);
                DataTable dtstock = new DataTable();
                dastock.Fill(dtstock);
                GoodsNum=int.Parse(dtstock.Rows[0][0].ToString());

                if (GoodsNum-int.Parse(NumCombo.Text) >= 0)
                {
                    dtstock.Clear();

                    cmd.Connection = cn;
                    cmd.CommandText = "UPDATE 在庫テーブル SET 在庫数=(在庫数-"+int.Parse(NumCombo.Text)+")WHERE 商品ID='" + GoodsidTextBox.Text + "'";
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    ErrMsg.Visible = false;
                    ErrMsg2.Visible = false;

                    //データーグリットビューにデータの追加を許可
                    OrderRegiDataGridview.AllowUserToAddRows = true;

                    for (int i = 0; i < int.Parse(NumCombo.Text); i++)
                    {
                        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                        cn.Open();

                        cmd.CommandText = "SELECT * FROM 商品マスタ";
                        cmd.Connection = cn;

                        OleDbDataReader rd = cmd.ExecuteReader();

                        dt = CreateSchemaDataTable(rd);
                        DataRow row = dt.NewRow();

                        InGoodsid = GoodsidTextBox.Text;

                        while (rd.Read())
                        {
                            db_Goodsid = (string)rd.GetValue(0);
                            db_Goodsname = (string)rd.GetValue(1);
                            db_GoodsPrice = (int)rd.GetValue(2);
                            if (db_Goodsid == InGoodsid)
                            {
                                OrderRegiDataGridview.Rows.Add();
                                OrderRegiDataGridview["GoodsId", cnt].Value = db_Goodsid;
                                OrderRegiDataGridview["GoodsName", cnt].Value = db_Goodsname;
                                OrderRegiDataGridview["GoodsPrice", cnt].Value = db_GoodsPrice;
                                cnt++;
                                sum += db_GoodsPrice;
                            }

                        }

                        //合計金額を表示
                        TotalLabel.Visible = true;
                        TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);

                        cn.Close();
                        //OrderRegiDataGridview.AutoResizeColumns();
                    }
                    GoodsidTextBox.Text = "";
                    NumCombo.SelectedIndex = 0;

                    //データーグリットビューにデータの追加を許可(空白行削除)
                    OrderRegiDataGridview.AllowUserToAddRows = false;

                    GetDataTable();
                }
                else
                {
                    MessageBox.Show("在庫が不足しています", "OICSystem");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in OrderRegiDataGridview.SelectedRows)
            {
                dttemp.Clear();
                dttemp.Columns.Clear();

                //OrderRegiDataGridviewから選択している行の商品名を取得
                string Goodsname = (string)OrderRegiDataGridview.CurrentRow.Cells[1].Value;

                //在庫数を増やす
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE 在庫テーブル INNER JOIN 商品マスタ ON 在庫テーブル.商品ID = 商品マスタ.商品ID SET 在庫テーブル.在庫数 = 在庫テーブル.在庫数 + 1 WHERE 商品マスタ.商品名 = '" + Goodsname + "'";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;";
                cn.Open();

                cmd.CommandText = "SELECT * FROM 商品マスタ";
                cmd.Connection = cn;

                OleDbDataReader rd = cmd.ExecuteReader();


                dt = CreateSchemaDataTable(rd);
                DataRow row = dt.NewRow();

                while (rd.Read())
                {
                    db_Goodsname = (string)rd.GetValue(1);
                    db_GoodsPrice = (int)rd.GetValue(2);
                    if (db_Goodsname == Goodsname)
                    {
                        sum -= db_GoodsPrice;
                    }               
                }
                //合計金額再表示
                TotalLabel.Text = string.Format("{0:#,###}円", sum + sum * Tax);



                cn.Close();


                if (!item.IsNewRow)
                {
                    OrderRegiDataGridview.Rows.Remove(item);
                    cnt--;
                }

                GetDataTable();
            }

            // 行データがなくなったら、ラベルを非表示
            if (OrderRegiDataGridview.Rows.Count == 0)
            {
                TotalLabel.Text = "";
                TotalLabel.Visible = false;
            }
        }

        private void GoodsidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void OrderCompBtn_Click(object sender, EventArgs e)
        {
            if (OrderRegiDataGridview.Rows.Count == 0)
            {
                ErrMsg.Visible = true;
                ErrMsg.Text = "";
                ErrMsg.Text = "※商品が一つも追加されていません";
            }

            else if (NameTextbox.Text == null || NameTextbox.Text == "" || KanaTextbox.Text == null || KanaTextbox.Text == "" || PoscodeTextbox.Text == null || PoscodeTextbox.Text == "" || AddressTextbox1.Text == null || AddressTextbox1.Text == "" || TelTextbox.Text == null || TelTextbox.Text == "")
            {
                ErrMsg2.Visible = true;
                ErrMsg2.Text = "";
                ErrMsg2.Text = "※必須項目で抜けている項目があります";
            }


            else
            {
                //ログイン中の従業員IDを取得する
                int Empid = Login.LoginInstance.Empid;

                //現在の日付
                DateTime dtNow = DateTime.Now;

                if (MessageBox.Show("注文を確定してもよろしいですか？", "OICSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                ////商品名からIDを抽出し、注文されたIDのリストをカンマ区切りで作成する
                string goodsIDlist = "";
                for (int i = 0; i < OrderRegiDataGridview.Rows.Count; i++)
                {
                    string Goodsname = OrderRegiDataGridview.Rows[i].Cells[1].Value.ToString();

                    cn.Open();

                    cmd.CommandText = "SELECT * FROM 商品マスタ";
                    cmd.Connection = cn;

                    OleDbDataReader rd = cmd.ExecuteReader();


                    dt = CreateSchemaDataTable(rd);
                    DataRow row = dt.NewRow();

                    while (rd.Read())
                    {
                        db_Goodsname = (string)rd.GetValue(1);
                        if (db_Goodsname == Goodsname)
                        {
                            goodsIDlist += (string)rd.GetValue(0).ToString() + ",";
                        }
                    }

                    cn.Close();

                }

                // 最後のカンマを取り除く
                goodsIDlist = goodsIDlist.Substring(0, goodsIDlist.Length - 1);


                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO 顧客テーブル (名前,ﾌﾘｶﾞﾅ,電話番号,郵便番号,住所1,住所2,登録日)" + "VALUES (@name,@kana,@tel,@pos,@addres1,@addres2,@date)";
                OleDbParameter prname = new OleDbParameter("@name", NameTextbox.Text);
                cmd.Parameters.Add(prname);
                OleDbParameter prkana = new OleDbParameter("@kana", KanaTextbox.Text);
                cmd.Parameters.Add(prkana);
                OleDbParameter prtel = new OleDbParameter("@tel", TelTextbox.Text);
                cmd.Parameters.Add(prtel);
                OleDbParameter prpos = new OleDbParameter("@pos", PoscodeTextbox.Text);
                cmd.Parameters.Add(prpos);
                OleDbParameter praddres1 = new OleDbParameter("@addres1", AddressTextbox1.Text);
                cmd.Parameters.Add(praddres1);
                OleDbParameter praddres2 = new OleDbParameter("@addres2", AddressTextbox2.Text);
                cmd.Parameters.Add(praddres2);
                OleDbParameter prdate = new OleDbParameter("@date", dtNow.ToString("MM/dd"));
                cmd.Parameters.Add(prdate);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = cn;
                    cmd3.CommandText = "SELECT * FROM 顧客テーブル";
                    OleDbDataReader rd = cmd3.ExecuteReader();


                    dt = CreateSchemaDataTable(rd);
                    DataRow row = dt.NewRow();

                    while (rd.Read())
                    {
                        db_memberid = (int)rd.GetValue(0);
                    }

                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = cn;
                    cmd2.CommandText = "INSERT INTO 注文テーブル (注文日,商品ID,顧客ID,従業員ID)" + "VALUES (@orderdate,@goodsid,@memberid,@empid)";
                    OleDbParameter prorderdate = new OleDbParameter("@orderdate", dtNow.ToString("MM/dd"));
                    cmd2.Parameters.Add(prorderdate);
                    OleDbParameter prgoodsid = new OleDbParameter("@goodsid", goodsIDlist.ToString());
                    cmd2.Parameters.Add(prgoodsid);
                    OleDbParameter prmemberid = new OleDbParameter("@memberid", db_memberid.ToString());
                    cmd2.Parameters.Add(prmemberid);
                    OleDbParameter prempid = new OleDbParameter("@empid", Empid);
                    cmd2.Parameters.Add(prempid);


                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("登録しました", "OICSystem");
                    cmd.Parameters.Clear();
                    cmd2.Parameters.Clear();
                    cmd3.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OICSystem");
                }
                cn.Close();

                //入力データ初期化
                GoodsidTextBox.Text = "";
                NumCombo.SelectedIndex = 0;
                NameTextbox.Text = "";
                KanaTextbox.Text = "";
                PoscodeTextbox.Text = "";
                AddressTextbox1.Text = "";
                AddressTextbox2.Text = "";
                TelTextbox.Text = "";
                //データグリッドビュー初期化
                dtclear();

                cnt = 0;
                sum = 0;

                //トータルラベルを非表示
                TotalLabel.Text = "";
                TotalLabel.Visible = false;

                ErrMsg.Visible = false;
                ErrMsg2.Visible = false;

                dttemp.Clear();
                dttemp.Columns.Clear();
            }
        }

        private void dtclear()
        {
            dt.Clear();
            OrderRegiDataGridview.Columns.Clear();
            OrderRegiDataGridview.DataSource = null;

            OrderRegiDataGridview.Columns.Add("GoodsId","商品ID");
            OrderRegiDataGridview.Columns.Add("GoodsName", "商品名");
            OrderRegiDataGridview.Columns.Add("GoodsPrice", "単価");
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
    }
}
