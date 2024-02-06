

using Aulagenerics2.Model.Services;

List<int> numbers = new List<int>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    numbers.Add(x);
}

CalculationService calculationService = new CalculationService();
int max = calculationService.Max(numbers);
Console.WriteLine("Max: ");
Console.WriteLine(max);
