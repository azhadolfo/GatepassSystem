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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input your username or password.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DataTable dataTable = GetInfo(rootVariable.ConnectionString);
                try
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        frmMain MainForm = new frmMain();
                        this.Hide();
                        MainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" ,ex.Message);
                }
            }
        }

        private DataTable GetInfo(string connectionString)
        {
            DataTable dataTable = new DataTable();

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
                    command.Parameters.AddWithValue("password", txtPassword.Text);

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
    }
}
