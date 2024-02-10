using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void PrintList<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message + ":");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // TIER 1 AND PRICE < 900
            var teste1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            PrintList("Tier 1 and Price < 900", teste1);

            // NAMES OF PRODUCTS FROM TOOLS
            var teste2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            PrintList("Names of product from tools", teste2);

            // NAMES STARTED WITH 'C'
            var teste3 = products.Where(p => p.Name[0] == 'c' || p.Name[0] == 'C');
            PrintList("Names started with C", teste3);

            // NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT
            var teste4 = products
                .Where(p => p.Name[0] == 'c' || p.Name[0] == 'C')
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            PrintList("Names started with C and anonymous object", teste4);

            // PRODUCTS WITH TIER 1, ORDER PER PRICE
            var teste5 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price);
            PrintList("Products with tier 1, ORDER PER PRICE", teste5);
            // ORDER PER PRICE AND PER NAME
            var teste6 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            PrintList("Products with tier 1, ORDER PER PRICE AND NAME", teste6);

            // USE TEST 6: IGNORE THE 2 FIRST AND TAKE 4
            var teste7 = teste6.Skip(2).Take(4);
            PrintList("SKIP 2 THEN TAKE 4", teste7);

            // FIRST ELEMENT
            var teste8 = products.FirstOrDefault();
            Console.WriteLine("FIRST: " + teste8);
            Console.WriteLine();

            // FIRST ELEMENT OR NULL
            var teste9 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("FIRST NULL: " + teste9);
            Console.WriteLine();

            // SINGLE VALUE
            var teste10 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SINGLE VALUE: " + teste10);
            Console.WriteLine();

            // SINGLE VALUE NULL
            var teste11 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SINGLE VALUE NULL: " + teste11);
            Console.WriteLine();

            // MAX & MIN 
            var teste12 = products.Max(p => p.Price);
            Console.WriteLine("Max:" + teste12);
            var teste13 = products.Min(p => p.Price);
            Console.WriteLine("Min:" + teste13);
            Console.WriteLine();

            // SUM & AVERAGE 
            var teste14 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum Category 1: " + teste14);
            Console.WriteLine();
            var teste15 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average category 1: " + teste15);
            Console.WriteLine();

            // Safe Average
            var teste16 = products.Where(p => p.Category.Id == 15).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Safe Average category 1: " + teste16);
            Console.WriteLine();

            // Aggregate 
            var teste17 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (acc, sum) => acc + sum);
            Console.WriteLine("Aggregate sum  category 1: " + teste17);
            Console.WriteLine();

            // Grouping  
            var teste18 = products.GroupBy(p => p.Category);
            foreach ( var group in teste18)
            {
                // Nomes das categorias
                Console.WriteLine(group.Key.Name); 

                // item de cada categoria
                foreach( var groupItem in group)
                {
                    Console.WriteLine(groupItem);
                }
                Console.WriteLine();
            }

        }

    }
}
