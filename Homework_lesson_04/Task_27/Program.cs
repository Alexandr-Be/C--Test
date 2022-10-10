/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int SumOfFigures(int number)
{
    int sum = 0;
    int processablenumber = Math.Abs(number);
    int index = 0;
    while (processablenumber > 0)
    {
        sum = sum + processablenumber % 10;
        processablenumber = processablenumber / 10;
        index++;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int res = SumOfFigures(num);
Console.WriteLine($"{num} -> {res}");