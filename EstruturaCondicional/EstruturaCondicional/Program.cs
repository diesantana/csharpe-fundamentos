using System;
using System.Globalization;
namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int quantidade = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Valor #{i+1}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma = {soma}");

        }
    }
}