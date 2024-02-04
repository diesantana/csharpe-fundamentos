

string path = @"c:\temp\file1.txt";
FileStream fs = null;
StreamReader sr = null;

try
{
    fs = new FileStream(path, FileMode.Open); // abre o arquivo
    sr = new StreamReader(fs);                // Stream para Ler o arquivo 
    string linha = sr.ReadLine();
    Console.WriteLine(linha);
}
catch (IOException e)
{
    Console.WriteLine("An Error occurred:");
    Console.WriteLine(e.Message);
}
finally
{
    if(sr != null) sr.Close();  //fecha o StreamReader se ele estiver aberto (!null)
    if(fs != null) fs.Close();  //fecha o FileStream se ele estiver aberto (!null)
}