
string source = @"c:\temp\file1.txt";
string targetPath = @"c:\temp\new file.txt";

try
{
    // ler o arquivo de origem e armazenar o seu conteúdo
    string[] lineSource = File.ReadAllLines(source);

    using (StreamWriter streamWriter = File.CreateText(targetPath))
    {
        foreach (string line in lineSource)
        {
            streamWriter.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}