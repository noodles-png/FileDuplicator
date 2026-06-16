using FileDuplicator;


try
{
   var program = new FileCounter(
       @"Path/Directory");
   program.DuplicateFile();
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}




