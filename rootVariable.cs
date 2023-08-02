using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestingPhase
{
    internal class rootVariable
    {
       

       //public static string CONNECTION_STR {  get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

    }

    class rootv
    {
        public static string ConnectionString { get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

        public static SqlConnection SqlConnection { get; set; } = new SqlConnection(ConnectionString);

        protected SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";
            return connection;
        }

        public static bool isadmin { get; set; } = false;

        public DataSet GetData(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd; // Set the SelectCommand property
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately.
                // Here, I am just re-throwing the exception to propagate it to the caller.
                // You can handle the exception according to your application's requirements.
                throw;
            }
            return ds;
        }


        public void SetData(string query, string msg)
        {
            try
            {
                SqlConnection connection = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();

                if (msg != null)
                {
                    MessageBox.Show(msg,"System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: ", ex.Message);
            }
        }

        //this is the function for Adding the data inside the database
        #region -- Add Data Function --
        public void AddData(string fname, string lname, string username, string password)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO tblemployee (first_name, last_name, username, password) VALUES (@fname, @lname, @username, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);

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

        //keypress method for inputting only digits not characted
       public static void onlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       public static string getUniqueId(string prefix)
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return prefix + nano;
        }

    }
}
