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
    public partial class frmUpdateEmployee : Form
    {
        rootv root = new rootv();
        //string query;
        //DataSet ds;
        DataTable dt;
        bool employeeAvailable;
        bool hasChange;
        private Logs logs;

        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Sql Injection Vulnerable
            //try { 
            //var username = txtUsername.Text;
            //query = $"SELECT * FROM tblemployee WHERE username = {username}";
            //ds = root.GetData(query);
            //if (ds != null && ds.Tables[0].Rows.Count != 0)
            //{
            //    ClearFields();
            //    employeeAvailable = true ;
            //    txtFirstname.Text = ds.Tables[0].Rows[0][1].ToString();
            //    txtLastname.Text = ds.Tables[0].Rows[0][2].ToString();
            //}
            //else
            //{
            //    employeeAvailable = false;
            //    ClearFields();
            //    MessageBox.Show("This username is not exist in the record!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //}
            //catch(Exception)
            //{
            //    ClearFields();
            //    MessageBox.Show("There's an error while connecting the database, Contact the MIS DEPARTMENT", "MIS DEPARTMENT" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                var username = txtUsername.Text.Trim();
                dt = root.GetDataByUsername(username);

                if (dt != null && dt.Rows.Count > 0)
                {
                    hasChange = false;
                    employeeAvailable = true;
                    txtFirstname.Text = dt.Rows[0]["first_name"].ToString().Trim();
                    txtLastname.Text = dt.Rows[0]["last_name"].ToString().Trim();
                }
                else
                {
                    employeeAvailable = false;
                    ClearFields();
                    MessageBox.Show("This username does not exist in the record!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception)
            {
                ClearFields();
                MessageBox.Show("There's an error while connecting the database, Contact the MIS DEPARTMENT", "MIS DEPARTMENT" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            rootv.isadd = false;
            //try
            //{
            //    // Validate user inputs before executing the query
            //    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text))
            //    {
            //        MessageBox.Show("Please fill in all the required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    var username = txtUsername.Text;
            //    var fname = txtFirstname.Text;
            //    var lname = txtLastname.Text;

            //    // Use parameterized query to prevent SQL injection
            //    query = "UPDATE tblemployee SET first_name = @fname, last_name = @lname WHERE id = @username";
            //    root.AddParameter("@fname", fname);
            //    root.AddParameter("@lname", lname);
            //    root.AddParameter("@username", username);

            //    ds = root.GetData(query);

            //    MessageBox.Show("Successfully Updated");
            //}
            //catch (SqlException ex)
            //{
            //    // Handle specific database-related exceptions
            //    MessageBox.Show("Error while updating data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    // Handle other unexpected exceptions
            //    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                if (hasChange)
                {
                    var username = txtUsername.Text;
                    var fname = txtFirstname.Text;
                    var lname = txtLastname.Text;

                    if (employeeAvailable)
                    {
                        if (!(String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtFirstname.Text) && String.IsNullOrEmpty(txtLastname.Text)))
                        {
                            root.UpdateData(username, fname, lname);
                            logs = new Logs(rootv.username, Environment.UserDomainName, $"Updating information of {username}", DateTime.Now);
                            hasChange = false;
                        }
                        else
                        {
                            MessageBox.Show("Fill input all the fields needed!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This user is not found!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No changes were made.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                
            }
            catch (Exception)
            {

                MessageBox.Show("There's an error while connecting the database, Contact the MIS DEPARTMENT", "MIS DEPARTMENT" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtUsername.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (!hasChange)
                hasChange = true;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if (!hasChange)
                hasChange = true;
        }

  
    }
}
