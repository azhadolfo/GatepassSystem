namespace DmsLibrary;

public class FileDocument
{
    public string FileName { get; set; }
    public string Department { get; set; }
    public string Description { get; set; }

    public FileDocument(string filename, string department, string description)
    {
        this.FileName = filename;
        this.Department = department;
        this.Description = description;
    }
}
