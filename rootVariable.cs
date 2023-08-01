using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TestingPhase
{
    internal class rootVariable
    {
        public static string ConnectionString { get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

        public static SqlConnection SqlConnection { get; set; } = new SqlConnection(ConnectionString);

       //public static string CONNECTION_STR {  get; set; } = "Data Source=WIN-IU3ACLEQUUI;Initial Catalog=cs_crud;Persist Security Info=True;User ID=user3;Password=twainc.";

    }

    class rootv
    {

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
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:", ex.Message);
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

    }
}
