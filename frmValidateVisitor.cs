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
    public partial class frmValidateVisitor : Form
    {
        private readonly GateGuard gateGuard;
        frmVisitorForm frmVisitorForm;
        private Logs logs;
        public frmValidateVisitor()
        {
            InitializeComponent();
            gateGuard = new GateGuard();
            frmVisitorForm = new frmVisitorForm();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Get the GatePassId from the form's input
            int gatePassIdToCheck = int.Parse(txtVerify.Text);

            // Retrieve the GatePass from the database
            GatePass gatePass = frmVisitorForm.GetGatePassByIdFromDatabase(gatePassIdToCheck);

            if (gatePass != null)
            {
                // Check the GatePass with the GateGuard
                gateGuard.CheckGatePass(gatePass);
                logs = new Logs(rootv.username, Environment.UserDomainName, $"{rootv.username} validated the gatepass {gatePass.GatePassId}", DateTime.Now);
            }
            else
            {
                MessageBox.Show("Gatepass not found");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
