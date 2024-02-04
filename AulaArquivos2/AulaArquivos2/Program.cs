

string path = @"c:\temp\file1.txt";
try
{
    using (FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
    }
}
catch (IOException e)
{
    Console.WriteLine("An Error occurred:");
    Console.WriteLine(e.Message);
}