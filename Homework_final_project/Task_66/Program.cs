/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbers(int num1, int num2)
{
    if (num2==num1-1) return 0;
    else return num2 + SumNumbers(num1, num2-1);
}

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N большее, чем число M:");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");