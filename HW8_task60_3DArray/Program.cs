/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] Create3DArrayRnd(int row, int collumns, int z, int minValue = 0, int maxValue = 100)
{
    int[,,] array = new int[row, collumns, z];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = rnd.Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k],3} ({i},{j},{k}){"",-2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Clear();

int row = 3;
int column = 3;
int z = 3;

int[,,] array = Create3DArrayRnd(row, column, z);
Print3DArray(array);