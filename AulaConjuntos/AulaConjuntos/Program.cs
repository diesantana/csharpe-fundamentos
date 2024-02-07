
//HashSet<string> names = new HashSet<string>();
//SortedSet<int> numbers = new SortedSet<int>();

HashSet<string> names = new HashSet<string> { "Pedro", "Bob", "Alice" };
SortedSet<int> numbers = new SortedSet<int> { 5, 7, 3, 4, };

names.Add("Maria");
names.Add("Bob");
names.Add("Alex");

PrintCollection(names);

Console.WriteLine();

SortedSet<int> a = new SortedSet<int>() { 50, 60, 70, 80 };
SortedSet<int> b = new SortedSet<int>(a);
SortedSet<int> c = a;
Console.Write("a = ");
PrintCollection(a);
Console.Write("b = ");
PrintCollection(b);
Console.Write("c = ");
PrintCollection(c);
Console.WriteLine();


SortedSet<int> n1 = new SortedSet<int> { 1, 2, 3};
SortedSet<int> n2 = new SortedSet<int> { 3, 4, 5};

// união
//Console.WriteLine("União");
//n1.UnionWith(n2);
//Console.WriteLine();


// interseção
/*Console.WriteLine("Interseção");
Console.Write("n1 = ");
PrintCollection(n1);
Console.Write("n2 = ");
PrintCollection(n2);*/

Console.Write("n1 = ");
PrintCollection(n1);
Console.Write("n2 = ");
PrintCollection(n2);

Console.WriteLine("Diferença:");
n1.ExceptWith(n2);

PrintCollection(n1);



static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}