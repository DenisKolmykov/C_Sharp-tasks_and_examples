/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

double[] FindSumInRow(double[,] array)
{
    double[] sumInRows = new double[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sumInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInRow = sumInRow + array[i, j];
        }
        sumInRows[i] = sumInRow;
    }
    return sumInRows;
}

void GetRowIndexWithMinSum(double[] sumInRows)
{
    double minSum = sumInRows[0];
    int indexOfRowWithMinSum = 0;

    for (int i = 0; i < sumInRows.Length; i++)
    {
        if (sumInRows[i] < minSum)
        {
            minSum = sumInRows[i];
            indexOfRowWithMinSum = i;
        }
    }
    Console.WriteLine("Row with min sum: " + (indexOfRowWithMinSum + 1));
}


int row = 4;
int column = 3;

Console.Clear();

double[,] array = CreateArrayDoubleRnd(row, column);
PrintArray(array);
Console.WriteLine();

GetRowIndexWithMinSum(FindSumInRow(array));
Console.WriteLine();