/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                // matr[i,j,k] = new Random().Next(1,100);
                matr[i, j, k] = 5;
            }
        }
    }
}

int[,,] ChekMatrix(int[,,] matr)
{
    int[,,] newMatr = new int[matr.GetLength(0), matr.GetLength(1), matr.GetLength(2)];
    int CompareElement(int l, int m, int n)
    {
        for (int l = 0; l < matr.GetLength(0); l++)
        {
            for (int m = 0; m < matr.GetLength(1); m++)
            {
                for (int n = 0; n < matr.GetLength(2); n++)
                {
                    if (matr[l,m,n]!=CompareElement(l+1,m,n)) return matr[l,m,n];
                    else
                        {
                           matr[l,m,n] = new Random().Next(1,100);
                           CompareElement(l,m,n);
                        }
                }
            }
        }
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                newMatr[i, j, k] = CompareElement(i, j, k);
            }
        }
    }
    return newMatr;
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
FillArray(matrix);
int[,,] chekedMatrix = ChekMatrix(matrix);

PrintMatr(chekedMatrix);
Console.WriteLine();