using System;
using System.Windows.Forms;

namespace TestingPhase
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


        }
    }

    #region -- Implementation of OOP --

    // Gatepass Class
    public class GatePass
    {
        public int GatePassId { get; set; }
        public Employee Employee { get; set; }

        public int EmployeeId { get; set; }
        public int VisitorId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public bool IsExpired ()
        {
            return DateTime.Now > ExpiryDate;
        }
    }

    // Employee Class
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        // Add other properties specific to the Employee
    }

    // Gateguard class
    public class GateGuard
    {
        public void CheckGatePass(GatePass gatePass)
        {
            if (gatePass.IsExpired())
            {
                MessageBox.Show("This gatepass is expired!", "MIS DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"This gatepass id:{gatePass.GatePassId} is valid." ,"MIS DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // Visitor class
    public class Visitor
    {
        public string Name { get; set; }
        //public int ID { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string PurposeOfVisit { get; set; }

    }


    #endregion
}
