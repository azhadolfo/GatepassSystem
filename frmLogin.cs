using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPhase
{
    
    public partial class frmLogin : Form
    {
        //rootv rootv = new rootv();
        //string query;
        //private PasswordHasher passwordHasher; 
        public frmLogin()
        {
            InitializeComponent();
            //passwordHasher = new PasswordHasher();
        }

        //closing the form
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();

            this.Hide();
        }

        //Login button and checking if the user is existing or not
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                //MessageBox.Show("Please input your username or password.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lblWrong.Visible == true)
                {
                    lblWrong.Visible = false;
                }
                lblEmpty.Visible = true;
                
            }
            else
            {
               
                DataTable dataTable = GetInfo(rootv.ConnectionString);
                try
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        rootv.employeeId = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
                        rootv.role = dataTable.Rows[0]["role"].ToString().Trim().ToLower();
                        rootv.username = dataTable.Rows[0]["username"].ToString().Trim();
                        var fname = dataTable.Rows[0]["first_name"].ToString().Trim();

                        //if (rootv.isadmin == true)
                        //{
                            frmDashboard dashboard = new frmDashboard(fname);
                            this.Hide();
                            dashboard.Show();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("You're not an admin.");
                        //}
                        
                    }
                    else
                    {
                        //MessageBox.Show("Wrong username or password", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                        if (lblEmpty.Visible == true)
                        {
                            lblEmpty.Visible = false;
                        }
                        lblWrong.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" ,ex.Message);
                }
            }
        }

        //This funciton was to get information if the user and pass is valid and return it as a table
        private DataTable GetInfo(string connectionString)
        {
            DataTable dataTable = new DataTable();
            string hashedPassword = PasswordHasher.HashPassword(txtPassword.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Here is the query
                    string query = "SELECT * FROM tblemployee WHERE username = @username AND password = @password";

                    // Create the SqlCommand object
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username", txtUsername.Text);
                    command.Parameters.AddWithValue("password", hashedPassword);

                    // Create a SqlDataAdapter to execute the command and fill the DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the execution
                    MessageBox.Show("Error :", ex.Message);
                }
            }


            return dataTable;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnHide.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Set the tooltip text for the button
            toolTip1.SetToolTip(btnSignUp, "Don't have an account? Click this button.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVisitorForm frmVisitorForm = new frmVisitorForm();
            frmVisitorForm.ShowDialog(this);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtPassword.Text))
            {
                btnShow.Visible = false;
                btnHide.Visible = false;
            }
            else
            {
                btnShow.Visible = true;
            }
            
        }
    }
}
