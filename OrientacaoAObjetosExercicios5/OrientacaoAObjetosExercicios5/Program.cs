using OrientacaoAObjetosExercicios5;
using System.Globalization;

Console.WriteLine("EXERCÍCIO: CONVERSOR DE MOEDAS");
Console.WriteLine();

Console.Write("Qual é a cotação do dólar? ");
double cotacaoDolar  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double dolaresQuantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double dolarEmReal = ConversorDeMoeda.ValorPagarReais(cotacaoDolar, dolaresQuantidade);

Console.WriteLine($"Valor a ser pago em reais = {dolarEmReal.ToString("F2", CultureInfo.InvariantCulture)}");