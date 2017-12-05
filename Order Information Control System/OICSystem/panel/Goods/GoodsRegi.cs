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
        public GoodsRegi()
        {
            InitializeComponent();
        }

        private void GoodsRegi_Load(object sender, EventArgs e)
        {
            this.商品マスタTableAdapter.Fill(this.iM2Data.商品マスタ);
            //pictureBox.Image = Image.FromFile(@".\IM2image\" + textBimage.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveNext();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            商品マスタBindingSource.MoveLast();
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

       
    }
}