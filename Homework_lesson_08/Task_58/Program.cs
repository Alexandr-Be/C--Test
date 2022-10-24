/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplexMatrixes(int[,] matr1, int[,] matr2)
{
    int[,] newMatr = new int[matr1.GetLength(1), matr2.GetLength(0)];
    for (int i = 0; i < matr1.GetLength(1); i++)
    {
        for (int j = 0; j < matr2.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr2.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            newMatr[i, j] = sum;

        }
    }
    return newMatr;
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
FillArray(matrix1);
FillArray(matrix2);

Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArray(matrix2);
Console.WriteLine();

Console.WriteLine("Результирующая матрица");
int[,] newMatrix = MultiplexMatrixes(matrix1, matrix2);
PrintArray(newMatrix);
