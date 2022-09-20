/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
double numberA, numberB, numberC;

Console.WriteLine("Введите число a:");
numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b:");
numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число c:");
numberC = Convert.ToDouble(Console.ReadLine());

double max = numberA;

if (max == numberB && max == numberC)
{
    Console.WriteLine("Числа равны");
    return;
}
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}

Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {max}");
