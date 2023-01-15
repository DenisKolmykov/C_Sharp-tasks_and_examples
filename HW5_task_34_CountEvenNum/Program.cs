// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int length = 12, int minElem = 100, int maxElem = 1000)
{
    int[] arr = new int[length];
    var rand = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(minElem, maxElem);
    }

    return arr;
}

int FindEvenNumberInArray(int[] arr)
{
    int countEvenNumber = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countEvenNumber++;
        }
    }

    return countEvenNumber;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

Console.Clear();

int[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

int countEvenNumber = FindEvenNumberInArray(array);
Console.WriteLine($"В данном массиве присутствует `{countEvenNumber}` четных чисел.");

Console.WriteLine();