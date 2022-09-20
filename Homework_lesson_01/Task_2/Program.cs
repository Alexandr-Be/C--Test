/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
double numberA, numberB;

Console.WriteLine("Введите число a:");
numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b:");
numberB = Convert.ToDouble(Console.ReadLine());

double max = numberA;
double min = numberB;
if (max == min)
{
    Console.WriteLine("Числа равны");
    return;
}
if (max < min)
{
    max = numberB;
    min = numberA;
}

Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {max}; min = {min}");
