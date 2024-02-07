

HashSet<int> studentsA = new HashSet<int>();
HashSet<int> studentsB = new HashSet<int>();
HashSet<int> studentsC = new HashSet<int>();

Console.Write("How many students for course A? ");
int quantity = int.Parse(Console.ReadLine());
for (int i = 0; i < quantity; i++)
{
    int id = int.Parse(Console.ReadLine());
    studentsA.Add(id);
}

Console.Write("How many students for course B? ");
quantity = int.Parse(Console.ReadLine());
for (int i = 0; i < quantity; i++)
{
    int id = int.Parse(Console.ReadLine());
    studentsB.Add(id);
}

Console.Write("How many students for course C? ");
quantity = int.Parse(Console.ReadLine());
for (int i = 0; i < quantity; i++)
{
    int id = int.Parse(Console.ReadLine());
    studentsC.Add(id);
}

HashSet<int> totalStudents = new HashSet<int>(studentsA);
totalStudents.UnionWith(studentsB);
totalStudents.UnionWith(studentsC);

Console.WriteLine("Total students: " + totalStudents.Count);