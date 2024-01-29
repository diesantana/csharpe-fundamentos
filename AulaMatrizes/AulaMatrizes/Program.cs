


int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

Console.WriteLine(matriz[0, 0]); // 1
Console.WriteLine(matriz[2, 1]); // 8

Console.WriteLine(matriz.Length);

double[,] mat = new double[3, 4];
Console.WriteLine(mat.Rank); // 2

int[,] matriz2 = { { 1, 2, 3 }, { 4, 5, 6 }};
Console.WriteLine(matriz2.GetLength(0)); // 2 linhas
Console.WriteLine(matriz2.GetLength(1)); // 3 colunas

Console.WriteLine();
Console.WriteLine("Iterando sobre uma matriz");

int[,] matriz3 = { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < matriz3.GetLength(0); i++)
{
    for (int j = 0; j < matriz3.GetLength(1); j++)
    {
        Console.Write(matriz3[i, j] + " ");
    }
    Console.WriteLine();
}
