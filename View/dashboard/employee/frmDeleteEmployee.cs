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
        private int selectedDataCount = 0;
        msgOK msgOK = new msgOK();
        public frmDeleteEmployee()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // Assuming checkbox is in the first column (index 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewCheckBoxCell checkboxCell)
                {
                    if (checkboxCell.Value == checkboxCell.TrueValue)
                    {
                        selectedDataCount++;
                    }
                    else
                    {
                        selectedDataCount--;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //// Check if any rows are selected for deletion
            //if (selectedDataCount > 0)
            //{
            //    // Ask for confirmation from the user
            //    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        List<int> selectedIds = new List<int>();

            //        // Loop through the selected rows and collect the IDs to delete
            //        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //        {
            //            int id = Convert.ToInt32(row.Cells["table_id"].Value); // Replace "table_id" with the actual name of the primary key column in your database
            //            selectedIds.Add(id);
            //        }

            //        // Perform the deletion in the database
            //        root.DeleteData(selectedIds);

            //        // Remove all the selected rows from the DataGridView
            //        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //        {
            //            dataGridView1.Rows.Remove(row);
            //        }

            //        // Reset the selectedDataCount after deletion
            //        selectedDataCount = 0;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select at least one row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Count(p => Convert.ToBoolean(p.Cells["Select"].Value) == true);

            if (total > 0)
            {
                string message = $"Are you sure you want to delete {total} row?";
                if (total > 1)
                    message = $"Are you sure you want to delete {total} rows?";

                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //List<int> idsToDelete = new List<int>();
                    

                    for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            int id = Convert.ToInt32(row.Cells["table_id"].Value);
                           
                            //idsToDelete.Add(id);
                            dataGridView1.Rows.Remove(row);
                            root.DeleteData(id);
                        }
                    }

                    msgOK.ShowDialog();
                    rootv.isdelete = false;

                }
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      



    }


}
