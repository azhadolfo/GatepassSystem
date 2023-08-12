using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPhase
{
   
    public partial class frmAddEmployee : Form
    {
        rootv root = new rootv();
        //string query;
        //DataSet ds;
        DataTable dt;
        private Logs logs;
     
        
        public frmAddEmployee()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
         
            //try
            //{
                var fname = txtFirstname.Text.Trim();
                var lname = txtLastname.Text.Trim();
                var role = cboRole.Text.Trim();
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();


                if(!String.IsNullOrEmpty(fname)&&
                   !String.IsNullOrEmpty(lname)&&
                   !String.IsNullOrEmpty(role)&&
                   !String.IsNullOrEmpty(username)&&
                   !String.IsNullOrEmpty(password))
                {
                    dt = root.GetDataByUsername(username);

                    if (dt != null && dt.Rows.Count == 0)
                    {
                        
                        root.AddData(fname,lname,role,username,password);
                        logs = new Logs(rootv.username,Environment.UserDomainName,$"Adding new user {username} ",DateTime.Now);
                        ClearFields();
                    
                    }
                    else
                    {
                        MessageBox.Show("The username is already linked with another account","System Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The fields is empty please fill and try again.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("There's an error while saving the data.", "MIS DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            cboRole.SelectedIndex = 0;
            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
