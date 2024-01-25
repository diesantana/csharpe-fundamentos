using OrientacaoAObjetosExercicios2;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a largura e altura do retângulo: ");
Console.Write("Largura: ");
double largura  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

retangulo.Largura = largura;
retangulo.Altura = altura;

double area = retangulo.Area();
double perimetro = retangulo.Perimetro();
double diagonal = retangulo.Diagonal();

Console.WriteLine($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERÍMETRO = {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");