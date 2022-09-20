/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
double numberA, numberB;
Console.WriteLine("Введите число А:");
numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B:");
numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число А = " + numberA);
Console.WriteLine("Число B = " + numberB);
double max = numberA;
if (max == numberB)
{
    Console.WriteLine("Числа равны");
    return;
}
if (max < numberB)
{
    max = numberB;
}

Console.WriteLine("max = " + max);
