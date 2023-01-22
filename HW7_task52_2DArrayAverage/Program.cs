/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] Create2DArrayRnd(int row, int collumns, int minValue = -100, int maxValue = 100)
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
            Console.Write($"{arr[i, j],5}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine(string.Join("; ", array));
}

double[] GetAverageCollumnsIn2DArr(int[,] arr)
{
    double[] averageCollumns = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            averageCollumns[j] = averageCollumns[j] + arr[i, j];
        }
        averageCollumns[j] = averageCollumns[j] / arr.GetLength(0);
    }
    return averageCollumns;
}

Console.Clear();

int row = 4;
int collumns = 7;
int[,] array = Create2DArrayRnd(row, collumns);

Console.WriteLine("Создан массив: ");
Print2DArray(array);

Console.WriteLine();

Console.WriteLine("Среднее арифметическое по каждому столбцу массива: ");
PrintArray(GetAverageCollumnsIn2DArr(array));

Console.WriteLine();
