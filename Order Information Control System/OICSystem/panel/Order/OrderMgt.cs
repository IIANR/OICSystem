using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderMgt : UserControl
    {
        public static OrderMgtRegister ctr1;
        public static OrderMgtInfo ctr2;

        public OrderMgt()
        {
            InitializeComponent();
            ctr1 = new OrderMgtRegister();
            ctr2 = new OrderMgtInfo();

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);

            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctr1.Visible = false;
            ctr2.Visible = true;
        }
    }
}
