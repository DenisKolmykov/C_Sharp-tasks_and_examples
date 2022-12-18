// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

start:

void PrintWeekend(int num)
{
    string day = "ВЫХОДНОЙ";

    string[] dayOfTheWeek = { "ПОНЕДЕЛЬНИК", "ВТОРНИК", "СРЕДА", "ЧЕТВЕРГ", "ПЯТНИЦА", "СУББОТА", "ВОСКРЕСЕНЬЕ" };

    if (num < 6)
    {
        day = "БУДНИЙ";
    }

    Console.WriteLine($"Указанное число {num} соответствует дню недели: {dayOfTheWeek[num - 1]}");
    Console.WriteLine($"и это {day} день.");
}

int number = 0;

Console.Clear();

Console.WriteLine("Данная программа определяет соответствие указанного числа выходному дню недели.");
Console.WriteLine();
Console.WriteLine("Вы введете число сами (1) или сгенерировать его случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (choice == 1)
{
    Console.Write("Введите любое число от 1 до 7: ");

    number = int.Parse(Console.ReadLine()!);

    if (number < 1 || number > 7)
    {
        Console.WriteLine("Вы ввели не корректное число. Ведь в неделе же 7 дней, поэтому только от 1 до 7.");
        goto end;
    }
}

if (choice == 2)
{
    number = new Random().Next(1, 8);
    Console.WriteLine($"Cгенерировано случайное число дня недели: {number}");
}

if (choice < 1 | choice > 2)
{
    Console.WriteLine("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
}

Console.WriteLine();
PrintWeekend(number); ;

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