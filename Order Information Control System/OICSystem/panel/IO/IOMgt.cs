using System.Windows.Forms;
using WindowsFormsApplication1.panel.IO;

namespace WindowsFormsApplication1
{
    public partial class IOMgt : UserControl
    {
        public static IOOutput InOutPanel;
        public static OrderingRegi RegiPanel;
        public static IOOrdering orderingPanel;

        public IOMgt()
        {
            InitializeComponent();

            InOutPanel = new IOOutput();
            RegiPanel = new OrderingRegi();
            orderingPanel = new IOOrdering();


            ctrPanel.Controls.Add(InOutPanel);
            ctrPanel.Controls.Add(RegiPanel);
            ctrPanel.Controls.Add(orderingPanel);

            InOutPanel.Visible = false;
            RegiPanel.Visible = false;
            orderingPanel.Visible = false;
        }

        private void inPanelBtn_Click(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = false;
            RegiPanel.Visible = false;
            orderingPanel.Visible = false;
        }

        private void outPanelBtn_Click(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = true;
            RegiPanel.Visible = false;
            orderingPanel.Visible = false;
        }

        private void RegiEditBtn_Click(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = false;
            RegiPanel.Visible = true;
            orderingPanel.Visible = false;
        }

        private void OrderingBtn_Click(object sender, System.EventArgs e)
        {
            InOutPanel.Visible = false;
            RegiPanel.Visible = false;
            orderingPanel.Visible = true;
        }
    }
}
