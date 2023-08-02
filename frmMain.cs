using System;
using System.Collections;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //this is the function for Getting Data in sql server
        #region -- Get Data Function --
        public void GetData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string query = "SELECT * FROM tblemployee";
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            { 
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string fname = rdr.GetString(1);
                    string lname = rdr.GetString(2);


                    dataGridView1.Rows.Add(id, fname, lname);
                }
                rdr.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("There's an error in your connection");
            }
            }
        }
        #endregion

        //this is the function for Updating the data inside the database
        #region -- Update Data Function --
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                string query = "UPDATE tblemployee SET first_name = @fname, last_name = @lname WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", txtId.Text);
                cmd.Parameters.AddWithValue("fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("lname", txtLastName.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("There's an error in your connection");
                }
            }
        }
        #endregion

        //this is the function for Deleting the data inside the database
        #region -- Delete Data Function --
        private void DeleteData()
        {
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                string query = "DELETE FROM tblemployee WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", txtId.Text);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted");
                }
                catch (Exception)
                {

                    MessageBox.Show("There's an error in your connection");
                }
            }
        }
        #endregion

        //this is the function for Adding the data inside the database
        #region -- Add Data Function --
        private void AddData()
        {

            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                string query = "INSERT INTO tblemployee (first_name,last_name) VALUES (@fname, @lname)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("lname", txtLastName.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Added");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("There's an error in your connection");
                }
            }
        }
        #endregion

        //this is the process once the user click the Read button
        private void btnRead_Click(object sender, EventArgs e)
        {
           GetData();
        }

        //this is the process once the form is done loading
        private void frmMain_Load(object sender, EventArgs e)
        {
            //// Fetch data from the database and fill a DataTable
            //DataTable dataTable = GetDataTableFromDatabase(rootVariable.ConnectionString);


            //// Bind the DataTable to the DataGridView
            //dataGridView1.ClearSelection();
            //dataGridView1.Refresh();
            //dataGridView1.DataSource = dataTable;


            GetData();


        }

        //private DataTable GetDataTableFromDatabase(string connectionString)
        //{
        //    DataTable dataTable = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            // Open the connection
        //            connection.Open();

        //            // Here is the query
        //            string query = "SELECT * FROM tblemployee";

        //            // Create the SqlCommand object
        //            SqlCommand command = new SqlCommand(query, connection);

        //            // Create a SqlDataAdapter to execute the command and fill the DataTable
        //            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

        //            // Fill the DataTable with data from the database
        //            dataAdapter.Fill(dataTable);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle any exceptions that occur during the execution
        //            MessageBox.Show("Error :", ex.Message);
        //        }
        //    }

        //    return dataTable;
        //}

        //this is the process once the user click the Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please input the required fields in order to add.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                AddData();
                GetData();

                txtFirstName.Clear();
                txtLastName.Clear();


            }
        }

        //private DataTable AddData(string connectionString) 
        //{ 
        //    DataTable dataTable = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            // Open the connection
        //            connection.Open();

        //            // Here is the query
        //            string query = "INSERT INTO tblemployee (first_name,last_name)VALUES(@first_name,@last_name)";

        //            // Create the SqlCommand object
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("first_name", txtFirstName.Text);
        //            command.Parameters.AddWithValue("last_name", txtLastName.Text);

        //            // Create a SqlDataAdapter to execute the command and fill the DataTable
        //            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

        //            // Fill the DataTable with data from the database
        //            dataAdapter.Fill(dataTable);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle any exceptions that occur during the execution
        //            MessageBox.Show("Error :", ex.Message);
        //        }
        //    }


        //    return dataTable;
        //}


        //this is the function for selecting a row and display the data in textbox
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows )
            {
                string stId = row.Cells[0].Value.ToString();
                string stFname = row.Cells[1].Value.ToString();
                string stLname = row.Cells[2].Value.ToString();

                txtId.Text = stId;
                txtFirstName.Text = stFname;
                txtLastName.Text = stLname;
            }

            
        }

        //this is the process once the user click the update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            GetData();

            txtFirstName.Clear();
            txtLastName.Clear();  
        }

       
        //this is the process once the user click the delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this record", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                DeleteData();
                GetData();
            }


            
        }

        //this is the process once the user click the SignOut link label text
        private void lblSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }
    }
}
