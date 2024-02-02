

using ExercicioHerancaPolimorfismo.Entities;
using System.Globalization;
using System.Linq.Expressions;

List<Product> products = new List<Product>();
Console.Write("Enter the number of products: ");
int numberProduct = int.Parse(Console.ReadLine());

for (int i = 0; i < numberProduct; i++)
{
    Console.WriteLine($"Product #{i + 1} data:");
    Console.Write("Commom, used or imported (c/u/i)? ");
    char productType = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    switch (productType)
    {
        case 'c':
            products.Add(new Product(name, price));
            break;
        case 'u':
            Console.Write("Manufacture date (DD/MM/YYYY): ");
            string sDate = Console.ReadLine();
            DateTime date = DateTime.Parse(sDate);
            products.Add(new UsedProduct(name, price, date));
            break;
        case 'i':
            Console.Write("Customs fee: ");
            double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            products.Add(new ImportedProduct(name, price, customs));
            break;
        default:
            Console.WriteLine("Invalid product type");
            break;

    }
}
Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}