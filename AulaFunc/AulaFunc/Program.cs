using AulaFunc.Entities;

namespace AulaFunc
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

            // criando uma referencia para o método (delegate)
            Func<Product, string> func = p => p.Name.ToUpper();

            // chamada do método
            List<string> result = products.Select(func).ToList();

            result.ForEach(x => Console.WriteLine(x));
        }

        // Método auxiliar que corresponde a assinatura do Func
        public static string NamesUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
