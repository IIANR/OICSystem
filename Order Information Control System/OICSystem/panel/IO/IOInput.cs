using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1.panel.IO
{
    public partial class IOInput : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public IOInput()
        {
            InitializeComponent();
        }

        private void IOInput_Load(object sender, EventArgs e)
        {
            
        }
    }
}
