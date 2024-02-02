

try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é possível dividir por zero!");
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}

Console.WriteLine("Continua a execução");