using System.Globalization;

Console.WriteLine("Digite um valor: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double desconto = (valor > 20.0) ? valor * 0.05 : valor * 0.1;
Console.WriteLine("Desconto de: " + desconto);
