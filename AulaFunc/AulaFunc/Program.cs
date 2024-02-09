﻿using AulaFunc.Entities;

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

            // expressão lambda direto do método
            List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

            result.ForEach(x => Console.WriteLine(x));
        }
    }
}
