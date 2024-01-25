

using OrientacaoAObjetosProblema2;
using System.Globalization;

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto();
produto.Nome = nome;
produto.Preco = preco;
produto.Quantidade = quantidade;

Console.WriteLine();
Console.WriteLine(
    $"Dados do produto: {produto.Nome}, " +
    $"$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
    $"{produto.Quantidade} unidades, " +
    $"Total: $ {produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ");

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine();
Console.WriteLine(
    $"Dados atualizados: {produto.Nome}, " +
    $"$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
    $"{produto.Quantidade} unidades, " +
    $"Total: $ {produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ");

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
produto.RemoverProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine();
Console.WriteLine(
    $"Dados atualizados: {produto.Nome}, " +
    $"$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
    $"{produto.Quantidade} unidades, " +
    $"Total: $ {produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ");