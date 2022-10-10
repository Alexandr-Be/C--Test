/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .

5 -> [1, 2, 5, 7, 19]

3 -> [6, 1, 33]
*/

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i==array.Length-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtArray];
FillArray(array);
Console.Write($"{lenghtArray} -> ");
PrintArray(array);
Console.WriteLine();