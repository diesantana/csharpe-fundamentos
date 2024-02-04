
string path = @"C:\temp";

try
{
    // listando as pastas 
    var folders = Directory.GetDirectories(path);
    foreach (var folder in folders)
    {
        Console.WriteLine(folder);
    }

    Console.WriteLine();
    // listando os arquivos em uma pasta
    var files = Directory.GetFiles(path);
    foreach(var file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + @"\pasta teste\pasta dentro do teste");
    Console.WriteLine("Criado!");

}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}