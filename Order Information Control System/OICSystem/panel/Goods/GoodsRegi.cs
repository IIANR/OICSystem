﻿using System;
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
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        BindingSource bds = new BindingSource();

        public GoodsRegi()
        {
            InitializeComponent();
        }

        //private void BindComboBox()
        //{
        //    comboBcate.DataSource = iM2DataSet.Tables["商品マスタ"];
        //    comboBcate.DisplayMember = "カテゴリID";
        //}

        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\IM2.accdb;");
            da = new OleDbDataAdapter("SELECT m.商品ID,m.商品名,m.単価,k.カテゴリ名,m.画像ファイル,m.備考,m.定期発注数 FROM 商品マスタ m,カテゴリマスタ k WHERE m.カテゴリID=k.カテゴリID ", cn);
            dt = new DataTable();
            da.Fill(dt);

            
            bds.DataSource = dt;

            bindingNavigator1.BindingSource = bds;

            textBID.DataBindings.Add("Text", bds, "商品ID");
            textBname.DataBindings.Add("Text", bds, "商品名");
            textBprice.DataBindings.Add("Text", bds, "単価");
            comboBcate.DataBindings.Add("Text", bds, "カテゴリ名");
            textBimage.DataBindings.Add("Text", bds, "画像ファイル");
            textBbikou.DataBindings.Add("Text", bds, "備考");
            textBnumber.DataBindings.Add("Text", bds, "定期発注数");
            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
            textBID.SelectionStart = 0;   //選択状態にならないようにする
        }




        private void panel_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void 商品マスタBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT ID FROM カテゴリマスタ WHERE カテゴリ名='" + comboBcate.Text + "'", cn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            string PosID = dt1.Rows[0][0].ToString();
            dt1.Clear();


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE 商品マスタ SET 商品名='" + textBname.Text + "', " +
                "単価='" + textBprice.Text + "', " +
                "備考='" + textBbikou.Text + "'" +
                "定量発注数='" + textBbikou.Text + "'" +
                "WHERE ID ='" + textBID.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "IM2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IM2");
            }
            finally
            {
                cn.Close();
            }
        }

        private void textBimage_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
        }
    }
}