/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите целое число больше единицы:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
int i = 1;
while (i <= number)
{
    Console.Write($"{Math.Pow(i,3)}, ");
    i++;
}
Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop); // Move the cursor one unit to the left
Console.Write("\x1B[1P"); // Delete the character
Console.WriteLine("");