/* 
Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


double[,] CreateArrayDoubleRnd(int row, int collumns, int minValue = 0, int maxValue = 10)
{
    double[,] array = new double[row, collumns];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
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
            Console.Write($"{arr[i, j],6:f2}");
        }
        Console.WriteLine();
    }
}

double[,] SortRows(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int k = 0;
        while (k < array.GetLength(1))
        {
            for (int j = 1; j < array.GetLength(1) - k; j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    double temp = array[i, j - 1];
                    array[i, j - 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
            k++;
        }
    }
    return array;
}

int row = 5;
int column = 4;

double[,] array = CreateArrayDoubleRnd(row, column);
PrintArray(array);
Console.WriteLine();

double[,] sortRowInArray = SortRows(array);
PrintArray(sortRowInArray);
