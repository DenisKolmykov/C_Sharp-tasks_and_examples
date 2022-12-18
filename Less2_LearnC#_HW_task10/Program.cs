// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

start:

int GetSecondDigit(int num)
{
    // int twoDigitNumber = num / 10;
    return num / 10 % 10;
}
int number = 0, secondDigit = 0;

Console.Clear();

Console.WriteLine("Данная программа выявляет вторую цифру в трехзначном числе.");
Console.WriteLine();
Console.WriteLine("Вы введете трехзначное число сами (1) или сгенерировать его случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (choice == 1)
{
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine()!);

    if (number > 99 && number < 1000)
    {
        secondDigit = GetSecondDigit(number);
    }

    else
    {
        Console.WriteLine("!Необходимо ввести ТРЕХЗНАЧНОЕ неотрицательное число!");
        goto end;
    }

}

if (choice == 2)
{
    number = new Random().Next(100, 1000);
    Console.WriteLine($"Из диапазона от 100 до 1000 сгенерировано случайное число: {number}");
    secondDigit = GetSecondDigit(number);
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}

Console.WriteLine();
Console.WriteLine($"В трехзначном числе {number} вторая цифра = {secondDigit}.");

end:;
Console.WriteLine();
Console.WriteLine("Продолжить работу с программой или выход?");
Console.Write("Ваш выбор (ведите Y-для продолжения или любой другой для выхода): ");
string str = Console.ReadLine()!;
if (str.ToLower() == "y")
{
    goto start;
}
else
{
    Console.Clear();
    Console.WriteLine("Спасибо за использование праграммы!");
    Console.WriteLine("До новых встреч!");
    Console.WriteLine();
}