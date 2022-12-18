// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

start:

int GetThirdDigit(int num)
{
    int thirdDigit = -1;
    int absNum = Math.Abs(num);

    if (absNum > 99)
    {
        while (absNum > absNum % 1000)
        {
            absNum = absNum / 10;
        }
        thirdDigit = absNum % 10;
    }

    return thirdDigit;
}

void PrintThirdDigit(int thirdDigit, int num)
{
    if (thirdDigit == -1)
    {
        Console.WriteLine($"В числе {num} третья цифра отсутствует.");
    }

    else
    {
        Console.WriteLine($"В числе {num} третья цифра = {thirdDigit}.");
    }
}

int number = 0, thirdDigit = 0;

Console.Clear();

Console.WriteLine("Данная программа выявляет третью цифру в указанном числе.");
Console.WriteLine();
Console.WriteLine("Вы введете число сами (1) или сгенерировать его случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (choice == 1)
{
    Console.WriteLine("Введите любое число");
    Console.WriteLine("не больше 2 147 483 647 (MaxValue), и не меньше -2 147 483 648 (MinValue)");
    Console.Write("Ваше число: ");

    number = int.Parse(Console.ReadLine()!);
    // можно было бы, но здесь не будем проверять если введенное число больше MaxValue или меньше MinValue

    thirdDigit = GetThirdDigit(number);
}

if (choice == 2)
{
    number = new Random().Next(int.MinValue, int.MaxValue);
    Console.WriteLine($"Из диапазона от MinValue (-2 147 483 648) до MaxValue (2 147 483 647)");
    Console.WriteLine($"сгенерировано случайное число: {number}");
    thirdDigit = GetThirdDigit(number);
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}

Console.WriteLine();
PrintThirdDigit(thirdDigit, number);

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