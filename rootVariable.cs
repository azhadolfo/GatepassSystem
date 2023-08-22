using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;
using Npgsql;

namespace TestingPhase
{
    internal class rootVariable
    {
       

       //public static string CONNECTION_STR {  get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

     
    }

    public class rootv
    {
        msgOK msgOK = new msgOK();

        public static string ConnectionString { get; set; } = "Host=localhost;Username=postgres;Password=mis123;Database=cs_crud";

        public static NpgsqlConnection NpgsqlConnection { get; set; } = new NpgsqlConnection(ConnectionString);

        protected NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=cs_crud";
            return connection;
        }

        public static string role { get; set; }

        public static string username { get; set; } = "";

        public static bool isupdate { get; set; }
        public static bool isadd { get; set; }
        public static bool isdelete { get; set; }

        public static bool isNew { get; set; }

        public static int employeeId { get; set; } = 0;

        public DataSet GetData(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                NpgsqlConnection connection = GetConnection();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
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
                NpgsqlConnection connection = GetConnection();
                NpgsqlCommand cmd = new NpgsqlCommand();
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
        public void AddData(string fname, string lname, string role, string username, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);

            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO userfile (first_name, last_name, username, password, role) VALUES (@fname, @lname, @username, @password, @role)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@role", role);

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
                finally
                {
                    isadd = false;
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
            using (NpgsqlConnection conn = new NpgsqlConnection(rootv.ConnectionString))
            {
                string query = "UPDATE userfile SET first_name = @fname, last_name = @lname WHERE username = @username";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);

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
                finally
                {
                    isupdate = false;
                }
            }
        }
        #endregion

        //this is the function for Getting Data in sql server
        #region -- Get Data Function --
        public DataTable GetDataByUsername(string username)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM userfile WHERE username = @username";
            using (NpgsqlConnection conn = new NpgsqlConnection(rootv.ConnectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

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

        //this is the function for Deleting the data inside the database
        #region -- Delete Data Function --
        public void DeleteData(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(rootv.ConnectionString))
            {
                string query = "DELETE FROM userfile WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    isdelete = true;
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("There's an error in your connection");
                }
            }
        }
        #endregion

        //public void DeleteData(List<int> ids)
        //{
        //    using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
        //    {
        //        string query = "DELETE FROM userfile WHERE id IN (@ids)";
        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        // Use SqlParameter to pass the list of ids as a parameter
        //        cmd.Parameters.AddWithValue("@ids", string.Join(",", ids));

        //        try
        //        {
        //            conn.Open();
        //            int rowsAffected = cmd.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                // Deletion successful
        //                isdelete = true;
        //                msgOK.ShowDialog();
        //            }
        //            else
        //            {
        //                // No rows deleted, handle accordingly (e.g., show a message)
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            isdelete = false;
        //        }
        //    }
        //}
        #region -- Upload File Function --
        public void UploadFile(string filename, string department, string description, DateTime dateUploaded, string filelocation, string username)
        {

            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO filedocument (name, department, description, dateuploaded, location, \"user\") VALUES (@name, @department, @description, @dateuploaded, @location, @user)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", filename);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@dateuploaded", dateUploaded);
                    cmd.Parameters.AddWithValue("@location", filelocation);
                    cmd.Parameters.AddWithValue("@user", username);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("File uploaded and saved successfully", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("An error occurred while uploading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }
        #endregion
    }
}
