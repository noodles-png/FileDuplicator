using FileDuplicator;


try
{
   var program = new FileCounter(
       @"Directory/Path"); // Insert Path here
   program.DuplicateFile();
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}




