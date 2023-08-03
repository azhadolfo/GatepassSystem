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
    public partial class frmDeleteEmployee : Form
    {
        rootv root = new rootv();
        public frmDeleteEmployee()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;

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
                        int id = rdr.IsDBNull(0) ? 0 : rdr.GetInt32(0);
                        string fname = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1);
                        string lname = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2);
                        string username = rdr.IsDBNull(3) ? string.Empty : rdr.GetString(3);

                        dataGridView1.Rows.Add(id, username, fname, lname);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Perform the search in the DataGridView based on the entered search term
            FilterDataGridView(searchTerm);
        }

        private void FilterDataGridView(string searchTerm)
        {
            dataGridView1.Rows.Clear();

            // Query the database based on the search term (username, firstname, lastname)
            string query = "SELECT * FROM tblemployee WHERE username LIKE @term OR first_name LIKE @term OR last_name LIKE @term";
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@term", $"%{searchTerm}%");
                SqlDataReader rdr;

                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        string fname = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1);
                        string lname = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2);
                        string username = rdr.IsDBNull(3) ? string.Empty : rdr.GetString(3);

                        dataGridView1.Rows.Add(username, fname, lname);
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDeleteEmployee_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected for deletion
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ask for confirmation from the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Loop through the selected rows and delete them
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["table_id"].Value); // Replace "ID_Column_Name" with the actual name of the primary key column in your database

                        // Perform the deletion in the database
                        root.DeleteData(id);

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
