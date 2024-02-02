
using ExercicioMetodosAbstratos.Entities;
using System.Globalization;

List<Taxpayer> taxpayers = new List<Taxpayer>();
Console.Write("Enter the number of taxpayers: ");
int nTaxpayers = int.Parse(Console.ReadLine());

for (int i = 0; i < nTaxpayers; i++)
{
    Console.WriteLine($"Taxpayer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char typeTaxpayer = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Annual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (typeTaxpayer == 'i')
    {
        Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        taxpayers.Add(new Individual(name, income, health));
    }
    if (typeTaxpayer == 'c')
    {
        Console.Write("Number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());
        taxpayers.Add(new Company(name, income, numberEmployees));
    }
}
Console.WriteLine();
Console.WriteLine("TAXES PAID");
foreach (Taxpayer t in taxpayers)
{
    Console.WriteLine(t);
}

double totalTaxes = 0.0;
foreach (Taxpayer t in taxpayers)
{
    totalTaxes += t.TaxCal();
}

Console.WriteLine($"Total Taxes: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");