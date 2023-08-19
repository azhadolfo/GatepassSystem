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
        private frmAddEmployee AddEmployeeForm;
        private frmDeleteEmployee DeleteEmployeeForm;
        private frmViewEmployee ViewEmployeeForm;
        private frmUpdateEmployee UpdateEmployeeForm;
        private frmLogs LogsForm;
        private frmVisitorForm VisitorForm;
        private frmValidateVisitor ValidateVisitorsForm;
        string fname;
        public frmMain(string fname)
        {
            InitializeComponent();
            this.fname = fname;
            AddEmployeeForm = new frmAddEmployee();
            DeleteEmployeeForm = new frmDeleteEmployee();
            ViewEmployeeForm = new frmViewEmployee();
            UpdateEmployeeForm = new frmUpdateEmployee();
            LogsForm = new frmLogs();
            VisitorForm = new frmVisitorForm();
            ValidateVisitorsForm = new frmValidateVisitor();
        }
        #region -- Gatepass Functions --
        private void OpenGatepassAdminModule()
        {
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnView.Visible = true;
            btnUpdate.Visible = true;
            btnVisitor.Visible = true;
        }

        private void CloseGatepassModules()
        {
            btnVisitor.Visible = false;
        }

        private void btnGatepass_Click(object sender, EventArgs e)
        {
            CloseDmsModules();
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
                CloseAllGatepassForms();

                // Show the login form
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();


            }
        }

        private void CloseAllGatepassForms()
        {

            ViewEmployeeForm.Close();
            AddEmployeeForm.Close();
            UpdateEmployeeForm.Close();
            DeleteEmployeeForm.Close();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmViewEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmViewEmployee>().First().BringToFront();
                ViewEmployeeForm.Show();
            }
            else
            {
                ViewEmployeeForm.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAddEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmAddEmployee>().First().BringToFront();
                AddEmployeeForm.Show();
            }
            else
            {
                AddEmployeeForm.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmUpdateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmUpdateEmployee>().First().BringToFront();
                UpdateEmployeeForm.Show();
            }
            else
            {
                UpdateEmployeeForm.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDeleteEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<frmDeleteEmployee>().First().BringToFront();
                DeleteEmployeeForm.Show();
            }
            else
            {
                DeleteEmployeeForm.Show();
            }
        }

        private void OpenGatepassUserModule()
        {
            btnVisitor.Visible = true;
            btnUser.Text = fname;
        }
        private void btnVisitor_Click(object sender, EventArgs e)
        {
            if (rootv.role == "admin" || rootv.role == "validator")
            {

                ValidateVisitorsForm.ShowDialog();
            }
            else
            {
                VisitorForm.ShowDialog();
            }
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (rootv.role == "admin")
            {
                btnUser.Text = "Admin";
                btnVisitor.Text = "Validate Visitor's";


            }
            else if (rootv.role == "validator")
            {
       
                btnVisitor.Text = "Validate Visitor's";
                btnLogs.Visible = false;
            }
            else
            {
                btnVisitor.Text = "Visitors Form";
                btnLogs.Visible = false;
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLogs>().Count() == 1)
            {
                Application.OpenForms.OfType<frmLogs>().First().BringToFront();
                LogsForm.Show();
            }
            else
            {
                LogsForm.Show();
            }
        }

        #region -- Document Management System --
        private void btnDms_Click(object sender, EventArgs e)
        {
            CloseGatepassModules();
            OpenDmsModules();
        }

        private void OpenDmsModules()
        {
            btnUploadFile.Visible = true;
            btnDownloadFile.Visible = true;
        }

        private void CloseDmsModules()
        {
            btnUploadFile.Visible = false;
            btnDownloadFile.Visible = false;
        }


        #endregion
    }
}
