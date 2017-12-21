using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.panel.Goods;
using WindowsFormsApplication1.panel;

namespace WindowsFormsApplication1
{
    public partial class GoodsMgt : UserControl
    {
        public static GoodsList ListCtr;
        public static GoodsRegi RegiCtr;
        public static GoodsStock StockCtr;
        public static GoodsPopularity PopularityCtr;

        public GoodsMgt()
        {
            InitializeComponent();
            ListCtr = new GoodsList();
            RegiCtr = new GoodsRegi();
            StockCtr = new GoodsStock();
            PopularityCtr = new GoodsPopularity();

            GoodsPanel.Controls.Add(ListCtr);
            GoodsPanel.Controls.Add(RegiCtr);
            GoodsPanel.Controls.Add(StockCtr);
            GoodsPanel.Controls.Add(PopularityCtr);

            ListCtr.Visible = true;
            RegiCtr.Visible = false;
            StockCtr.Visible = false;
            PopularityCtr.Visible = false;

        }

        private void goodsRegiBtn_Click(object sender, EventArgs e)
        {
            ListCtr.Visible = false;
            RegiCtr.Visible = true;
            StockCtr.Visible = false;
            PopularityCtr.Visible = false;
        }

        private void goodsListBtn_Click(object sender, EventArgs e)
        {
            ListCtr.Visible = true;
            RegiCtr.Visible = false;
            StockCtr.Visible = false;
            PopularityCtr.Visible = false;
        }

        private void goodsStockBtn_Click(object sender, EventArgs e)
        {
            ListCtr.Visible = false;
            RegiCtr.Visible = false;
            StockCtr.Visible = true;
            PopularityCtr.Visible = false;
        }

        private void GoodsMgt_Load(object sender, EventArgs e)
        {

        }

        private void goodsPopularityBtn_Click(object sender, EventArgs e)
        {
            ListCtr.Visible = false;
            RegiCtr.Visible = false;
            StockCtr.Visible = false;
            PopularityCtr.Visible = true;
        }

    }
}
