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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        String fname;
        public frmDashboard(String fname)
        {
            InitializeComponent();
            this.fname = fname;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (rootv.isadmin == true)
            {
                lblWelcome.Text = "Welcome Admin";
               
            }
            else
            {
                btnEmployees.Visible = false;
                lblWelcome.Text = $"Welcome {fname}";
            }
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmViewEmployee>().First().BringToFront();
            }
            else
            {
                frmViewEmployee viewEmployee = new frmViewEmployee();
                viewEmployee.Show();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAddEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmAddEmployee>().First().BringToFront();
            }
            else
            {
                frmAddEmployee addEmployee = new frmAddEmployee();
                addEmployee.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmUpdateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmUpdateEmployee>().First().BringToFront();
            }
            else
            {
                frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
                updateEmployee.Show();
            }
        }
    }
}
