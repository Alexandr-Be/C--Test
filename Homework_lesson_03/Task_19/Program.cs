/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void Is_Palindrom(int[] processablenumber)
{   
    int result, index;
    int[] array = new int[5];
    // Console.WriteLine("Введите пятизначное число:");
    // processablenumber = Convert.ToInt32(Console.ReadLine());

    index = 0;
    while (processablenumber > 0)
    {
        result = processablenumber % 10;
        processablenumber = processablenumber / 10;
        array[index] = result;
        Console.WriteLine(array[index]);
        index++;
        
    }
    
    // if (result >= 0)
    // {
    //     Console.WriteLine($"{number} -> {result}");
    // }
    // else Console.WriteLine($"{number} -> третьей цифры нет");
}

    Console.WriteLine("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Is_Palindrom(number);
