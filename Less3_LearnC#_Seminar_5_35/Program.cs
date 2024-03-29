﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество двухзначных элементов массива.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] CreateArray(int length = 123, int minElem = -200, int maxElem = 200)
{
    int[] arr = new int[length];
    var rand = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(minElem, maxElem + 1);
    }

    return arr;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int FindTwoDigitNumberInArray(int[] arr)
{
    int countTwoDigitNumber = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        // if (arr[i] / 100 == 0 && Math.Abs(arr[i] / 10) > 0) // такая проверка на двузначность тоже работает
        if (Math.Abs(arr[i]) >= 10 && Math.Abs(arr[i]) <= 99)
        {
            countTwoDigitNumber++;
        }
    }

    return countTwoDigitNumber;
}

Console.Clear();

int[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

int countTwoDigitNumber = FindTwoDigitNumberInArray(array);
Console.WriteLine($"В данном массиве присутствует `{countTwoDigitNumber}` двузначных чисел");

Console.WriteLine();