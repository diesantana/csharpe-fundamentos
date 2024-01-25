

using OrientacaoAObjetosProblema3;
using System.Globalization;

Calculadora calculadora = new Calculadora();

Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
calculadora.Raio = raio;

double circunferencia = calculadora.Circunferencia();
double volume = calculadora.Volume();

Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Valor de PI: {calculadora.PI.ToString("F2", CultureInfo.InvariantCulture)}");
