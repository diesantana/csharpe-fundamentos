
Console.WriteLine("Digite dois números inteiros (Mesma linha, separados por um espaço em branco Ex: 5 8): ");
Console.Write("Números: ");
string[] valores = Console.ReadLine().Split(' ');
int m = int.Parse(valores[0]);
int n = int.Parse(valores[1]);
int[,] matriz = new int[m, n];
Console.WriteLine("Digite os valores da matriz:");
// inserindo os valores na matriz
for (int i = 0; i < m; i++)
{
    string[] linha = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        matriz[i,j] = int.Parse(linha[j]);
    }
}

Console.Write("Digite um número, que percente a matriz: ");
int search = int.Parse(Console.ReadLine());

// buscando o valor "search" na matriz
for (int i = 0;i < m; i++)
{
    for (int j = 0;j < n; j++)
    {
        if (matriz[i,j] == search)
        {
            Console.WriteLine($"Position {i},{j}:");

            //verifica se existe um elemento a esquerda
            if (j > 0) // se a coluna for > 0
            {
                Console.WriteLine("Left: " + matriz[i, (j -1)]);
            }
            //verifica se existe um elemento acima
            if (i > 0) // se a linha for > 0
            {
                Console.WriteLine("Up: " + matriz[(i - 1), j]);
            }
            //verifica se existe um elemento a direita
            if (j < ( matriz.GetLength(1) -1 ) ) // se a coluna for < (qtd colunas -1)
            {
                Console.WriteLine("Right: " + matriz[i, (j + 1)]);
            }
            //verifica se existe um elemento abaixo
            if (i < (matriz.GetLength(0)-1))  // se a linha atual < (qtd de linhas -1)
            {
                Console.WriteLine("Down: " + matriz[(i + 1), j]);
            }
        }
    }
}

