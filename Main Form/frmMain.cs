using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestingPhase.Main_Form
{
    public partial class frmMain : Form
    {
        string fname;
        public frmMain(string fname)
        {
            InitializeComponent();
            this.fname = fname;
        }
       
        private void OpenGatepassAdminModule()
        {
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnView.Visible = true;
            btnUpdate.Visible = true;
            btnVisitor.Visible = true;
        }

        private void CloseGatepassButton()
        {
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnView.Visible = false;
            btnUpdate.Visible = false;
            btnVisitor.Visible = false;
        }

        private void btnGatepass_Click(object sender, EventArgs e)
        {
            if (rootv.role == "admin")
            {
                OpenGatepassAdminModule();
            }
            else
            {
                OpenGatepassUserModule();
            }
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

        private void btnView_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void OpenGatepassUserModule()
        {
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnView.Visible = false;
            btnUpdate.Visible = false;
            btnVisitor.Visible = true;
            btnUser.Text = fname;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (rootv.role == "admin")
            {
                btnLogout.Text = "Admin";
                btnVisitor.Text = "Validate Visitor's Form";


            }
            else if (rootv.role == "validator")
            {
       
                btnVisitor.Text = "Validate Visitor's Form";
            }
            else
            {
                btnVisitor.Text = "Visitors Form";
            }
        }
    }
}
