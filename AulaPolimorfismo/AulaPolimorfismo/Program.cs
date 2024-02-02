
using AulaPolimorfismo.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int numberEmp = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 0; i < numberEmp; i++)
{
    Console.WriteLine($"Employee #{i + 1} data:");
    Console.Write("Outsourced (y/n)? ");
    char bIsOutsourced = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hours: ");

    double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (bIsOutsourced == 'n')
    {
        employees.Add(new Employee(name, hours, valuePerHours));
    }
    else if (bIsOutsourced == 'y')
    {
        Console.Write("Additional charge: ");
        double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        employees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additional));
    }
    else
    {
        Console.WriteLine("Valor inválido!");
    }


}
Console.WriteLine();
Console.WriteLine("PAYMENTS: ");
foreach (Employee emp in employees)
{
    Console.WriteLine(emp);
}