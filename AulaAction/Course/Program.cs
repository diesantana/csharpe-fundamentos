using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Mouse", 50.0));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            // chamando a função direto método
            products.ForEach(UpdatePrice);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        // função auxiliar
        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
