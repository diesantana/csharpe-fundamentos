

using System.Globalization;

internal class Program
{
    static double PI = 3.14;
    private static void Main(string[] args)
    {
        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double circunferencia = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture )}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de PI: {PI.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    static double Circunferencia(double raio)
    {
        return 2.0 * PI * raio;
    }

    static double Volume(double raio)
    {
        return 4.0 / 3.0 * PI * Math.Pow(raio, 3);
    }
}