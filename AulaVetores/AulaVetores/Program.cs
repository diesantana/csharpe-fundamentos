using System.Globalization;

Console.Write("Quantas pessoas: ");
int n = int.Parse(Console.ReadLine());
double[] alturas = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Digite a altua da {i + 1}° pessoa: ");
    alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double media = alturas.Average();
Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));