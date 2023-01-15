// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на чётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int GetSumNumOnEvenPosition(int[] arr, int position) // position = 0 - на нечетных; 1 - на четных
{
    int sum = 0;

    for (int i = position; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }

    return sum;
}


Console.Clear();

int[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

int position = 1; // 0 - на нечетных; 1 - на четных
string text = string.Empty;
if (position == 1) text = "четных"; else text = "НЕчетных";

int sum = GetSumNumOnEvenPosition(array, position);

Console.WriteLine("Сумма элементов, стоящих на " + text + " позициях = " + sum);

Console.WriteLine();