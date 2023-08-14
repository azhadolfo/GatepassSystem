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



        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (rootv.role == "admin")
            {
                SayWelcome("Admin");
                btnVisitor.Text = "Validate Visitor's Form";

               
            }
            else if (rootv.role == "validator") {

                btnEmployees.Visible = false;
                btnLogs.Visible = false;
                SayWelcome(fname);
                btnVisitor.Text = "Validate Visitor's Form";
            }
            else
            {
                btnEmployees.Visible = false;
                btnLogs.Visible = false;
                SayWelcome(fname);
                btnVisitor.Text = "Visitors Form";
            }

            btnUser.Text = fname;
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmViewEmployee>().First().Close();
                frmViewEmployee viewEmployee = new frmViewEmployee();
                viewEmployee.Show();
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
                Application.OpenForms.OfType<frmAddEmployee>().First().Close();
                frmAddEmployee addEmployee = new frmAddEmployee();
                addEmployee.Show();
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
                Application.OpenForms.OfType<frmUpdateEmployee>().First().Close();
                frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
                updateEmployee.Show();
            }
            else
            {
                frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
                updateEmployee.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDeleteEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmDeleteEmployee>().First().Close();
                frmDeleteEmployee deleteEmployee = new frmDeleteEmployee();
                deleteEmployee.Show();
            }
            else
            {
                frmDeleteEmployee deleteEmployee = new frmDeleteEmployee();
                deleteEmployee.Show();
            }
        }

        private void CloseAllForms()
        {
            frmViewEmployee viewEmployee = new frmViewEmployee();
            frmAddEmployee addEmployee = new frmAddEmployee();
            frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
            frmDeleteEmployee deleteEmployee = new frmDeleteEmployee();

            viewEmployee.Close();
            addEmployee.Close();
            updateEmployee.Close();
            deleteEmployee.Close();

        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAllForms();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<frmViewEmployee>().Count() == 1)
            //{
            //    Application.OpenForms.OfType<frmVisitorForm>().First().Close();
            //    frmVisitorForm visitorForm = new frmVisitorForm();
            //    visitorForm.Show();
            //}
            //else
            //{
            if(rootv.role == "admin" || rootv.role == "validator")
            {
                frmValidateVisitor frmValidateVisitor = new frmValidateVisitor();
                frmValidateVisitor.ShowDialog();
            }    
            else
            {
                frmVisitorForm visitorForm = new frmVisitorForm();
                visitorForm.ShowDialog();
            }


            //frmVisitorForm visitorForm = new frmVisitorForm();
            //visitorForm.ShowDialog();
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                // Hide the current form
                this.Close();
                CloseAllForms();

                // Show the login form
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();

               
            }
        }

        private void SayWelcome(string fname) => lblWelcome.Text = $"Welcome {fname}";

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLogs>().Count() == 1)
            {
                Application.OpenForms.OfType<frmLogs>().First().Close();
                frmLogs logs = new frmLogs();
                logs.Show();
            }
            else
            {
                frmLogs logs = new frmLogs();
                logs.Show();
            }
        }
    }
}
