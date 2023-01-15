// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// Вариант  1.1 - max и min находим через метод, разницу считаем в основном коде


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

double GetMaxMinElement(double[] arr, bool max = true) // если мах - то находим мах. если false - находим min
{
    double maxMin = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if ((maxMin < arr[i] && max) || (maxMin > arr[i] && !max))
        {
            maxMin = arr[i];
        }
    }
    return maxMin;
}


Console.Clear();

double[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

double max = GetMaxMinElement(array);
double min = GetMaxMinElement(array, false);
double difference = max - min;

Console.WriteLine($"max = {max:f}");
Console.WriteLine($"min = {min:f}");
Console.WriteLine($"Разница между `{max:f}` и `{min:f}` равна `{difference:f}`");

Console.WriteLine();