

using Aulagenerics2.Model.Entities;
using Aulagenerics2.Model.Services;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] filds = Console.ReadLine().Split(',');
    string name  = filds[0];
    double price = double.Parse(filds[1], CultureInfo.InvariantCulture);
    products.Add(new Product(name, price));
}

CalculationService calculationService = new CalculationService();
Product max = calculationService.Max(products);
Console.WriteLine("Max: ");
Console.WriteLine(max);
