
using AulaComparison.Model.Entities;

List<Product> products = new List<Product>();
products.Add(new Product("TV", 900.0));
products.Add(new Product("Notebook", 1200.0));
products.Add(new Product("Tablet", 450.0));

// Comparison<Product> comp = (p1, p2) => p1.Price.CompareTo(p2.Price);

products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));

foreach (Product product in products)
{
    Console.WriteLine(product);
}