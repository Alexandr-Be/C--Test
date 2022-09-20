/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
double numberA, numberB, numberC;

Console.WriteLine("Введите число А:");
numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B:");
numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число C:");
numberC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число А = " + numberA);
Console.WriteLine("Число B = " + numberB);
Console.WriteLine("Число C = " + numberC);

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

Console.WriteLine("max = " + max);
