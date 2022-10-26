/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
    return AckermannFunction(numM, numN);
}

Console.WriteLine("Введите неотрицательное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int func = AckermannFunction(numberM, numberN);
Console.WriteLine($"m = {numberM}, n = {numberN}) -> A(m,n) = {func}");