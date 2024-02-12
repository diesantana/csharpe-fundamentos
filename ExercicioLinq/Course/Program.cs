using Course.Entities;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();
                List<Product> products = new List<Product>();

                using (StreamReader sr = File.OpenText(path))

                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                    }

                    double averagePrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Average price: " + averagePrice.ToString("F2", CultureInfo.InvariantCulture));

                    // produtos abaixo da média 
                    var belowAverage = products.Where(p => p.Price < averagePrice).Select(p => p.Name).OrderDescending();
                    foreach (var item in belowAverage)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
