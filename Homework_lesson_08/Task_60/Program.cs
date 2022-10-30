/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateMatr(int[,,] matr)
{
    int[] FillArray(int[] array)
    {
        for (int i=0; i< array.GetLength(0); i++)
            array[i]=new Random().Next(10,100);
        return array;
    }

    int[] CheckElements(int[] array)
    {
        for (int i=0; i< array.GetLength(0); i++)
        {
            for(int j=i+1; j<array.GetLength(0); j++)
            {
                if (array[i]==array[j])
                {
                    array[j]= new Random().Next(10,100);
                    CheckElements(array);
                }
            }
        }
        return array;
    }

    int[,,] FillMatr( int[,,]matr, int[] array)
    {
        int arrayPosition=0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    // matr[i,j,k] = new Random().Next(1,100);
                    matr[i, j, k] = array[arrayPosition];
                    arrayPosition++;
                }
            }
        }
        return matr;
    }
    int[] array = new int[matr.GetLength(0)*matr.GetLength(1)*matr.GetLength(2)];
    FillArray(array);
    CheckElements(array);
    FillMatr(matr, array);
    return matr;
}

void PrintMatr(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] matrix = new int[2, 2, 2];
int[,,] chekedMatrix=CreateMatr(matrix);
PrintMatr(chekedMatrix);
Console.WriteLine();