/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void Is_Palindrom(int inputednumber)
{   
    int result, index, processablenumber;
    int[] array = new int[5];

    processablenumber = inputednumber;
    index = 0;
    while (processablenumber > 0)
    {
        result = processablenumber % 10;
        processablenumber = processablenumber / 10;
        array[index] = result;
        index++;
        
    }
    
    if (array[0]==array[4] && array[1]==array[3])
        Console.WriteLine($"{inputednumber} -> да");
    else Console.WriteLine($"{inputednumber} -> нет");
}

    Console.WriteLine("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Is_Palindrom(number);
