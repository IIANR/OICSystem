using System;
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

        public GoodsMgt()
        {
            InitializeComponent();
            ListCtr = new GoodsList();
            RegiCtr = new GoodsRegi();
            StockCtr = new GoodsStock();

            GoodsPanel.Controls.Add(ListCtr);
            GoodsPanel.Controls.Add(RegiCtr);
            GoodsPanel.Controls.Add(StockCtr);

            ListCtr.Visible = true;
            RegiCtr.Visible = false;
            StockCtr.Visible = false;
          
        }

        private void goodsRegiBtn_Click(object sender, EventArgs e)
        {

            ListCtr.Visible = false;
            RegiCtr.Visible = true;
            StockCtr.Visible = false;
        }

        private void goodsListBtn_Click(object sender, EventArgs e)
        {

            ListCtr.Visible = true;
            RegiCtr.Visible = false;
            StockCtr.Visible = false;
        }

        private void goodsStockBtn_Click(object sender, EventArgs e)
        {

            ListCtr.Visible = false;
            RegiCtr.Visible = false;
            StockCtr.Visible = true;
        }
    }
}
