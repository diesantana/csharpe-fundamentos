

int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];

// Inserindo os valores na matriz
// linha por linha
// n linhas 
// separado por espaço (split)

for (int i = 0; i < matriz.GetLength(0); i++)
{
    string[] linha = Console.ReadLine().Split(' ');
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i,j] = int.Parse(linha[j]);
    }
}

Console.WriteLine("Main diagonal: ");
// Diagonal principal
for (int i = 0; i < matriz.GetLength(0); i++)
{
      Console.Write(matriz[i, i] +" ");
}
Console.WriteLine();


// Números negativos
int negativeNumbers = 0;

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        if (matriz[i,j] < 0)
        {
            negativeNumbers ++;
        }
    }
}

Console.WriteLine("Negative numbers = " + negativeNumbers);
