/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
double number;

Console.WriteLine("Введите число:");
number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Вы ввели число:" + number);
if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
