﻿/*/ Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
// double number;
int result, number;
Console.WriteLine("Введите трёхзначное число:");
number = Convert.ToInt32(Console.ReadLine());
result = (number%100-number%10)/10;
Console.WriteLine($"{number} -> {result}");
