/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
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

int CountEvenPositions(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];

    }
    return count;
}

Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtArray];
FillArray(array);
PrintArray(array);
int countedNumbers = CountEvenPositions(array);
Console.Write($" -> {countedNumbers}");
Console.WriteLine();