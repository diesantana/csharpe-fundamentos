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
            var teste1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            PrintList("Tier 1 and Price < 900", teste1);

            // NAMES OF PRODUCTS FROM TOOLS
            var teste2 = from p in products
                         where p.Category.Name == "Tools"
                         select p.Name;
            PrintList("Names of product from tools", teste2);

            // NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT
            var teste3 =
                from p in products
                where p.Name[0] == 'C' || p.Name[0] == 'c'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            PrintList("Names started with C and anonymous object", teste3);

            var teste4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            PrintList("TIER 1 ORDER PRO  PREÇO E ENTÃO POR NOME", teste4);
            Console.WriteLine();

            // USE TEST 4: IGNORE THE 2 FIRST AND TAKE 4
            var teste5 =
                (from p in teste4 select p)
                .Skip(2)
                .Take(4);
            PrintList("SKIP 2 THEN TAKE 4", teste5);
            Console.WriteLine();

            var teste66 = products.GroupBy(p => p.Category);
            var teste6 =
                from p in products
                group p by p.Category;
            foreach (var group in teste6)
            {
                Console.WriteLine(group.Key.Name);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}
