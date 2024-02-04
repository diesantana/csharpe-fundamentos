
string path = @"c:\temp\file1.txt";

char separadorDiretorio = Path.DirectorySeparatorChar;
Console.WriteLine("separadorDiretorio: " + separadorDiretorio);

char separadorCaminho = Path.PathSeparator;
Console.WriteLine("separadorCaminho: " + separadorCaminho);

string directoryName = Path.GetDirectoryName(path);
Console.WriteLine("Directory name: " + directoryName);


