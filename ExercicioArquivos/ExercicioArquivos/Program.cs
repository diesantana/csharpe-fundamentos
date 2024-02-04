
using ExercicioArquivos.Entities;
using System.Globalization;

string sourcePath = @"c:\temp\file.csv";
List<Product> products = new List<Product>();

try
{
    Directory.CreateDirectory(@"c:\temp\out");
    string fullTargetPath = @"c:\temp\out\summary.csv";
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        string[] filds = line.Split(',');
        string name = filds[0];
        double price = double.Parse(filds[1], CultureInfo.InvariantCulture);
        int quantity = int.Parse(filds[2]);

        products.Add(new Product(name, price, quantity));
    }

    using (StreamWriter streamWriter = File.CreateText(fullTargetPath))
    {
        foreach (Product product in products) { streamWriter.WriteLine(product.TagProduct()); }
    }

}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}
