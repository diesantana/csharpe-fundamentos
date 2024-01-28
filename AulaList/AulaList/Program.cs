

List<string> nomes1 = new List<string>();

nomes1.Add("Maria");
nomes1.Add("Bob");
nomes1.Add("Joao");

foreach (string nome in nomes1)
{
    Console.WriteLine(nome);
}
Console.WriteLine();

nomes1.Insert(1, "Pedro");

foreach (string nome in nomes1) 
{
    Console.WriteLine(nome); 
}

//Console.WriteLine("Primeiro elemento: " + nomes[0]);

Console.WriteLine(nomes1.Count); // 4
Console.WriteLine("-------------------------------");

List<string> nomes = new List<string> { "Maria", "Bob", "Alex", "Pedro", "Ana", "Julia"};

foreach (string nome2 in nomes)
{
    Console.WriteLine(nome2);
}
Console.WriteLine();

string s1 = nomes.FindLast(x => x[0] == 'A');
Console.WriteLine(s1); // Ana

// string s1 = nomes2.Find(x => x[0] == 'A');
//Console.WriteLine(s1); // Alex

int pos = nomes.FindIndex(x => x[0] == 'A');
Console.WriteLine("Pos FindIndex 'A' = " + pos);

int posLast = nomes.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Pos FindLastIndex 'A' = " + posLast); // 4
Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();


// List<string> nomes = new List<string> { "Maria", "Bob", "Alex", "Pedro", "Ana", "Julia"};

List<string> nomesFiltrados = nomes.FindAll(x => x.Length >= 5); // Maria Pedro Julia

foreach (string nome in nomes)
{
    Console.WriteLine(nome); 
}

Console.WriteLine();
// nomes.Remove("Bob");
// nomes.RemoveAll(x => x[0] == 'M');
// nomes.RemoveAt(2);

nomes.RemoveRange(1, 2);

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}