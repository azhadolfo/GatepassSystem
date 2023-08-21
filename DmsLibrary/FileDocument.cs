using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsLibrary
{
    public class FileDocument
    {
        public string FileName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public DateTime DateUploaded { get; set; }

        public FileDocument(string filename, string department, string description, DateTime dateUploaded)
        {
            this.FileName = filename;
            this.Department = department;
            this.Description = description;
            DateUploaded = dateUploaded;
        }
    }

}
