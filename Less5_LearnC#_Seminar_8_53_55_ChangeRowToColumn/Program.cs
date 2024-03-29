﻿// Задача 53: 
// Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Задача 55: 
//Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.



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
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowInArray(int[,] array, int row1, int row2)
{
    int rowArray = array.GetLength(0);
    int columnArray = array.GetLength(1);

            for (int j = 0; j < columnArray; j++)
            {
                int temp = array[row1, j];
                array[row1, j] = array[row2, j];
                array[row2, j] = temp;
            }

    return array;
}

bool ChangeRowToColumn(int[,] array)
{
    bool result = true;
    int rowArray = array.GetLength(0);
    int columnArray = array.GetLength(1);
    if (rowArray == columnArray)
    {
        for (int i = 0; i < rowArray; i++)
        {
            for (int j = i+1; j < columnArray; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else result = false;

    return result;
}

int row = 5;
int column = 5;
int[,] arrayForChange = Create2DArrayRnd(row, column);
Print2DArray(arrayForChange);
Console.WriteLine("\n");

int row1 = 0;
int row2 = 2;

Print2DArray(ChangeRowInArray(arrayForChange, row1, row2));
Console.WriteLine("\n");

if (ChangeRowToColumn(arrayForChange))
{
    Print2DArray(arrayForChange);
}
else
{
    Console.WriteLine(" Заменить строки на столбцы невозможно");
}
