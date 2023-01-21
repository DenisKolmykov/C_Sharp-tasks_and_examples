// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

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

Console.Clear();

Console.WriteLine("Введите через пробел любое количество любых чисел: ");
Console.Write(": ");
double[] numbers = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

Console.WriteLine();
int count = GetCountInterNumbers(numbers);
Console.WriteLine("Среди указанных чисел, " + count + " - больше нуля.");

Console.WriteLine();
