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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestingPhase
{
    //public partial class frmVisitorForm : Form
    //{
    //    private List<GatePass> gatePasses;
    //    private GateGuard gateGuard;
    //    //private int lastGeneratedGatePassId = 0;
    //    public frmVisitorForm()
    //    {
    //        InitializeComponent();

    //        gatePasses = new List<GatePass>();
    //        gateGuard = new GateGuard();
    //    }

    //    private void btnCancel_Click(object sender, EventArgs e)
    //    {
    //        this.Close();
    //    }

    //    private void btnSubmit_Click(object sender, EventArgs e)
    //    {
    //        // Create a new Visitor from the form's input
    //        Visitor visitor = new Visitor
    //        {
    //            Name = this.txtFullname.Text,
    //            ContactNo = this.txtContact.Text,
    //            Address = this.txtAddress.Text,
    //            PurposeOfVisit = this.txtPurpose.Text
    //        };

    //        // Create a new GatePass for the Visitor
    //        GatePass newGatePass = new GatePass
    //        {
    //            GatePassId = GenerateGatePassId(), // Generate a unique GatePass ID
    //            Employee = null, // For visitors, set the Employee to null
    //            IssueDate = DateTime.Now,
    //            ExpiryDate = DateTime.Now.AddDays(2) // Set the expiry time for the visitor (you can adjust this as per your requirements)

    //        };

    //        // Add the GatePass to the list
    //        gatePasses.Add(newGatePass);

    //        // Keep track of the last generated GatePassId
    //        //lastGeneratedGatePassId = newGatePass.GatePassId;

    //        // Clear the form fields
    //        ClearForm();

    //        // Update txtVerify with the last generated GatePassId
    //        //txtVerify.Text = lastGeneratedGatePassId.ToString();

    //        MessageBox.Show($"Your Gatepass number is {newGatePass.GatePassId}");

    //    }

    //    private int GenerateGatePassId()
    //    {
    //        // Generate a unique GatePass ID (you can implement your own logic here)
    //        // For simplicity, you can use a random number or a combination of timestamp and random number.
    //        return new Random().Next(1000, 9999);
    //    }

    //    private void ClearForm()
    //    {
    //        this.txtFullname.Clear();
    //        this.txtContact.Clear();
    //        this.txtAddress.Clear();
    //        this.txtPurpose.Clear();
    //    }

    //    private void btnCheck_Click(object sender, EventArgs e)
    //    {
    //        // Get the GatePassId from the form's input
    //        int gatePassIdToCheck = int.Parse(txtVerify.Text);

    //        // Find the GatePass in the list
    //        GatePass gatePass = gatePasses.FirstOrDefault(gp => gp.GatePassId == gatePassIdToCheck);

    //        if (gatePass != null)
    //        {
    //            // Check the GatePass with the GateGuard
    //            gateGuard.CheckGatePass(gatePass);
    //        }
    //        else
    //        {
    //            MessageBox.Show("Gatepass not found");
    //        }
    //    }

    //}

    public partial class frmVisitorForm : Form
    {
        private List<GatePass> gatePasses;
        private GateGuard gateGuard;
        private Logs logs;

        public frmVisitorForm()
        {
            InitializeComponent();

            gatePasses = new List<GatePass>();
            gateGuard = new GateGuard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create a new Visitor from the form's input
            Visitor visitor = new Visitor
            {
                Name = this.txtFullname.Text,
                ContactNo = this.txtContact.Text,
                Address = this.txtAddress.Text,
                PurposeOfVisit = this.txtPurpose.Text
            };

            // Insert the Visitor into the database
            int visitorId = InsertVisitorIntoDatabase(visitor);

            // Create a new GatePass for the Visitor
            GatePass newGatePass = new GatePass
            {
                GatePassId = GenerateGatePassId(), // Generate a unique GatePass ID
                VisitorId = visitorId,
                EmployeeId = rootv.employeeId, // For visitors, set the Employee to null
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddHours(2) // Set the expiry time for the visitor (you can adjust this as per your requirements)
            };

            // Insert the GatePass into the database
            InsertGatePassIntoDatabase(newGatePass);
            logs = new Logs(rootv.username, Environment.UserDomainName, $"{visitor.Name} request a gatepass id: {newGatePass.GatePassId} ", DateTime.Now);
            // Add the GatePass to the list
            gatePasses.Add(newGatePass);

            // Clear the form fields
            ClearForm();

            MessageBox.Show($"Your gatepass id is: {newGatePass.GatePassId}");
            
        }

        private int InsertVisitorIntoDatabase(Visitor visitor)
        {
            int visitorId = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(rootv.ConnectionString))
            {
                string query = "INSERT INTO visitors (Name, ContactNo, Address, PurposeOfVisit) " +
               "VALUES (@Name, @ContactNo, @Address, @PurposeOfVisit) " +
               "RETURNING id;";


                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", visitor.Name);
                    command.Parameters.AddWithValue("@ContactNo", visitor.ContactNo);
                    command.Parameters.AddWithValue("@Address", visitor.Address);
                    command.Parameters.AddWithValue("@PurposeOfVisit", visitor.PurposeOfVisit);

                    connection.Open();
                    visitorId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return visitorId;
        }

        private void InsertGatePassIntoDatabase(GatePass gatePass)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(rootv.ConnectionString))
            {
                string query = "INSERT INTO gatepass (GatePassId, VisitorId, EmployeeId, IssueDate, ExpiryDate) " +
                               "VALUES (@GatePassId, @VisitorId, @EmployeeId, @IssueDate, @ExpiryDate);";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GatePassId", gatePass.GatePassId);
                    command.Parameters.AddWithValue("@VisitorId", gatePass.VisitorId);
                    command.Parameters.AddWithValue("@EmployeeId", gatePass.EmployeeId);
                    command.Parameters.AddWithValue("@IssueDate", gatePass.IssueDate);
                    command.Parameters.AddWithValue("@ExpiryDate", gatePass.ExpiryDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private int GenerateGatePassId()
        {
            // Generate a unique GatePass ID (you can implement your own logic here)
            // For simplicity, you can use a random number or a combination of timestamp and random number.
            return new Random().Next(1000, 9999) + 1;
        }

        private void ClearForm()
        {
            this.txtFullname.Clear();
            this.txtContact.Clear();
            this.txtAddress.Clear();
            this.txtPurpose.Clear();
        }

        //private void btnCheck_Click(object sender, EventArgs e)
        //{
        //    // Get the GatePassId from the form's input
        //    int gatePassIdToCheck = int.Parse(txtVerify.Text);

        //    // Retrieve the GatePass from the database
        //    GatePass gatePass = GetGatePassByIdFromDatabase(gatePassIdToCheck);

        //    if (gatePass != null)
        //    {
        //        // Check the GatePass with the GateGuard
        //        gateGuard.CheckGatePass(gatePass);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Gatepass not found");
        //    }
        //}

        public GatePass GetGatePassByIdFromDatabase(int gatePassId)
        {
            GatePass gatePass = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(rootv.ConnectionString))
            {
                string query = "SELECT GatePassId, VisitorId, EmployeeId, IssueDate, ExpiryDate FROM gatepass WHERE GatePassId = @GatePassId";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GatePassId", gatePassId);

                    connection.Open();

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            gatePass = new GatePass
                            {
                                GatePassId = (int)reader["GatePassId"],
                                VisitorId = (int)reader["VisitorId"],
                                EmployeeId = reader["EmployeeId"] != DBNull.Value ? (int)reader["EmployeeId"] : 0,
                                IssueDate = (DateTime)reader["IssueDate"],
                                ExpiryDate = (DateTime)reader["ExpiryDate"]
                            };
                        }
                    }
                }
            }

            return gatePass;
        }
    }
}
