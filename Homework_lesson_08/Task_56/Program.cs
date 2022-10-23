/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
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

void PrintAll(int[,] matr, int[] array)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine($"  сумма строки = {array[i]} ");
    }
}

int[] CountSumString(int[,] matr)
{
    int[] arrSumStr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arrSumStr[i] += matr[i, j];
        }
    }
    return arrSumStr;
}

int DetermineNumberStr(int[] array)
{
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minPosition])  minPosition = i;
    }
    return minPosition;
}


Console.WriteLine("Введите количество строк в массиве:");
int heightMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве:");
int widthMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[heightMatrix, widthMatrix];
FillArray(matrix);

int[] newArray = CountSumString(matrix);
Console.WriteLine("Задан массив:");
PrintAll(matrix, newArray);
Console.WriteLine();

int minPosition = DetermineNumberStr(newArray)+1;
Console.WriteLine($"{minPosition} строка");