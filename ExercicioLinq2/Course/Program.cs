using Course.Entities;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();
                Console.Write("Enter Salary: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }

                    Console.WriteLine($"Email of people whose salary is more than " +
                        $"{amount.ToString("F2", CultureInfo.InvariantCulture)}:");

                    var emails = employees.Where(p => p.Salary > amount)
                        .Select(p => p.Email)
                        .Order();

                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    double sum = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
                    Console.WriteLine("Sum of salary of people whose name starts with 'M': "
                        + sum.ToString("F2", CultureInfo.InvariantCulture));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


        }
    }
}
