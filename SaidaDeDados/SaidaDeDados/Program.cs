using System;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.35784;
            int idade = 30;
            string nome = "Maria";
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");
            // Maria tem 30 anos e tem saldo igual a 10.36 reais

            Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a " +  saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}