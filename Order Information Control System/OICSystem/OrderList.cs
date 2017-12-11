using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderList : Form
    {
        private int curPageNumber;

        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public OrderList()
        {
            InitializeComponent();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (OrderListDataGridView.RowCount < 1)
            {
                MessageBox.Show("データがありません", "CS-29");
                return;
            }
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                curPageNumber = 1;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (curPageNumber == 1)
            {
                PrintGdata(e, 0, 10);
                e.HasMorePages = true;
            }
            else if (curPageNumber == 2)
            {
                PrintGdata(e, 10, 20);
                e.HasMorePages = true;
            }
            else
            {
                PrintGdata(e, 20, OrderListDataGridView.RowCount - 1);
                e.HasMorePages = false;
            }
            curPageNumber++;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("印刷が終わりました。", "OICSystem");
        }

        private void PrintGdata(System.Drawing.Printing.PrintPageEventArgs e, int ds, int df)
        {
            int[] xp = { 50, 100, 200, 300, 400, 500, 550, 600 };
            for (int j = 0; j < OrderListDataGridView.ColumnCount; j++)
            {
                e.Graphics.DrawString(OrderListDataGridView.Columns[j].HeaderCell.Value.ToString(), new Font("MS ゴシック", 12), Brushes.Black, xp[j], 50);
            }

            for (int i = ds; i < df; i++)
            {
                for (int j = 0; j < OrderListDataGridView.ColumnCount; j++)
                {
                    if (OrderListDataGridView[j, i].Value.ToString() != "")
                    {
                        if (j == 4)
                        {
                            string s0 = OrderListDataGridView[j, i].Value.ToString();
                            string[] s1 = s0.Split(' ');
                            e.Graphics.DrawString(s1[0], new Font("MS ゴシック", 12), Brushes.Black, xp[j], 50 + 20 * (i + 1 - ds));
                        }
                        else
                        {
                            e.Graphics.DrawString(OrderListDataGridView[j, i].Value.ToString(), new Font("MS ゴシック", 12), Brushes.Black, xp[j], 50 + 20 * (i + 1 - ds));
                        }
                    }
                }
            }


        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT 注文テーブル.注文ID, 注文テーブル.注文日, 注文テーブル.商品ID, 顧客テーブル.名前, 顧客テーブル.郵便番号, 顧客テーブル.住所1, 顧客テーブル.住所2, 顧客テーブル.電話番号 FROM 従業員マスタ INNER JOIN(顧客テーブル INNER JOIN 注文テーブル ON 顧客テーブル.顧客ID = 注文テーブル.顧客ID) ON 従業員マスタ.従業員ID = 注文テーブル.従業員ID WHERE 注文テーブル.フラグ = '入金済み' AND 注文テーブル.入金済み = True; ", cn);
            da.Fill(dt);
            OrderListDataGridView.DataSource = dt;

            OrderListDataGridView.AllowUserToAddRows = false;
        }
    }
}
