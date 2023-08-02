﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPhase
{
   
    public partial class frmAddEmployee : Form
    {
        rootv root = new rootv();
        string query;
        DataSet ds;
        
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var fname = txtFirstname.Text;
                var lname = txtLastname.Text;
                var username = txtUsername.Text;
                var password = txtPassword.Text;


                if(!String.IsNullOrEmpty(fname)&&
                   !String.IsNullOrEmpty(lname)&&
                   !String.IsNullOrEmpty(username)&&
                   !String.IsNullOrEmpty(password))
                {
                    query = $"SELECT * FROM tblemployee WHERE username = {username}";     
                    ds = root.GetData(query);
                    if ( ds != null && ds.Tables[0].Rows.Count == 0 )
                    {
                        root.AddData(fname,lname,username,password);
                        ClearFields();
                    
                    }
                    else
                    {
                        MessageBox.Show("The username is already linked with another account","System Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The fields is empty please fill and try again.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception)
            {
                MessageBox.Show("There's an error while saving the data.", "MIS DEPARTMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
