using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.panel.IO
{
    public partial class IOInput : UserControl
    {
        public IOInput()
        {
            InitializeComponent();
        }

        private void IOInput_Load(object sender, EventArgs e)
        {
            this.入庫テーブルTableAdapter.FillInMgt(this.iM2DataSet.入庫テーブル);
        }
    }
}
