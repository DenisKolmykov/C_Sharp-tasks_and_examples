/* 
Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] Create2DArrayRnd(int row, int collumns, int minValue = 0, int maxValue = 5)
{
    int[,] array = new int[row, collumns];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],-4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool MultiArr1Arr2(int[,] arr1, int[,] arr2)
{
    bool resultMulti = true;
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        resultMulti = false;
    }
    else
    {
        int[,] multi = new int[arr1.GetLength(0), arr2.GetLength(1)];
        
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    sum = sum + arr1[i, k] * arr2[k, j];
                }
                multi[i, j] = sum;
            }
        }
        Print2DArray(multi);
    }
    return resultMulti;
}


Console.Clear();

int row1 = 3;
int column1 = 4;

int row2 = 4;
int column2 = 5;

int[,] array1 = Create2DArrayRnd(row1, column1);
Print2DArray(array1);

Console.WriteLine($"{"",5} x\n ");

int[,] array2 = Create2DArrayRnd(row2, column2);
Print2DArray(array2);

Console.WriteLine($"{"",5} ||\n");

if (MultiArr1Arr2(array1, array2) == false)
{
    Console.WriteLine("!!! Multiplication IMpossible");
    Console.WriteLine();
}