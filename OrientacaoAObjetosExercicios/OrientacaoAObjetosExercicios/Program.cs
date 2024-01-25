using OrientacaoAObjetosExercicios;
using System.Globalization;
/*
Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

Pessoa p1 = new Pessoa();
p1.Nome = nome;
p1.Idade = idade;

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Idade: ");
idade = int.Parse(Console.ReadLine());

Pessoa p2 = new Pessoa();
p2.Nome = nome;
p2.Idade = idade;

if (p1.Idade > p2.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
}
else
{
    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
}
*/
Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Salário: ");
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Funcionario f1 = new Funcionario();
f1.Nome = nome;
f1.Salario = salario;

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Salário: ");
salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Funcionario f2 = new Funcionario();
f2.Nome = nome;
f2.Salario = salario;

double media = (f1.Salario + f2.Salario) / 2;
Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");


