// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// Вариант  1.2 - Разницу между max и min находим в методе


double[] CreateArray(int length = 5, double minElem = -100, double maxElem = 100)
{
    double[] arr = new double[length];
    var rand = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.NextDouble() * (maxElem - minElem) + minElem;
    }

    return arr;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double GetMaxMinusMin(double[] arr)
{
    double difference = 0;

    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        
        if (min > arr[i])
        {
            min = arr[i];
        }

        difference = max - min;
    }

    Console.WriteLine($"max = {max:f}");
    Console.WriteLine($"min = {min:f}");

    return difference;
}

Console.Clear();

double[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

double difference = GetMaxMinusMin(array);
Console.WriteLine($"Разница между max и min равна: {difference:f}");

Console.WriteLine();