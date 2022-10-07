/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance_Between_Points()
{
    Console.WriteLine("Введите координату Х точки 1:");
    int point_1_X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y точки 1:");
    int point_1_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки 1:");
    int point_1_Z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату Х точки 2:");
    int point_2_X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y точки 2:");
    int point_2_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки 2:");
    int point_2_Z = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((point_2_X - point_1_X), 2)
                            + Math.Pow((point_2_Y - point_1_Y), 2)
                            + Math.Pow((point_2_Z - point_1_Z), 2)
                            );
    return result;
}

double result = Distance_Between_Points();
Console.WriteLine(Math.Round(result, 2));