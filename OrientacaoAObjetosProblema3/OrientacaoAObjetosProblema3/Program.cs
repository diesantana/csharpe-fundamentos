

using OrientacaoAObjetosProblema3;
using System.Globalization;


Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double circunferencia = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor de PI: {Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture)}");
