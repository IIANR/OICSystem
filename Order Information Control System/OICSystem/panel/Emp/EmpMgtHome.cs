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
    public partial class EmpMgtHome : UserControl
    {
        public static EmpMgt ctr1;
        public static EmpMgtInfo ctr2;

        public EmpMgtHome()
        {
            InitializeComponent();
            ctr1 = new EmpMgt();
            ctr2 = new EmpMgtInfo();

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
