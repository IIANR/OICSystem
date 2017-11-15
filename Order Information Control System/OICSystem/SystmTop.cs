using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SystmTop : Form
    {
        public static OrderMgt order;
        public static IOMgt io;
        public static GoodsMgt goods;
        public static MemberMgt member;
        public static EmpMgt emp;
        public static SalMgt sal;

        public SystmTop()
        {
            InitializeComponent();

            order = new OrderMgt();
            io = new IOMgt();
            goods = new GoodsMgt();
            member = new MemberMgt();
            emp = new EmpMgt();
            sal = new SalMgt();

            ctrPanel.Controls.Add(order);
            ctrPanel.Controls.Add(io);
            ctrPanel.Controls.Add(goods);
            ctrPanel.Controls.Add(member);
            ctrPanel.Controls.Add(emp);
            ctrPanel.Controls.Add(sal);

            order.Visible = false;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = false;
            emp.Visible = false;
            sal.Visible = false;
        }

        private void SystmTop_Load(object sender, EventArgs e)
        {
        }
        private void ctrPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void orderMgtBtn_Click(object sender, EventArgs e)
        {
            order.Visible = true;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = false;
            emp.Visible = false;
            sal.Visible = false;
        }

        private void ioMgtBtn_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = true;
            goods.Visible = false;
            member.Visible = false;
            emp.Visible = false;
            sal.Visible = false;
        }

        private void goodsMgtBtn_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = false;
            goods.Visible = true;
            member.Visible = false;
            emp.Visible = false;
            sal.Visible = false;
        }

        

        private void salMgtBtn_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = false;
            emp.Visible = false;
            sal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = true;
            emp.Visible = false;
            sal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = false;
            emp.Visible = true;
            sal.Visible = false;
        }
    }
}
