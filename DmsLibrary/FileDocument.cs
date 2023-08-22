using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsLibrary
{
    public class FileDocument
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public DateTime DateUploaded { get; set; }
        public string Location { get; set; }
        public string User { get; set; }

        public FileDocument(string filename, string department, string description, DateTime dateUploaded, string filelocation, string username)
        {
            this.Name = filename;
            this.Department = department;
            this.Description = description;
            this.DateUploaded = dateUploaded;
            this.Location = filelocation;
            this.User = username;
        }
    }

}
