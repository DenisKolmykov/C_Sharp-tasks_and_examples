// Задача 45
// напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования


double[] CreateArray(int length = 10, int minElem = -100, int maxElem = 100)
{
    double[] arr = new double[length];
    var rand = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(minElem, maxElem + 1);
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] GetCopyArray(double[] arr)
{
    double[] copyarr = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyarr[i] = arr[i];
    }
    return copyarr;
}

Console.Clear();

double[] array = CreateArray();
Console.WriteLine("Создан массив: ");
PrintArray(array);

Console.WriteLine();

double[] copyArray = GetCopyArray(array);
Console.WriteLine("Копия исходного массива (поэлементное копирование): ");
PrintArray(copyArray);

Console.WriteLine();