// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//  через четыре метода:
// 1. создаем (заполняем) массив (два метода: вручную или случайно генерим)
// 2. выводим массив на печать

int CreateElemManualy(int i)
{
    Console.WriteLine();
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    int j = int.Parse(Console.ReadLine()!);

    return j;
}

int CreateElemRandom(int i)
{
    var rand = new Random();
    int max = 1000;          //  для диапазона генерирования чисел
    int j = rand.Next(0, max);
    
    return j;
}

int[] CreateArray(int length, int choice)
{
    int[] arr = new int[length];

    for (int i = 0; i < length; i++)
    {
        if (choice == 1)
        {
            arr[i] = CreateElemManualy(i);
        }
        else
        {
            arr[i] = CreateElemRandom(i);
        }
    }
return arr;
}

void PrintArray(int length,int choice)
{
    int[] array = CreateArray(length, choice);
    
    Console.WriteLine();
    Console.WriteLine($"Создан массив из `{length}` элементов: ");
    
    Console.Write("[");

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();

Console.Write("Введите длину массива (любое целое число): ");
int length = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Выберете способ создания массива:");
Console.Write("1 - ввод элементов вручную, 2 - элементы формируются случайно: ");
int choice = int.Parse(Console.ReadLine()!);

PrintArray(length,choice);


Console.WriteLine();
