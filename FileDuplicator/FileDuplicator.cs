namespace FileDuplicator;
using System.IO;


public class FileCounter
{
    private string _fullPath;
    private string _directory;
    public string newName { get; }

    // Looks for file with highest counter and creates new Name with +1 on highest counter (e.g. KW24 -> KW25)
    public FileCounter(string path) 
    {
        _fullPath = path;
        _directory = Path.GetDirectoryName(path);
        
        string srcFile =  Path.GetFileNameWithoutExtension(path);
        int kwIndex = srcFile.LastIndexOf("kw", StringComparison.OrdinalIgnoreCase); // Returns the index of the string where "kw" is
        string prefixName = srcFile[..kwIndex];
        
        int highestCounter = 1;
        int newCounter = 0;
        
        foreach (string file in Directory.EnumerateFiles(_directory))
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            int fileKwIndex = fileName.LastIndexOf("kw", StringComparison.OrdinalIgnoreCase);

            if (fileKwIndex < 0) // Ignores files with keyword
                continue;
            
            int checkIndex = int.Parse(fileName[(kwIndex + 2)..]);
            if (checkIndex > highestCounter)
            {
                highestCounter = checkIndex;
            }
        }
        newCounter = highestCounter + 1;
        newName = prefixName + "KW" + newCounter.ToString("D2"); // Change the KW to any other string that ends before the counter
    }
    
    // Creates new Copy with the new counter name 
    public void DuplicateFile()
    {
        string extension = Path.GetExtension(_fullPath);
        string newFilePath = Path.Combine(_directory, newName + extension);
        File.Copy(_fullPath, newFilePath);
    }
}