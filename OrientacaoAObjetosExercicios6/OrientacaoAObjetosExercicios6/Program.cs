using OrientacaoAObjetosExercicios6;
using System.Globalization;

Console.WriteLine("EXERCÍCIO: CONTA BANCÁRIA");

Console.Write("Entre com o número da conta:  ");
int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre com o nome do titular da conta:  ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char bTemDeposito = char.Parse(Console.ReadLine());

double deposito = 0.0;

if (bTemDeposito == 's')
{
    Console.Write("Entre com o valor de depósito inicial: ");
    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitular, deposito);

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre com um valor para depósito: ");
deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(deposito);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre com um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(saque);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
Console.WriteLine();



