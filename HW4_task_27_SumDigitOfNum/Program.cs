// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

void PrintSumDigitsOfNumber(int number)
{
    int digit = number / 10;
    int remainder = number % 10;
    int sum = remainder;

    for (int i = 1; i < 11; i++)  // 11 = 1 + (количество разрядов int.MaxValue - 10)
    {
        if ( digit > 0)
        {
            remainder = digit % 10;
            digit = digit / 10;

            sum = sum + remainder;
        }
        else break;
    }
    Console.WriteLine(sum);
}

Console.Clear();

Console.Write("Введите любое целое число (int): ");
int n = int.Parse(Console.ReadLine()!);


Console.Write($"Сумма цифр в числе {n} = ");
PrintSumDigitsOfNumber(n);

Console.WriteLine();
