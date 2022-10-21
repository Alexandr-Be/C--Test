/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
            // matr[i, j] = j + 1;
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

int[,] SelectionSort(int[,] matr)
{
    int[,] newMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int minPosition = j;
            for (int n = j + 1; n < matr.GetLength(1); n++)
            {
                if (matr[i, n] > matr[i, minPosition])  minPosition = n;
            }
            int temporary = matr[i, j];
            newMatr[i, j] = matr[i, minPosition];
            matr[i, minPosition] = temporary;
        }
    }
    return newMatr;
}


Console.WriteLine("Введите количество строк в матрице:");
int heightMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в матрице:");
int widthMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[heightMatrix, widthMatrix];
FillArray(matrix);
Console.WriteLine("Исходная матрица");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
int[,] newMatrix = SelectionSort(matrix);
PrintArray(newMatrix);
