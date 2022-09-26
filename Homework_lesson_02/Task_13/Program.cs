/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int result, number, processablenumber;
Console.WriteLine("Введите число:");
number = Convert.ToInt32(Console.ReadLine());
result = -1;
processablenumber = number;
while (processablenumber > 99)
{
    result = processablenumber % 10;
    processablenumber = processablenumber / 10;
}
if (result >= 0)
{
    Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine($"{number} -> третьей цифры нет");

