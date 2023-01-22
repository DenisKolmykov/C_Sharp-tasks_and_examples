/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
*/


int[,] CreateArray(int row, int collumns, int minValue = -100, int maxValue = 100)
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

void PrintArray(int[,] arr)
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


Console.Clear();

int row = 5;
int collumns = 6;
int[,] array = CreateArray(row, collumns);

Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

Console.Write("Введите через пробел позиции элемента массива (строка столбец): ");
var elementPosition = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int indexRow = elementPosition[0];
int indexCollumn = elementPosition[1];


if ((indexRow <= 0 || indexCollumn <= 0) || (indexRow > row || indexCollumn > collumns))
{
    Console.WriteLine($"Массив имеет размер {row}x{collumns}");
    Console.WriteLine($"Введенная позиция ({indexRow},{indexCollumn}) - за пределами массива.");
}
else
{
    Console.WriteLine($"Значение элемента на позиции ({indexRow},{indexCollumn}) = {array[indexRow - 1, indexCollumn - 1]}");
}
Console.WriteLine();