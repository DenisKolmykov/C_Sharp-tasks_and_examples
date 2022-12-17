// Задача 6: 
// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

start:

Console.Clear();

int numberA=0, numberRange;


Console.WriteLine($"Данная программа опредлеят является указанное число четным.");

Console.WriteLine("Вы введете числа сами (1) или сгенерировать их случайным образом (2)?");
Console.Write("Ваш выбор (ведите 1 или 2): ");

int choice = int.Parse(Console.ReadLine()!);
// проверять на коректность ввода не будем

if (choice == 1)
    {
    Console.Write("Введите число: ");
    numberA = int.Parse(Console.ReadLine()!);
    }

if (choice == 2)
    {
    Console.WriteLine("Будет случайным образом сгенерировано число из заданного диапазона (от -N до N)");
    Console.Write("Введите число N для задания диапазона: ");
    numberRange = int.Parse(Console.ReadLine()!);
    
    numberA = new Random().Next(-numberRange, numberRange+1);
    Console.WriteLine ($"Сгенерировано случайное число: {numberA}");
    }

if (choice <1 |choice > 2)
    {
    Console.WriteLine ("Вы ввели не корректное число. Только 1 или 2.");
    goto end;
    }

if (numberA % 2 == 0)
    {
        Console.WriteLine ($"Число {numberA} является ЧЕТНЫМ");
    }   

else 
    {
        Console.WriteLine ($" Число = {numberA} является НЕчетным");
    }


end:;
Console.WriteLine ("Продолжить работу с программой или выход?");
Console.Write ("Ваш выбор (ведите Y-для продолжения или любой другой для выхода): ");
string str = Console.ReadLine()!;
if (str.ToLower() == "y")
    {
    goto start;
    }
else 
    {
    Console.WriteLine ("Спасибо за использование праграммы!");
    Console.WriteLine ("До новых встреч!");
    }