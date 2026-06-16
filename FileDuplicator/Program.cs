using FileDuplicator;


try
{
   var program = new FileCounter(
       @"Path/Directory"); // Insert file path here
   program.DuplicateFile();
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}




