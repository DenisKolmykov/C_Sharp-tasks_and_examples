// Задача 47. 
/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] CreateArrayDoubleRnd(int row, int collumns, int minValue = -10, int maxValue = 10)
{
    double[,] array = new double[row, collumns];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            array[i,j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],7:f2}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


Console.Clear();

int m = 5;
int n = 6;

double [,] array = new double[m,n];
array = CreateArrayDoubleRnd(m,n);

PrintArray(array);

Console.WriteLine();