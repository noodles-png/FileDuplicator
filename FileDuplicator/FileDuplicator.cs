namespace FileDuplicator;
using System.IO;


public class FileCounter
{
    string _path = Directory.GetCurrentDirectory();
    public string NewFileName { get; }

    public FileCounter(string path) 
    {
        string srcFile =  Path.GetFileNameWithoutExtension(path);
        int highestCounter = 1;
        int newCounter = 0;
        int kwIndex = srcFile.LastIndexOf("kw", StringComparison.OrdinalIgnoreCase);
        string prefixName = srcFile[..kwIndex];
        
        foreach (string file in Directory.EnumerateFiles(path))
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            int checkIndex = int.Parse(fileName[(kwIndex + 2)..]);
            if (checkIndex > highestCounter)
            {
                highestCounter = checkIndex;
            }
        }
        
        newCounter = highestCounter + 1;
        NewFileName = prefixName + "kw" + newCounter.ToString("D2");
    }
}

public class FileDuplicator
{
    
}