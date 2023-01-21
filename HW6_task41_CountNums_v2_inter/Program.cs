// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

double[] InterNumbers(int m)
{
    double[] arr = new double[m];

    Console.WriteLine("Введите " + m + " любых чисел:");

    for (int i = 0; i < m; i++)
    {
        Console.Write((i + 1) + "-е число: ");
        arr[i] = double.Parse(Console.ReadLine()!);
    }
    return arr;
}

int GetCountInterNumbers(double[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

int m = 5;

Console.Clear();

double[] numbersForCount = InterNumbers(m);

int count = GetCountInterNumbers(numbersForCount);
Console.WriteLine("Среди указанных чисел, " + count + " - больше нуля.");

Console.WriteLine();
