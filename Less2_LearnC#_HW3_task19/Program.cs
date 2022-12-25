// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

void PrintPolindrom(int num)
{
    int i = 0;

    string strNum = num.ToString();
    int length = strNum.Length;
    
    char[] reverseCharNum = new char[length];

    while (i < length)
    {
        reverseCharNum[i] = strNum[length - i - 1];
        i++;
    }

    string reverseStrNum = new string(reverseCharNum);

    int reverseNum = Int32.Parse(reverseStrNum);

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

PrintPolindrom(number);

Console.WriteLine();