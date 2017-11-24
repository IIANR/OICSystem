using System.Windows.Forms;
using WindowsFormsApplication1.panel.IO;

namespace WindowsFormsApplication1
{
    public partial class IOMgt : UserControl
    {

        public static IOInput inPanel;
        public static IOOutput outPanel;

        public IOMgt()
        {
            InitializeComponent();

            inPanel = new IOInput();
            outPanel = new IOOutput();

            ctrPanel.Controls.Add(inPanel);
            ctrPanel.Controls.Add(outPanel);

            inPanel.Visible = false;
            outPanel.Visible = false;
        }

        private void inPanelBtn_Click(object sender, System.EventArgs e)
        {
            inPanel.Visible = true;
            outPanel.Visible = false;
        }

        private void outPanelBtn_Click(object sender, System.EventArgs e)
        {
            inPanel.Visible = false;
            outPanel.Visible = true;
        }
    }
}
