
using OrientacaoAObjetosExercicios3;
using System.Globalization;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Entre com os dados do funcionário:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.Nome = nome;
funcionario.SalarioBruo = salarioBruto;
funcionario.Imposto = imposto;
Console.WriteLine();

Console.WriteLine("Funcionário: " +  funcionario);
Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.AumentarSalario(porcentagemAumento);

Console.WriteLine("Dados atualizos: " + funcionario);
