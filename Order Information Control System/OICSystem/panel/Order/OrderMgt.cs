using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Panel1.Controls.Add(ctr1);
            Panel1.Controls.Add(ctr2);

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

        private void OrderMgt_Load(object sender, EventArgs e)
        {

        }
    }
}
