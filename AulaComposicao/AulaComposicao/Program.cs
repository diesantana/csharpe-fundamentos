
using AulaComposicao.Entities;
using AulaComposicao.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string deparmentName = Console.ReadLine();

Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Juniot/MidLevel/Senior) : ");
string level = Console.ReadLine();
WorkerLevel workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

Console.Write("How many contracts to this worker? ");
int quantityContracts = int.Parse(Console.ReadLine());

// instancia o trabalhador
Worker worker = new Worker(name, workerLevel, baseSalary, new Department(deparmentName));


// add os contratos
for (int i = 0; i < quantityContracts; i++)
{
    Console.WriteLine($"Enter #{i+1} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    string sDate = Console.ReadLine();
    DateTime date = DateTime.Parse(sDate);
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
    Console.Write("Duration: ");
    int hours = int.Parse(Console.ReadLine());
    worker.AddContract(new HourContract(date, valuePerHour, hours));
}
Console.WriteLine();

// Calculando o salário de um mês específico
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string dateIncome = Console.ReadLine();
string[] fildsDate = dateIncome.Split('/');
double salary = worker.Income(int.Parse(fildsDate[1]), int.Parse(fildsDate[0]));
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department);
Console.WriteLine($"Income for {dateIncome}: {salary.ToString("F2", CultureInfo.InvariantCulture)}");


