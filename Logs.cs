using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestingPhase
{
    public class Logs
    {
        public string username { get; set; }
        public string computer { get; set; }
        public string activity { get; set; }
        public DateTime date { get; set; }

        // Parameterized Constructor
        public Logs(string username, string computer, string activity, DateTime date)
        {
            this.username = username;
            this.computer = computer;
            this.activity = activity;
            this.date = date;

            using (SqlConnection conn = new SqlConnection(rootv.ConnectionString))
            {
                string query = "INSERT INTO tbllogs (username, computer, activity, date) VALUES (@username, @computer, @activity, @date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@computer", computer);
                cmd.Parameters.AddWithValue("@activity", activity);
                cmd.Parameters.AddWithValue("@date", date);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("There's an error in your connection", ex.Message);
                }
                }

            }
        }
    }



