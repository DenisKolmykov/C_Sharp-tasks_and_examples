// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// один метод ( создание элементов массива рандомно)

void PrintArray(int n)
{
    int[] arr = new int[n];
    var rand = new Random();
    int max = 1000;          //  для диапазона генерирования чисел
    
    Console.WriteLine($"!!! Все '{n}' элементов массива сгенерированы случайным образом:");
    Console.WriteLine();

    Console.Write("[");

    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(0, max);
        if (i == n - 1)
        {
            Console.Write(arr[i]);
        }
        else
        {
            Console.Write(arr[i] + ", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();

Console.Write("Введите длину массива (любое целое число): ");
int length = int.Parse(Console.ReadLine()!);

PrintArray(length);

Console.WriteLine();
