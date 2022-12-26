// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int GetDigitsOfNumber(int num)
{
    int digits = 0; // счетчик количестваразрядов числа num
    int i = 2; // счетчик цикла

    while (i <= 10) // возможность определения числа до 10^10
    {
        // если 2х значное число разделить на 100 - результат = 0; если 3х значное на 1000 - результат = 0;  и т.д.
        if (num / Convert.ToInt64(Math.Pow(10, i)) == 0) 
        {
            digits = i;
            break;
        }

        else i++;
    }
    return digits;
}

void PrintPalindrom(int digits, int num)
{
    int i = 0;
    double[] reverseDigit = new double[digits]; // массив для записи значений разрядов числа num
    double reverseNum = 0; // число num в обратной записи

    while (i < digits)
    {
        // поочередно (по циклу) с конца (справа-налево) числа num вычисляем цифру в соответствующем i разряде,
        // "ставим" ее на место начальных разрядов (слева-направо) путем умножения на соответствующий 10^i
        reverseDigit[i] = num % (Convert.ToInt64(Math.Pow(10, (i + 1)))) / (Convert.ToInt64(Math.Pow(10, (i)))) * Convert.ToInt64(Math.Pow(10, (digits - i - 1)));

        reverseNum = reverseNum + reverseDigit[i]; // складываем получившие значения десятков, сотен, тысячных и тп и получаем "перевернутое" число num
        i++;
    }
    
    Console.WriteLine();
    Console.WriteLine($"Обратная запись числа: {reverseNum}");

    if (num == reverseNum)
    {
        Console.WriteLine("Введенное Вами число ЯВЛЯЕТСЯ палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное Вами число НЕ является палиндромом.");
    }
}

Console.Clear();

Console.Write("Введите любое целое число (int): ");
int number = int.Parse(Console.ReadLine()!);

PrintPalindrom(GetDigitsOfNumber(number), number);

Console.WriteLine();