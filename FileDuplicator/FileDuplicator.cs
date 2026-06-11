namespace FileDuplicator;
using System.IO;


public class FileNamer
{
    string _path = Directory.GetCurrentDirectory();
    string _fileName = ;
    private string _file = "";

    public FileNamer(string path) // ToDo: Choose a better name
    {
        string srcFile =  Path.GetFileNameWithoutExtension(path);
        
        int extIndex = srcFile.LastIndexOf("kw", StringComparison.OrdinalIgnoreCase);
        
    }
}