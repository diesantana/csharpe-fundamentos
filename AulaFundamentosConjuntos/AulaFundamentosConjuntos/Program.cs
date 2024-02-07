
using Course.Entities;

HashSet<Product> products = new HashSet<Product>();
products.Add(new Product("TV", 900.0));
products.Add(new Product("Notebook", 1200.0));

Product notebook = new Product("Notebook", 1200.0);
Console.WriteLine(products.Contains(notebook)); // false

products.Add(notebook);
foreach (Product product in products)
{
    Console.WriteLine(product);
}



HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Point c = new Point(5, 10);
Console.WriteLine(b.Contains(c)); // true