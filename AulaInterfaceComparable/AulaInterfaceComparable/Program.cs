

string path = @"C:\temp\in.txt";
List<string> names = new List<string>();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            names.Add(sr.ReadLine());
        }
    }
    // Comparação na ordem natural
    names.Sort();

    // Lógica parsonalizada
    // names.Sort((x, y) => x.Length.CompareTo(y.Length));

    // Comparação na ordem decrescente 
    //names.Sort();
    //names.Reverse();

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}
catch(IOException e)
{
    Console.WriteLine("Error: ");
    Console.WriteLine(e.Message);
}