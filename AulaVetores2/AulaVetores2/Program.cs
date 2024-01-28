using AulaVetores2;
using System.Globalization;

Console.Write("Quantos produtos? ");
int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Product[] products = new Product[n];


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Digite os dados do {i+1}º produto:");
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Preço: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    products[i] = new Product(name, price);
}

double sum  = 0.0;

foreach (Product p in products)
{
    sum += p.Price;
}

double average = sum / products.Length;

Console.WriteLine("Media de preço: " + average.ToString("F2", CultureInfo.InvariantCulture));