/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int[] CountCompositionOfCouples(int[] array, int lenghtArray)
{
    int[] newarray = new int[lenghtArray/2];
    int newarraylenth=lenghtArray/2;
    for (int i = 0; i < newarraylenth; i ++)
    {
        newarray[i]= array[i]*array[array.Length-1-i];
    }
    return newarray;
}

Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtArray];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
int[] countedArray = CountCompositionOfCouples(array, lenghtArray);
PrintArray(countedArray);
Console.WriteLine();