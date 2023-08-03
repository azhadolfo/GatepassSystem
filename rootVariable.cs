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
        msgOK msgOK = new msgOK();

        public static string ConnectionString { get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

        public static SqlConnection SqlConnection { get; set; } = new SqlConnection(ConnectionString);

        protected SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";
            return connection;
        }

        public static bool isadmin { get; set; } = false;

        public static bool isupdate { get; set; }
        public static bool isadd { get; set; }

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
                Console.WriteLine("Error:", ex.Message);
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
                        isadd = true;
                        msgOK.ShowDialog();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("There's an error in your connection", ex.Message);
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

        //this is the function for Updating the data inside the database
        #region -- Update Data Function --
        public void UpdateData(string username, string fname, string lname)
        {
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                string query = "UPDATE tblemployee SET first_name = @fname, last_name = @lname WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isupdate = true;
                        msgOK.ShowDialog();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("There's an error in your connection");
                }
            }
        }
        #endregion

        //this is the function for Getting Data in sql server
        #region -- Get Data Function --
        public DataTable GetDataByUsername(string username)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblemployee WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    conn.Open();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There's an error in your connection: " + ex.Message);
                }
            }

            return dt;
        }
        #endregion
    }
}
