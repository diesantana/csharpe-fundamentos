

string path = @"c:\temp\file1.txt";
StreamReader sr = null;

try
{
    sr = File.OpenText(path);  // Instancia um StreamReader a partir do File, com UTF8 (File.OpenText) 
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }

}
catch (IOException e)
{
    Console.WriteLine("An Error occurred:");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();  //fecha o StreamReader se ele estiver aberto (!null)
}