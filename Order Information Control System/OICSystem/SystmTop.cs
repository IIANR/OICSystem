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
        public Login frm1;

        public static OrderMgt order;
        public static IOMgt io;
        public static GoodsMgt goods;
        public static MemberMgt member;
        public static EmpMgtHome emp;
        public static SalMgt sal;

        public SystmTop()
        {
            InitializeComponent();

            order = new OrderMgt();
            io = new IOMgt();
            goods = new GoodsMgt();
            member = new MemberMgt();
            emp = new EmpMgtHome();
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

            DateTime dtNow = DateTime.Now;
            DateTime dtToday = DateTime.Today;

            dateLabel.Text = (dtToday.ToString("MM月dd日"));
            timeLabel.Text = (dtNow.ToLongTimeString());

            timer1.Interval = 1000;
            timer1.Enabled = true;
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

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            order.Visible = false;
            io.Visible = false;
            goods.Visible = false;
            member.Visible = true;
            emp.Visible = false;
            sal.Visible = false;
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            if (frm1.db_admin == true)
            {
                order.Visible = false;
                io.Visible = false;
                goods.Visible = false;
                member.Visible = false;
                emp.Visible = true;
                sal.Visible = false;
            }
            else
            {
                MessageBox.Show("権限がありません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salMgtBtn_Click(object sender, EventArgs e)
        {
            if (frm1.db_admin == true)
            {
                order.Visible = false;
                io.Visible = false;
                goods.Visible = false;
                member.Visible = false;
                emp.Visible = false;
                sal.Visible = true;
            }
            else
            {
                MessageBox.Show("権限がありません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtToday = DateTime.Today;

            // 取得した日付と時刻を表示する
            dateLabel.Text = (dtToday.ToString("MM月dd日"));
            timeLabel.Text = (dtNow.ToLongTimeString());
        }

        private void SystmTop_Load(object sender, EventArgs e)
        {
            memberNameLabel.Text = frm1.db_name;

            timer1.Interval = 1000;
            timer1.Enabled = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = !this.MaximizeBox;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトしますか？", "OICSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login frm1 = new Login();
                frm1.Show();
            }
        }
    }
}
