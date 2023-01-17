// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, -3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


int[] CreateArray(int length = 10, int minElem = -100, int maxElem = 100)
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

void FindNumInArray(int[] arr, int number)
{
    int i = 0;
    int position = -1;

    while (i < arr.Length)
    {
        if (number == arr[i])
        {
            position = i + 1;
            Console.WriteLine($"Указанное число `{number}` находится в маcсиве на позиции `{position}` (индекс: {i})");
            i++;
        }
        else
        {
            i++;
        }
    }

    if (position == -1)
    {
        Console.WriteLine($"В массиве отсутствует указанное число `{number}` ");
    }
}


Console.Clear();

int[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

Console.Write($"Введите число для поиска в массиве: ");
int num = int.Parse(Console.ReadLine()!);

FindNumInArray(array, num);

Console.WriteLine();