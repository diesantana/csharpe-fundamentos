using OrientacaoAObjetosExercicios6;
using System.Globalization;

Console.WriteLine("EXERCÍCIO: CONTA BANCÁRIA");

Console.Write("Entre com o número da conta:  ");
int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre com o nome do titular da conta:  ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char bTemDeposito = char.Parse(Console.ReadLine());

double quantia = 0.0;

if (bTemDeposito == 's' || bTemDeposito == 'S')
{
    Console.Write("Entre com o valor de depósito inicial: ");
    quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitular, quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre com um valor para depósito: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre com um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
Console.WriteLine();



