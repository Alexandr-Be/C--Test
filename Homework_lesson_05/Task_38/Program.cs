/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

int DetermineMaxElement(int[] array)
{
    int maxEl=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxEl) 
            maxEl=array[i];
    }
    return maxEl;
}

int DetermineMinElement(int[] array)
{
    int minEl=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minEl) 
            minEl=array[i];
    }
    return minEl;
}

Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtArray];
FillArray(array);
PrintArray(array);
int maxElement = DetermineMaxElement(array);
int minElement = DetermineMinElement(array);
int difference=maxElement-minElement;

Console.Write($" -> {difference}");

Console.WriteLine();