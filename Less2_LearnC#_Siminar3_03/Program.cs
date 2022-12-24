// программа выдает таблицу квадратов чисел от 1 до N

void PrintTableSqrt(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine(i*i);
        i++;
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Таблица квадратов чисел от 1 до N");
PrintTableSqrt(number);