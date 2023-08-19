using System;
using Npgsql;
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
    public partial class frmViewEmployee : Form
    {
        //rootv root = new rootv();
        //DataTable dt;

        public frmViewEmployee()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            GetData();
        }

        //this is the function for Getting Data in sql server
        #region -- Get Data Function --
        public void GetData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string query = "SELECT * FROM userfile";
            using (NpgsqlConnection conn = new NpgsqlConnection(rootv.ConnectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataReader rdr;

                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        string fname = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1).Trim();
                        string lname = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2).Trim();
                        string username = rdr.IsDBNull(3) ? string.Empty : rdr.GetString(3).Trim();

                        dataGridView1.Rows.Add(username, fname, lname);
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
            string query = "SELECT * FROM userfile WHERE username LIKE @term OR first_name LIKE @term OR last_name LIKE @term";
            using (NpgsqlConnection conn = new NpgsqlConnection(rootv.ConnectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@term", $"%{searchTerm}%");
                NpgsqlDataReader rdr;

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

    }
}
