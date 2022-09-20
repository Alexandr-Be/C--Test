/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите целое число больше единицы:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}
Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop); // Move the cursor one unit to the left
Console.Write("\x1B[1P"); // Delete the character
Console.WriteLine("");