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
    public partial class frmSignUp : Form
    {
        rootv root = new rootv();
        DataTable dt;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var fname = txtFirstname.Text.Trim();
                var lname = txtLastname.Text.Trim();
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();
                
                


                if (!String.IsNullOrEmpty(fname) &&
                   !String.IsNullOrEmpty(lname) &&
                   !String.IsNullOrEmpty(username) &&
                   !String.IsNullOrEmpty(password))
                {
                    dt = root.GetDataByUsername(username);

                    if (dt != null && dt.Rows.Count == 0)
                    {

                        root.AddData(fname, lname, "user", username, password);
                        ClearFields();
                        lblNotAvailable.Visible = false;

                    }
                    else
                    {
                        lblNotAvailable.Visible = true;
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The fields is empty please fill and try again.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception)
            {
                MessageBox.Show("There's an error while saving the data.", "MIS DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
