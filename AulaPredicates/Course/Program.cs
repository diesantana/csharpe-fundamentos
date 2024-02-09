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

            // remova da lista somente aqueles cujo preço mínimo seja 100
            //products.RemoveAll(p => p.Price >= 100.0);
            products.RemoveAll(ProductTeste);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            // saída: 
            // Mouse, 50,00
            // HD Case, 80,90

        }

        public static bool ProductTeste(Product product)
        {
            return product.Price >= 100.0;
        }
    }
}
