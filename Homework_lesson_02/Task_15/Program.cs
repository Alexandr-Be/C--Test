/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int weekday;
Console.WriteLine("Введите номер дня недели:");
weekday = Convert.ToInt32(Console.ReadLine());
while (weekday <= 0 || weekday > 7)
{
    Console.WriteLine($"В неделе 7 дней, введите правильный номер дня:");
    weekday = Convert.ToInt32(Console.ReadLine());
}

if (weekday > 5)
{
    Console.WriteLine($"{weekday} -> да");
}
else Console.WriteLine($"{weekday} -> нет");
