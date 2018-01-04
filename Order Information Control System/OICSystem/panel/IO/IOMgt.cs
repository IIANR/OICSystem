using System.Windows.Forms;
using WindowsFormsApplication1.panel.IO;

namespace WindowsFormsApplication1
{
    public partial class IOMgt : UserControl
    {
        public static IOOutput InOutPanel;
        public static OrderingRegi RegiPanel;
        public static IOOrdering orderingPanel;

        bool admin;

        public IOMgt()
        {
            InitializeComponent();

            InOutPanel = new IOOutput();
            RegiPanel = new OrderingRegi();
            orderingPanel = new IOOrdering();


            ctrPanel.Controls.Add(InOutPanel);
            ctrPanel.Controls.Add(RegiPanel);
            ctrPanel.Controls.Add(orderingPanel);
        }

        private void OrderingBtn_Click(object sender, System.EventArgs e)
        {
            if (admin == true)
            {
                InOutPanel.Visible = false;
                RegiPanel.Visible = false;
                orderingPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("権限がありません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InOutPanelBtn_Click(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = true;
            RegiPanel.Visible = false;
            orderingPanel.Visible = false;
        }

        private void IOMgt_VisibleChanged(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = true;
            InOutPanel.ActiveControl = InOutPanel.IdTextbox;
            RegiPanel.Visible = false;
            orderingPanel.Visible = false;
        }

        private void OrderingEditBtn_Click(object sender, System.EventArgs e)
        {
            if (admin == true)
            {
                InOutPanel.Visible = false;
                RegiPanel.Visible = true;
                orderingPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("権限がありません", "OICSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IOMgt_Load(object sender, System.EventArgs e)
        {
            admin = Login.LoginInstance.Authority;
        }
    }
}
