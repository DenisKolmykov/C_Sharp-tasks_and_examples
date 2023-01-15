// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// 1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10


int[] CreateArray(int length = 10, int minElem = -10, int maxElem = 10)
{
    int[] arr = new int[length];
    var rand = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(minElem, maxElem);
    }

    return arr;
}

int[] GetProdPairInArray(int[] arr)
{
    int lengthPairArr = arr.Length / 2;

    if (arr.Length % 2 > 0)
    {
        lengthPairArr = lengthPairArr + 1;
    }

    int[] resultArr = new int[lengthPairArr];
    resultArr[lengthPairArr - 1] = arr[lengthPairArr - 1];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        {
            resultArr[i] = arr[i] * arr[arr.Length - i - 1];
        }
    }
    return resultArr;
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

Console.WriteLine($"Массив произведений пар элементов исходного массива состоит из `{GetProdPairInArray(array).Length}` элементов: ");
PrintArray(GetProdPairInArray(array));

Console.WriteLine();
