
using OrientacaoAObjetosExercicios4;
using System.Globalization;

double minParaSerAprovado = 60.0;
Aluno aluno = new Aluno();
Console.WriteLine("Digite os dados do aluno:");
Console.Write("Nome: ");
string nome  = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno:");
Console.Write("1° Trimestre: ");
double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("2° Trimestre: ");
double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("3° Trimestre: ");
double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

aluno.Nome = nome;
aluno.Nota1 = nota1;
aluno.Nota2 = nota2;
aluno.Nota3 = nota3;

double notaFinal = aluno.NotaFinal();
Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");

if (notaFinal >= minParaSerAprovado)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine($"FALTARAM {(minParaSerAprovado - notaFinal).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
}