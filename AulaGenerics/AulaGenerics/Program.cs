

using AulaGenerics.Model.Services;
/*
List<int> numbers = new List<int>();
Console.Write("How many values (max 10)? ");
int valuesQuantity = int.Parse(Console.ReadLine());
if(valuesQuantity > 10)
{
    Console.WriteLine("Invalid quantity (max 10)");
    while (valuesQuantity > 10)
    {
        Console.Write("Enter another value (max 10): ");
        valuesQuantity = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < valuesQuantity; i++)
{
    numbers.Add(int.Parse(Console.ReadLine()));
}

PrintService<int>.Print(numbers);
int first =  PrintService<int>.First(numbers);
Console.WriteLine("First: " + first);
*/
List<string> nomes = new List<string>();
Console.Write("How many values (max 10)? ");
int valuesQuantity = int.Parse(Console.ReadLine());
if (valuesQuantity > 10)
{
    Console.WriteLine("Invalid quantity (max 10)");
    while (valuesQuantity > 10)
    {
        Console.Write("Enter another value (max 10): ");
        valuesQuantity = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < valuesQuantity; i++)
{
    nomes.Add(Console.ReadLine());
}

PrintService<string>.Print(nomes);
string first = PrintService<string>.First(nomes);
Console.WriteLine("First: " + first);