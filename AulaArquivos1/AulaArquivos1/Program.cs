
string sourcePath = @"c:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    //fileInfo.CopyTo(targetPath);
    File.Copy(sourcePath, @"c:\temp\file3.txt");

    string[] lines = File.ReadAllLines(sourcePath);
    Console.WriteLine("File ReadAllLines:");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    bool exist = File.Exists(targetPath);
    Console.WriteLine("Exist: " + exist);


}

catch(IOException e)
{
    Console.WriteLine("An error ocurred:");
    Console.WriteLine(e.Message);
}