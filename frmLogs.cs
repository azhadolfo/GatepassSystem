using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPhase
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logs_DataSet.tbllogs' table. You can move, or remove it, as needed.
            this.tbllogsTableAdapter.Fill(this.logs_DataSet.tbllogs);

        }
    }
}
