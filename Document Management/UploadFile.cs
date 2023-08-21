using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DmsLibrary;


namespace TestingPhase.Document_Management
{
    public partial class UploadFile : UserControl
    {
        private FileDocument fileDocument;
        public UploadFile()
        {
            InitializeComponent();
        }

        // Declare a string to store the selected file name
        private string selectedFilePath = "";

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File"; // Change the title to indicate uploading a file
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            //openFileDialog.Filter = "All Files (*.*)|*.*"; // Allow all file types to be selected

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store the selected file path
                selectedFilePath = openFileDialog.FileName;

                // Display the selected file name in the text box
                //txtFileName.Text = Path.GetFileName(selectedFilePath); //This is for specified name only
                txtFileName.Text = openFileDialog.FileName; //this is for including the path 
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Kindly select a file to upload!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSearchFile.Focus();
            }
            else if (string.IsNullOrEmpty(cboDepartment.Text))
            {
                MessageBox.Show("Kindly select the designated department!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartment.Focus();
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Kindly input the description of the file!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
            else
            {
                // Prepare the customized filename
                string departmentName = cboDepartment.Text;
                string currentDate = DateTime.Now.ToString("yyyyMMddHHmmss"); // Format the date as needed
                string customizedFileName = $"{departmentName}_{currentDate}_{Path.GetFileName(selectedFilePath)}";

                // Construct the destination file path
                string destinationFolderPath = @"C:\Users\FILPRIDE\Desktop\Azh Folder"; // Destination folder path
                string destinationFilePath = Path.Combine(destinationFolderPath, customizedFileName);

                try
                {
                    // Copy the selected file to the chosen location
                    File.Copy(selectedFilePath, destinationFilePath);

                    // Now you can use the fileDocument object as needed
                    fileDocument = new FileDocument(txtFileName.Text, cboDepartment.Text, txtDescription.Text, DateTime.Now);

                    ClearFields();

                    MessageBox.Show("File uploaded and saved successfully", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while copying the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ClearFields()
        {
            txtFileName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cboDepartment.Text = string.Empty;
        }
    }
}
