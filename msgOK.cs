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
    public partial class msgOK : Form
    {
        public msgOK()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgOK_Load(object sender, EventArgs e)
        {
            if(rootv.isupdate == true)
            {
                lblMessage.Text = "Successfully Updated";
            }
            if(rootv.isadd == true)
            {
                lblMessage.Text = "Successfully Added";
            } 
        }
    }
}
