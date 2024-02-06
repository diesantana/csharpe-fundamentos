

using AulaInterfaceComparable.Entities;

string path = @"C:\temp\in.csv";
List<Employee> employees = new List<Employee>();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            employees.Add(new Employee(sr.ReadLine()));
        }
        // Comparação na ordem natural
        employees.Sort();

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }

    }

}
catch (IOException e)
{
    Console.WriteLine("Error: ");
    Console.WriteLine(e.Message);
}