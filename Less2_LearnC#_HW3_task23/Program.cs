// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

void PrintCubeTableOfNumber(int num)
{
    int i = 1;
    if (num == 0)
    {
        Console.Write("Вы ввели значение `ноль`, таблица кубов состоит из одного значения `ноль`");
        Console.WriteLine();
    }
    else
    {
        while (i <= Math.Abs(num)) // Abs добавлено для возможности работы с отрицательными числами
        {
            if (num > 0)
            {
                Console.Write($"{i * i * i}, ");
            }
            else // для отрицательных чисел
            {
                Console.Write($"{-i * i * i}, ");
            }
            i++;
        }
        Console.WriteLine(); // если эту пустую строку не ставить, то в конце таблицы прога выдает символ "%"
    }

}
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine($"Таблица кубов чисел от +/-1 до {number}:");
PrintCubeTableOfNumber(number);

Console.WriteLine();